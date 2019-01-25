using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_programacion_1
{
    class Program
    {
        double d;
        void Main(string[] args)

        {
            Console.Write("introduce la a");
            double a = double.Parse(Console.ReadLine());
            Console.Write("introduce la b");
            double b = double.Parse(Console.ReadLine());
            Console.Write("introduce la c");
            double c = double.Parse(Console.ReadLine());

            double x1;
            double x2;
            if (Discriminante(a, b, c) == true)
            {
                if (d == 0)
                {
                    UniS(a,b);
                }

                else
                {
                    DosS(a, b);
                }

            }
        }
        bool Discriminante(double a, double b, double c)
        {
            d = (Math.Pow(b, 2) - (4 * a * c));
            Console.WriteLine(d);

            if (d >= 0)
            {
                return true;
            }

            else
            {
                Console.WriteLine("No es posible calcular la solución ");
                return false;
            }
        }

        void UniS (double a, double b)
        {
            double sol = -b / (2 * a);
            Console.WriteLine("la solucion es==" + sol);
        }

        void DosS (double a, double b)
        {
            double x1 = (-b + (Math.Sqrt(d)) / (2 * a));
            double x2 = (-b - (Math.Sqrt(d)) / (2 * a));

            Console.WriteLine("las soluciones son:  x={0} y x{1}", x1, x2);
        }
    }
}
