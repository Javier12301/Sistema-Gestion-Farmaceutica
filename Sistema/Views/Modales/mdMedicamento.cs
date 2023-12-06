using Sistema.Controles.Interfaz;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Views.Modales
{
    public partial class mdMedicamento : Form
    {
        MessageBoxManager sGestorMensajes = MessageBoxManager.ObtenerInstancia;
        private Point mouseDownLocation;
        public MEDICAMENTO medicine { get; set; }
        public mdMedicamento()
        {
            InitializeComponent();
        }

        private void mdProducto_Load(object sender, EventArgs e)
        {
            //this.vistaInventarioTableAdapter.Fill(farmaciaDBDataSet.VistaInventario);
            loadCMBData();
        }



        // // /// /// INTERFAZ /// /// /// //

        // Cargar Combobox de Filtros
        private void loadCMBData()
        {
            // Cargar ComboBox de Filtros con código, lote, nombre, estante y categoría
            cmbFiltro.Items.Add("Código");
            cmbFiltro.Items.Add("Lote");
            cmbFiltro.Items.Add("Nombre");
            cmbFiltro.Items.Add("Estante");
            cmbFiltro.Items.Add("Categoría");
            cmbFiltro.SelectedIndex = 0;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterData();
            }
            catch (DbUpdateException)
            {
                // Excepción relacionada con problemas de actualización en la base de datos
                sGestorMensajes.Error.MostrarErrorActualizacionBaseDatos();

                // Loguear dbEx si es necesario para fines de depuración
            }
            catch (SqlException)
            {
                // Excepción relacionada con errores de SQL
                sGestorMensajes.Error.MostrarErrorSQL();
                // Loguear sqlEx si es necesario para fines de depuración
            }
            catch (Exception)
            {
                // Otras excepciones no manejadas
                sGestorMensajes.Error.MostrarErrorInesperado();
                // Loguear ex si es necesario para fines de depuración
            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                filterData();
            }
            catch (DbUpdateException)
            {
                // Excepción relacionada con problemas de actualización en la base de datos
                sGestorMensajes.Error.MostrarErrorActualizacionBaseDatos();

                // Loguear dbEx si es necesario para fines de depuración
            }
            catch (SqlException)
            {
                // Excepción relacionada con errores de SQL
                sGestorMensajes.Error.MostrarErrorSQL();
                // Loguear sqlEx si es necesario para fines de depuración
            }
            catch (Exception)
            {
                // Otras excepciones no manejadas
                sGestorMensajes.Error.MostrarErrorInesperado();
                // Loguear ex si es necesario para fines de depuración
            }
        }



        // Función para filtrar los datos de la tabla
        private void filterData()
        {
            if (txtBusqueda.Text != string.Empty)
            {
                // Solo se buscarán los medicamentos que estén activos
                //this.vistaInventarioTableAdapter.Filter(farmaciaDBDataSet.VistaInventario, cmbFiltro.Text, txtBusqueda.Text, null, null, true);
            }
            else
            {
                //this.vistaInventarioTableAdapter.Fill(farmaciaDBDataSet.VistaInventario);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectMedicine(e.RowIndex);

            }
            catch (Exception)
            {
                sGestorMensajes.Error.MostrarErrorInesperado();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos el index de la fila donde se encuentra la celda seleccionada
                int rowIndex = dgvdata.CurrentCell.RowIndex;
                if (rowIndex >= 0 && dgvdata.SelectedRows.Count > 0)
                {
                    selectMedicine(rowIndex);
                }
                else
                {
                    MessageBox.Show("Error: No se ha seleccionado ningún medicamento.\nPor favor, seleccione al menos un medicamento de la lista antes de continuar con esta operación.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                sGestorMensajes.Error.MostrarErrorInesperado();
            }
        }

        private void selectMedicine(int rowIndex)
        {
            // La fila debe ser mayor a 0     
            if (rowIndex >= 0)
            {
                //Instanciamos el objeto medicamento
                medicine = new MEDICAMENTO();
                medicine.MedicamentoID = Convert.ToInt32(dgvdata.Rows[rowIndex].Cells[0].Value);
                // Cerramos el formulario
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pnlControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - mouseDownLocation.X;
                int deltaY = e.Y - mouseDownLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void pnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }





        // /// // /// FIN INTERFAZ /// /// /// //
    }
}
