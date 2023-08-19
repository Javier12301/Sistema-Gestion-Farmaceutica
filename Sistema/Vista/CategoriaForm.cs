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
using Sistema.Database.Logica;
using Sistema.Database.Modelo;
using System.Data.SqlClient;

namespace Sistema.Vista
{
    public partial class CategoriaForm : Form
    {
        Controladora controladora = new Controladora();
        Shortcuts shortcuts = new Shortcuts();
        PaletaColores colorPalette = new PaletaColores();
        //Se crea una instancia de la clase CategoriaLogica
        CategoriaLogica categoriaLogica = new CategoriaLogica();
        // Modelos
        Categoria categoria = new Categoria();

        public CategoriaForm()
        {
            InitializeComponent();
        }
        // Lista de filas del datagridview

        private void Categorias_Load(object sender, EventArgs e)
        {
            // Se cargan los datos en el datagridview
            cargarDatosCategorias();
            // Desactivar boton guardar hasta que se haga un cambio en el datagridview
            btnGuardarG.Enabled = false;
        }

        // Variables para el datagridview
        private BindingSource bindingSourceCategorias;

        private void cargarDatosCategorias()
        {
            // obtener las categorias desde la base de datos
            try
            {
                List<Categoria> listaCategorias = categoriaLogica.obtenerCategoria();
                bindingSourceCategorias = new BindingSource(listaCategorias, null);

                // cargar los datos en el datagridview
                dtaIDCategoria.DataPropertyName = "CategoriaID";
                dtaNombreCategoria.DataPropertyName = "Nombre";
                dtaDescripcionCategoria.DataPropertyName = "Descripcion";
                // Se asigna el binding source al datagridview
                dtaViewCategoria.DataSource = bindingSourceCategorias;
                controladora.CheckEmptyDataGridView(dtaViewCategoria, "dtaIDCategoria");

            }
            catch (SqlException)
            {
                throw;
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool txtBoolNombreCategoria = controladora.VerifyTextBoxG(txtNombreCat);
            if (txtBoolNombreCategoria)
            {
                // Se utiliza la instancia de la clase categoria
                categoria.Nombre = txtNombreCat.Text;
                categoria.Descripcion = txtDescripcionCat.Text;

                try
                {
                    bool resultado = categoriaLogica.agregarCategoria(categoria);
                    if (resultado)
                    {
                        MessageBox.Show("Se agrego corectamente una nueva categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Se limpian los campos
                        txtNombreCat.Text = "";
                        txtDescripcionCat.Text = "";
                        // Se cargan los datos en el datagridview
                        cargarDatosCategorias();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //cargarDatosCategorias();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocurrio un error al agregar la categoría. " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else

            {
                MessageBox.Show("¡Por favor, complete los campos!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombreCat_Enter(object sender, EventArgs e)
        {
            txtNombreCat.LineColor = colorPalette.ColorDisabled;
        }

        // Modificación de celdas
        private void btnGuardarG_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in modifiedRows)
            {
                int id = Convert.ToInt32(row.Cells["dtaIDCategoria"].Value);
                string nombre = row.Cells["dtaNombreCategoria"].Value.ToString();
                string descripcion = row.Cells["dtaDescripcionCategoria"].Value.ToString();

                categoria.CategoriaID = id;
                categoria.Nombre = nombre;
                categoria.Descripcion = descripcion;
                try
                {
                    bool resultado = categoriaLogica.modificarCategoria(categoria);
                    if (resultado)
                    {
                        MessageBox.Show("Se modifico correctamente la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Se cargan los datos en el datagridview
                        cargarDatosCategorias();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (SqlException)
                {
                    throw;
                }

            }

            modifiedRows.Clear();
            btnGuardarG.Enabled = false;

        }

        private List<DataGridViewRow> modifiedRows = new List<DataGridViewRow>();
        // Evento cuando se modifique una celda del datagridview
        private void dtaViewCategoria_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtaViewCategoria.Rows[e.RowIndex];
            if (!modifiedRows.Contains(row))
            {
                modifiedRows.Add(row);
            }
            // Activar boton guardar
            btnGuardarG.Enabled = true;


        }

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

        private void btnEliminarG_MouseEnter(object sender, EventArgs e)
        {
            btnEliminarG.Radius = 12;
        }

        private void btnEliminarG_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarG.Radius = 5;
        }

        private void btnEliminarG_Click(object sender, EventArgs e)
        {
            // verificar si se selecciono una fila
            if (dtaViewCategoria.SelectedRows.Count > 0)
            {
                // Obtenemos el id de la fila seleccionada
                int _id = Convert.ToInt32(dtaViewCategoria.CurrentRow.Cells["dtaIDCategoria"].Value);
                // Se crea un cuadro de dialogo para confirmar la eliminacion
                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar la categoría?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    // Eliminar la categoria de la base de datos
                    try
                    {
                        bool resultadoEliminar = categoriaLogica.eliminarCategoria(_id);
                        if (resultadoEliminar)
                        {
                            // Eliminar la fila del datagridview
                            Categoria categoria = (Categoria)bindingSourceCategorias[dtaViewCategoria.CurrentRow.Index];
                            bindingSourceCategorias.Remove(categoria);
                            MessageBox.Show("Se elimino correctamente la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDatosCategorias();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException)
                    {
                        throw;
                    }

                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
