using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strangers Things: ¡Liberando a Will… otra vez!");
            Console.WriteLine("Se recolectan 3 artefactos por amigo,el poder místico va desde 1 a 100 puntos");
            Console.WriteLine("Meta individual: 250 puntos, para liberar a Will debe haber 1230 puntos.\n");

            string[] amigos = { "Mike", "Lucas", "Dustin", "Eleven", "Max" };
            int[] totalPuntajesChicos = new int[amigos.Length];

            int Artefactos, poderArtefacto, metaLograda = 0;

            for (int i = 0; i < amigos.Length; i++)
            {
                Console.WriteLine("\n # de artefactos recolectados por", amigos[i]);

                totalPuntajesChicos[i] = 0;
                Artefactos = 0;

                while (Artefactos < 3)
                {
                    try
                    {
                        Console.Write("Ingrese el poder mistico del artefacto # ", Artefactos + 1);
                        poderArtefacto = int.Parse(Console.ReadLine());

                        
                        if (poderArtefacto >= 1 && poderArtefacto <= 100)
                        {
                            totalPuntajesChicos[i] += poderArtefacto;
                            Artefactos++;
                        }
                        else
                            Console.WriteLine("El puntaje del poder místico no está en el rango permitido. Vamos de nuevo! \n");
                    }
                    catch (FormatException error)
                    {
                        Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                        Console.WriteLine("Error: " + error.Message + "\n");
                    }                  
                }
                metaLograda += totalPuntajesChicos[i];
            }
            float[] porcentajesChicos = CalculaPorcentajes(totalPuntajesChicos);

            Console.WriteLine("\nResultados alcanzados por cada chico:\n");

            for (int i = 0; i < amigos.Length; i++)
            {
                Console.WriteLine(
                    amigos[i],
                    totalPuntajesChicos[i],
                    porcentajesChicos[i].ToString("00.00"),
                    CumpleMeta(totalPuntajesChicos[i]));
            }
            Console.WriteLine("\nLa meta lograda fue de {0}", metaLograda);
            if (metaLograda >= 1200)
                Console.WriteLine("Se logró la meta de 1200 puntos para liberar a Will");
            else
                Console.WriteLine("No se logró la meta de 1200 puntos, el pueblo de Hawkins está condenado a su destrucción!");
        }
        static float[] CalculaPorcentajes(int[] arregloValores)
        {
            float[] porcentajes = new float[arregloValores.Length];
            int total = 0;

           
            for (int i = 0; i < arregloValores.Length; i++)
                total += arregloValores[i];

          
            for (int i = 0; i < porcentajes.Length; i++)
                porcentajes[i] = ((float)arregloValores[i] / total) * 100;

            return porcentajes;
        }
        static string CumpleMeta(int valor)
        {
            string resultado = "";

            if (valor >= 250)
                resultado = "Cumple la meta de 250";
            else
                resultado = "No cumple la meta de 250";

            return resultado;
        }
    }
}
/* int[] artefactos = { int.Parse(Console.ReadLine()) };
                int ptsmisticos = 0;
                Random aleatorio = new Random();
                ptsmisticos = aleatorio.Next(1, 101); */
