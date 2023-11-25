using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Controles;
using Sistema.Models;
using System.Media;
using Sistema.Controles.Logica;
using System.Data.Entity.Core.Objects;
using Sistema.Controles.Interfaz;
using System.Data.Entity.Infrastructure;

namespace Sistema.Vista
{
    public partial class EstantesForm : Form
    {
        // Instancias de las clases de Control
        Controladora controladora = Controladora.GetInstance;
        PaletaColores palette = PaletaColores.GetInstance;
        EstanteLogica shelfLogic = new EstanteLogica();
        ObservadorDataGridView dgvObserver = new ObservadorDataGridView();
        MessageBoxManager messageManager = MessageBoxManager.GetInstance;

        private bool isModifyButtonPressed { get; set; } = false;


        public EstantesForm()
        {
            InitializeComponent();
        }

        private void Estantes_Load(object sender, EventArgs e)
        {
            loadShelvesData();
            btnGuardarG.Enabled = false;
            toggleEditMode();
            // Acomodar tamaño de la celda selectora de filas
            dgvShelvesList.RowHeadersWidth = 30;
            updateTotalRowCount();
        }

        private void txtNumE_KeyPress(object sender, KeyPressEventArgs e)
        {
            controladora.OnlyNumbers(e);
        }

        // Método para obtener los datos del datagridview

