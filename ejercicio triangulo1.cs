using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_triangulo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la Y");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la Z");
            double z = double.Parse(Console.ReadLine());

            double t = Math.Sqrt ((y * y) + (z * z));

            double c = (Math.Asin(z / t)) * (180 / Math.PI);

            double a = 180 - 90 - c;

            Console.WriteLine("Los resultados de T {0}, C {1} y A {1} ", t,c,a);
        }
    }
}
