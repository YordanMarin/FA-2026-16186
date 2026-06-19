using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE13_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiantes e = new Estudiantes();
            string continuar;
            do
            {
                switch (e.menu())
                {
                    case 1: e.insertar(); break;
                    case 2: e.mostrar(); break;
                    case 3:
                        Console.Write("\nIngrese el nombre a buscar: ");
                        string nom = Console.ReadLine();
                        Console.WriteLine("\nEl nombre existe y esta en la posición "+(e.buscar(nom)+1));
                        break;
                    case 4: e.modificar(); break;
                    case 5: e.eliminar(); break;
                    case 6: e.ordenar(); break;
                    case 7: Environment.Exit(0); break;
                }

                Console.Write("\n¿Desea continuar? presione [s]: ");
                continuar = Console.ReadLine().Trim().ToLower();
                Console.Clear();
            } while (continuar == "s");
        }
    }
}
