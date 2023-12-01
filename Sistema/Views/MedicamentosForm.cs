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
        private CategoriaLogica categoryLogic = new CategoriaLogica();
        private EstanteLogica shelfLogic = new EstanteLogica();
        private MedicamentoLogica medicineLogic = new MedicamentoLogica();
        Controladora controladora = Controladora.GetInstance;
        private MessageBoxManager messageManager = MessageBoxManager.GetInstance;
        private int originalRowCount { get; set; }
        private int cmbTextRow { get; set; }

        public MedicamentosForm()
        {
            InitializeComponent();
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDBDataSet.VistaInventario' Puede moverla o quitarla según sea necesario.
            this.vistaInventarioTableAdapter.Fill(this.farmaciaDBDataSet.VistaInventario);
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDBDataSet.MEDICAMENTO' Puede moverla o quitarla según sea necesario.
            // Cargar datos en el datagridview
            this.vistaInventarioTableAdapter.Fill(this.farmaciaDBDataSet.VistaInventario);
            originalRowCount = dgvMedicineList.RowCount;
            // Cargar combobox de filtros
            loadCMBData();
            loadMedicine();
            // Establecer nuevo tamaño al formulario
            this.Size = new Size(573, 299);
            // Establecer tamaño de botones de imprimir, pdf y excel
            btnExcelG.Size = new Size(73, 32);
            updateTotalRowCount();
            // Desactivar datagridview ID
            tsmiID.Checked = false;

        }

        // Cargar datos en el datagridview



        private void loadMedicine()
        {
            try
            {
                this.vistaInventarioTableAdapter.Top(this.farmaciaDBDataSet.VistaInventario, Convert.ToInt32(cmbFilas.Text));
                // Comprobar si se dejaron filtros activados
                if (txtBuscar.Text != string.Empty)
                {
                    this.vistaInventarioTableAdapter.Filter(this.farmaciaDBDataSet.VistaInventario, cmbFiltro.Text, txtBuscar.Text, null, null);
                }
            }
            catch (DbUpdateException)
            {
                // Excepción relacionada con problemas de actualización en la base de datos
                messageManager.ShowDatabaseUpdateError();

                // Loguear dbEx si es necesario para fines de depuración
            }
            catch (SqlException)
            {
                // Excepción relacionada con errores de SQL
                messageManager.ShowSqlError();
                // Loguear sqlEx si es necesario para fines de depuración
            }
            catch (Exception)
            {
                // Otras excepciones no manejadas
                messageManager.ShowUnexpectedError();
                // Loguear ex si es necesario para fines de depuración
            }

        }



        // // // /// AGREGAR, MODIFICAR, ELIMINAR // // // //
        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            openMedicineForm(null);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            openMedicineFormForModification();
        }

        private void dgvMedicineList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
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
                messageManager.ShowDatabaseUpdateError();

                // Loguear dbEx si es necesario para fines de depuración
            }
            catch (SqlException)
            {
                // Excepción relacionada con errores de SQL
                messageManager.ShowSqlError();
                // Loguear sqlEx si es necesario para fines de depuración
            }
            catch (Exception)
            {
                // Otras excepciones no manejadas
                messageManager.ShowUnexpectedError();
                // Loguear ex si es necesario para fines de depuración
            }
        }

        ////ELIMINAR ////
        // Obtener mensaje confirmación para eliminar medicamento
        private string getDeleteConfirmationMessage()
        {
            string message = "";
            if (dgvMedicineList.SelectedRows.Count > 1)
            {
                List<string> medicineNames = getSelectedMedicinesNames();
                for (int i = 0; i < medicineNames.Count; i++)
                {
                    medicineNames[i] = $"- {medicineNames[i]}";
                }
                message = "¿Está seguro que desea eliminar los siguientes medicamentos?\n\n" + string.Join("\n", medicineNames);

            }
            else if (dgvMedicineList.SelectedRows.Count == 1)
            {
                string medicineName = getSelectedMedicinesNames()[0];
                message = "¿Está seguro que desea eliminar el medicamento " + medicineName + "?";
            }
            return message;
            // Lista para almacenar los nombres de los medicamentos seleccionados
        }


        private void deleteSelectedMedicine()
        {
            if (dgvMedicineList.SelectedRows.Count > 0)
            {
                int medicineCount = dgvMedicineList.SelectedRows.Count;
                string message = getDeleteConfirmationMessage();
                DialogResult userConfirmation = MessageBox.Show(message, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvMedicineList.SelectedRows)
                    {
                        int selectedMedicineID = Convert.ToInt32(row.Cells[0].Value);
                        bool medicineDeleted = medicineLogic.DeleteMedicine(selectedMedicineID);
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
                messageManager.ShowDeletionMessage(medicineCount, "medicamento");
                loadMedicine();
            }
        }
        // // // ///  AGREGAR, MODIFICAR, ELIMINAR // // // //

        // // // // INTERFAZ // // // //

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
            cmbFiltro.Items.Add("Vencimiento");
            cmbFiltro.SelectedItem = "Código";
        }
        private List<string> getSelectedMedicinesNames()
        {
            if (dgvMedicineList.SelectedRows.Count > 0)
            {
                // Lista para almacenar los nombres de los medicamentos seleccionados
                List<string> medicineNames = new List<string>();
                // iterar sobre las filas seleccionadas
                foreach (DataGridViewRow row in dgvMedicineList.SelectedRows.Cast<DataGridViewRow>().Reverse())
                {
                    int selectedMedicineId = Convert.ToInt32(row.Cells[0].Value);
                    string shelfName = medicineLogic.GetMedicine(selectedMedicineId).Nombre.ToString();
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
                MEDICAMENTO medicine = medicineLogic.GetMedicine(id);
                openMedicineForm(medicine);
            }
            else
            {
                MessageBox.Show("Seleccione una fila/columna para modificar el medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void openMedicineForm(MEDICAMENTO medicine)
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

        private void updateTotalRowCount()
        {
            lblTotalRow.Text = "Filas Totales: " + vistaInventarioBindingSource.List.Count;
        }

        private void bindingSourceMedicine_ListChanged(object sender, ListChangedEventArgs e)
        {
            updateTotalRowCount();
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
                messageManager.ShowDatabaseUpdateError();

                // Loguear dbEx si es necesario para fines de depuración
            }
            catch (SqlException)
            {
                // Excepción relacionada con errores de SQL
                messageManager.ShowSqlError();
                // Loguear sqlEx si es necesario para fines de depuración
            }
            catch (Exception)
            {
                // Otras excepciones no manejadas
                messageManager.ShowUnexpectedError();
                // Loguear ex si es necesario para fines de depuración
            }
        }

        private void cmbFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedFilter = cmbFiltro.Text;
                resetAllControls();

                if (selectedFilter == string.Empty)
                {
                    cmbFiltro.SelectedIndex = 0;
                }
                else if (selectedFilter == "Vencimiento")
                {
                    enableDateVTOControls();
                }

            }
            catch (DbUpdateException)
            {
                // Excepción relacionada con problemas de actualización en la base de datos
                messageManager.ShowDatabaseUpdateError();

                // Loguear dbEx si es necesario para fines de depuración
            }
            catch (SqlException)
            {
                // Excepción relacionada con errores de SQL
                messageManager.ShowSqlError();
                // Loguear sqlEx si es necesario para fines de depuración
            }
            catch (Exception)
            {
                // Otras excepciones no manejadas
                messageManager.ShowUnexpectedError();
                // Loguear ex si es necesario para fines de depuración
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Si no escribe nada deverá devolver la tabla que está establecida
            try
            {
                if (txtBuscar.Enabled)
                {
                    if (txtBuscar.Text == string.Empty)
                    {
                        filterRow(Convert.ToInt32(cmbFilas.Text));
                    }
                    else if (cmbFiltro.Text != "Vencimiento")
                    {
                        this.vistaInventarioTableAdapter.Filter(this.farmaciaDBDataSet.VistaInventario, cmbFiltro.Text, txtBuscar.Text, null, null);
                    }
                }

            }
            catch (DbUpdateException)
            {
                // Excepción relacionada con problemas de actualización en la base de datos
                messageManager.ShowDatabaseUpdateError();
                // mostrar excepción


                // Loguear dbEx si es necesario para fines de depuración
            }
            catch (SqlException)
            {
                // Excepción relacionada con errores de SQL
                messageManager.ShowSqlError();
                // Loguear sqlEx si es necesario para fines de depuración
            }
            catch (Exception)
            {
                // Otras excepciones no manejadas
                messageManager.ShowUnexpectedError();
                // Loguear ex si es necesario para fines de depuración
            }
        }

        private void cmbFilas_Leave(object sender, EventArgs e)
        {
            if(cmbFilas.Text == string.Empty)
            {
                cmbFilas.Text = cmbTextRow.ToString();
            }
        }

        



        private void enableDateVTOControls()
        {
            lblDesde.Enabled = true;
            lblDesde.Visible = true;
            lblHasta.Enabled = true;
            lblHasta.Visible = true;
            dtaDesdeVTO.Enabled = true;
            dtaDesdeVTO.Visible = true;
            dtaHastaVTO.Enabled = true;
            dtaHastaVTO.Visible = true;

            // Desactivar el txtBuscar
            txtBuscar.Enabled = false;
            txtBuscar.Text = "";
            txtBuscar.Visible = false;
        }

        private void resetAllControls()
        {
            lblDesde.Enabled = false;
            lblDesde.Visible = false;
            lblHasta.Enabled = false;
            lblHasta.Visible = false;
            dtaDesdeVTO.Enabled = false;
            dtaDesdeVTO.Visible = false;
            dtaHastaVTO.Enabled = false;
            dtaHastaVTO.Visible = false;

            // Activar y mostrar el cuadro de texto de búsqueda
            txtBuscar.Enabled = true;
            txtBuscar.Visible = true;
        }

        private void cmbFilas_KeyPress(object sender, KeyPressEventArgs e)
        {
            controladora.OnlyNumbers(e);
        }

        private void filterRow(int numberOfRows)
        {
            if (numberOfRows > 0)
            {
                this.vistaInventarioTableAdapter.Top(this.farmaciaDBDataSet.VistaInventario, numberOfRows);
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
                        this.vistaInventarioTableAdapter.Fill(this.farmaciaDBDataSet.VistaInventario);
                        cmbFilas.Text = originalRowCount.ToString();
                    }
                    else
                    {
                        cmbFilas.Text = "100";
                    }
                }
                else
                {
                    this.vistaInventarioTableAdapter.Top(this.farmaciaDBDataSet.VistaInventario, numberOfRows);
                }
            }

        }

        private void dtaDesdeVTO_ValueChanged(object sender, EventArgs e)
        {
            string desde = dtaDesdeVTO.Value.ToString("yyyy-MM-dd");
            string hasta = dtaHastaVTO.Value.ToString("yyyy-MM-dd");
            if (desde != string.Empty && hasta != string.Empty && !txtBuscar.Enabled)
            {
                this.vistaInventarioTableAdapter.Filter(this.farmaciaDBDataSet.VistaInventario, cmbFiltro.Text, txtBuscar.Text, desde, hasta);
            }
        }
     

        














        // // // // INTERFAZ // // // //
    }
}
