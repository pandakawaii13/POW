using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FABRICA_DE_AREPAS
{   // El constructor sirva para instanciar
    class ArepaCongelada : Arepa, ICongelable
    { 
        //Los atributos
        private int diasMaximosCongelado;
        //El constructor de la clase
        public ArepaCongelada() : base() //invocar el constructor de la clase padre
        //Si la arepa no tuviera constructor abstracto o un constructor se asigna el valor en la clase hija
        {
            diasMaximosCongelado = 0;
        }
        //cosntructor sobrecargado
        public ArepaCongelada(int numeroMolino, int diasCaducidad, int diasMaximosCongelado) : base(diasCaducidad, numeroMolino)
        {
            this.diasMaximosCongelado = diasMaximosCongelado;
        }
        // propiedad para los atributos
        public int DiasMaximosCongelado
        {
            get { return diasMaximosCongelado; }
            set { diasMaximosCongelado = value; }
        }
        //implemantación
        public string InfoCongelacion()
        {
            string resultado = "Días máximos de congelación: " + diasMaximosCongelado + Environment.NewLine; //environment. new line es el sdalto de líunea
            return resultado;
        }
        //si se implementa no se usa el abstract
        public override string ObtieneInformacion()
        {
            string resultado = "Esta arepa fue congelada. " + Environment.NewLine + "La masa salió del molino" + numeroMolino +
                Environment.NewLine + "Tiene " + diasCaducidad + " dias de caducidad" + Environment.NewLine + InfoCongelacion(); 
            //Se concatena InfoCongelacion para que se lea días máximas de caducación
            return resultado;
        }
    }
}
