using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0;
            int total = 0;
            int dobles = 0;
            int turnos = 0;
            int seis = 0;
            Console.WriteLine("Bienvenido al juego");
            Console.WriteLine("ingrese el numero de jugadores(minimo 2, maximo 5)");
            int n = int.Parse(Console.ReadLine());
            while (n < 2 || n > 5)
            {
                Console.WriteLine("error,  numero invalido de jugadores");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("inicio del juego");
            string continuar = "s";

            while (continuar == "s" && (dado1 != 1 && dado2 != 1))
            {

                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);

                Console.WriteLine("Dado 1 = " + dado1 + "Dado 2 = " + dado2);

                if (dado1 == 1 && dado2 == 1)
                {
                    Console.WriteLine("Eliminado");
                }
                else
                {
                    total = +(dado1 + dado2);
                    Console.WriteLine("Total=" + total);
                    if (dado1 == dado2)
                    {
                        dobles = +1;
                    }
                    else dobles = 0;
                    if ((dado1 + dado2) > 6)
                    {
                        seis = +1;
                    }
                    if (total >= 100 || dobles >= 3)
                    {
                        Console.WriteLine("Ganador");
                        continuar = "n";
                    }
                    else
                    {
                        Console.WriteLine("desea continuar? s/n");
                        continuar = Console.ReadLine();
                    }
                }
                turnos = +1;
            }
            Console.WriteLine("su total fue=" ++ total + "puntos");
            double porcentaje = 100 * (((double)seis) / turnos);
            Console.WriteLine("su porcentaje fue" + porcentaje + "% de veces que saco mas de 6");
            Console.WriteLine("gracias por jugar");
        }
    }
}
