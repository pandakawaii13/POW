using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarrización_Camiones
{
    class CamionSubsidiado : Camion
    {
        private int cantidadInfracciones;
        private bool viable;

        public CamionSubsidiado() : base()
        {
            cantidadInfracciones = 0;
            viable = false;
        }
        public CamionSubsidiado(int cantidadInfracciones, int tiempoUso, int capacidadCarga, int kmRecorridos) : base(tiempoUso, capacidadCarga, kmRecorridos)
        {
            this.cantidadInfracciones = cantidadInfracciones;
        }
        public int CantidadInfracciones
        {
            get { return cantidadInfracciones; }
        }
        public bool Viable
        {
            get { return viable; }
        }
        public override void InfoCamion() 
        {
            if (chatarrizable == true && cantidadInfracciones <= 5) 
                viable = true;
           /* string resultado = "Su cantidad de infracciones es: " + cantidadInfracciones;
            return resultado;*/
        }
    }
}

