using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFiguras
{
    class Figura
    {
        protected int centroX, centroY; //se usa protected para darle acceso a las clases hijas

        public Figura()
        {
            centroX = 0;
            centroY = 0;
        }

        public int CentroX
        {
            get { return centroX;}
            set { centroX = value;}
        }
        public int CentroY {
            get { return centroY;}
            set { centroY = value;}
        }

        public virtual string Info()
        {
            string resultado = "La figura tiene centro en " + centroX + "," + centroY + ")";

            return resultado;
        }
    }
}
