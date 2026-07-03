using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE15_C
{
    internal class Productos
    {
        string[,] productos = new string[0, 3];
        int cantidad = 0;

        public void redimensionar(int nuevoT)
        {
            string[,] temp = new string[nuevoT, 3];

            for(int i = 0; i < cantidad; i++)
            {
                for(int j = 0;j< temp.GetLength(1); j++)
                {
                    temp[i, j] = productos[i, j];
                }
            }
            productos = temp;
        }

        public void registrar()
        {
            redimensionar(cantidad+1);
            Console.Write("\nIngrese el nombre del producto: ");
            productos[cantidad, 0] = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            productos[cantidad, 1] = Console.ReadLine();
            Console.Write("Ingrese el stock del producto: ");
            productos[cantidad, 2] = Console.ReadLine();

            Console.WriteLine("\nProducto registrado correctamente.");
            cantidad++;
        }

        public void mostrar()
        {
            for (int i = 0; i<cantidad;i++)
            {
                Console.WriteLine("\nProducto N° "+(i+1));
                Console.WriteLine("Nombre: " + productos[i, 0]);
                Console.WriteLine("Precio: " + productos[i, 1]);
                Console.WriteLine("Stock: " + productos[i, 2]);
            }
        }
    }
}
