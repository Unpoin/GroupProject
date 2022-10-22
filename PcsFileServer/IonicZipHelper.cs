using Ionic.Zip;
using Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace PcsFileServer
{
    static public class IonicZipHelper
    {
        public static void CompressionDirectory(string fileName,
        string sourceDirectory,
        CompressionLevel compressionLevel = CompressionLevel.Default)
        {
            using (var zipFile = new ZipFile(fileName))
            {
                zipFile.CompressionLevel = compressionLevel;
                zipFile.Password = "a1sda42kld31sa987e2";
                zipFile.AddDirectory(sourceDirectory, "\\");
                zipFile.Save();
            }
        }

        //public static void AppendFilesToArchive(string fileName,
        //    List<string> appendFiles,
        //    CompressionLevel compressionLevel = CompressionLevel.Default)
        //{
        //    try
        //    {
        //        var options = new ReadOptions();
        //        options.Encoding = Encoding.UTF8;
        //        using (var zipFile = ZipFile.Read(fileName, options))
        //        {
        //            zipFile.CompressionLevel = compressionLevel;
        //            zipFile.Password = "a1sda42kld31sa987e2";
        //            zipFile.AddFiles(appendFiles, "\\");
        //            zipFile.Save();
        //        }
        //    }
        //    catch (Exception) { }
        //}
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
            var mstream = new MemoryStream();
            zipEntry.ExtractWithPassword(mstream, password);
            mstream.Position = 0;
            return mstream;
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
                foreach(var e in filesToDelete)
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
        public static void AppendFilesToZipFromArray(string fileName,
            List<byte[]> appendFiles,
            CompressionLevel compressionLevel = CompressionLevel.Default)
        {
            using (var zipFile = new ZipFile(fileName))
            {
                zipFile.CompressionLevel = compressionLevel;
                foreach (var file in appendFiles)
                {
                    var tempFileName = Guid.NewGuid().ToString();
                    zipFile.AddEntry(tempFileName, file);
                }
                zipFile.Save();
            }
        }

        public static void ExtractZip(string fileName, string outFolder)
        {
            using (var zip = ZipFile.Read(fileName))
            {
                foreach (var e in zip)
                {
                    e.Extract(outFolder, ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }
        public static void ExtractZipWithPassword(string fileName, string outFolder)
        {
            using (var zip = ZipFile.Read(fileName))
            {
                foreach (var e in zip)
                {
                    e.ExtractWithPassword("a1sda42kld31sa987e2", outFolder);
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

        //public static void RefreshPassword(string archiveName, string password)
        //{
        //    using (var zipFile = ZipFile.Read(archiveName))
        //    {
        //        zipFile.Password = password;
        //    }
        //}

        //public static void GetInfoFiles(string fileName)
        //{
        //    using (var zipFile = ZipFile.Read($@"C:\TestZip\{CurrentUser.User.Login}.zip"))
        //    {
        //        ZipEntry zipEntry = zipFile.Entries.FirstOrDefault(z => Path.GetFileName(z.FileName) == fileName);
        //        string size = "";
        //        if (zipEntry.CompressedSize < 1024)
        //            size = $"Р Р°Р·РјРµСЂ С„Р°Р№Р»Р°: {zipEntry.CompressedSize} Р‘";
        //        if (zipEntry.CompressedSize >= 1024)
        //            size = $"Р Р°Р·РјРµСЂ С„Р°Р№Р»Р°: {Math.Round(zipEntry.CompressedSize / 1024d)} РљР‘";
        //        if ((zipEntry.CompressedSize / 1024) > 1024)
        //            size = $"Р Р°Р·РјРµСЂ С„Р°Р№Р»Р°: {Math.Round(zipEntry.CompressedSize / 1024 / 1024d)} РњР‘";
        //        MessageBox.Show($"РќР°Р·РІР°РЅРёРµ С„Р°Р№Р»Р°: {Path.GetFileName(zipEntry.FileName)}\n{size}",
        //                        "РРЅС„РѕСЂРјР°С†РёСЏ Рѕ С„Р°Р№Р»Рµ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}




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
    }
}
