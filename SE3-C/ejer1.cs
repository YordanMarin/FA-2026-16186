using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            string n, c;

            Console.Write("Ingrese nombre: ");
            n = Console.ReadLine();
            Console.Write("Ingrese carrera: ");
            c = Console.ReadLine();

            Console.WriteLine("\n-------- IMPRESIÓN CON + --------");
            Console.WriteLine(n+", Bienvenido al curso FA de la carrera "+c);

            Console.WriteLine("\n-------- IMPRESIÓN CON $ --------");
            Console.WriteLine($"{n}, Bienvenido al curso FA de la carrera {c}");
            Console.ReadKey();
        }
    }
}
