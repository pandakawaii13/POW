using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Fachada
{
    class EntidadCrediticia //FACHADA
    {
        //atributos de la clase
        Cliente elCliente;
        DeptoCredito elDeptoCredito;
        DeptoMontos elDeptoMontos;
        DeptoJuridico elDeptoJuridico;

        //constructor de la clase

        public EntidadCrediticia()
        {
            elCliente = new Cliente();
            elDeptoCredito = new DeptoCredito();
            elDeptoMontos = new DeptoMontos();
            elDeptoJuridico = new DeptoJuridico();
        }

        public void AsignaInfoCliente(string nombre,int valorPrestamo, int valorCesantias, int puntajeDataCredito)
        {
            elCliente.Nombre = nombre;
            elCliente.ValorPrestamo = valorPrestamo;
            elCliente.ValorCesantias = valorCesantias;
            elCliente.PuntajeDataCredito = puntajeDataCredito;
        }

        public bool ValidaInfoCliente()
        {
            bool resultado = false;

            if (elCliente.ValorPrestamo == 0 || elCliente.ValorCesantias == 0 || elCliente.PuntajeDataCredito == 0)

                resultado = false;
            else
                resultado = true;
            return resultado;
        }

        public void EstudiaCredito() //ORQUESTA
        {
            //evaluar reputación credicticia
            elDeptoCredito.AsignaReputacion(elCliente);

            //Calculamos el monto maximo del prestamo
            elDeptoMontos.AsignaMontoMaximo(elCliente);

            //SE EVALUA SI LA SOLICITUD SE PUEDE APROBAR

            elDeptoJuridico.AsignaEstadoSolicitud(elCliente);
        }

        public string ObtieneResultadoValidacion()
        {
            StringBuilder resultado = new StringBuilder();

            resultado.Append("El cliente" + elCliente.Nombre + "ha solicitado un crédito por un valor de" + elCliente.ValorPrestamo);

            resultado.Append(Environment.NewLine + "El Departamento de Créditos puntaje datacrédito" + elCliente.PuntajeDataCredito + "le da una reputación crediticia de" + elCliente.ReputacionCredito);

            resultado.Append(Environment.NewLine + "El Departamento de Montos puntaje de cesantías" + elCliente.ValorCesantias + "en conjunto con la reputación crediticia le permite un monto máximo de "
                + elCliente.MontoMaximo.ToString("0.00"));

            resultado.Append(Environment.NewLine + "El Departamento Juridico dice que la solicitud está: " );
            if (elCliente.EstadoSolicitud)
                resultado.Append("APROBADA ♥");
            else
                resultado.Append("DENEGADA ☻");
            return resultado.ToString();
        }
    }
}
