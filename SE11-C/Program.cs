using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE11_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nom = {"jose", "oscar", "carmen", "alexa"};
            string evaluar;

            for (int i = 0; i < nom.Length; i++)
            {
                Console.Write($"Ingrese nombre a modificar: ");
                evaluar = Console.ReadLine();
                bool duplicado = false;

                    if(nom[i] == evaluar)
                    {
                        Console.Write("Ingrese el nuevo nombre: ");
                        nom[i] = Console.ReadLine();
                        duplicado = true;
                        break;
                    }
                
                if (!duplicado)
                    Console.WriteLine("\nNo se puede modificar porque no existe\n");
            }
            
            Console.WriteLine("\nLista de nombres modificado: ");
            foreach(string s in nom)
                Console.WriteLine(s);
        }
    }
}
