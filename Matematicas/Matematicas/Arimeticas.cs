using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematicas
{
    public static class Arimeticas
    {
        public static int sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public static int multiplicar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static bool ISBN(int[] Isbn)
        {


            if(Isbn.Length == 10)
            {
                int sumatoria = 0;
                int multiplicacion = 0;
                int contador = 10;

                for (int i = 0; i < Isbn.Length; i++)
                {
                    multiplicacion = Isbn[i] * contador;
                    sumatoria = sumatoria + multiplicacion;
                    multiplicacion = 0;
                    contador--;
                }

                if(sumatoria % 11 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if(Isbn.Length == 13)
            {
                int sumatoria = 0;
                int multiplicacion = 0;

                for (int i = 0; i < Isbn.Length; i++)
                {
                    if(Isbn[i] % 2 == 0)
                    {
                        multiplicacion = Isbn[i] * 3;
                    }
                    else
                    {
                        multiplicacion = Isbn[i] * 1;
                    }
                    sumatoria = sumatoria + multiplicacion;
                    
                }

                if(sumatoria % 10 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
            
        }
    }
}
