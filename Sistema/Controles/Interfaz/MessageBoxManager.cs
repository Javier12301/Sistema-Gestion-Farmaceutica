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
        private static MessageBoxManager _instance;
        public static MessageBoxManager GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new MessageBoxManager();
                return _instance;
            }
        }
        private MessageBoxManager()
        {

        }

        // Mensajes de Error en la base de datos
        public void ShowDatabaseUpdateError()
        {
            MessageBox.Show("Hubo un error al actualizar la base de datos. Por favor, contacte al administrador del sistema.", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSqlError()
        {
            MessageBox.Show("Hubo un error en la consulta a la base de datos. Por favor, contacte al administrador del sistema.", "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowUnexpectedError()
        {
            MessageBox.Show("Se produjo un error inesperado. Por favor, contacte al administrador del sistema.", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Mensaje de modificación, poner el nombre del elemento en singular, el sistema se encarga de ponerlo en plural si es necesario
        public void ShowModificationMessage(int modifiedCount, string elementName)
        {
            if (modifiedCount > 0)
            {
                string message;
                if (modifiedCount == 1)
                {
                    message = $"Se modificó correctamente 1 {elementName}.";
                }
                else if(elementName != "proveedor")
                {
                    message = $"Se modificaron correctamente {modifiedCount} {elementName}s.";
                }
                else
                {
                    message = $"Se modificaron correctamente {modifiedCount} {elementName}es.";
                }
                MessageBox.Show(message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ShowDeletionMessage(int modifiedCount, string elementName)
        {
            if (modifiedCount > 0)
            {
                string message;
                if (modifiedCount == 1)
                {
                    message = $"Se eliminó correctamente 1 {elementName}.";
                }
               
                else if(elementName != "proveedor")
                { 
                    message = $"Se eliminarón correctamente {modifiedCount} {elementName}s.";
                }
                else
                {
                    message = $"Se eliminarón correctamente {modifiedCount} {elementName}es.";
                }
               
                MessageBox.Show(message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Mensaje de de Advertencía
        public void ShowMessageCellEmpty()
        {
            MessageBox.Show("No se permite dejar este campo vacío.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
