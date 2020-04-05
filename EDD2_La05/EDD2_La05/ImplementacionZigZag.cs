using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EDD2_La05
{
    public static class ImplementacionZigZag
    {
        public static void Cifrado(string path, string root, int niveles)
        {
            string texto = System.IO.File.ReadAllText(@path);
            ZigZagEncoded cifrado = new ZigZagEncoded(niveles, texto);
            string txtcifrado =cifrado.Cifrado();

            List<char> bytecompress = new List<char>();


            root = root + @"\\Upload\\cifrado.ZigZag";
            using (StreamWriter outputFile = new StreamWriter(root))
            {
                foreach (char caracter in txtcifrado)
                {
                    outputFile.Write(caracter.ToString());
                }
            }
        }

        public static void Descifrado(string path, string root, int niveles)
        {
            string texto = System.IO.File.ReadAllText(@path);
            ZigZagDecoded descifrado = new ZigZagDecoded(niveles, texto);
            string txtdescifrado = descifrado.Descifrado();

            root = root + @"\\Upload\\descifradoZigZag.txt";
            using (StreamWriter outputFile = new StreamWriter(root))
            {
                foreach (char caracter in txtdescifrado)
                {
                    outputFile.Write(caracter.ToString());
                }
            }
        }
    }
}
