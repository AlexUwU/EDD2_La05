using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EDD2_La05
{
    public class ImplementacionEspiral
    {

        public static void Cifrado(string path, string root, int tamaño)
        {
            string texto = System.IO.File.ReadAllText(@path);
            RutaEspiral cifrado = new RutaEspiral(texto, tamaño);
            string txtcifrado = cifrado.Cifrado();

            List<char> bytecompress = new List<char>();

            root = root + @"\\Upload\\cifrado.Espiral";
            using (StreamWriter outputFile = new StreamWriter(root))
            {
                foreach (char caracter in txtcifrado)
                {
                    outputFile.Write(caracter.ToString());
                }

            }
        }

        public static void Descifrado(string path, string root, int tamaño)
        {
            string texto = System.IO.File.ReadAllText(@path);
            RutaEspiral descifrado = new RutaEspiral(texto, tamaño);
            string txtdescifrado = descifrado.Descifrado();
            txtdescifrado.Replace("ascii 197", "");

            root = root + @"\\Upload\\descifradoEspiral.txt";
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
