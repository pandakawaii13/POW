using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FABRICA_DE_AREPAS
{
    abstract class Arepa //algo dentro de la definición debe ser abstracto
    {
        //atributos

        protected int numeroMolino, diasCaducidad;
        //asignación de atributos
        public Arepa()
        {
            numeroMolino = 0;
            diasCaducidad = 0;
        }

        //sino hay constructor no se pone Arepa ();
         public Arepa(int diasCaducidad, int numeroMolino)
        {
            this.diasCaducidad = diasCaducidad;
            this.numeroMolino = numeroMolino;
        }
        public int NumeroMolino
        {
            get { return numeroMolino; }
            set { numeroMolino = value; }
        }
        public int DiasCaducidad
        {
            get { return diasCaducidad; }
            set { diasCaducidad = value; }
        }
        //Metodos get/set para los atributos
        public int GetNumeroMolino()
        {
            return numeroMolino;
        }

        public void SetNumeroMolino(int numeroMolino)
        {
            this.numeroMolino = numeroMolino;
        }

        public abstract string ObtieneInformacion();

    }
}
