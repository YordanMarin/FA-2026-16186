using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM5_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.Write("Ingrese la cantidad: ");
            int cant = int.Parse(Console.ReadLine());

            for (int i = 1;i<=cant ;i++)
            {
                Console.Write(i +" ");

                if (i % 2 == 0) suma += i; //suma = suma + i;
            }

            Console.WriteLine("\n\nSuma de pares: " + suma);
        }
    }
}
