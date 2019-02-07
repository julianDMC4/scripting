using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_clase_grupos
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "the quick brown fox jumps over the lazy dog";
            string salida = "";
            int contador = 0;
            string palabra = "the";

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i]!= ' ')
                {
                    salida += texto[i];
                }
                else if (texto[i]== ' ')
                {
                    if (salida == palabra)
                    {
                        contador += 1;
                        
                    }
                    salida = "";

                  
                }
              
            }
              Console.WriteLine(texto);
                Console.WriteLine("cantidad de the que salen:::" + contador);
        }
    }
}
