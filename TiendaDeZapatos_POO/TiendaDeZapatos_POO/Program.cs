using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeZapatos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para abastecer una tienda de zapatos");
            Console.WriteLine("Llenaremos el inventario de la tienda con 1000 zapatos");
            Console.WriteLine("Cada zapato tiene tres atributos: color, talla, estilo");
            Console.WriteLine("Tres colores: verde, negro, violeta");
            Console.WriteLine("Cinco estilos: crocs, sandalia gladiadora, botas, tenis, alapargatas ");
            Console.WriteLine("Tallas desde 34 hasta 45 ");

            string[] colores = { "verde", "negro", "violeta","amarilla", "naranja"};
            string[] estilos = { "Crocs", "Sandalia gladiadora", "Botas","Tenis","Alpargatas", "Sandalia tres puntadas" };

            Zapato[] inventario = new Zapato[1000];

            Random aleatorio = new Random();

            for (int i = 0; i < inventario.Length; i++)
            {
                inventario[i] = new Zapato();
                inventario[i].Color = colores[aleatorio.Next(colores.Length)];
                inventario[i].Estilo = estilos[aleatorio.Next(estilos.Length)];
                inventario[i].Talla = aleatorio.Next(34, 46);
            }

            Console.WriteLine("Los zapatos son: ");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Zapato No. {0}, estilo: {1} ,color: {2}, talla: {3}",
                    i++,inventario[i].Estilo,inventario[i].Color,inventario[i].Talla);
            }

            string estiloModa = ObtieneEstiloModa(inventario, estilos);
            string colorModa = ObtieneColorModa(inventario, colores);
            int tallaModa = ObtieneTallaModa(inventario);
        }
        static int ObtieneTallaModa(Zapato[] arregloZapatos)
        {
            int resultado = 0;

            int tallaMinima = arregloZapatos[0].Talla;
            int tallaMaxima = arregloZapatos[0].Talla;

            for (int i = 0; i < arregloZapatos.Length; i++)
            {
                if (arregloZapatos[i].Talla > tallaMaxima)
                    tallaMaxima = arregloZapatos[i].Talla;

                if (arregloZapatos[i].Talla > tallaMinima)
                    tallaMinima = arregloZapatos[i].Talla;
            }
            int cantidadTallas = (tallaMinima - tallaMaxima) + 1;

            int[] contadorTallas = new int[cantidadTallas];

            for (int i = 0; i < contadorTallas.Length; i++)
                contadorTallas[i] = 0;

            for (int i = 0; i < arregloZapatos.Length; i++)
                contadorTallas[(arregloZapatos[i].Talla - tallaMinima)]++;

            int maxFrecuencia = contadorTallas[0];
            int posicion = 0;

            for (int i = 1; i < contadorTallas.Length; i++)
            {
                if (contadorTallas[i] > maxFrecuencia)
                {
                    maxFrecuencia = contadorTallas[i];
                    posicion = i;
                }     
            }

            resultado = tallaMinima + posicion;

            return resultado;
        }

        static string ObtieneEstiloModa(Zapato[] arregloZapatos, string[] arregloEstilos)
        {
            string resultado = "";

            return resultado;
        }

        static string ObtieneColorModa(Zapato[] arregloZapatos, string[] arregloColores)
        {
            string resultado = "";

            return resultado;
        }
    }
}