        private void loadShelvesData()
        {
            try
            {
            this.estantesModelTableAdapter.Fill(this.farmaciaDBData.ESTANTE);
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

        // // // // // Funciones de botones // // // // //
        private void toggleEditMode()
        {
            if (isModifyButtonPressed)
            {
                // Activar el modo edición del datagridview
                isModifyButtonPressed = false;
                btnModifyG.Image = Properties.Resources.EditingIcon;
                btnModifyG.BaseColor = palette.ButtonModifyActive;

                dgvShelvesList.ReadOnly = false;
            }
            else
            {
                // Si se han realizado cambios, muestra un MessageBox.
                if (controladora.IsDatagridViewModified)
                {
                    DialogResult result = MessageBox.Show("Has realizado modificaciones y estás cambiando al modo de lectura. ¿Deseas guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Guarda los cambios.                      
                        updateShelfData(true);

                    }
                    else
                    {
                        // Restaura los datos originales.
                        loadShelvesData();
                    }
                    controladora.IsDatagridViewModified = false;
                }

                // Desactivar el modo edición del datagridview
                isModifyButtonPressed = true;
                btnModifyG.Image = Properties.Resources.PencilIcon;
                btnModifyG.BaseColor = palette.ButtonModifyDisabled;

                dgvShelvesList.ReadOnly = true;
            }
        }




        // // // // // // // Agregar Estante // // // // // // //
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (controladora.IsDatagridViewModified)
                {
                    // Preungar al usuario si desea guardar los cambios realizados antes de agregar una nueva categoria.
                    DialogResult userAnswer = MessageBox.Show("Has realizado modificaciones y estás agregando un nuevo proveedor. ¿Deseas guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (userAnswer == DialogResult.Yes)
                    {
                        // Guarda los cambios.                      
                        updateShelfData(true);
                        addShelf();
                    }
                    else
                    {
                        // Restaura los datos originales.
                        addShelf();
                        loadShelvesData();
                    }
                }
                else
                {
                    addShelf();
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

        private void addShelf()
        {
            // Model
            ESTANTE shelves = new ESTANTE();
            //Validaciones
            bool isShelfNameValid = controladora.VerifyTextBoxG(txtNombreE);
            bool isShelfNumberValid = controladora.VerifyTextBoxG(txtNumE);
            bool isShelfSectorValid = controladora.VerifyTextBoxG(txtSectorE);
            if (isShelfNameValid && isShelfNumberValid && isShelfSectorValid)
            {
                // Se utiliza la instancia de la clase Estante
                shelves.Nombre = txtNombreE.Text;
                shelves.Numero = Convert.ToInt32(txtNumE.Text);
                shelves.Sector = txtSectorE.Text;

                bool result = shelfLogic.AddShelf(shelves);
                if (result)
                {
                    MessageBox.Show("Se agrego corectamente un nuevo estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Se limpian los campos
                    controladora.ClearTextBoxG(txtNombreE, txtNumE, txtSectorE);
                    // Se actualiza el datagridview
                    loadShelvesData();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("¡Por favor, complete los campos!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // // // // // //// /// AGREGAR ESTANTE /// /// //// ///


        // Variable para almacenar las filas modificadas
        Dictionary<int, DataGridViewRow> modifiedRows = new Dictionary<int, DataGridViewRow>();

        private void btnGuardarG_Click(object sender, EventArgs e)
        {
            updateShelfData(true);
        }
        private void updateShelfData(bool refresh)
        {
            ESTANTE shelf = new ESTANTE();
            int modifiedShelves = 0; // Variable para contar las filas modificadas

            try
            {
                foreach (KeyValuePair<int, DataGridViewRow> row in modifiedRows)
                {
                    shelf.EstanteID = Convert.ToInt32(row.Value.Cells[0].Value);
                    shelf.Nombre = Convert.ToString(row.Value.Cells[1].Value);
                    shelf.Numero = Convert.ToInt32(row.Value.Cells[2].Value);
                    shelf.Sector = Convert.ToString(row.Value.Cells[3].Value);

                    bool result = shelfLogic.ModifyShelf(shelf);
                    if (result)
                    {
                        modifiedShelves++; // Incrementa el contador de estantes modificados
                    }
                }

                // Limpia el diccionario y deshabilita el botón
                modifiedRows.Clear();
                controladora.IsDatagridViewModified = false;
                btnGuardarG.Enabled = false;

                // Mensaje de notificación dinámico
                showMessageShelfModify(modifiedShelves);
                // Recargar los datos después de procesar todas las filas modificadas
                if (refresh)
                {
                loadShelvesData();
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


        // Mensajes Dinámicos
        // Mensaje de Estantes modificados
        private void showMessageShelfModify(int modifiedShelves)
        {
            if (modifiedShelves > 0)
            {
                string mensaje;
                if (modifiedShelves == 1)
                {
                    mensaje = "Se modificó correctamente 1 estante.";
                }
                else
                {
                    mensaje = $"Se modificaron correctamente {modifiedShelves} estantes.";
                }
                MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void btnModifyG_Click(object sender, EventArgs e)
        {
            toggleEditMode();
        }


        // // // // // // ELIMINAR ESTANTES // // // // // //
        // Función para retornar una lista con los nombres de los estantes seleccionados
        private object originalValue { get; set; }


        private List<string> getSelectedShelvesNames()
        {
            if (dgvShelvesList.SelectedRows.Count > 0)
            {

                // Lista para almacenar los nombres de los estantes seleccionados
                List<string> shelfNames = new List<string>();
                // Iterar sobre las filas seleccionadas
                foreach (DataGridViewRow row in dgvShelvesList.SelectedRows)
                {
                    int selectedShelfID = Convert.ToInt32(row.Cells["dgvcID"].Value);
                    string shelfName = shelfLogic.GetShelf(selectedShelfID).Nombre.ToString();
                    shelfNames.Add(shelfName);
                }
                return shelfNames;
            }
            else
            {
                return null;
            }
        }

        // Obtener mensaje confirmación para eliminar estantes
        private string getDeleteConfirmationMessage()
        {
            string message = "";
            if (dgvShelvesList.SelectedRows.Count > 1)
            {
                // Lista para almacenar los nombres de los estantes seleccionados
                List<string> shelfNames = getSelectedShelvesNames();
                for (int i = 0; i < shelfNames.Count; i++)
                {
                    shelfNames[i] = $"- {shelfNames[i]}";
                }
                message = "¿Está seguro que desea eliminar los siguientes estantes?\n\n" + string.Join("\n", shelfNames);
            }
            else if (dgvShelvesList.SelectedRows.Count == 1)
            {
                string shelfName = getSelectedShelvesNames()[0];
                message = "¿Está seguro que desea eliminar el estante: \"" + shelfName + "\"?";
            }
            return message;
        }

     

        // Evento para eliminar un estante
        private void btnEliminarG_Click(object sender, EventArgs e)
        {
            try
            {
                // Utilizar patron observer
                if (controladora.IsDatagridViewModified)
                {
                    // preguntar al usuario si desea guardar los cambios
                    DialogResult userAnswer = MessageBox.Show("¿Desea guardar los cambios antes de eliminar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (userAnswer == DialogResult.Yes)
                    {
                        updateShelfData(false);
                        deleteSelectedShelf();
                    }
                    else
                    {
                        // Eliminar los estantes seleccionados
                        deleteSelectedShelf();
                    }
                }
                else
                {
                    deleteSelectedShelf();
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

        private void deleteSelectedShelf()
        {
            if (dgvShelvesList.SelectedRows.Count > 0)
            {
                int shelvesCount = dgvShelvesList.SelectedRows.Count;
                string message = getDeleteConfirmationMessage();
                DialogResult userConfirmation = MessageBox.Show(message, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvShelvesList.SelectedRows)
                    {
                        // condicional multiples SelectedRows
                        int selectedShelfID = Convert.ToInt32(row.Cells[0].Value);
                        bool deletionResult = shelfLogic.DeleteShelf(selectedShelfID); ;
                        if (!deletionResult)
                        {
                            MessageBox.Show("No se pudo eliminar el estante: " + shelfLogic.GetShelf(selectedShelfID).Nombre, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    // Mensaje de notificación dinámico // Poner siempre en singular el nombre del elemento
                    messageManager.ShowDeletionMessage(shelvesCount, "estante");
                }
                // Se actualiza el datagridview
                loadShelvesData();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // // // // // // ELIMINAR ESTANTES // // // // // //



        // // // // INTERFAZ // // // // //
        private void txtNombreE_Enter(object sender, EventArgs e)
        {
            txtNombreE.LineColor = palette.ColorDisabled;
        }

        private void txtNumE_Enter(object sender, EventArgs e)
        {
            txtNumE.LineColor = palette.ColorDisabled;
        }

        private void txtSectorE_Enter(object sender, EventArgs e)
        {
            txtSectorE.LineColor = palette.ColorDisabled;
        }

        // Limitar solo número en la columa número de estante
        private void dtaViewEstante_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (dgvShelvesList.CurrentCell.OwningColumn.Name == "dgvcNumeroE") // Columna deseada
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }

        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void dtaViewEstante_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgvShelvesList.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            // Obtener el valor original de la celda
            originalValue = cell.Value != null ? cell.Value : null;
        }




        private void dtaViewEstante_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // obtener valor de celda a modificar
            DataGridViewRow row = dgvShelvesList.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            // Verifica si el valor es un espacio en blanco o una cadena vacía, y si la celda está en la columna de números de estante
            if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
            {
                messageManager.ShowMessageCellEmpty();
                // Restaura el valor original de la celda
                cell.Value = originalValue;
            }
            else
            {
                // 
                if (!modifiedRows.ContainsKey(row.Index))
                {
                    modifiedRows.Add(row.Index, row);
                }
                else
                {
                    modifiedRows[row.Index] = row;
                }

                btnGuardarG.Enabled = true;
                controladora.Attach(dgvObserver);
                controladora.IsDatagridViewModified = true;
            }

        }

        private void dtaViewEstante_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Verifica si el error es causado por el usuario
            if (e.Exception is FormatException && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dgvShelvesList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellValue = cell.Value != null ? cell.Value.ToString() : string.Empty;

                if (string.IsNullOrWhiteSpace(cellValue))
                {
                    // Restaura el valor original de la celda
                    cell.Value = originalValue;
                }
                else
                {
                    // Restaura el valor original de la celda
                    cell.Value = originalValue;
                }

                e.ThrowException = false;
            }
            messageManager.ShowMessageCellEmpty();

        }

        private void btnEliminarG_MouseEnter(object sender, EventArgs e)
        {
            btnEliminarG.Radius = 12;
        }

        private void btnEliminarG_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarG.Radius = 5;
        }
        // // // //

        // Manejo de filtros y ordenamiento del datagridview
        private void dgvShelvesList_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            bindingSourceShelves.Sort = dgvShelvesList.SortString;
        }
        private void dgvShelvesList_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            bindingSourceShelves.Filter = dgvShelvesList.FilterString;
        }

        private void updateTotalRowCount()
        {
            lblTotalRow.Text = "Total de Estantes: " + bindingSourceShelves.List.Count;
        }

        private void bindingSourceShelves_ListChanged(object sender, ListChangedEventArgs e)
        {
            // Actualiza el contador de estantes
            updateTotalRowCount();

        }
        //  // // // //
    }
}
