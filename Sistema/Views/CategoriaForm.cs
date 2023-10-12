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
using Sistema.Database.Modelo;
using System.Data.SqlClient;
using Sistema.Models;
using Sistema.Controles.Logica;

namespace Sistema.Vista
{
    public partial class CategoriaForm : Form
    {
        Controladora controladora = Controladora.GetInstance;
        Shortcuts shortcuts = new Shortcuts();
        PaletaColores colorPalette = new PaletaColores();
        // Se crea una instancia de la clase categoria
        CategoriaLogica categoryLogic = new CategoriaLogica();

        public CategoriaForm()
        {
            InitializeComponent();
        }
        // Lista de filas del datagridview

        private void Categorias_Load(object sender, EventArgs e)
        {
            // Se cargan los datos en el datagridview
            loadCategoriesData();
            // Desactivar boton guardar hasta que se haga un cambio en el datagridview
            btnGuardarG.Enabled = false;
        }

        // Variables para el datagridview
        private BindingSource bindingSourceCategories;
        private void loadCategoriesData()
        {
            // obtener las categorias desde la base de datos
            try
            {
                List<CategoriasModel> categoriesList = categoryLogic.GetCategories();
                bindingSourceCategories = new BindingSource(categoriesList, null);

                // cargar los datos en el datagridview
                dtaIDCategoria.DataPropertyName = "CategoriaID";
                dtaNombreCategoria.DataPropertyName = "Nombre";
                dtaDescripcionCategoria.DataPropertyName = "Descripcion";
                // Se asigna el binding source al datagridview
                dtaViewCategoria.DataSource = bindingSourceCategories;
                dtaViewCategoria.Columns["MedicamentosModel"].Visible = false;
                controladora.CheckEmptyDataGridView(dtaViewCategoria, "dtaIDCategoria");

            }
            catch (SqlException)
            {
                throw;
            }
        }


        // // // // // // AGREGAR CATEGORIA // // // // // //

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Model Categoria
            CategoriasModel category = new CategoriasModel();
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
                MessageBox.Show("¡Por favor, complete los campos!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // // // // // // AGREGAR CATEGORIA // // // // // //



        // // // // // // MODIFICAR CATEGORIA // // // // // //
        // Modificación de celdas
        private List<DataGridViewRow> modifiedRows = new List<DataGridViewRow>();
        private void btnGuardarG_Click(object sender, EventArgs e)
        {
            //  Se crea una isntancia de la clase categoria
            CategoriasModel category = new CategoriasModel();
            foreach (DataGridViewRow row in modifiedRows)
            {
                int selectedCategoryID = Convert.ToInt32(row.Cells["dtaIDCategoria"].Value);
                string selectedCategoryName = row.Cells["dtaNombreCategoria"].Value.ToString();
                string selectedCategoryDescription = row.Cells["dtaDescripcionCategoria"].Value.ToString();

                category.CategoriaID = selectedCategoryID;
                category.Nombre = selectedCategoryName;
                // Se utiliza un operador ternario para verificar si el campo esta vacio o tiene espacio.
                category.Descripcion = selectedCategoryDescription;

                bool result = categoryLogic.ModifyCategory(category);
                if (result)
                {
                    MessageBox.Show("Se modifico correctamente la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Se cargan los datos en el datagridview
                    loadCategoriesData();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }


        private void showMessageError()
        {
            MessageBox.Show("No se permite dejar este campo vacío.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        // // // // // // MODIFICAR CATEGORIA // // // // // //




        // // // // // // ELIMINAR CATEGORIA // // // // // //
        private object originalValue { get; set; }

        // Función para retoran una lista con los nombres de las categorias seleccionadas
        private List<string> getSelectedCategories()
        {
            if (dtaViewCategoria.SelectedRows.Count > 0)
            {
                // Lista para almacenar los nombres de las categorias seleccionadas
                List<string> selectedCategories = new List<string>();
                // Se recorren las filas seleccionadas
                foreach (DataGridViewRow row in dtaViewCategoria.SelectedRows)
                {
                    int selectedCategoryID = Convert.ToInt32(row.Cells["dtaIDCategoria"].Value);
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
            if (dtaViewCategoria.SelectedRows.Count > 1)
            {
                // Lista para almacenar los nombres de las categorias seleccionadas
                List<string> categoryNames = getSelectedCategories();
                for (int i = 0; i < categoryNames.Count; i++)
                {
                    categoryNames[i] = $"- {categoryNames[i]}";
                }
                message = "¿Está seguro que desea eliminar las siguientes categorías?\n\n" + string.Join("\n", categoryNames);
            }
            else if (dtaViewCategoria.SelectedRows.Count == 1)
            {
                // Significa que se selecciono una categoria
                string categoryName = getSelectedCategories()[0];
                message = "¿Está seguro que desea eliminar la categoría " + categoryName + "?";
            }
            return message;
        }

        // Mensaje de eliminación de varias categorias o una categoria
        private void deleteCategoriesMessage(int categories)
        {
            if (categories > 1)
            {
                MessageBox.Show("Se eliminaron correctamente las categorías seleccionadas.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (categories == 1)
            {
                MessageBox.Show("Se elimino correctamente la categoría seleccionada.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEliminarG_Click(object sender, EventArgs e)
        {
            if (dtaViewCategoria.SelectedRows.Count > 0)
            {
                int categoriesCount = dtaViewCategoria.SelectedRows.Count;
                string message = getDeleteConfirmationMessage();
                DialogResult userConfirmation = MessageBox.Show(message, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (userConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dtaViewCategoria.SelectedRows)
                    {
                        // Condicional multiples selección
                        int selectedCategoryId = Convert.ToInt32(row.Cells["dtaIDCategoria"].Value);

                        // bool para verificar si un medicamento esta asociado a una categoria
                        bool hasMedicine = categoryLogic.CheckIfMedicineHasCategory(selectedCategoryId);

                        // Eliminar el estante
                        bool deletionResult = categoryLogic.DeleteCategory(selectedCategoryId);
                        if (deletionResult)
                        {
                            CategoriasModel category = (CategoriasModel)bindingSourceCategories[row.Index];
                            bindingSourceCategories.Remove(category);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la categoria: " + categoryLogic.GetCategory(selectedCategoryId).Nombre, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                deleteCategoriesMessage(categoriesCount);
            loadCategoriesData();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // // // // // // ELIMINAR CATEGORIA // // // // // //

        // // // // // // INTERFAZ // // // // // //
        // Evento cuando se clicke una celda del datagridview
        private void dtaViewCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
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
            txtNombreCat.LineColor = colorPalette.ColorDisabled;
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
        private void dtaViewCategoria_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // obtener valor de celda a modificar
            DataGridViewRow row = dtaViewCategoria.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];
            // Verifica si la celda está en la columna de descripción
            if (cell.OwningColumn.Name == "dtaDescripcionCategoria" && cell.Value == null)
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
        }



        private void dtaViewCategoria_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtaViewCategoria.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            // Obtener el valor original de la celda
            originalValue = cell.Value != null ? cell.Value : null;
        }

        private void dtaViewCategoria_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Verifica si el error es causado por el usuario y no por el sistema
            if (e.Exception is FormatException && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dtaViewCategoria.Rows[e.RowIndex].Cells[e.ColumnIndex];
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


        // // // // // // INTERFAZ // // // // // //

    }
}
