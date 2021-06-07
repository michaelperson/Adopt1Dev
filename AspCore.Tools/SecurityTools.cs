using System;
using System.Security.Cryptography;
using System.Text;

namespace AspCore.Tools
{
    public class SecurityTools
    {
        public static byte[] HashMe(string passwordIn)
        {
            //Je transforme le password en tableau de bytes
            byte[] data = Encoding.UTF8.GetBytes(passwordIn);
            byte[] result;
            //J'instancie la classe qui permet de hasher
            SHA512 shaM = new SHA512Managed();
            //Je calcule le sha (Miaouw)
            result = shaM.ComputeHash(data);
            return result;
        }
    }
}
