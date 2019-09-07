using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FABRICA_DE_AREPAS
{
    public partial class Form1 : Form
    {
        private CreadorArepas elCreador;
        public Form1()
        {
            InitializeComponent();

            elCreador = new CreadorArepas();
        }

       private void BtnInicio_Click(object sender, EventArgs e)
        {
            elCreador.IncializaArepas();

            //Aqui visualizamos resultados
            txtTotalAsadas.Text = elCreador.TotalAsadas.ToString();
            txtTotalcongeladas.Text = elCreador.TotalCongeladas.ToString();
            txtTotalProcesadas.Text = elCreador.TotalProcesadas.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
