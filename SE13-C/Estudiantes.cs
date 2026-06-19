using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE13_C
{
    internal class Estudiantes
    {
        string[] nombre = new string[0];
        byte[] edad = new byte[0];
        int cantidad = 0;
        public int menu()
        {
            int opc;
            Console.WriteLine("BIENVENIDOS AL SISTEMA DE REGISTRO DE EDADES\n");
            Console.WriteLine("******** MENÚ DE OPCIONES ********");
            Console.WriteLine("* 1. Insertar                    *");
            Console.WriteLine("* 2. Mostrar                     *");
            Console.WriteLine("* 3. Buscar                      *");
            Console.WriteLine("* 4. Modificar                   *");
            Console.WriteLine("* 5. Eliminar                    *");
            Console.WriteLine("* 6. Ordenar                     *");
            Console.WriteLine("* 7. Salir                       *");
            Console.WriteLine("**********************************");

            do
            {
                Console.Write("\nIngrese una opción: ");
                opc = int.Parse(Console.ReadLine());
            } while (opc <= 0 || opc > 7);
            return opc;
        }

        public void insertar()
        {
            Console.Write("\nIngrese su nombre: ");
            string nom = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            byte ed = byte.Parse(Console.ReadLine());

            Array.Resize(ref nombre, nombre.Length + 1);
            Array.Resize(ref edad, edad.Length + 1);
            nombre[cantidad] = nom;
            edad[cantidad] = ed;
            cantidad++;
            Console.WriteLine("\nNombre y Edad registrado con éxito.");
        }

        public void mostrar()
        {
            Console.WriteLine("\nLista de nombres y edades: \n");
            Console.Write("POS\tNOMBRE\tEDAD\n");
            for (int i = 0; i < edad.Length; i++)
            {
                Console.Write($"{i + 1}\t{nombre[i]}\t{edad[i]}\n");
            }
        }

        public int buscar(string nom)
        {
            int indice = -1;

            for(int i = 0;i < nombre.Length; i++)
            {
                if (nom == nombre[i])
                    indice = i;
            }
            return indice;
        }

        public void modificar()
        {
            Console.Write("\nIngrese el nombre: ");
            string nom = Console.ReadLine();

            int modi = buscar(nom);

            if (modi != -1)
            {
                Console.Write("\nIngrese el nuevo nombre: ");
                nombre[modi] = Console.ReadLine();
                Console.Write("Ingrese la nueva edad: ");
                edad[modi] = byte.Parse(Console.ReadLine());
                Console.WriteLine("\nNombre y edad modificado correctamente.");
            }
            else Console.WriteLine("\nNo existe el nombre.");
        }

        public void ordenar()
        {
            for (int i = 0; i < edad.Length - 1; i++)
            {
                for (int j = 0; j < edad.Length - 1 - i; j++)
                {
                    if (string.Compare(nombre[j], nombre[j+1])>0)
                    {
                        byte temp = edad[j];
                        edad[j] = edad[j + 1];
                        edad[j + 1] = temp;

                        string temp2=nombre[j];
                        nombre [j] = nombre[j+1];
                        nombre[j+1] = temp2;
                    }
                }
            }
        }

        public void eliminar()
        {
            Console.Write("\nIngrese el nombre a eliminar: ");
            string nom = Console.ReadLine();

            int eli = buscar(nom);

            if (eli != -1)
            {
                for(int i = eli;i < nombre.Length-1; i++)
                {
                    nombre[eli] = nombre[eli+1];
                    edad[eli] = edad[eli+1];
                }
                Array.Resize(ref edad, edad.Length-1);
                Array.Resize(ref nombre, nombre.Length - 1);
                cantidad--;
                Console.WriteLine("\nNombre y edad eliminado corrrectamente.");
            }
            else Console.WriteLine("\nNo existe el nombre.");
        }
    }
}
