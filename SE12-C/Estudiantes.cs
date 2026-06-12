using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE12_C
{
    internal class Estudiantes
    {
        public int menu()
        {
            int opc; 

            Console.WriteLine("BIENVENIDOS AL SISTEMA DE REGISTRO DE EDADES\n");
            Console.WriteLine("******** MENÚ DE OPCIONES ********");
            Console.WriteLine("* 1. Insertar                    *");
            Console.WriteLine("* 2. Mostrar                     *");
            Console.WriteLine("* 3. Eliminar                    *");
            Console.WriteLine("* 4. Ordenar                     *");
            Console.WriteLine("* 5. Salir                       *");
            Console.WriteLine("**********************************");

            do
            {
                Console.Write("\nIngrese una opción: ");
                opc = int.Parse(Console.ReadLine());
            } while (opc <=0 || opc > 5);

            return opc;
        }

        byte[] edad = new byte[0];
        int cantidad=0;

        public void insertar()
        {
            Console.Write("\nIngrese la edad: ");
            byte ed;

            while (!byte.TryParse(Console.ReadLine(), out ed) || ed > 120 || ed <14)
            {
                Console.Write("Ingrese una edad válida entre 14 y 120: ");
            }

            Array.Resize(ref edad, edad.Length+1);
            edad[cantidad] = ed;
            cantidad++;
            Console.WriteLine("\nEdad registrado con éxito.");

        }

        public void mostrar()
        {
            Console.WriteLine("\nLista de edades: \n");
            Console.Write("POS\tEDAD\n");
            for (int i = 0; i <edad.Length; i++)
            {
                Console.Write($"{i+1}\t{edad[i]}\n");
            }
        }

        public void eliminar()
        {
            Console.Write("\nIngrese la edad a eliminar: ");
            byte ed;

            while (!byte.TryParse(Console.ReadLine(), out ed) || ed > 120 || ed < 14)
            {
                Console.Write("Ingrese una edad válida entre 14 y 120: ");
            }

            int indice = Array.IndexOf(edad, ed);

            if (indice != -1)
            {
                for (int i = indice; i < cantidad - 1; i++)
                {
                    edad[i] = edad[i + 1];
                }
                Array.Resize(ref edad, edad.Length - 1);
                cantidad--;
                Console.WriteLine("\nEdad eliminado correctamente.");
            }
            else Console.WriteLine("\nLa edad no existe. No se puede eliminar!");
        }
    }
}
