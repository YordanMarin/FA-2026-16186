using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM4_C
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            double area;
            Console.WriteLine("--- SISTEMA DE CALCULO DE ÁREAS ---\n");

            Console.WriteLine("1. Área del cuadrado");
            Console.WriteLine("2. Área del triángulo");
            Console.WriteLine("3. Área del rectángulo");
            Console.WriteLine("4. Área del círculo\n");

            Console.Write("Ingrese una opción: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Write("\nIngresa el lado del cuadrado: ");
                    int l = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea del cuadrado: "+(l*l));
                    break;
                case 2:
                    Console.Write("\nIngresa la base del triángulo: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura del triángulo: ");
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea del triángulo: " + (b*h/2));
                    break;
                case 3:
                    Console.Write("\nIngresa la base del rectangulo: ");
                    int br = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura del rectangulo: ");
                    int hr = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea del triángulo: " + (br * hr));
                    break;
                case 4:
                    Console.Write("\nIngresa la radio del circulo: ");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea del circulo: " + (Math.PI * Math.Pow(r, 2)));
                    break;
                default:
                    Console.WriteLine("\nOpción incorrecta!");
                    break;
            }
        }
    }
}
