using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE12_C
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
                    case 3: e.eliminar(); break;
                    case 4: e.ordenar(); break;
                    case 5: Environment.Exit(0); break;
                }

                Console.Write("\n¿Desea contunar? presione [s]: ");
                continuar = Console.ReadLine().Trim().ToLower();
                Console.Clear();
            } while (continuar =="s");
            
        }
    }
}
