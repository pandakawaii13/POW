using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosU
{
    class JugadorPlataformer : Jugador
    {
        private int nivelesAlcanzados, cantidadRecompensas;

        public JugadorPlataformer() : base()
        {
            nivelesAlcanzados = 0;
            cantidadRecompensas = 0;
        }
        public JugadorPlataformer(int nivelesAlcanzados,
          int cantidadRecompensas)
        {
            this.nivelesAlcanzados = nivelesAlcanzados;
            this.cantidadRecompensas = cantidadRecompensas;
        }

        public int NivelesAlcanzados
        {
            get { return nivelesAlcanzados; }
            set { nivelesAlcanzados = value; }
        }

        public int CantidadRecompensas
        {
            get { return cantidadRecompensas; }
            set { cantidadRecompensas = value; }
        }
        public override string EvaluaEntusiasmo()
        {
            if (nivelesAlcanzados >= 10 && cantidadRecompensas >= 300)
                esEntusiasta = true;
            else
                esEntusiasta = false;

            string resultado = "El jugador es: " + esEntusiasta + "De la facultad: " + facultad +
                "Participó en el torneo: " + torneo + "Sus niveles alcanzados fueron: " 
                + nivelesAlcanzados + "Su cantidad de recompensas fue: " + cantidadRecompensas;

            return resultado;
        }
    }
}
