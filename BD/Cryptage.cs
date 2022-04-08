using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace GestionPret.BD
{
    class Cryptage
    {
        const String KEY = "hs9xnrg2fskc7rmc";

        /// <summary>
        /// Méthode pour encrypter
        /// </summary>
        /// <param name="_Texte">Texte à cryter</param>
        /// <returns>String</returns>
        public static String Encrypt(String _Texte)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(KEY);
                aes.IV = iv;

                ICryptoTransform dechiffreur = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, dechiffreur, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(_Texte);
                        }
                        array = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(array);
        }

        /// <summary>
        /// Méthode pour décrypter
        /// </summary>
        /// <param name="_Texte">Texte à décrypter</param>
        /// <returns>String</returns>
        public static String Decrypt(String _Texte)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(_Texte);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(KEY);
                aes.IV = iv;

                ICryptoTransform dechiffreur = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, dechiffreur, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }

            }
        }
    }
}
