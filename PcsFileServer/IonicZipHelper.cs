using Ionic.Zip;
using Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PcsFileServer
{
    static public class IonicZipHelper
    {
        public static void AppendFilesToArchive(string archiveName,
    List<string> appendFiles, string password,
    CompressionLevel compressionLevel = CompressionLevel.Default)
        {
            var options = new ReadOptions();
            options.Encoding = Encoding.UTF8;
            using (var zipFile = ZipFile.Read(archiveName, options))
            {
                zipFile.AlternateEncodingUsage = ZipOption.Always;
                zipFile.AlternateEncoding = Encoding.UTF8;
                zipFile.Password = password;
                zipFile.CompressionLevel = compressionLevel;
                zipFile.AddFiles(appendFiles, "\\");
                zipFile.Save();
            }
        }
        public static ZipFile ReadZip(string fileName)
        {
            using (var zip = ZipFile.Read(fileName))
            {
                return zip;
            }
        }
        public static MemoryStream ExtractToMemoryStreamWithPassword(this ZipEntry zipEntry, string password)
        {
            try
            {
                var mstream = new MemoryStream();
                zipEntry.ExtractWithPassword(mstream, password);
                mstream.Position = 0;
                return mstream;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static ZipFile ReadSubZipWithPassword(string fileName, string subFileName, string password)
        {
            using (var zip = ZipFile.Read(fileName))
            {
                zip.AlternateEncodingUsage = ZipOption.Always;
                zip.AlternateEncoding = Encoding.UTF8;
                ZipEntry entry = zip[subFileName];
                using (var subZip = ZipFile.Read(entry.ExtractToMemoryStreamWithPassword(password)))
                {
                    subZip.AlternateEncodingUsage = ZipOption.Always;
                    subZip.AlternateEncoding = Encoding.UTF8;
                    return subZip;
                }
            }
        }
        public static void DeleteFilesFromZip(string archiveName, string subArchive, List<string> filesToDelete, string password)
        {
            using (var zipFile = ReadSubZipWithPassword(archiveName, subArchive, password))
            {
                zipFile.Password = password;
                foreach (var e in filesToDelete)
                {
                    zipFile.RemoveEntry(e);
                }
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    zipFile.Save(memoryStream);
                    memoryStream.Position = 0;
                    using (var outerZip = ReadZip(archiveName))
                    {
                        outerZip.UpdateEntry(subArchive, memoryStream);
                        outerZip.Save();
                    }
                }
            }
        }
        public static string CreateArchive(string archiveName,
        CompressionLevel compressionLevel = CompressionLevel.Default)
        {
            using (var zipFile = new ZipFile())
            {
                zipFile.CompressionLevel = compressionLevel;
                zipFile.Save(archiveName);
                return archiveName;
            }
        }

        public static void GetInfoFiles(string archiveName, string subArchive, string fileName, string password)
        {
            using (var zipFile = ReadSubZipWithPassword(archiveName, subArchive, password))
            {
                zipFile.Password = password;
                {
                    ZipEntry zipEntry = zipFile.Entries.FirstOrDefault(z => Path.GetFileName(z.FileName) == fileName);
                    string size = "";
                    if (zipEntry.CompressedSize < 1024)
                        size = $"Размер файла: {zipEntry.CompressedSize} Б";
                    if (zipEntry.CompressedSize >= 1024)
                        size = $"Размер файла: {Math.Round(zipEntry.CompressedSize / 1024d)} КБ";
                    if ((zipEntry.CompressedSize / 1024) > 1024)
                        size = $"Размер файла: {Math.Round(zipEntry.CompressedSize / 1024 / 1024d)} МБ";
                    MessageBox.Show($"Название файла: {Path.GetFileName(zipEntry.FileName)}\n{size}" +
                        $"\nДата и время создания:{zipEntry.CreationTime}" +
                        $"\nДата и время изменения: {zipEntry.LastModified}",
                                    "Информация о файле", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public static void AppendFilesToZip(string archiveName, string subArchive, List<string> filesName, string password)
        {
            using (ZipFile zip = ReadSubZipWithPassword(archiveName, subArchive, password))
            {
                zip.CompressionLevel = CompressionLevel.Default;
                zip.Password = password;
                foreach (var item in filesName)
                {
                    zip.AddFile(item, "");
                }
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    zip.Save(memoryStream);
                    memoryStream.Position = 0;
                    using (var outerZip = ReadZip(archiveName))
                    {
                        outerZip.UpdateEntry(subArchive, memoryStream);
                        outerZip.Save();
                    }
                }
            }
        }
        public static void DownloadFilesFromZip(string archiveName, string subArchive, List<string> filesToDownload, string password, string outerPath)
        {
            using (var zipFile = ReadSubZipWithPassword(archiveName, subArchive, password))
            {
                zipFile.Password = password;
                foreach (var e in filesToDownload)
                {
                    zipFile.ExtractSelectedEntries($"name = {e}", null, outerPath, ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }
    }
}
