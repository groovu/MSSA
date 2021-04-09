using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace EncryptionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = "pw";
            var salt = "s@lt";

            //generate secret key and IV
            var rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));

            var algorithm = new AesManaged();

            var rgbKey = rgb.GetBytes(algorithm.KeySize / 8);
            var rgbIV = rgb.GetBytes(algorithm.BlockSize / 8);

            var bufferstream = new FileStream(".\\encrypted.txt", FileMode.OpenOrCreate);
            //bufferstream.Write(Encoding.ASCII.GetBytes("YO"), 0, 2);
            //bufferstream.Close();

            var algo = algorithm.CreateEncryptor(rgbKey, rgbIV);

            var cryptostream = new CryptoStream(bufferstream, algo, CryptoStreamMode.Write);

            byte[] transform = Encoding.Unicode.GetBytes("secret secret, I've got a secret");

            cryptostream.Write(transform, 0, transform.Length);
            cryptostream.FlushFinalBlock();

            cryptostream.Close();
            bufferstream.Close();

            Console.WriteLine("Text is encrypted");

            byte[] decryptedbuffer = new byte[100];
            var decalgo = algorithm.CreateDecryptor(rgbKey, rgbIV);
            var filestream = new FileStream(".\\decrypted.txt", FileMode.OpenOrCreate);

            var decryptStream = new CryptoStream(filestream, decalgo, CryptoStreamMode.Read);
            decryptStream.Read(decryptedbuffer, 0, 100);

            string s = Encoding.Unicode.GetString(decryptedbuffer);
            Console.WriteLine(s);
            filestream.Write(Encoding.Unicode.GetBytes(s), 0, s.Length);

            //decryptStream.FlushFinalBlock();
            //decryptStream.Close();
            filestream.Close();







            //Asymmetric




            var plaintext = "hello world";
            var rawBytes = Encoding.Default.GetBytes(plaintext);
            var decryptedText = string.Empty;

            using (var rsaProvider = new RSACryptoServiceProvider())
            {
                var useOaepPadding = true;
                var encryptedBytes = rsaProvider.Encrypt(rawBytes, useOaepPadding);
                var decryptedBytes = rsaProvider.Decrypt(rawBytes, useOaepPadding);

                decryptedText = Encoding.Default.GetString(decryptedBytes);
            }

            Console.WriteLine("Asymmetric");

            Console.WriteLine(decryptedText);
            


            /** asdasd
             * 
             */
            Console.ReadKey();
        }
    }
}
