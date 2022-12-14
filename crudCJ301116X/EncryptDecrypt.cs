using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace crudCJ301116X
{
    public class EncryptDecrypt
    {       

        public string base64Encode(string dados)
        {
            try
            {
                byte[] encodeData = new byte[dados.Length];

                encodeData = System.Text.Encoding.UTF8.GetBytes(dados);

                string encoded = Convert.ToBase64String(encodeData);

                return encoded;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro na criptografia!" + ex.Message);
            }
        }

        public string base64Decode(string dados)
        {

            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();

            System.Text.Decoder utf8Decode = encoder.GetDecoder();

            byte[] todecode = Convert.FromBase64String(dados);

            int charCount = utf8Decode.GetCharCount(todecode, 0, todecode.Length);

            char[] decoded = new char[charCount];

            utf8Decode.GetChars(todecode, 0, todecode.Length, decoded, 0);

            string resultado = new String(decoded);

            return resultado;

        }



    }
}
