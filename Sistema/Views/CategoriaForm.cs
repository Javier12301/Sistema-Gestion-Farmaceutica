using Sistema.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// hacer using de las carpetas de logica y modelo
using System.Data.SqlClient;
using Sistema.Models;
using Sistema.Controles.Logica;
using Sistema.Controles.Interfaz;
using System.Data.Entity.Infrastructure;

namespace Sistema.Vista
{
    public partial class CategoriaForm : Form
    {
        Controladora controladora = Controladora.GetInstance;
        Shortcuts shortcuts = new Shortcuts();
        PaletaColores palette = PaletaColores.GetInstance;
        // Se crea una instancia de la clase categoria
        CategoriaLogica categoryLogic = new CategoriaLogica();
        ObservadorDataGridView dgvObserver = new ObservadorDataGridView();
        MessageBoxManager messageManager = MessageBoxManager.GetInstance;

        private bool isModifyButtonPressed { get; set; } = false;
        private object originalValue { get; set; }



        public CategoriaForm()
        {
            InitializeComponent();
        }
        // Lista de filas del datagridview

        private void Categorias_Load(object sender, EventArgs e)
        {
            loadCategoriesData();
            // Desactivar boton guardar hasta que se haga un cambio en el datagridview
            btnGuardarG.Enabled = false;
            toggleEditMode();
            // Acomodar tamaño de la celda selectora de filas
            dgvCategoriesList.RowHeadersWidth = 30;
            updateTotalRowCount();
        }

        // Variables para el datagridview
        private void loadCategoriesData()
        {
            // Comprobar si existe categoria
            try
            {
                this.cATEGORIATableAdapter.Fill(this.farmaciaDBDataSet.CATEGORIA);
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
                dgvCategoriesList.ReadOnly = false;
                dgvcID.ReadOnly = true;
            }
            else
            {
                // Si se han realizado cambios, muestra un MessageBox.
                if (controladora.IsDatagridViewModified)
                {
                    DialogResult result = MessageBox.Show("Has realizado modificaciones y estás cambiando al modo de lectura. ¿Deseas guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Guarda los cambios.                      
                        updateCategoriesData(true);

                    }
                    else
                    {
                        // Restaura los datos originales.
                        loadCategoriesData();
                    }
                    controladora.IsDatagridViewModified = false;
                }

                // Desactivar el modo edición del datagridview
                isModifyButtonPressed = true;
                btnModifyG.Image = Properties.Resources.PencilIcon;
                btnModifyG.BaseColor = palette.ButtonModifyDisabled;

                dgvCategoriesList.ReadOnly = true;
            }
        }


        // // // // // // AGREGAR CATEGORIA // // // // // //

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (controladora.IsDatagridViewModified)
                {
                    // Preungar al usuario si desea guardar los cambios realizados antes de agregar una nueva categoria.
                    DialogResult userAnswer = MessageBox.Show("Has realizado modificaciones y estás agregando una nueva categoría. ¿Deseas guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (userAnswer == DialogResult.Yes)
                    {
                        // Guarda los cambios.                      
                        updateCategoriesData(true);
                        addCategory();
                    }
                    else
                    {
                        // Restaura los datos originales.
                        addCategory();
                        loadCategoriesData();
                    }
                }
                else
                {
                    addCategory();
                }
            }
            catch (DbUpdateException)
            {
                messageManager.ShowDatabaseUpdateError();
            }
            catch (SqlException)
            {
                messageManager.ShowSqlError();
            }
            catch (Exception)
            {
                messageManager.ShowUnexpectedError();
            }
        }

