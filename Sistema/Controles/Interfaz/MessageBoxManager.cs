using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Controles.Interfaz
{
    public class MessageBoxManager
    {
        // Singleton MessageBoxManager
        private static MessageBoxManager _instancia;
        public static MessageBoxManager ObtenerInstancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new MessageBoxManager();
                return _instancia;
            }
        }
        private MessageBoxManager()
        {

        }

        // Mensajes de Error en la base de datos
        // llamar a la clase Error
        public Error Error
        {
            get
            {
                return new Error();
            }
        }

        // Mensajes de Información
        public Informacion Informacion
        {
            get
            {
                return new Informacion();
            }
        }

        // Mensajes de Advertencia
        public Advertencia Advertencia
        {
            get
            {
                return new Advertencia();
            }
        }
             
    }

    // Tipos de Mensajes: Error, Advertencia, Información, Pregunta
    // Clase de mensaje de errores
    public class Error
    {
        // Mensajes de Error SQL
        public void MostrarErrorActualizacionBaseDatos()
        {
            MessageBox.Show("Hubo un error al actualizar la base de datos. Por favor, contacte al administrador del sistema.", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarErrorSQL()
        {
            MessageBox.Show("Hubo un error en la consulta a la base de datos. Por favor, contacte al administrador del sistema.", "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarErrorInesperado()
        {
            MessageBox.Show("Se produjo un error inesperado. Por favor, contacte al administrador del sistema.", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public class Informacion
    {
        // Mensaje de modificación, poner el nombre del elemento en singular, el sistema se encarga de ponerlo en plural si es necesario
        public void MostrarMensajeModificacion(int cantidadModificada, string nombreElemento)
        {
            if (cantidadModificada > 0)
            {
                string mensaje;
                if (cantidadModificada == 1)
                {
                    mensaje = $"Se modificó correctamente 1 {nombreElemento}.";
                }
                else if (nombreElemento != "proveedor")
                {
                    mensaje = $"Se modificaron correctamente {cantidadModificada} {nombreElemento}s.";
                }
                else
                {
                    mensaje = $"Se modificaron correctamente {cantidadModificada} {nombreElemento}es.";
                }
                MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void MostrarMensajeEliminacion(int cantidadModificada, string nombreElemento)
        {
            if (cantidadModificada > 0)
            {
                string mensaje;
                if (cantidadModificada == 1)
                {
                    mensaje = $"Se eliminó correctamente 1 {nombreElemento}.";
                }
                else if (nombreElemento != "proveedor")
                {
                    mensaje = $"Se eliminaron correctamente {cantidadModificada} {nombreElemento}s.";
                }
                else
                {
                    mensaje = $"Se eliminaron correctamente {cantidadModificada} {nombreElemento}es.";
                }
                MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class Advertencia
    {
        public void MostrarMensajeCeldaVacia()
        {
            MessageBox.Show("No se permite dejar este campo vacío.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
