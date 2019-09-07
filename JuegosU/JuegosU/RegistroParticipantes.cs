using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosU
{
    class RegistroParticipantes
    {
        private int totalCarrera,totalCombate,totalPlataformer, totaljugadores, totaljugadoresE;
        private Jugador[] jugadores;

        public RegistroParticipantes()
        {
            Jugador[] jugadores = new Jugador[600];
            totaljugadores = 0;
            totaljugadoresE = 0;
            totalCarrera = 0;
            totalCombate = 0;
            totalPlataformer = 0;
        }

        public int TotalJugadores
        {
            get { return totaljugadores; }
        }
        public int TotalJugadoresE
        {
            get { return totaljugadoresE; }
        }
        public void InicizalizaSimulacion()
        {
            totaljugadores = 0;
            totaljugadoresE = 0;
            totalCarrera = 0;
            totalCombate = 0;
            totalPlataformer = 0;

            Random aleatorio = new Random(DateTime.Now.Millisecond);

            int tipoTorneo = 0; // 0: Carrera, 1: Combate, 2: Plataformer
            string[] datoFacultades = {"MCIA", "MCIB", "MCIC", "MCIE", "MCIG", "MCII", "MCIL", "MCIM",
                "MCIO", "MCIQ", "MCIT", "MCNT" };
            int datoNivelesAlcanzados = 0; //Entre 0 y 100 niveles
            int datoCantidadRecompensas = 0;  // 0 y 1000
            int datoCarrerasGanadas = 0; // 0 y 20
            int datoKmRecorridos = 0; // 0 y 1000
            int datoBatallasGanadas = 0; // 0 y 100
            int datoNivelEnergia = 0; // 0 y 100

            for (int i = 0; i < jugadores.Length; i++)
            {
                tipoTorneo = aleatorio.Next(3);  
                jugadores[i].Facultad = datoFacultades[aleatorio.Next(datoFacultades.Length)];

                switch (tipoTorneo)
                {
                    
                    case 0:
                        datoCarrerasGanadas = aleatorio.Next(0, 21);
                        datoKmRecorridos = aleatorio.Next(0, 1001);
                        jugadores[i] = new JugadorCarrera(datoCarrerasGanadas,
                            datoKmRecorridos);
                        totalCarrera++;
                        break;

                    case 1:
                        datoBatallasGanadas = aleatorio.Next(0, 101);
                        datoNivelEnergia = aleatorio.Next(0, 101);
                        jugadores[i] = new JugadorCombate(datoBatallasGanadas,
                            datoNivelEnergia);

                        totalCombate++; 
                        break;

                    case 2:
                        datoNivelesAlcanzados = aleatorio.Next(0, 101);
                        datoCantidadRecompensas = aleatorio.Next(0, 1001);
                        jugadores[i] = new JugadorPlataformer(datoNivelesAlcanzados,
                            datoCantidadRecompensas);
                        totalPlataformer++;
                        break;
                }
                totaljugadores = totalCarrera + totalCombate + totalPlataformer; 
            }
        }
    }
}

