using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Controles
{
    public class PaletaColores
    {     
        //Paletas de colore que se usaran en su mayoría en el sistema
            Color colorActive = ColorTranslator.FromHtml("#5AA8E1");
            Color colorError = ColorTranslator.FromHtml("#FF4136");
            Color colorDisabled = ColorTranslator.FromHtml("#CCCCCC");
     
        public Color ColorActive
        {
            get { return colorActive; }
        }
        
        public Color ColorError
        {
            get { return colorError; }
        }

        public Color ColorDisabled
        {
            get { return colorDisabled; }
        }
    }
}
