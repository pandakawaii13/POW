
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar el concepto de herencia de clases");
            Console.WriteLine("Jerarquía de figuras geométricas cerradas");

            Figura miFigura = new Figura();

            Console.WriteLine("La figura tiene centro en las coordenadas ({0},{1})", miFigura.CentroX, miFigura.CentroY);

            Console.Write("Ingresa la coordenada X del centro de la figura:");
            miFigura.CentroX = int.Parse(Console.ReadLine());

            Console.Write("Ingresa la coordenada Y del centro de la figura:");
            miFigura.CentroY = int.Parse(Console.ReadLine());

            Console.WriteLine("La figura tiene centro en las coordenadas ({0},{1})", miFigura.CentroX,miFigura.CentroY);

            Console.WriteLine("Ahora con el triangulo... ");

            Triangulo miTria = new Triangulo();

            Console.WriteLine("El triangulo tiene centro en las coordenadas ({0},{1})", miTria.CentroX, miTria.CentroY);

            Console.WriteLine("Ingresa la coordenada x del centro del triangulo: ");
            miTria.CentroX = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la coordenada y del centro del triangulo: ");
            miTria.CentroY = int.Parse(Console.ReadLine());

            Console.WriteLine("El triangulo tiene centro en las coordenadas ({0},{1})", miTria.CentroX, miTria.CentroY);

            Console.WriteLine("Ahora otro triangulo");

            int x, y;

            Console.WriteLine("Ingresa la coordenada x del centro del triangulo: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la coordenada x del centro del triangulo: ");
            y = int.Parse(Console.ReadLine());

            Triangulo otroTri = new Triangulo(x, y);

            Console.WriteLine("El triangulo tiene centro en las coordenadas ({0},{1})", x, y);

        }
    }
}
