using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FABRICA_DE_AREPAS
{
    class ArepaAsada : Arepa, IAsable
    {
        //Atributos
        private int temperaturaCoccion;

        public ArepaAsada() : base()
        {
            temperaturaCoccion = 0;
        }

        //se referencia elementos de la clase padre
        public ArepaAsada(int temperaturaCoccion, int diasCaducidad,int numeroMolino) : base(diasCaducidad, numeroMolino)
        {
            this.temperaturaCoccion = temperaturaCoccion;
        }
        //Propiedada del atributo
        public int TemperaturaCoccion
        {
            get { return temperaturaCoccion; }
            set { temperaturaCoccion = value; }
        }
        public string InfoCoccion()
        {
            string resultado = "Temperatura de cocción: " + temperaturaCoccion + Environment.NewLine;
            return resultado;
        }
        public override string ObtieneInformacion()
        {
            string resultado = "Esta arepa fue asada. " + Environment.NewLine + "La masa salió del molino" + numeroMolino +
                Environment.NewLine + "Tiene " + diasCaducidad + " dias de caducidad" + Environment.NewLine + InfoCoccion();
            //Se concatena InfoCongelacion para que se lea días máximas de caducación
            return resultado;
        }
    }
}
