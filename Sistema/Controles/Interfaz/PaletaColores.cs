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
        private static PaletaColores instancia = null;
        private PaletaColores() { }
        public static PaletaColores ObtenerInstancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new PaletaColores();
                }
                return instancia;
            }
        }

        // Paletas de colores que se usarán en su mayoría en el sistema
        Color colorActivo = ColorTranslator.FromHtml("#5AA8E1");
        Color colorError = ColorTranslator.FromHtml("#FF4136");
        Color colorDeshabilitado = ColorTranslator.FromHtml("#CCCCCC");

        public Color ColorActivo
        {
            get { return colorActivo; }
        }

        public Color ColorError
        {
            get { return colorError; }
        }

        public Color ColorDeshabilitado
        {
            get { return colorDeshabilitado; }
        }

        // Paleta de colores para botones
        Color colorBotonActivo = ColorTranslator.FromHtml("#267da6");
        Color colorBotonDeshabilitado = ColorTranslator.FromHtml("#fcfcfc");
        Color colorBotonHover = ColorTranslator.FromHtml("#3789b4");

        public Color ColorBotonActivo
        {
            get { return colorBotonActivo; }
        }

        public Color ColorBotonDeshabilitado
        {
            get { return colorBotonDeshabilitado; }
        }

        public Color ColorBotonHover
        {
            get { return colorBotonHover; }
        }

        // Paleta de color para botón modificar
        Color colorBotonModificarActivo = ColorTranslator.FromHtml("#a6d95b");
        Color colorBotonModificarDeshabilitado = ColorTranslator.FromHtml("#b0e068");

        public Color ColorBotonModificarActivo
        {
            get { return colorBotonModificarActivo; }
        }

        public Color ColorBotonModificarDeshabilitado
        {
            get { return colorBotonModificarDeshabilitado; }
        }
    }
}
