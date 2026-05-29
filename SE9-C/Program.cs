using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace SE9_C
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            Rectangulo r = new Rectangulo();
            Trapecio tr = new Trapecio();
            Cuadrado c = new Cuadrado();

            string continuar;
            int opc, opc2;
            do
            {
                Console.Clear();

                Console.WriteLine("BIENVENIDO AL SISTEMA DE CALCULOS DE ÁREAS Y PERÍMETROS\n");
                Console.WriteLine("1. Triangulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Rectangulo");
                Console.WriteLine("4. Trapecio");
                Console.WriteLine("5. Salir\n");

                Console.Write("Ingrese una opción: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("\nSeleccione una opción: ");
                        Console.WriteLine("1. Área");
                        Console.WriteLine("2. Perímetro");

                        Console.Write("\nIngrese una opción: ");
                        opc2 = int.Parse(Console.ReadLine());

                        switch (opc2)
                        {
                            case 1: t.Area(); break;
                            case 2: t.Perimetro(); break;
                            default: Console.WriteLine("\nOpción no válida");break;
                        }
                        break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: Environment.Exit(0); break;
                    default: Console.WriteLine("\nOpción no válida!"); break;
                }

                Console.Write("\n¿Desea continuar? (presione [si]: ");
                continuar = Console.ReadLine();
            } while (continuar =="si");
        }
    }
}
