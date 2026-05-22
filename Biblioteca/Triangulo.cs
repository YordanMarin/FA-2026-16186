using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Triangulo
    {
        public void Area()
        {
            Console.WriteLine("Ingrese la base: ");
            int baase = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura: ");
            int altura = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEl área del triangulo es: ", ((baase * altura) / 2));
        }

        public void Perimetro()
        {
            Console.WriteLine("Ingrese primer lado: ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo lado: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer lado: ");
            int lado3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEl perímetro del triangulo es: " + (lado1 + lado2+lado3));
        }
    }
}
