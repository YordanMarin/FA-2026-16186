using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE7_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            string continar;
            
            do
            {
                int num = 0, suma = 0, i = 1;
                Console.Clear();
                Console.Write("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());
                do
                {
                    suma += i;
                    i++;
                } while (i<=num);

                Console.WriteLine($"\nLa suma del rango de 1 - {num} es "+suma);

                Console.Write("\n¿Desea continuar? (presione s): ");
                continar = Console.ReadLine();
            } while (continar =="s");
        }
    }
}
