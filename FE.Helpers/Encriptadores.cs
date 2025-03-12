using System.Security.Cryptography;
using System.Text;

namespace FE.Helpers
{
    public class Encriptadores
    {
        public static string Encriptar(string textoPlano)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(textoPlano.PadRight(32));
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(textoPlano);
                        sw.Flush();
                        cs.FlushFinalBlock();
                    }

                    array = ms.ToArray();
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string Desencriptar(string textoPlano, string textoEncriptado)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(textoEncriptado);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(textoPlano.PadRight(32));
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(buffer))
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        public static bool Comparar(string textoPlano, string textoEncriptado)
        {
            try
            {
                string desencriptado = Desencriptar(textoPlano, textoEncriptado);
                return textoPlano == desencriptado;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la comparación: {ex.Message}");
                return false;
            }
        }
    }
}