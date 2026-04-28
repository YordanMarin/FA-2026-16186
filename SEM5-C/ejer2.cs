using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM5_C
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese lado 1: ");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 2: ");
            int l2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 3: ");
            int l3 = int.Parse(Console.ReadLine());

            if (l1 == l2 && l2 == l3)
            {
                Console.WriteLine("\nEQUILÁTERO");
            }else if (l1 == l2 || l2 == l3 || l1 == l3)
            {
                Console.WriteLine("\nISÓSCELES");
            }else
            {
                Console.WriteLine("\nESCALENO");
            } 
        }
    }
}
