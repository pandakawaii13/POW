using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FABRICA_DE_AREPAS
{
    interface ICongelable
    {
        string InfoCongelacion(); //no se coloca private o protected en las interfaces 
        //todos los elementos de la intefaz son predeterminada/. público
    }
}
