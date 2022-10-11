using Ionic.Zip;
using Ionic.Zlib;
using System;
using System.Collections.Generic;

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
                zipFile.AddDirectory(sourceDirectory, "\\");
                zipFile.Save();
            }
        }

        public void AppendFilesToZip(string fileName,
            List<string> appendFiles,
            CompressionLevel compressionLevel = CompressionLevel.Default)
        {
            using (var zipFile = ZipFile.Read(fileName))
            {
                zipFile.CompressionLevel = compressionLevel;
                zipFile.AddFiles(appendFiles, "\\");
                zipFile.Save();
            }
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
    }
}
