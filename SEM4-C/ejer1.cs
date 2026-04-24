using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM4_C
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Menor de edad");
            if(edad >= 18 && edad <=64) Console.WriteLine("Adulto");
            if (edad >= 65) Console.WriteLine("Adulto mayor");
        }
    }
}
