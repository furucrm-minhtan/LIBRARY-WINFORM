using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Server.Utils.Constrant;

namespace Server.Utils
{
    public class Helpers
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

        public static Byte[] convertImageToBinary(Image img)
        {
            return (Byte[])new ImageConverter().ConvertTo(img, typeof(Byte[]));
        }
        
        public static string convertImageToBinaryString(Image img)
        {
            return Encoding.UTF8.GetString(convertImageToBinary(img));
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

        public static string imageToBase64(string _imagePath)
        {
            string _base64String = null;

            using (System.Drawing.Image _image = System.Drawing.Image.FromFile(_imagePath))
            {
                using (MemoryStream _mStream = new MemoryStream())
                {
                    _image.Save(_mStream, _image.RawFormat);
                    byte[] _imageBytes = _mStream.ToArray();
                    _base64String = Convert.ToBase64String(_imageBytes);

                    return "data:image/jpg;base64," + _base64String;
                }
            }
        }

        public static int getUnixTime()
        {
            return (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        public static List<Options> createOptionsForCombobox(List<Object> data, string displayValue, string value, bool hasNone)
        {
            List<Options> options = new List<Options>();

            if(hasNone) options.Add(new Options { label="---None---", value="" });
            foreach(var item in data) {
                options.Add(new Options { label = item.GetType().GetProperty(displayValue).GetValue(item).ToString(), value = item.GetType().GetProperty(value).GetValue(item).ToString() });
            }

            return options;
        }
    }
}
