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


        public List<List<char>> ListasCifrado()
        {
            List<List<char>> ListasOlas = new List<List<char>>();
            char[] TamañoText = Texto.ToCharArray();
            char res = ' ';
            List<char> Temporal = ListaCaracteresTotales();
            for (int i = 0; i <= NumeroOlas(); i++)
            { 
                List<char> ListaPrueba = new List<char>();

                if (Temporal != null)
                {
                    for (int j = 0; j < TamañoOla(); j++)
                    {
                        res = Temporal.Remove(0);
                        ListaPrueba.Add(res);
                        if (Temporal == null)
                        {
                            int tamaño = TamañoOla() - ListaPrueba.();
                            for (int h = 0; h < tamaño; h++)
                            {
                                ListaPrueba.Add('|');

                            }
                            j = TamañoOla() + 1;
                        }
                    }
                    ListasOlas.Add(ListaPrueba);
                }
                else
                {
                    ListaPrueba.Add('1');
                }
            }
            return ListasOlas;
        }
    }
}
