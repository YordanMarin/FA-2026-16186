using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE14_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese sus nombres: ");
            string nom = Console.ReadLine().Trim();
            Console.Write("Ingrese sus apellidos: ");
            string ape = Console.ReadLine().Trim();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n# caracteres apellidos: "+ape.Length);
            Console.WriteLine("Nombres mayus: " + nom.ToUpper());
            Console.WriteLine("Apellidos minus: " + ape.ToLower());
            if(ape.CompareTo(nom) == 0)
                Console.Write("Apellidos y nombres son iguales");
            else
                Console.Write("Apellidos y nombres son diferentes");
            if (nom.Contains("an"))
                Console.WriteLine("En nombres si existe el caracter 'an'");
            else
                Console.WriteLine("En nombres no existe el caracter 'an'");

            Console.ForegroundColor = ConsoleColor.Blue;
            if (ape.IndexOf("a") == -1)
                Console.WriteLine("No existe 'a' en apellidos");
            else
                Console.WriteLine("'a' en apellidos esta en la pos " + ape.IndexOf("a"));
            if (ape.LastIndexOf("a") == -1)
                Console.WriteLine("No existe 'a' en apellidos");
            else
                Console.WriteLine("'a' en apellidos esta en la pos " + ape.LastIndexOf("a"));
            Console.WriteLine(nom.Insert(0,"UPN"));
            Console.WriteLine(ape.Insert(ape.Length,"SISTEMAS"));
            if (nom.Length > 5)
                Console.WriteLine(nom.Remove(5));
            else
                Console.WriteLine("En nombres no hay almenos 5 caracteres");
            if (nom.Contains("a"))
                Console.WriteLine(nom.Replace("a", "@"));
            else
                Console.WriteLine("No existe 'a' en nombres");

            if (nom.Contains("a"))
            {
                string[] partes = nom.Split('a');
                for(int i = 0;i<partes.Length;i++)
                    Console.Write(partes[i]+" ");
                Console.WriteLine();
            }
            else
                Console.WriteLine("No existe 'a' en nombres");

            if (nom.Length > 4)
                Console.WriteLine(nom.Substring(4));
            else Console.WriteLine("En nombres no hay almenos 4 caracteres");

            char[] vertical = nom.ToCharArray();
            foreach (char c in vertical)
                Console.WriteLine(c);

            char[] reversa = nom.ToCharArray();
            Array.Reverse(reversa);
            foreach (char c in reversa)
                Console.Write(c);
            
            Console.WriteLine();

            char[] ordenado = nom.ToCharArray();
            Array.Sort(ordenado);
            foreach (char c in ordenado)
                Console.Write(c);
        }
    }
}
