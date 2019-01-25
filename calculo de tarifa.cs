using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_calculo_de_tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su salario (en pesos colombianos, no me venga a presumir dolares ni euros)");
            double salario = double.Parse(Console.ReadLine());

            double smv = 828116;

            if (salario < (smv * 2))
            {
                Console.WriteLine("su tarifa a pagar  es la A.... busca otro trabajo?");
            }

            if(salario >= (smv*2) && salario < (smv * 4))
            {
                Console.WriteLine("su tarifa a pagar  es la B... bueno la clase media nunca esta mal, ¿verdad?");
            }

            if (salario >= (smv * 4))
            {
                Console.WriteLine("su tarifa a pagar  es la C... Hora de pagar por codicioso!!!");
            }
        }
    }
}
