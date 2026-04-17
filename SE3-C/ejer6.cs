using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer6
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los segundos: ");
            int se = int.Parse(Console.ReadLine());

            int horas = se / 3600;
            int min = (se % 3600) / 60;
            int resto = se % 60;

            Console.WriteLine($"Horas: {horas}\nMinuto: {min}\nResto: {resto}");
        }
    }
}
