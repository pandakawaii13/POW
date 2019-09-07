using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosU
{
    abstract class Jugador
    {
        protected string facultad, torneo;
        protected bool esEntusiasta = false;

        public Jugador()
        {
            facultad = "";
            torneo = "";
        }

        public Jugador(string facultad, string torneo)
        {
            this.facultad = facultad;
            this.torneo = torneo;
        }
        public string Facultad
        {
            get { return facultad; }
            set { facultad = value; }
        }

        public string Torneo
        {
            get { return torneo; }
            set { torneo = value; }
        }
        public abstract string EvaluaEntusiasmo();
       
    }
}
