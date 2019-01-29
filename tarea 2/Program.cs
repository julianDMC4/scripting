using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_casa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero de votos por el partido 1");
            int votos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de votos por el partido 2");
            int votos2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de votos en blanco");
            int votosblan = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de votos anulados");
            int votosanul= int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de la poblacion");
            int Npoblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el  el porcentaje (de 0 a 100%) de la población que es mayor de edad");
           double mayorP = double.Parse(Console.ReadLine());

            int votosT = votos1 + votos2 + votosblan+ votosanul;

            bool a = votosT > Npoblacion;
            bool b = votos1 - votos2 < votosT * 0.01;
            bool d = votosT < Npoblacion * 0.03;

            if ((a||b) && (d))
            {
                Console.WriteLine("las elecciones  deben ser ejecutadas nuevamente");
            }

            else if( votos1 > votos2)
            {
                Console.WriteLine("el ganador es el partido 1");
            }
            else if ( votos2 > votos1)
            {
                Console.WriteLine("el ganador es el partido 2");
            }
        }
    }
}
