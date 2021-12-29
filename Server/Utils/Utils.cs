using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Utils
{
    public class Utils
    {
        public static string fullPathFolderImage
        {
            get
            {
                return $"{getRootFolderApplication()}\\Images\\";
            }
        }

        public static string createAbsolutePath(string fileName)
        {
            String root = AppDomain.CurrentDomain.BaseDirectory;

            return $"{root}{fileName}";
        }

        public static string getRootFolderApplication()
        {
            DirectoryInfo runFolder = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            return runFolder.Parent.Parent.FullName;
        }

        public static void moveFile(string sourcePath, string destinationPath)
        {
            File.Move(sourcePath, destinationPath);
        }

        public static void copyFile(string sourcePath, string destinationPath)
        {
            File.Copy(sourcePath, destinationPath);
        }

        public static void removeFile(string filePath)
        {
            File.Delete(filePath);
        }

        public static string hashPassword(string password, string salt = "10")
        {
            if (String.IsNullOrEmpty(password) || String.IsNullOrWhiteSpace(password)) return "";
            byte[] plainTextByte = UnicodeEncoding.Unicode.GetBytes(password + salt);
            System.Security.Cryptography.HashAlgorithm hashAlgo = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = hashAlgo.ComputeHash(plainTextByte);
            return Convert.ToBase64String(hash, 0, hash.Length);
        }

        public static string generateDestinationPathImage(string fileName, string ext)
        {
            return $"{fullPathFolderImage}{fileName}.{ext}";
        }

        public static string getRandomString(int length)
        {
            System.Byte[] seedBuffer = new System.Byte[4];
            using (var rngCryptoServiceProvider = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rngCryptoServiceProvider.GetBytes(seedBuffer);
                System.String chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                System.Random random = new System.Random(System.BitConverter.ToInt32(seedBuffer, 0));
                return new System.String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            }
        }
    }
}
