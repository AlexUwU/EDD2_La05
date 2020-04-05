using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EDD2_La05
{
    public class ImplementacionVertical
    {

        public static void Cifrado(string path, string root, int tamaño)
        {
            string texto = System.IO.File.ReadAllText(@path);
            RutaVertical cifrado = new RutaVertical(texto, tamaño);
            string txtcifrado = cifrado.Cifrado();

            List<char> bytecompress = new List<char>();

            root = root + @"\\Upload\\cifrado.Vertical";
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
            RutaVertical descifrado = new RutaVertical(texto, tamaño);
            string txtdescifrado = descifrado.Descifrado();

            root = root + @"\\Upload\\descifradoRuta.txt";
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
