using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Fachada
{
    class Cliente
    {
        //atributos de la clase
        private string nombre;
        private int valorPrestamo, valorCesantias, puntajeDataCredito;
        private string reputacionCredito;
        private bool estadoSolicitud;
        private float montoMaximo;


        //constructor de la clase
        public Cliente()
        {
            nombre = "";
            valorPrestamo = 0;
            valorCesantias = 0;
            puntajeDataCredito = 0;
            reputacionCredito = "D";
            montoMaximo = 0f;
            estadoSolicitud = false;
        }
        public Cliente(string nombre, int valorPrestamo, int valorCesantias, int puntajeDataCredito)
        {
            Nombre = nombre;
            ValorPrestamo = valorPrestamo;
            ValorCesantias = valorCesantias;
            PuntajeDataCredito = puntajeDataCredito;
            reputacionCredito = "D";
            montoMaximo = 0f;
            estadoSolicitud = false;
        }
        //propiedades para los atributos

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int ValorPrestamo
        {
            get { return valorPrestamo; }
            set
            {
                if (value > 0)
                    valorPrestamo = value;
                else
                    valorPrestamo = 0;
            }
        }

        public int ValorCesantias
        {
            get { return valorCesantias; }
            set
            {
                if (value > 0)
                    valorCesantias = value;
                else
                    valorCesantias = 0;
            }
        }

        public int PuntajeDataCredito
        {
            get { return puntajeDataCredito; }
            set
            {
                if (value > 0)
                    puntajeDataCredito = value;
                else
                    puntajeDataCredito = 0;
            }
        }

        public bool EstadoSolicitud
        {
            get { return estadoSolicitud; }
            set { estadoSolicitud = value; }
        }

        public float MontoMaximo
        {
            get { return montoMaximo; }
            set
            {
                if (value > 0f)
                    montoMaximo = value;
                else
                    montoMaximo = 0f;
            }
        }

        public string ReputacionCredito
        {
            get { return reputacionCredito; }
            set {
                if (value == "A" || value == "B" || value == "C" || value == "D")
                    reputacionCredito = value;
                else
                    reputacionCredito = "D";
                    }
        }
    }
}
