using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_triangulo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 3;
            double c = 56.31;
            double c1 = c * (Math.PI / 180);

            double t = z / Math.Sin(c1);
          
            double y = Math.Sqrt((t * t) - (z * z));

            double a = 180 - c - 90;


            Console.WriteLine("La hipotenusa mide {0}", t);

            Console.WriteLine("El cateto  mide {0}", y);

            Console.WriteLine("El ángulo a mide {0}", a);

        }
    }
}
