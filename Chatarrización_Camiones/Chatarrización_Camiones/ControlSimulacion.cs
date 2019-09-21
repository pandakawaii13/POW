using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarrización_Camiones
{
    class ControlSimulacion
    {
        private CamionSubsidiado[] losCamiones;

        public ControlSimulacion()
        {
            losCamiones = new CamionSubsidiado[1000];
            InicializaSimulacion();
        }
        public void InicializaSimulacion()
        {
            Random aleatorio = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < losCamiones.Length; i++)
            {
                losCamiones[i] = new CamionSubsidiado(aleatorio.Next(5),
                 aleatorio.Next(31),
                 aleatorio.Next(15, 250) / 10,
                 aleatorio.Next(8,130) / 10);

                losCamiones[i].InfoCamion();
            }
        }
        public string InformacionPrograma()
        {
            StringBuilder resultado = new StringBuilder();

            resultado.Append("Resultados de la ejecución:" + Environment.NewLine + Environment.NewLine);
            resultado.Append(ObtieneCamionesSubsidiados() + Environment.NewLine);

            return resultado.ToString();
        }
        private string ObtieneCamionesSubsidiados()
        {
            int[] contadorViables = new int[losCamiones.Length];

            for (int i = 0; i < contadorViables.Length; i++)
                contadorViables[i] = 0;

            for (int i = 0; i < losCamiones.Length; i++)
                    if (losCamiones[i] == losCamiones[i].InfoCamion)
                        contadorViables[i]++;

        }
    }
}
