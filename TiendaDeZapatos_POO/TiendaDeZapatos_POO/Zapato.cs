using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeZapatos_POO
{
    class Zapato
    {
        //atributos
        private int talla;
        private string color, estilo;

        //constructor

        public Zapato()
        {
            talla = 0;
            color = "sin color";
            estilo = "horrible";
        }

        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Talla
        {
            get { return talla; }
            set {
                if (value >= 34 && value <= 45)
                    talla = value;
            }
        }

    }
}
