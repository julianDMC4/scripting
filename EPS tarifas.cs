using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPS_TARIFAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su salario (en pesos colombianos)");
            double salario = double.Parse(Console.ReadLine());

            double smv = 828116;

            if (salario < (smv * 2))
            {
                Console.WriteLine("su tarifa a pagar  es la A");
            }

            if (salario >= (smv * 2) && salario < (smv * 5))
            {
                Console.WriteLine("su tarifa a pagar  es la B");
            }

            if (salario >= (smv * 5))
            {
                Console.WriteLine("su tarifa a pagar  es la C");
            }
        }
    }
}
