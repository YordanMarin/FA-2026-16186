using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE15_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            Productos p = new Productos();
            do
            {
                Console.WriteLine("BIENVENIDOS AL SISTEMA DE RESGISTRO DE PRODUCTOS\n");
                Console.WriteLine("1. Registrar");
                Console.WriteLine("2. Mostrar");

                Console.Write("\nIngrese una opción: ");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1: p.registrar(); break;
                    case 2: p.mostrar(); break;
                }
                Console.Write("\n¿Desea continuiar? [s]: ");
                continuar = Console.ReadLine();
                Console.Clear();
            } while (continuar == "s");
            
        }
    }
}
