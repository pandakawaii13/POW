using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FABRICA_DE_AREPAS
{
    class ArepaProcesada : Arepa, IAsable, ICongelable
    {
        //Los atributos
        private int diasMaximosCongelado, temperaturaCoccion;
        //constructor de la clase
        public ArepaProcesada() : base()
        {
            diasMaximosCongelado = 0;
            temperaturaCoccion = 0;
        }
        //constructor sobrecargado de arepa procesada que invoca el constructor de la clase padre
        public ArepaProcesada (int diasMaximosCongelado, int temperaturaCoccion, int numeroMolino, int diasCaducidad) : base (diasCaducidad, numeroMolino)
        {
            this.diasMaximosCongelado = diasMaximosCongelado;
            this.temperaturaCoccion = temperaturaCoccion;
        }
        public int DiasMaximosCongelado
        {
            get { return diasMaximosCongelado; }
            set { diasMaximosCongelado = value; }
        }
        public int TemperaturaCoccion
        {
            get { return temperaturaCoccion; }
            set { temperaturaCoccion = value; }
        }
        public string InfoCoccion()
        {
            string resultado = "Temperatura de cocción en proceso: " + temperaturaCoccion + Environment.NewLine;
            return resultado;
        }
        public string InfoCongelacion()
        {
            string resultado = "Días máximos de congelación en proceso: " + diasMaximosCongelado + Environment.NewLine; //environment. new line es el sdalto de líunea
            return resultado;
        }
        public override string ObtieneInformacion()
        {
            string resultado = "Esta arepa fue procesada. " + Environment.NewLine + "La masa salió del molino" + numeroMolino +
                Environment.NewLine + "Tiene " + diasCaducidad + " dias de caducidad" + Environment.NewLine + InfoCongelacion() + InfoCoccion();
            //Se concatena InfoCongelacion para que se lea días máximas de caducación
            return resultado;
        }
    }
}
