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
using Sistema.Modelo;
using System.Media;
using Sistema.Controles.Logica;
using System.Data.Entity.Core.Objects;

namespace Sistema.Vista
{
    public partial class EstantesForm : Form
    {
        // Instancias de las clases de Control
        Controladora controladora = new Controladora();
        PaletaColores colorPalette = new PaletaColores();
        EstanteLogica shelfLogic = new EstanteLogica();

        public EstantesForm()
        {
            InitializeComponent();
        }

        private void Estantes_Load(object sender, EventArgs e)
        {
            loadShelvesData();
            btnGuardarG.Enabled = false;
        }

        private void txtNumE_KeyPress(object sender, KeyPressEventArgs e)
        {
            controladora.OnlyNumbers(e);
        }

        // Método para obtener los datos del datagridview
        private BindingSource bindingSourceShelves;

        private void loadShelvesData()
        {
            List<EstantesModel> shelvesList = shelfLogic.GetShelves();
            bindingSourceShelves = new BindingSource(shelvesList, null);

            // cargar los datos en el datagridview
            dtaIDEstante.DataPropertyName = "EstanteID";
            dtaNombreEstante.DataPropertyName = "Nombre";
            dtaNumEstante.DataPropertyName = "Numero_de_estante";
            dtaSectorEstante.DataPropertyName = "Sector";
            // Se asigna el binding source al datagridview
            dtaViewEstante.DataSource = bindingSourceShelves;
            dtaViewEstante.Columns["MedicamentosModel"].Visible = false;
            controladora.CheckEmptyDataGridView(dtaViewEstante, "dtaIDEstante");
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Model
            EstantesModel shelves = new EstantesModel();
            //Validaciones
            bool isShelfNameValid = controladora.VerifyTextBoxG(txtNombreE);
            bool isShelfNumberValid = controladora.VerifyTextBoxG(txtNumE);
            bool isShelfSectorValid = controladora.VerifyTextBoxG(txtSectorE);
            if (isShelfNameValid && isShelfNumberValid && isShelfSectorValid)

            {
                // Se utiliza la instancia de la clase Estante
                shelves.Nombre = txtNombreE.Text;
                shelves.Numero_de_estante = Convert.ToInt32(txtNumE.Text);
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

        // Evento cuando se modifique una celda del datagridview
        private List<DataGridViewRow> modifiedRows = new List<DataGridViewRow>();
        private void btnGuardarG_Click(object sender, EventArgs e)
        {
            // Se crea una instancia de la clase Estante
            EstantesModel shelf = new EstantesModel();
            foreach (DataGridViewRow row in modifiedRows)
            {
                int selectedShelfID = Convert.ToInt32(row.Cells["dtaIDEstante"].Value);
                if (row.Cells["dtaNombreEstante"] != null && row.Cells["dtaNombreEstante"].Value != null)
                {
                    string selectedShelfName = row.Cells["dtaNombreEstante"].Value.ToString();
                    string selectedShelfNumber = (row.Cells["dtaNumEstante"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["dtaNumEstante"].Value.ToString())) ? row.Cells["dtaNumEstante"].Value.ToString() : "-";
                    string selectedShelfSection = (row.Cells["dtaSectorEstante"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["dtaSectorEstante"].Value.ToString())) ? row.Cells["dtaSectorEstante"].Value.ToString() : "-";

                    // Verificar si el nombre del estante está vacío o contiene solo espacios en blanco
                    shelf.EstanteID = selectedShelfID;
                    shelf.Nombre = selectedShelfName;
                    shelf.Numero_de_estante = Convert.ToInt32(selectedShelfNumber);
                    shelf.Sector = selectedShelfSection;

                    bool result = shelfLogic.ModifyShelf(shelf);
                    if (result)
                    {
                        MessageBox.Show("Se modifico corectamente el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Se actualiza el datagridview
                        loadShelvesData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un nombre los estantes que desee modificar.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            modifiedRows.Clear();
            btnGuardarG.Enabled = false;
        }

        private void showMessageError()
        {
            MessageBox.Show("No se permite dejar este campo vacío.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // // // // // // ELIMINAR ESTANTES // // // // // //
        // Función para retornar una lista con los nombres de los estantes seleccionados
        private object originalValue { get; set; }


        private List<string> getSelectedShelvesNames()
        {
            if (dtaViewEstante.SelectedRows.Count > 0)
            {

                // Lista para almacenar los nombres de los estantes seleccionados
                List<string> shelfNames = new List<string>();
                // Iterar sobre las filas seleccionadas
                foreach (DataGridViewRow row in dtaViewEstante.SelectedRows)
                {
                    int selectedShelfID = Convert.ToInt32(row.Cells["dtaIDEstante"].Value);
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
            if (dtaViewEstante.SelectedRows.Count > 1)
            {
                // Lista para almacenar los nombres de los estantes seleccionados
                List<string> shelfNames = getSelectedShelvesNames();
                for (int i = 0; i < shelfNames.Count; i++)
                {
                    shelfNames[i] = $"- {shelfNames[i]}";
                }
                message = "¿Está seguro que desea eliminar los siguientes estantes?\n\n" + string.Join("\n", shelfNames);
            }
            else if (dtaViewEstante.SelectedRows.Count == 1)
            {
                string shelfName = getSelectedShelvesNames()[0];
                message = "¿Está seguro que desea eliminar el estante " + shelfName + "?";
            }
            return message;
        }

        // Mensaje de eliminación de estantes o un estante
        private void deleteShelvesMessage(int shelves)
        {
            if (shelves > 1)
            {
                MessageBox.Show("Se eliminaron corectamente los estantes seleccionados.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (shelves == 1)
            {
                MessageBox.Show("Se elimino corectamente el estante seleccionado.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Evento para eliminar un estante
        private void btnEliminarG_Click(object sender, EventArgs e)
        {
            if (dtaViewEstante.SelectedRows.Count > 0)
            {
                int shelvesCount = dtaViewEstante.SelectedRows.Count;
                string message = getDeleteConfirmationMessage();
                DialogResult userConfirmation = MessageBox.Show(message, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dtaViewEstante.SelectedRows)
                    {
                        // condicional multiples SelectedRows
                        int selectedShelfID = Convert.ToInt32(row.Cells["dtaIDEstante"].Value);

                        bool hasMedicine = shelfLogic.CheckIfShelfHasMedicines(selectedShelfID);

                        using (var db = new SistemaGestionFarmaceuticaEntities())
                        {
                            if (hasMedicine)
                            {
                                userConfirmation = MessageBox.Show("Existen medicamentos asociados al estante: " + shelfLogic.GetShelf(selectedShelfID).Nombre + "\n¿Está seguro que desea eliminar el estante y reasignar los medicamentos al estante predeterminado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (userConfirmation == DialogResult.Yes)
                                {
                                    // Reasignar medicamentos al estante predeterminado
                                    int defaultShelfID = 0; // ID del estante predeterminado "Sin Estante"
                                    db.MedicamentosModel
                                        .Where(m => m.EstanteID == selectedShelfID)
                                        .ToList()
                                        .ForEach(m => m.EstanteID = defaultShelfID);

                                    db.SaveChanges();
                                }
                                else
                                {
                                    return; // Cancelar la eliminación
                                }
                            }

                            // Eliminar el estante
                            bool deletionResult = shelfLogic.DeleteShelf(selectedShelfID);
                            if (deletionResult)
                            {
                                EstantesModel shelf = (EstantesModel)bindingSourceShelves[row.Index];
                                bindingSourceShelves.Remove(shelf);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el estante: " + shelfLogic.GetShelf(selectedShelfID).Nombre, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    // Mensaje de eliminación de estantes
                    deleteShelvesMessage(shelvesCount);
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
            txtNombreE.LineColor = colorPalette.ColorDisabled;
        }

        private void txtNumE_Enter(object sender, EventArgs e)
        {
            txtNumE.LineColor = colorPalette.ColorDisabled;
        }

        private void txtSectorE_Enter(object sender, EventArgs e)
        {
            txtSectorE.LineColor = colorPalette.ColorDisabled;
        }

        // Limitar solo número en la columa número de estante
        private void dtaViewEstante_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (dtaViewEstante.CurrentCell.OwningColumn.Name == "dtaNumEstante") // Columna deseada
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

            DataGridViewRow row = dtaViewEstante.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            // Obtener el valor original de la celda
            originalValue = cell.Value != null ? cell.Value : null;
        }


        private void dtaViewEstante_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // obtener valor de celda a modificar
            DataGridViewRow row = dtaViewEstante.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            // Verifica si el valor es un espacio en blanco o una cadena vacía, y si la celda está en la columna de números de estante
            if (cell.Value == null)
            {
                showMessageError();
                // Restaura el valor original de la celda
                cell.Value = originalValue;
            }
            else
            {
                // Si el valor es válido, agrega la fila modificada a la lista
                if (!modifiedRows.Contains(row))
                {
                    modifiedRows.Add(row);
                }
                btnGuardarG.Enabled = true;
            }

        }

        private void dtaViewEstante_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Verifica si el error es causado por el usuario
            if (e.Exception is FormatException && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dtaViewEstante.Rows[e.RowIndex].Cells[e.ColumnIndex];
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
            showMessageError();

        }

        private void btnEliminarG_MouseEnter(object sender, EventArgs e)
        {
            btnEliminarG.Radius = 12;
        }

        private void btnEliminarG_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarG.Radius = 5;
        }

        // 
    }
}
