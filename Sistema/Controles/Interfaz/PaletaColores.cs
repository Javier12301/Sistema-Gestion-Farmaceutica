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
        // Establecer un Singleton
        private static PaletaColores instance = null;
        private PaletaColores() { }
        public static PaletaColores GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PaletaColores();
                }
                return instance;
            }
        }


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

        // Paleta de colores para botones
        Color buttonActive = ColorTranslator.FromHtml("#267da6");
        Color buttonDisabled = ColorTranslator.FromHtml("#fcfcfc");
        Color buttonHoover = ColorTranslator.FromHtml("#3789b4");

        public Color ButtonActive
        {
            get { return buttonActive; }
        }

        public Color ButtonDisabled
        {
            get { return buttonDisabled; }
        }

        public Color ButtonHoover
        {
            get { return buttonHoover; }
        }

        // Paleta de color para botón modificar
        Color buttonModifyActive = ColorTranslator.FromHtml("#a6d95b");
        Color buttonModifyDisabled = ColorTranslator.FromHtml("#b0e068");

        public Color ButtonModifyActive
        {
            get { return buttonModifyActive; }
        }

        public Color ButtonModifyDisabled
        {
            get { return buttonModifyDisabled; }
        }
    }
}
