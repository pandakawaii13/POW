using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFiguras
{
    class Triangulo : Figura
    {
        private string v_tipo;
        private int v_base, v_altura; //atributos

        public Triangulo()
        {
            v_tipo = "";
            v_base = 0;
            v_altura = 0;
            centroX = 10;
            centroY = 10;
        }

        public Triangulo(int p_cx, int p_cy) //parametros u argumentos
        {
            v_tipo = "";
            v_base = 0;
            v_altura = 0;
            centroX = p_cx;
            centroY = p_cy;
        }

        public Triangulo(string p_tipo, int p_altura, int p_base, int p_cx, int p_cy)
        {
            v_tipo = p_tipo;
            v_base = p_base;
            v_altura = p_altura;
            centroX = p_cx;
            centroY = p_cy;
        }

        public int V_base 
        {
            get { return v_base; }
            set { v_base = value; }
        }
        public string V_tipo {
            get { return v_tipo; }
            set { v_tipo = value; }
        }
        public int V_altura {
            get { return v_altura; }
            set { v_altura = value; }
        }

        public override string Info()
        {
            string resultado = "El triangulo tiene base" + v_base + "y altura" + v_altura;

            return resultado;
        }
    }
}
