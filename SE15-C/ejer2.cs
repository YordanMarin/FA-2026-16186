using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE15_C
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la matriz: ");
            int t = int.Parse(Console.ReadLine());

            int[,] matriz = new int[t, t];
            Random rnd = new Random();

            Console.WriteLine("MATRIZ ORIGINAL:");
            for(int i = 0; i < t; i++)
            {
                for(int j = 0; j < t; j++)
                {
                    matriz[i, j] = rnd.Next(40, 51);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMATRIZ TRANSPUESTA:");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.Write(matriz[j, i] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
