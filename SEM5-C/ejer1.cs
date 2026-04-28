using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM5_C
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese edad: ");
            int ed = int.Parse(Console.ReadLine());

            if(ed < 18)
                Console.WriteLine("No puede votar\nNo puede ser candidato");
            else if (ed < 25)
                Console.WriteLine("Si puede votar\nNo puede ser candidato");
            else 
                Console.WriteLine("Puede votar\nSi puede ser candidato");
        }
    }
}
