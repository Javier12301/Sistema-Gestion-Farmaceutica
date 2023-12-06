using Sistema.Controles.Interfaz;
using Sistema.Controles.Logica;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistema.Vista
{

    public partial class MedicamentosForm : Form
    {
        //private CategoriaLogica lCategoria = new CategoriaLogica();
        private EstanteLogica shelfLogic = new EstanteLogica();
        private MedicamentoLogica lMedicina = new MedicamentoLogica();
        Controladora controladora = Controladora.ObtenerInstancia;
        private MessageBoxManager sGestorMensajes = MessageBoxManager.ObtenerInstancia;
        private int originalRowCount { get; set; }
        private int cmbTextRow { get; set; }

        public MedicamentosForm()
        {
            InitializeComponent();
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            originalRowCount = dgvMedicineList.RowCount;
            // Cargar combobox de filtros
            loadCMBData();
            loadDateTimePicker();
            loadMedicine();
            // Establecer nuevo tamaño al formulario
            this.Size = new Size(695, 483);
            // Establecer tamaño de botones de imprimir, pdf y excel
            actualizarFilasTotales();
            // Desactivar datagridview ID
            tsmiID.Checked = false;
        }

        // Cargar datos en el datagridview

       

        private void loadMedicine()
        {
            try
            {
                // No permitir que se vea la primera fila del datagridview
                //this.vistaInventarioTableAdapter.Top(this.farmaciaDBDataSet.VistaInventario, Convert.ToInt32(cmbFilas.Text));
                dtaFilter();
                // Comprobar si se dejaron filtros activados
                if (txtBuscar.Text != string.Empty)
                {
                    //this.vistaInventarioTableAdapter.Filter(this.farmaciaDBDataSet.VistaInventario, cmbEstado.Text, txtBuscar.Text, null, null, null);
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



        // // // /// AGREGAR, MODIFICAR, ELIMINAR // // // //
        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            OpenMedicineForm(null);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            openMedicineFormForModification();
        }

        private void dgvMedicineList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                openMedicineFormForModification();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                deleteSelectedMedicine();
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

        ////ELIMINAR ////
        // Obtener mensaje confirmación para eliminar medicamento
        private string mensajeConfirmacionEliminar()
        {
            string mensaje = "";
            if (dgvMedicineList.SelectedRows.Count > 1)
            {
                List<string> medicineNames = getSelectedMedicinesNames();
                for (int i = 0; i < medicineNames.Count; i++)
                {
                    medicineNames[i] = $"- {medicineNames[i]}";
                }
                mensaje = "¿Está seguro que desea eliminar los siguientes medicamentos?\n\n" + string.Join("\n", medicineNames);

            }
            else if (dgvMedicineList.SelectedRows.Count == 1)
            {
                string medicineName = getSelectedMedicinesNames()[0];
                mensaje = "¿Está seguro que desea eliminar el medicamento " + medicineName + "?";
            }
            return mensaje;
            // Lista para almacenar los nombres de los medicamentos seleccionados
        }


        private void deleteSelectedMedicine()
        {
            if (dgvMedicineList.SelectedRows.Count > 0)
            {
                int medicineCount = dgvMedicineList.SelectedRows.Count;
                string mensaje = mensajeConfirmacionEliminar();
                DialogResult userConfirmation = MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow fila in dgvMedicineList.SelectedRows)
                    {
                        int selectedMedicineID = Convert.ToInt32(fila.Cells[0].Value);
                        bool medicineDeleted = lMedicina.DeleteMedicine(selectedMedicineID);
                        if (!medicineDeleted)
                        {
                            MessageBox.Show("La operación ha sido cancelada debido a un error inesperado.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La operación ha sido cancelada.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sGestorMensajes.Informacion.MostrarMensajeEliminacion(medicineCount, "medicamento");
                loadMedicine();
            }
        }
        // // // ///  AGREGAR, MODIFICAR, ELIMINAR // // // //

        // // // // INTERFAZ // // // //

        private void loadDateTimePicker()
        {
            // Se establecerá fecha por default la actual y la fecha final será 10 años
            dtaDesdeVTO.Value = DateTime.Now;
            // Se sumara 10 años a la fecha actual
            dtaHastaVTO.Value = DateTime.Now.AddYears(10);
        }

        // Cargar ComboBox //
        private void loadCMBData()
        {
            // Primero, se carga el combobox de filtros de filas, se cargarán con valores: 10, 20, 50, 100, 200
            cmbFilas.Items.Add("10");
            cmbFilas.Items.Add("20");
            cmbFilas.Items.Add("50");
            cmbFilas.Items.Add("100");
            cmbFilas.Items.Add("200");
            // Se inicializa con 100 para evitar sobrecargas de datos
            cmbFilas.SelectedItem = "100";
            // Segundo, se carga el combobox de filtros de columnas, se cargarán con los nombres de las columnas

            cmbFiltro.Items.Add("Código");
            cmbFiltro.Items.Add("Nombre");
            cmbFiltro.Items.Add("Lote");
            cmbFiltro.Items.Add("Estante");
            cmbFiltro.Items.Add("Categoría");
            cmbFiltro.Items.Add("Proveedor");
            cmbFiltro.SelectedItem = "Código";

            // Cargar combobox de Estados
            cmbEstado.Items.Add("Todos los Medicamentos");
            cmbEstado.Items.Add("Activos");
            cmbEstado.Items.Add("Inactivos");
            cmbEstado.SelectedItem = "Todos los Medicamentos";
        }
        private List<string> getSelectedMedicinesNames()
        {
            if (dgvMedicineList.SelectedRows.Count > 0)
            {
                // Lista para almacenar los nombres de los medicamentos seleccionados
                List<string> medicineNames = new List<string>();
                // iterar sobre las filas seleccionadas
                foreach (DataGridViewRow fila in dgvMedicineList.SelectedRows.Cast<DataGridViewRow>().Reverse())
                {
                    int selectedMedicineId = Convert.ToInt32(fila.Cells[0].Value);
                    string shelfName = lMedicina.GetMedicine(selectedMedicineId).Nombre.ToString();
                    medicineNames.Add(shelfName);
                }
                return medicineNames;
            }
            else
            {
                return null;
            }
        }

        private void openMedicineFormForModification()
        {
            if (dgvMedicineList.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMedicineList.SelectedRows[0].Cells[0].Value);
                MEDICAMENTO medicine = lMedicina.GetMedicine(id);
                OpenMedicineForm(medicine);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para modificar el medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OpenMedicineForm(MEDICAMENTO medicine)
        {
            using (var modal = new NuevoMedicamentoForm(medicine))
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    loadMedicine();
                }
            }
        }

        private void formAgregarMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void tsmiButtons_Click(object sender, EventArgs e)
        {
            // Variable del ToolStripMenuItem que fue clickeado
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            // Al clickear, cambiaremos el estado de la propiedad Checked del ToolStripMenuItem
            item.Checked = !item.Checked;

        }

        private void tsmiMenuCheckChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem subItem in item.DropDownItems)
            {
                subItem.Checked = item.Checked;
            }
        }

        private void tsmiSubmenuCheckChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem subMenu = (ToolStripMenuItem)sender;
            switch (subMenu.Tag)
            {
                case "idTAG":
                    dgvMedicineList.Columns[0].Visible = subMenu.Checked;
                    break;
                case "codigoTAG":
                    dgvMedicineList.Columns[1].Visible = subMenu.Checked;
                    break;
                case "loteTAG":
                    dgvMedicineList.Columns[2].Visible = subMenu.Checked;
                    break;
                case "nombreMTAG":
                    dgvMedicineList.Columns[3].Visible = subMenu.Checked;
                    break;
                case "cantidadMTAG":
                    dgvMedicineList.Columns[4].Visible = subMenu.Checked;
                    break;
                case "vencimientoMTAG":
                    dgvMedicineList.Columns[5].Visible = subMenu.Checked;
                    break;
                case "precioVentaMTAG":
                    dgvMedicineList.Columns[6].Visible = subMenu.Checked;
                    break;
                case "precioCompraMTAG":
                    dgvMedicineList.Columns[7].Visible = subMenu.Checked;
                    break;
                case "nombreETAG":
                    dgvMedicineList.Columns[8].Visible = subMenu.Checked;
                    break;
                case "sectorETAG":
                    dgvMedicineList.Columns[9].Visible = subMenu.Checked;
                    break;
                case "numeroETAG":
                    dgvMedicineList.Columns[10].Visible = subMenu.Checked;
                    break;
                case "nombreCTAG":
                    dgvMedicineList.Columns[11].Visible = subMenu.Checked;
                    break;
                case "nombrePTAG":
                    dgvMedicineList.Columns[12].Visible = subMenu.Checked;
                    break;
                case "estadoMTAG":
                    dgvMedicineList.Columns[13].Visible = subMenu.Checked;
                    break;
                default:
                    break;
            }
        }



        private void dgvMedicineList_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            vistaInventarioBindingSource.Sort = dgvMedicineList.SortString;
        }

        private void dgvMedicineList_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            vistaInventarioBindingSource.Filter = dgvMedicineList.FilterString;
        }

        private void actualizarFilasTotales()
        {
            lblTotalRow.Text = "Filas Totales: " + vistaInventarioBindingSource.List.Count;
        }

        private void bindingSourceMedicine_ListChanged(object sender, ListChangedEventArgs e)
        {
            actualizarFilasTotales();
        }

        private void cmbFilas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFilas.Text != string.Empty)
                {
                    int numberOfRows = Convert.ToInt32(cmbFilas.Text);
                    cmbTextRow = Convert.ToInt32(cmbFilas.Text);
                    filterRow(numberOfRows);
                }
                else
                {
                    filterRow(cmbTextRow);
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

        private void dtaFilter()
        {
            try
            {
                string desde = dtaDesdeVTO.Value.ToString("yyyy-MM-dd");
                string hasta = dtaHastaVTO.Value.ToString("yyyy-MM-dd");
                if (desde != string.Empty && hasta != string.Empty)
                {
                    //this.vistaInventarioTableAdapter.Filter(this.farmaciaDBDataSet.VistaInventario, cmbFiltro.Text, txtBuscar.Text, desde, hasta, cmbStateSelected());
                }
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Enabled)
            {
                if (txtBuscar.Text == string.Empty)
                {
                    filterRow(Convert.ToInt32(cmbFilas.Text));
                }
                else
                {
                    dtaFilter();
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dtaFilter();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtaFilter();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtaFilter();
        }

        private void dtaDesdeVTO_ValueChanged(object sender, EventArgs e)
        {
            dtaFilter();
        }

        private void cmbFilas_Leave(object sender, EventArgs e)
        {
            if (cmbFilas.Text == string.Empty)
            {
                cmbFilas.Text = cmbTextRow.ToString();
            }
        }

        private void cmbFilas_KeyPress(object sender, KeyPressEventArgs e)
        {
            controladora.SoloNumeros(e);
        }

        private void filterRow(int numberOfRows)
        {
            if (numberOfRows > 0)
            {
             //   this.vistaInventarioTableAdapter.Top(this.farmaciaDBDataSet.VistaInventario, numberOfRows);
            }
            else if (numberOfRows < 0)
            {
                MessageBox.Show("El número de filas no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si el usuario tiene más de 1000 filas, le advertirá que la operación puede tardar
                if (originalRowCount > 5000)
                {
                    DialogResult result = MessageBox.Show("La operación que está a punto de realizar involucra un gran volumen de datos y podría llevar varios minutos.\\n\" +\r\n    \"¿Desea continuar?\"", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //this.vistaInventarioTableAdapter.Fill(this.farmaciaDBDataSet.VistaInventario);
                        cmbFilas.Text = originalRowCount.ToString();
                    }
                    else
                    {
                        cmbFilas.Text = "100";
                    }
                }
                else
                {
                    //this.vistaInventarioTableAdapter.Top(this.farmaciaDBDataSet.VistaInventario, numberOfRows);
                }
            }

        }

        private bool? cmbStateSelected()
        {
            if (cmbEstado.SelectedIndex == -1)
            {
                return null;
            }
            if (cmbEstado.SelectedItem.ToString() == "Activos")
            {
                return true;
            }
            else if (cmbEstado.SelectedItem.ToString() == "Inactivos")
            {
                return false;
            }
            else
            {
                return null;
            }
        }

        private void dgvMedicineList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Al tocar la celda dgvcEstado que es una celda checkbox, se cambiara su estado de true a false o viceversa
            // Se usará la lógica de la clase Medicamento para cambiar el estado en la base de datos
            // Al tocar la celda dgvcEstado que es una celda checkbox, se cambiará su estado de true a false o viceversa
            // Se usará la lógica de la clase Medicamento para cambiar el estado en la base de datos
            try
            {
                if (e.ColumnIndex == 13) // Asumiendo que la columna 13 es la columna del checkbox
                {
                    bool currentState = Convert.ToBoolean(dgvMedicineList.Rows[e.RowIndex].Cells[13].Value);
                    bool newState = !currentState; // Invertir el estado actual
                    int id = Convert.ToInt32(dgvMedicineList.Rows[e.RowIndex].Cells[0].Value);

                    string mensaje = newState ? "¿Está seguro que desea activar este medicamento?" : "¿Está seguro que desea desactivar este medicamento?";
                    DialogResult respuestaUsuario = MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuestaUsuario == DialogResult.Yes)
                    {
                        MEDICAMENTO oMedicine = lMedicina.GetMedicine(id);
                        oMedicine.Estado = newState;
                        bool result = lMedicina.ModifyMedicine(oMedicine);
                        if(result)
                        {
                            dtaFilter();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cambiar el estado del medicamento, contacte con el administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Si el usuario elige 'No', revertir el cambio en la interfaz de usuario
                        dgvMedicineList.Rows[e.RowIndex].Cells[13].Value = currentState;
                    }
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

        // // // // INTERFAZ // // // //
    }
}
