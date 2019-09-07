using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FABRICA_DE_AREPAS
{
    class CreadorArepas
    {
        //Artributos
        private int totalAsadas, totalCongeladas, totalProcesadas;
        private Arepa[] misArepas;
        //constructor de clase
        public CreadorArepas()
        {
            totalAsadas = 0;
            totalCongeladas = 0;
            totalProcesadas = 0;

            misArepas = new Arepa[100];
        }

        //las propiedades de los atributos
        //solo get porque no se necesita que se revalue osea que no se asgina nada desde afuera
        public int TotalAsadas
        {
            get { return totalAsadas; }
        }
        public int TotalCongeladas
        {
            get { return totalCongeladas; }
        }
        public int TotalProcesadas
        {
            get { return totalProcesadas; }
        }
        //void no devuelve ni recibe
        public void IncializaArepas()
        {
            //Cada ejecución de la simulación comienza con los totales en cero
            totalAsadas = 0;
            totalCongeladas = 0;
            totalProcesadas = 0;

            Random aleatorio = new Random(DateTime.Now.Millisecond);

            int tipo = 0; //varibale de apoyo 0: Congelada, 1: Asada, 2: Procesada
            int datoMolino = 0; //Hay 10 molinos
            int datoDiasCaducidad = 0; //Entre 15 y 30 días
            int datoTemperatura = 0; // 60 y 90
            int datoCongelacion = 0; // días entre 20 o 60

            for (int i = 0; i < misArepas.Length; i++)
            {
                tipo = aleatorio.Next(3); // (0,3) va de 0 a 2
                datoMolino = aleatorio.Next(1, 11); // va desde 1 hasta 10
                datoDiasCaducidad = aleatorio.Next(15, 31);

                switch (tipo)
                { 
                    //Del tipo congelada
                    case 0:
                        datoCongelacion = aleatorio.Next(20, 61);
                        misArepas[i] = new ArepaCongelada(datoMolino,datoDiasCaducidad,datoCongelacion); //invocando el constructor sobrecargado
                        //si hace con misArepas no se puede acceder a algo
                        totalCongeladas++;
                        break;
                    //Del tipo asada
                    case 1:
                        datoTemperatura = aleatorio.Next(60, 91);
                        misArepas[i] = new ArepaAsada(datoTemperatura, datoDiasCaducidad, datoMolino);
                        totalAsadas++; // totalAsadas con T mayuscula no se puede porque este busca que se le asigne
                        break;
                    //Del tipo procesada
                    case 2:
                        datoCongelacion = aleatorio.Next(20, 61);
                        datoTemperatura = aleatorio.Next(60, 91);
                        misArepas[i] = new ArepaProcesada(datoCongelacion, datoTemperatura, datoMolino, datoDiasCaducidad);
                        break;
                }
            }
        }
        public string ObtieneTotalInfo()
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < misArepas.Length; i++)
            {
                resultado.Append("Arepa # " + (i + 1) + Environment.NewLine + misArepas[i].ObtieneInformacion()); //(i + 1) para que se evalue primero
            }

            return resultado.ToString();
        }
    }
}
