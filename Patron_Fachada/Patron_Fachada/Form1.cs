using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patron_Fachada
{
    public partial class Form1 : Form
    {
        private EntidadCrediticia laEntidad;
        public Form1()
        {
            InitializeComponent();

            laEntidad = new EntidadCrediticia();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEvaluaCredito_Click(object sender, EventArgs e)
        {

            try
            {
                //Asignar info del cliente
                laEntidad.AsignaInfoCliente(
                    textNombreCliente.Text,
                    int.Parse(textValorPrestamo.Text), int.Parse(textValorCesantias.Text), int.Parse(textPuntajeDatacredito.Text));


                //validación para realizar crédito

                if (laEntidad.ValidaInfoCliente() == false)
                {
                    MessageBox.Show
                        ("Los valores de préstamo, cesantías y puntaje datacrédito deben ser númericos positivos", "Valores númericos incorrectos"
                        ,MessageBoxButtons.OK, MessageBoxIcon.Warning
                        );
                }
                else
                {
                    //laEntidad.EstudiaCredito();
                    //Se visualiza el resultado de la validación
                    laEntidad.EstudiaCredito();
                    textResultadoValidacion.Text = laEntidad.ObtieneResultadoValidacion();
                }
            }

            catch (FormatException elError)
            {
                MessageBox.Show("Los valores deben ser númericos a excepción del nombre! ", "Madre mía", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

