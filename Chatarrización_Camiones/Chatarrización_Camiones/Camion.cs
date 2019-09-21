using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarrización_Camiones
{
    class Camion
    {
        protected int tiempoUso, capacidadCarga, kmRecorridos;
        protected bool chatarrizable = false;

        public Camion()
        {
            tiempoUso = 0;
            capacidadCarga = 0;
            kmRecorridos = 0;
        }
         public Camion(int tiempoUso, int capacidadCarga, int kmRecorridos)
        {
           this.tiempoUso = tiempoUso;
           this.capacidadCarga = capacidadCarga;
           this.kmRecorridos = kmRecorridos;
        }
        public int TiempoUso
        {
            get { return tiempoUso; }
        }
        public int CapacidadCarga
        {
            get { return capacidadCarga; }
        }
        public int KmRecorridos
        {
            get { return kmRecorridos; }
        }
        public bool Chatarrizable
        {
            get { return chatarrizable; }
        }
        public virtual void InfoCamion() 
        {
            if (tiempoUso > 15 && capacidadCarga < 18 && kmRecorridos > 4)
                chatarrizable = true;
           /* string resultado = "Su tiempo de uso es: " + tiempoUso +
                               ", Su capacidad de carga es: " + capacidadCarga +
                               ", Sus kilometros recorridos son: " + kmRecorridos;
            return resultado;*/
        }
    }
}