        private void addCategory()
        {
            // Model Categoria
            CATEGORIA category = new CATEGORIA();
            bool isCategoryNameValid = controladora.VerifyTextBoxG(txtNombreCat);
            if (isCategoryNameValid)
            {
                // Se utiliza la instancia de la clase categoria
                category.Nombre = txtNombreCat.Text;
                // Se utiliza un operador ternario para verificar si el campo esta vacio o tiene espacio.
                category.Descripcion = (string.IsNullOrWhiteSpace(txtDescripcionCat.Text)) ? "-" : txtDescripcionCat.Text;

                bool result = categoryLogic.AddCategory(category);
                if (result)
                {
                    MessageBox.Show("Se agrego correctamente la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Se limpian los campos
                    controladora.ClearTextBoxG(txtNombreCat);
                    controladora.ClearTextBoxT(txtDescripcionCat);
                    // Se cargan los datos en el datagridview
                    loadCategoriesData();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else

            {
                MessageBox.Show("¡Por favor, complete los campos obligatorios!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // // // // // // AGREGAR CATEGORIA // // // // // //



        // // // // // // MODIFICAR CATEGORIA // // // // // //
        // Modificación de celdas
        Dictionary<int, DataGridViewRow> modifiedRows = new Dictionary<int, DataGridViewRow>();
        private void btnGuardarG_Click(object sender, EventArgs e)
        {
            updateCategoriesData(true);
        }

        private void btnModifyG_Click(object sender, EventArgs e)
        {
            toggleEditMode();
        }

        private void updateCategoriesData(bool refresh)
        {
            try
            {
                CATEGORIA category = new CATEGORIA();
                int modifiedShelves = 0; // Variable para contar las filas modificadas
                foreach (KeyValuePair<int, DataGridViewRow> row in modifiedRows)
                {
                    category.CategoriaID = Convert.ToInt32(row.Value.Cells[0].Value);
                    category.Nombre = Convert.ToString(row.Value.Cells[1].Value);
                    category.Descripcion = Convert.ToString(row.Value.Cells[2].Value);

                    bool result = categoryLogic.ModifyCategory(category);
                    if (result)
                    {
                        modifiedShelves++; // Incrementa el contador de categorias modificados
                    }
                }

                // Limpia el diccionario y deshabilita el botón
                modifiedRows.Clear();
                controladora.IsDatagridViewModified = false;
                btnGuardarG.Enabled = false;

                // Mensaje de notificación dinámico // Poner siempre en singular el nombre del elemento
                messageManager.ShowModificationMessage(modifiedShelves, "categoría");
                // Recargar los datos después de procesar todas las filas modificadas
                if (refresh)
                {
                    loadCategoriesData();
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



        // // // // // // MODIFICAR CATEGORIA // // // // // //




        // // // // // // ELIMINAR CATEGORIA // // // // // //

        // Función para retoran una lista con los nombres de las categorias seleccionadas
        private List<string> getSelectedCategories()
        {
            if (dgvCategoriesList.SelectedRows.Count > 0)
            {
                // Lista para almacenar los nombres de las categorias seleccionadas
                List<string> selectedCategories = new List<string>();
                // Se recorren las filas seleccionadas
                foreach (DataGridViewRow row in dgvCategoriesList.SelectedRows.Cast<DataGridViewRow>().Reverse())
                {
                    int selectedCategoryID = Convert.ToInt32(row.Cells["dgvcID"].Value);
                    // Se utiliza el id para obtener el objeto categoria y luego obtenemos el nombre
                    string categoryName = categoryLogic.GetCategory(selectedCategoryID).Nombre.ToString();
                    selectedCategories.Add(categoryName);
                }
                return selectedCategories;
            }
            else
            {
                return null;
            }
        }

        // Obtener mensaje confirmación para eliminar categorias
        private string getDeleteConfirmationMessage()
        {
            string message = "";
            // Significa que se selecciono más de una categoria
            if (dgvCategoriesList.SelectedRows.Count > 1)
            {
                // Lista para almacenar los nombres de las categorias seleccionadas
                List<string> categoryNames = getSelectedCategories();
                for (int i = 0; i < categoryNames.Count; i++)
                {
                    categoryNames[i] = $"- {categoryNames[i]}";
                }
                message = "¿Está seguro que desea eliminar las siguientes categorías?\n\n" + string.Join("\n", categoryNames);

            }
            else if (dgvCategoriesList.SelectedRows.Count == 1)
            {
                // Significa que se selecciono una categoria
                string categoryName = getSelectedCategories()[0];
                message = "¿Está seguro que desea eliminar la categoría: \"" + categoryName + "\"?";
            }
            return message;
        }




        private void btnEliminarG_Click(object sender, EventArgs e)
        {
            try
            {
                // Utilizamos el observer para comprobar si el usuario modifico el datagridview
                if (controladora.IsDatagridViewModified)
                {
                    // preguntar al usuario si desea guardar los cambios antes de eliminar
                    DialogResult userAnswer = MessageBox.Show("¿Desea guardar los cambios antes de eliminar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (userAnswer == DialogResult.Yes)
                    {
                        updateCategoriesData(false);
                        deleteSelectedCategory();
                    }
                    else
                    {
                        deleteSelectedCategory();
                    }
                }
                else
                {
                    deleteSelectedCategory();
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
            catch (Exception ex)
            {
                // Otras excepciones no manejadas
                messageManager.ShowUnexpectedError();
                MessageBox.Show(ex.ToString());
                // Loguear ex si es necesario para fines de depuración
            }

        }

        private void deleteSelectedCategory()
        {
            if (dgvCategoriesList.SelectedRows.Count > 0)
            {
                int categoriesCount = dgvCategoriesList.SelectedRows.Count;
                string message = getDeleteConfirmationMessage();
                DialogResult userConfirmation = MessageBox.Show(message, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvCategoriesList.SelectedRows)
                    {
                        // condicional multiples SelectedRows
                        int selectedCategoryID = Convert.ToInt32(row.Cells["dgvcID"].Value);
                        bool deletionResult = categoryLogic.DeleteCategory(selectedCategoryID);
                        if (!deletionResult)
                        {
                            MessageBox.Show("La operación ha sido cancelada.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }                  
                    }
                    messageManager.ShowDeletionMessage(categoriesCount, "categoria");
                    // Mensaje de notificación dinámico // Poner siempre en singular el nombre del elemento
                }
                else
                {
                    MessageBox.Show("La operación ha sido cancelada.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                // Se actualiza el datagridview
                loadCategoriesData();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar la categoria.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // // // // // // ELIMINAR CATEGORIA // // // // // //

        // // // // // // INTERFAZ // // // // // //
        // Evento cuando se clicke una celda del datagridview
        private void dgvCategoriesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // habilitar boton eliminar
            if (e.RowIndex >= 0)
            {
                btnEliminarG.Enabled = true;
            }
            else
            {
                btnEliminarG.Enabled = false;
            }
        }

        private void txtNombreCat_Enter(object sender, EventArgs e)
        {
            txtNombreCat.LineColor = palette.ColorDisabled;
        }

        private void btnEliminarG_MouseEnter(object sender, EventArgs e)
        {
            btnEliminarG.Radius = 12;
        }

        private void btnEliminarG_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarG.Radius = 5;
        }


        // Evento cuando se modifique una celda del datagridview
        private void dgvCategoriesList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // obtener valor de celda a modificar
            DataGridViewRow row = dgvCategoriesList.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];
            // Verifica si la celda está en la columna de descripción
            if (cell.OwningColumn.Name == "dgvcDescripcionC" && cell.Value == null)
            {
                // Si el valor es nulo o está en blanco, establece el valor en "-"
                if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    cell.Value = "-";
                    btnGuardarG.Enabled = true;
                }
            }
            else
            {
                // Verifica si el valor es un espacio en blanco o una cadena vacía
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
        }



        private void dgvCategoriesList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCategoriesList.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            // Obtener el valor original de la celda
            originalValue = cell.Value != null ? cell.Value : null;
        }

        // Evento cuando ocurre un error al modificar una celda del datagridview (Ej: ingresar letras en una celda de tipo numérico)
        private void dgvCategoriesList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Verifica si el error es causado por el usuario y no por el sistema
            if (e.Exception is FormatException && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dgvCategoriesList.Rows[e.RowIndex].Cells[e.ColumnIndex];
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

        private void dgvCategoriesList_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            bindingSourceCategories.Sort = dgvCategoriesList.SortString;
        }

        private void dgvCategoriesList_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            bindingSourceCategories.Filter = dgvCategoriesList.FilterString;

        }

        private void updateTotalRowCount()
        {
            lblTotalRow.Text = "Total de categoría: " + bindingSourceCategories.List.Count;
        }

        private void bindingSourceCategories_ListChanged(object sender, ListChangedEventArgs e)
        {
            updateTotalRowCount();
        }

        private void dgvCategoriesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // // // // // // INTERFAZ // // // // // //

    }
}
