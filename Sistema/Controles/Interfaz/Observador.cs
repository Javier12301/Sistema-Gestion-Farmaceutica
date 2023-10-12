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

    public class ObservadorDataGridView : IObserverDataGridView
    {
        private bool isDatagridViewModified;
        public void Update(bool isDatagridViewModified)
        {
            this.isDatagridViewModified = isDatagridViewModified;
        }
        public bool GetIsDatagridViewModified()
        {
            return isDatagridViewModified;
        }
    }




}
