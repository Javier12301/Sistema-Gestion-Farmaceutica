using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Controles.Interfaz
{
    // Este Observador se encargará de revisar cambios en el DataGridView y actualizar el estado de la variable isDatagridViewModified

    public interface IObserverDataGridView
    {
        void Update(bool isDatagridViewModified);
    }

    // Esta clase se encargará de actualizar el estado de la variable isDatagridViewModified
    public class ObservadorDataGridView : IObserverDataGridView
    {
        // Variable que se encargará de almacenar el estado del DataGridView
        private bool isDatagridViewModified;
        // Método que se encargará de actualizar el estado de la variable isDatagridViewModified
        public void Update(bool isDatagridViewModified)
        {
            this.isDatagridViewModified = isDatagridViewModified;
        }
        // Método que se encargará de devolver el estado de la variable isDatagridViewModified
        public bool GetIsDatagridViewModified()
        {
            return isDatagridViewModified;
        }
    }




}
