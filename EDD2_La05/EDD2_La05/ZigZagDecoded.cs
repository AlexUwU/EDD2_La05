using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDD2_La05
{
    public class ZigZagDecoded
    {


        public ZigZagDecoded(int niveles, String texto)
        {
            this.niveles = niveles;
            Texto = texto;
        }

        public int niveles;
        public String Texto;

        public int TamañoOla()
        {
            int resultado = 0;
            resultado = (niveles * 2) - 2;
            return resultado;
        }

     
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

        private List<char> ListaCaracteresTotales()
        {
            List<char> lista = new List<char>();
            char[] caracteres = Texto.ToCharArray();

            for (int i = 0; i < TamañoTexto(); i++)
            {
                lista.Add(caracteres[i]);
            }

            return lista;
        }

        public List<List<char>> ListaDescifrado()
        {
            List<List<char>> ListasOlas = new List<List<char>>();
            List<char> temporal = ListaCaracteresTotales();


            List<char> ListaAuxiliar = new List<char>();
            for (int j = 0; j < NumeroOlas(); j++)
            {
                ListaAuxiliar.Add(temporal.ElementAt(0));
                temporal.RemoveAt(0);
            }
            ListasOlas.Add(ListaAuxiliar);


            ListaAuxiliar = new List<char>();
            int CantidadBloques = temporal.Count() / TamañoBloque();
            for (int i = 0; i < CantidadBloques; i++)
            {
                ListaAuxiliar = new List<char>();
                for (int j = 0; j < TamañoBloque(); j++)
                {
                    ListaAuxiliar.Add(temporal.ElementAt(0));
                    temporal.RemoveAt(0);
                }
                ListasOlas.Add(ListaAuxiliar);
            }


            ListaAuxiliar = new List<char>();
            int Tamaño = temporal.Count() - 1;
            for (int j = 0; j <= Tamaño; j++)
            {
                ListaAuxiliar.Add(temporal.ElementAt(0));
                temporal.RemoveAt(0);
            }
            ListasOlas.Add(ListaAuxiliar);


            return ListasOlas;
        }

    }
}
