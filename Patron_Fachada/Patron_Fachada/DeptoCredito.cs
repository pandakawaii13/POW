using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Fachada
{
    class DeptoCredito
    {
        //asigan reptación bsadao en el puntaje de datacrédito
        public void AsignaReputacion(Cliente unCliente) //con esto se modifica, todo esto es porque pasa el objeto por referencia
        {
            if (unCliente.PuntajeDataCredito > 800)
                unCliente.ReputacionCredito = "A";

            if (unCliente.PuntajeDataCredito > 600 && unCliente.PuntajeDataCredito <= 800)
                unCliente.ReputacionCredito = "B";

            if (unCliente.PuntajeDataCredito > 400 && unCliente.PuntajeDataCredito <= 600)
                unCliente.ReputacionCredito = "C";

            if (unCliente.PuntajeDataCredito <= 400)
                unCliente.ReputacionCredito = "D";

        }
    }
}
