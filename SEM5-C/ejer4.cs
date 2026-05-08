using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM5_C
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números: ");
            int cant = int.Parse(Console.ReadLine());

            int num, Cceros=0, Cpares=0, cImpares=0;
            Console.WriteLine();
            for (int i = 0; i<cant; i++)
            {
                Console.Write($"Ingrese número {i+1}: ");
                num = int.Parse(Console.ReadLine());

                if (num == 0) Cceros++;
                else if(num % 2==0) Cpares++;
                else cImpares++;
            }
            Console.WriteLine("\n\nCantidad ceros: "+Cceros);
            Console.WriteLine("Cantidad pares: "+Cpares);
            Console.WriteLine("Cantidad impares: " + cImpares);
        }
    }
}
