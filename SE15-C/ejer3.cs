using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE15_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la fila: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tamaño de la columna: ");
            int c = int.Parse(Console.ReadLine());

            int[,] matriz = new int[f, c];
            Random rnd = new Random();
            int[] suma = new int[c];

            Console.WriteLine("\nMATRIZ ORIGINAL:");
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matriz[i, j] = rnd.Next(20, 31);
                    suma[j] += matriz[i, j];
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            for(int i = 0; i < suma.Length; i++)
            {
                Console.Write(suma[i]+"\t");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
