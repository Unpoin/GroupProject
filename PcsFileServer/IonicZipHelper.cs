using Ionic.Zip;
using Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.Text;

namespace PcsFileServer
{
    public class IonicZipHelper
    {
        public void CompressionDirectory(string fileName,
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

        public void AppendFilesToZip(string fileName,
            List<string> appendFiles,
            CompressionLevel compressionLevel = CompressionLevel.Default)
        {
            try
            {
                var options = new ReadOptions();
                options.Encoding = Encoding.UTF8;
                using (var zipFile = ZipFile.Read(fileName, options))
                {
                    zipFile.CompressionLevel = compressionLevel;
                    zipFile.Password = "a1sda42kld31sa987e2";
                    zipFile.AddFiles(appendFiles, "\\");
                    zipFile.Save();
                }
            }
            catch (Exception){ }
        }

        public void AppendFilesToZipFromArray(string fileName,
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

        public void ExtractZip(string fileName, string outFolder)
        {
            using (var zip = ZipFile.Read(fileName))
            {
                foreach (var e in zip)
                {
                    e.Extract(outFolder, ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }
        public void ExtractZipWithPassword(string fileName, string outFolder)
        {
            using (var zip = ZipFile.Read(fileName))
            {
                foreach (var e in zip)
                {
                    e.ExtractWithPassword("a1sda42kld31sa987e2", outFolder);
                }
            }
        }
    }
}
