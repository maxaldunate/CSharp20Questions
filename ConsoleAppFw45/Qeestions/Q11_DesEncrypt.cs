using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace ConsoleAppFw45.Questions
{
    public class Q11_DesEncrypt
    {
        public static void Run()
        {
            var texto = "Este es el texto que desaseamos encryptar";
            texto.ToConsole();

            var pwd = "P@$$w0rd";

            var testEncrypt = new Q11_DesEncrypt();

            "********** Encrypted Text * *********".ToConsole();
            var encText = testEncrypt.EncryptString(texto, pwd);
            encText.ToConsole();
            "".ToConsole();

            "********** Decrypted Text * *********".ToConsole();
            var plain = testEncrypt.EncryptString(encText, pwd);
            plain.ToConsole();
            "".ToConsole();
        }

        private static TripleDES CreateDES(string key)
        {
            var md5 = MD5.Create();
            var des = TripleDES.Create();
            var bytesKey = Encoding.Unicode.GetBytes(key);
            des.Key = md5.ComputeHash(bytesKey);
            des.IV = new byte[des.BlockSize / 8];
            return des;
        }

        private string EncryptString(string plainText, string password)
        {
            byte[] plainTextBytes = Encoding.Unicode.GetBytes(plainText);
            var myStream = new MemoryStream();
            var des = CreateDES(password);
            var cryptStream = new CryptoStream(myStream, des.CreateEncryptor(), CryptoStreamMode.Write);
            cryptStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptStream.FlushFinalBlock();
            return Convert.ToBase64String(myStream.ToArray());
        }

        private string DecryptString(string encryptedText, string password)
        {
            byte[] encryptedTextBytes = Convert.FromBase64String(encryptedText);
            var myStream = new MemoryStream();
            var des = CreateDES(password);
            var decryptStream = new CryptoStream(myStream, des.CreateDecryptor(), CryptoStreamMode.Write);
            decryptStream.Write(encryptedTextBytes, 0, encryptedTextBytes.Length);
            decryptStream.FlushFinalBlock();
            return Encoding.Unicode.GetString(myStream.ToArray());
        }
    }
}