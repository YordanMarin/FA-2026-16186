using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM4_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sistema de conversión monetario ---\n");

            Console.Write("Ingrese el monto en soles: ");
            double mo = double.Parse(Console.ReadLine());

            Console.WriteLine("\n1. Convertir a dolares");
            Console.WriteLine("2. Convertir a euros\n");

            Console.Write("Ingrese una opción: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    double dolares = mo/3.75;
                    Console.WriteLine("\nDolares: "+dolares);
                    break;
                case 2:
                    double euros = mo / 4.05;
                    Console.WriteLine("\nEuros: " + euros);
                    break;
                default:
                    Console.WriteLine("Opción incorrecta!");
                    break;
            }
        }
    }
}
