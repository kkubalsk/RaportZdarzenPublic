using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace RaportZdarzen
{
    public class Ochrona
    {
        public static string Szyfruj(HashAlgorithm hashAlgoritm, string jawnyText)
        {
            byte[] data = hashAlgoritm.ComputeHash(Encoding.UTF8.GetBytes(jawnyText));

            var sBuilder = new StringBuilder();
            for (int i = 0; i <data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString(); 
        }

        public static bool SprawdzSzyfr(HashAlgorithm hashAlgorithm, string hasloLogowania, string hasloHash)
        {
            var hashOfhaslo = Szyfruj(hashAlgorithm, hasloLogowania);
            StringComparer comparer = StringComparer.Ordinal;  //      OrdinalIgnoreCase;
            return comparer.Compare(hashOfhaslo, hasloHash) == 0;
        }
    }
}
