using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDD2_La05
{
    public class ZigZagEncoded
    {
        public void ZigZag(int niveles, string texto)
        {
            this.niveles = niveles;
            Texto = texto;
        }
        public int niveles;
        public string Texto;
        public int TamañoOla()
        {
            int resultado = 0;
            resultado = (niveles * 2) - 2;
            return resultado;
        }
        //devuelva la cantidad de olas que existen
        private int NumeroOlas()
        {
            int resultado = 0;
            resultado = TamañoTexto() / TamañoOla();
            return resultado;
        }
        private int TamañoBloque()
        {
            int resultado = 0;
            resultado = 2 * NumeroOlas();
            return resultado;
        }
        private int TamañoTexto()
        {
            int resultado = 0;
            char[] TamañoTexto = Texto.ToCharArray();
            for (int i = 0; i < TamañoTexto.Length; i++)
            {
                resultado++;
            }
            return resultado;
        }
    }
}
