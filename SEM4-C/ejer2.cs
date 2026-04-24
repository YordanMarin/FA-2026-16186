using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM4_C
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el año: ");
            int an = int.Parse(Console.ReadLine());

            if ((an % 4 == 0 & an %100 != 0) || an%400 == 0)
            {
                Console.WriteLine("\nEl año es bisiesto");
            }else Console.WriteLine("\nEl año no es bisiesto");

            if(an%2 == 0) Console.WriteLine("\nEl año es par");
            else Console.WriteLine("\nEl año es impar");
        }
    }
}
