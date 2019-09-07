using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosU
{
    class JugadorCarrera : Jugador
    {
        private int carrerasGanadas, kmRecorridos;

        public JugadorCarrera() : base()
        {
            carrerasGanadas = 0;
            kmRecorridos = 0;
        }
        public JugadorCarrera(int carrerasGanadas,
          int kmRecorridos)
        {
            this.carrerasGanadas = carrerasGanadas;
            this.kmRecorridos = kmRecorridos;
        }

        public int CarrerasGanadas
        {
            get { return carrerasGanadas; }
            set { carrerasGanadas = value; }
        }

        public int KmRecorridos
        {
            get { return kmRecorridos; }
            set { kmRecorridos = value; }
        }
        public override string EvaluaEntusiasmo()
        {
            if (carrerasGanadas >= 8 && kmRecorridos >= 200)
                esEntusiasta = true;
            else
                esEntusiasta = false;

            string resultado = "El jugador es: " + esEntusiasta + "De la facultad: " + facultad +
                "Participó en el torneo: " + torneo + "Ganó #" + carrerasGanadas + " carreras" +
                "Su kms recorridos fueron: " + kmRecorridos;

            return resultado;
        }
    }
}
