using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE7_C
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            int intentos = 3;
            Random rnd = new Random();

            int aleatorio = rnd.Next(1,21);
            int num;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("|               BIENVENIDO AL JUEGO ADIVINADOR                 |");
            Console.WriteLine("----------------------------------------------------------------\n");

            Console.WriteLine("Intrucciones: ");
            Console.WriteLine("1. Ud. tiene 3 intentos.");
            Console.WriteLine("2. El número a adivinar esta en el rango de 1-20\n");

            do
            {
                Console.Write("Ingrese el número: ");
                num = int.Parse(Console.ReadLine());

                if(num < aleatorio)
                {
                    Console.WriteLine("Incorrecto. El número a adivinar es mayor");
                    intentos--;
                }else if(num > aleatorio)
                {
                    Console.WriteLine("Incorrecto. El número a adivinar es menor");
                    intentos--;
                }
                else
                {
                    Console.WriteLine("\nCorrecto adivinaste el número " + aleatorio);
                    break;
                }

            } while (intentos > 0);

            if (intentos == 0) 
                Console.WriteLine("\nJuego terminado. No lograste adivinar el número "+aleatorio);
        }
    }
}
