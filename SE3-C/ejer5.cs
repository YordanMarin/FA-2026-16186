using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine($"\nResto: {entero % 2}");
            Console.WriteLine($"Dividido entre 3: {deci/3}");
        }
    }
}
