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
    public partial class mdProveedor : Form
    {
        MessageBoxManager sGestorMensajes = MessageBoxManager.ObtenerInstancia;
        private Point mouseDownLocation;
        public PROVEEDOR supplier { get; set; }

        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {           
            loadDataSupplier();
            loadCMBData();
        }


        // // /// /// INTERFAZ /// /// /// //
        private void loadDataSupplier()
        {
            //this.pROVEEDORTableAdapter.Fill(this.farmaciaDBDataSet.PROVEEDOR);

        }
        // Cargar Combobox de Filtros
        private void loadCMBData()
        {
            // Cargar ComboBox de Filtros con código, lote, nombre, estante y categoría
            cmbFiltro.Items.Add("Razón Social");
            cmbFiltro.Items.Add("Documento");
            cmbFiltro.Items.Add("Teléfono");
            cmbFiltro.Items.Add("Correo");
            cmbFiltro.SelectedIndex = 0;
        }


        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData();
        }


        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            filterData();
        }

        // Función para filtrar los datos de la tabla
        private void filterData()
        {
            try
            {
                if (txtBusqueda.Text != string.Empty)
                {
                    //pROVEEDORTableAdapter.Filter(farmaciaDBDataSet.PROVEEDOR, cmbFiltro.Text, txtBusqueda.Text);
                }
                else
                {
                    loadDataSupplier();
                }
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectMedicine(e.RowIndex);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // Obtenemos el index de la fila donde se encuentra la celda seleccionada
            int rowIndex = dgvdata.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                selectMedicine(rowIndex);
            }
            else
            {
                MessageBox.Show("Error: No se ha seleccionado ningún proveedor.\nPor favor, seleccione al menos un proveedor de la lista antes de continuar con esta operación.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectMedicine(int rowIndex)
        {
            // La fila debe ser mayor a 0
            if (rowIndex >= 0)
            {
                //Instanciamos el objeto medicamento
                supplier = new PROVEEDOR();
                supplier.ProveedorID = Convert.ToInt32(dgvdata.Rows[rowIndex].Cells[0].Value);
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

        // // /// /// FIN INTERFAZ /// /// /// //
    }

}
