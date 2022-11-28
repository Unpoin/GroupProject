using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Security.Cryptography;

namespace PcsFileServer
{
    static public class FtpHelper
    {
        public static string EncryptString(this string input)
        {
            byte[] hash;
            using (var sha1 = SHA1.Create())
            {
                hash = sha1.ComputeHash(Encoding.Unicode.GetBytes(input));
            }
            var sb = new StringBuilder();
            foreach (byte b in hash)
                sb.AppendFormat("{0:x2}", b);
            return sb.ToString();
        }
        public static byte[] GetKey(this string input, int length)
        {
            byte[] hash = new byte[length];
            using (var sha1 = SHA1.Create())
            {
                var temp = sha1.ComputeHash(Encoding.Unicode.GetBytes(input));
                for (int i = 0; i < hash.Length; i++)
                {
                    hash[i] = temp[i];
                }
            }
            return hash;
        }

        public static void EncryptStream(this Stream input, Stream output, byte[] key)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = key;
                byte[] iv = Encoding.ASCII.GetBytes("P-C-S-FileServer");
                aes.Padding = PaddingMode.Zeros;
                using (CryptoStream cs = new CryptoStream(output, aes.CreateEncryptor(key, iv), CryptoStreamMode.Write))
                {
                    int data;
                    while ((data = input.ReadByte()) != -1)
                        cs.WriteByte((byte)data);
                }
            }
        }

        public static void DecryptStream(this Stream input, Stream output, byte[] key)
        {
            byte[] iv = Encoding.ASCII.GetBytes("P-C-S-FileServer");
            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Padding = PaddingMode.Zeros;
                using (CryptoStream cs = new CryptoStream(input, aes.CreateDecryptor(key, iv), CryptoStreamMode.Read))
                {
                    int data;
                    while ((data = cs.ReadByte()) != -1)
                        output.WriteByte((byte)data);
                }
            }
        }
        public static FtpStatusCode DownloadFile(string filename, string address, string login, string password)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(address);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(login, password);
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Create))
                    {
                        responseStream.DecryptStream(fs, login.GetKey(16));
                    }
                }
                return response.StatusCode;
            }
        }

        public static FtpStatusCode UploadFile(string filename, string address, string login, string password)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(address);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(login, password);
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (Stream requestStream = request.GetRequestStream())
                {
                    fs.EncryptStream(requestStream, login.GetKey(16));
                }

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    return response.StatusCode;
                }
            }
        }

        public static List<string> GetFilesList(string address, string login, string password)
        {
            List<string> lines = new List<string>();
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(address);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential(login, password);

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        while (!reader.EndOfStream)
                        {
                            lines.Add(reader.ReadLine());
                        }
                    }
                }
            }
            List<string> files = new List<string>();
            foreach (string line in lines)
            {
                string[] tokens =
                    line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[8];
                string permissions = tokens[0];

                files.Add(name + (permissions[0] == 'd' ? "/" : ""));
            }
            return files;
        }

        public static FtpStatusCode DeleteFile(string address, string login, string password)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(address);

            request.Method = WebRequestMethods.Ftp.DeleteFile;
            request.Credentials = new NetworkCredential(login, password);

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                return response.StatusCode;
            }
        }
    }
}
