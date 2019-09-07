using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosU
{
    class JugadorCombate : Jugador
    {
        private int batallasGanadas, nivelEnergia;

        public JugadorCombate() : base()
        {
            batallasGanadas = 0;
            nivelEnergia = 0;
        }
        public JugadorCombate(int batallasGanadas,
          int nivelEnergia) 
        {
            this.batallasGanadas = batallasGanadas;
            this.nivelEnergia = nivelEnergia;
        }

        public int BatallasGanadas
        {
            get { return batallasGanadas; }
            set { batallasGanadas = value; }
        }

        public int NivelEnergia
        {
            get { return nivelEnergia; }
            set { nivelEnergia = value; }
        }

        public override string EvaluaEntusiasmo()
        {
            if (batallasGanadas >= 30 && nivelEnergia >= 60)
                esEntusiasta = true;
            else
                esEntusiasta = false;

            string resultado = "El jugador es: " + esEntusiasta + "De la facultad: "+ facultad +
                "Participó en el torneo: " + torneo + "Ganó #" + batallasGanadas + " batallas"+
                "Su nivel de energía fue: " + nivelEnergia ;

            return resultado;
        }
    }
}
