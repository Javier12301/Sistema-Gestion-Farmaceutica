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
        Controladora controladora = Controladora.ObtenerInstancia;
        Shortcuts shortcuts = new Shortcuts();
        readonly PaletaColores paleta = PaletaColores.ObtenerInstancia;
        // Se crea una instancia de la clase categoria
        private readonly CategoriaLogica lCategoria = new CategoriaLogica();
        ObservadorDataGridView dgvObserver = new ObservadorDataGridView();
        MessageBoxManager sGestorMensajes = MessageBoxManager.ObtenerInstancia;
        private bool botonModificarPresionado { get; set; } = false;
        private object valorOriginal { get; set; }



        public CategoriaForm()
        {
            InitializeComponent();
        }
    
        // Lista de filas del datagridview

        private void Categorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDBDataSet.CATEGORIA' Puede moverla o quitarla según sea necesario.
            cargarDataGridView();
            cargarComboBox();
            // Desactivar boton guardar hasta que se haga un cambio en el datagridview
            btnGuardarG.Enabled = false;
            alternarModoEdicion();
            // Acomodar tamaño de la celda selectora de filas
            dgvCategoria.RowHeadersWidth = 30;
            actualizarFilasTotales();
        }

        // Variables para el datagridview
        private void cargarDataGridView()
        {
            // Comprobar si existe categoria
            try
            {
                // Cargamos el datagridview y ponemos en parametro false, para no cargar la categoria default
                cATEGORIATableAdapter.Fill(this.farmaciaDBDataSet.CATEGORIA);
                actualizarFilasTotales();
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

        // // // // // Funciones de botones // // // // //
        private void alternarModoEdicion()
        {
            if (botonModificarPresionado)
            {
                // Activar el modo edición del datagridview
                botonModificarPresionado = false;
                btnModificarG.Image = Properties.Resources.EditingIcon;
                btnModificarG.BaseColor = paleta.ColorBotonModificarActivo;
                dgvCategoria.ReadOnly = false;
                dgvcID.ReadOnly = true;
            }
            else
            {
                // Si se han realizado cambios, muestra un MessageBox.
                if (controladora.IsDatagridViewModified)
                {
                    DialogResult resultado = MessageBox.Show("Has realizado modificaciones y estás cambiando al modo de lectura. ¿Deseas guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Guarda los cambios.                      
                        modificarCategoria(true);

                    }
                    else
                    {
                        // Restaura los datos originales.
                        cargarDataGridView();
                    }
                    controladora.IsDatagridViewModified = false;
                }

                // Desactivar el modo edición del datagridview
                botonModificarPresionado = true;
                btnModificarG.Image = Properties.Resources.PencilIcon;
                btnModificarG.BaseColor = paleta.ColorBotonModificarActivo;

                dgvCategoria.ReadOnly = true;
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
                    DialogResult respuestaUsuario = MessageBox.Show("Has realizado modificaciones y estás agregando una nueva categoría. ¿Deseas guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuestaUsuario == DialogResult.Yes)
                    {
                        // Guarda los cambios.                      
                        modificarCategoria(true);
                        agregarCategoria();
                        txtNombreCat.Focus();
                    }
                    else
                    {
                        // Restaura los datos originales.
                        agregarCategoria();
                        cargarDataGridView();
                        txtNombreCat.Focus();
                    }
                }
                else
                {
                    agregarCategoria();
                    txtNombreCat.Focus();
                }
            }
            catch (DbUpdateException)
            {
                sGestorMensajes.Error.MostrarErrorActualizacionBaseDatos();
            }
            catch (SqlException)
            {
                sGestorMensajes.Error.MostrarErrorSQL();
            }
            catch (Exception)
            {
                sGestorMensajes.Error.MostrarErrorInesperado();
            }
        }

        private void agregarCategoria()
        {
            // Model Categoria
            CATEGORIA oCategoria = new CATEGORIA();
            bool campoCategoriaValido = controladora.VerificarTextBoxG(txtNombreCat);
            if (campoCategoriaValido)
            {
                // Se utiliza la instancia de la clase categoria
                oCategoria.Nombre = txtNombreCat.Text;
                // Se utiliza un operador ternario para verificar si el campo esta vacio o tiene espacio.
                oCategoria.Descripcion = (string.IsNullOrWhiteSpace(txtDescripcionCat.Text)) ? "-" : txtDescripcionCat.Text;

                bool resultado = lCategoria.AgregarCategoria(oCategoria);
                if (resultado)
                {
                    MessageBox.Show("Se agrego correctamente la categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Se limpian los campos
                    controladora.LimpiarTextBoxG(txtNombreCat);
                    controladora.LimpiarTextBoxT(txtDescripcionCat);
                    // Se cargan los datos en el datagridview
                    cargarDataGridView();
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
        Dictionary<int, DataGridViewRow> filasModificadas = new Dictionary<int, DataGridViewRow>();
        private void btnGuardarG_Click(object sender, EventArgs e)
        {
            modificarCategoria(true);
        }

        private void btnModifyG_Click(object sender, EventArgs e)
        {
            alternarModoEdicion();
        }

        private void modificarCategoria(bool actualizarDGV)
        {
            try
            {
                CATEGORIA oCategoria = new CATEGORIA();
                int celdasModificadas = 0; // Variable para contar las filas modificadas
                foreach (KeyValuePair<int, DataGridViewRow> fila in filasModificadas)
                {
                    oCategoria.CategoriaID = Convert.ToInt32(fila.Value.Cells[0].Value);
                    oCategoria.Nombre = Convert.ToString(fila.Value.Cells[1].Value);
                    oCategoria.Descripcion = Convert.ToString(fila.Value.Cells[2].Value);

                    bool resultado = lCategoria.ModificarCategoria(oCategoria);
                    if (resultado)
                    {
                        celdasModificadas++; // Incrementa el contador de categorias modificados
                    }
                }

                // Limpia el diccionario y deshabilita el botón
                filasModificadas.Clear();
                controladora.IsDatagridViewModified = false;
                btnGuardarG.Enabled = false;

                // Mensaje de notificación dinámico // Poner siempre en singular el nombre del elemento
                sGestorMensajes.Informacion.MostrarMensajeModificacion(celdasModificadas, "categoría");
                // Recargar los datos después de procesar todas las filas modificadas
                if (actualizarDGV)
                {
                    cargarDataGridView();
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



        // // // // // // MODIFICAR CATEGORIA // // // // // //




        // // // // // // ELIMINAR CATEGORIA // // // // // //

        // Función para retoran una lista con los nombres de las categorias seleccionadas
        private List<string> obtenerCategoriasSeleccionadas()
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                // Lista para almacenar los nombres de las categorias seleccionadas
                List<string> categoriasSeleccionadas = new List<string>();
                // Se recorren las filas seleccionadas
                foreach (DataGridViewRow fila in dgvCategoria.SelectedRows.Cast<DataGridViewRow>().Reverse())
                {
                    int categoriaSeleccionadaID = Convert.ToInt32(fila.Cells["dgvcID"].Value);
                    // Se utiliza el id para obtener el objeto categoria y luego obtenemos el nombre
                    string nombreCategoria = lCategoria.ObtenerCategoria(categoriaSeleccionadaID).Nombre.ToString();
                    categoriasSeleccionadas.Add(nombreCategoria);
                }
                return categoriasSeleccionadas;
            }
            else
            {
                return null;
            }
        }

        // Obtener mensaje confirmación para eliminar categorias
        private string mensajeConfirmacionEliminar()
        {
            string mensaje = "";
            // Significa que se selecciono más de una oCategoria
            if (dgvCategoria.SelectedRows.Count > 1)
            {
                // Lista para almacenar los nombres de las categorias seleccionadas
                List<string> categoryNames = obtenerCategoriasSeleccionadas();
                for (int i = 0; i < categoryNames.Count; i++)
                {
                    categoryNames[i] = $"- {categoryNames[i]}";
                }
                mensaje = "¿Está seguro que desea eliminar las siguientes categorías?\n\n" + string.Join("\n", categoryNames);

            }
            else if (dgvCategoria.SelectedRows.Count == 1)
            {
                // Significa que se selecciono una categoria
                string nombreCategoria = obtenerCategoriasSeleccionadas()[0];
                mensaje = "¿Está seguro que desea eliminar la categoría: \"" + nombreCategoria + "\"?";
            }
            return mensaje;
        }




        private void btnEliminarG_Click(object sender, EventArgs e)
        {
            try
            {
                // Utilizamos el observer para comprobar si el usuario modifico el datagridview
                if (controladora.IsDatagridViewModified)
                {
                    // preguntar al usuario si desea guardar los cambios antes de eliminar
                    DialogResult respuestaUsuario = MessageBox.Show("¿Desea guardar los cambios antes de eliminar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuestaUsuario == DialogResult.Yes)
                    {
                        modificarCategoria(false);
                        eliminarCategoriasSeleccionadas();
                    }
                    else
                    {
                        eliminarCategoriasSeleccionadas();
                    }
                }
                else
                {
                    eliminarCategoriasSeleccionadas();
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
            catch (Exception ex)
            {
                // Otras excepciones no manejadas
                sGestorMensajes.Error.MostrarErrorInesperado();
                MessageBox.Show(ex.ToString());
                // Loguear ex si es necesario para fines de depuración
            }

        }

        private void eliminarCategoriasSeleccionadas()
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                int categoriesCount = dgvCategoria.SelectedRows.Count;
                string mensaje = mensajeConfirmacionEliminar();
                DialogResult userConfirmation = MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow fila in dgvCategoria.SelectedRows)
                    {
                        // condicional multiples SelectedRows
                        int categoriaSeleccionadaID = Convert.ToInt32(fila.Cells["dgvcID"].Value);
                        bool eliminacionResultado = lCategoria.EliminarCategoria(categoriaSeleccionadaID);
                        if (!eliminacionResultado)
                        {
                            MessageBox.Show("La operación ha sido cancelada.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }                  
                    }
                    sGestorMensajes.Informacion.MostrarMensajeEliminacion(categoriesCount, "categoria");
                    // Mensaje de notificación dinámico // Poner siempre en singular el nombre del elemento
                }
                else
                {
                    MessageBox.Show("La operación ha sido cancelada.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                // Se actualiza el datagridview
                cargarDataGridView();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar la categoria.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // // // // // // ELIMINAR CATEGORIA // // // // // //

        // // // // // // INTERFAZ // // // // // //
        // Combobox
        private void cargarComboBox()
        {
            // Combobox Estados
            cmbEstadoCat.Items.Add("Seleccionar Estado");
            cmbEstadoCat.Items.Add("Activo");
            cmbEstadoCat.Items.Add("Inactivo");
            cmbEstadoCat.SelectedIndex = 0;
        }

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
            txtNombreCat.LineColor = paleta.ColorDeshabilitado;
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
            DataGridViewRow fila = dgvCategoria.Rows[e.RowIndex];
            DataGridViewCell celda = fila.Cells[e.ColumnIndex];
            // Verifica si la celda está en la columna de descripción
            if (celda.OwningColumn.Name == "dgvcDescripcionC" && celda.Value == null)
            {
                // Si el valor es nulo o está en blanco, establece el valor en "-"
                if (celda.Value == null || string.IsNullOrWhiteSpace(celda.Value.ToString()))
                {
                    celda.Value = "-";
                    btnGuardarG.Enabled = true;
                }
            }
            else
            {
                // Verifica si el valor es un espacio en blanco o una cadena vacía
                if (celda.Value == null || string.IsNullOrWhiteSpace(celda.Value.ToString()))
                {
                    sGestorMensajes.Advertencia.MostrarMensajeCeldaVacia();
                    // Restaura el valor original de la celda
                    celda.Value = valorOriginal;
                }
                else
                {
                    // 
                    if (!filasModificadas.ContainsKey(fila.Index))
                    {
                        filasModificadas.Add(fila.Index, fila);
                    }
                    else
                    {
                        filasModificadas[fila.Index] = fila;
                    }

                    btnGuardarG.Enabled = true;
                    controladora.Attach(dgvObserver);
                    controladora.IsDatagridViewModified = true;
                }
            }
        }



        private void dgvCategoriesList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvCategoria.Rows[e.RowIndex];
            DataGridViewCell celda = fila.Cells[e.ColumnIndex];

            // Obtener el valor original de la celda
            valorOriginal = celda.Value ?? null;
        }

        // Evento cuando ocurre un error al modificar una celda del datagridview (Ej: ingresar letras en una celda de tipo numérico)
        private void dgvCategoriesList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Verifica si el error es causado por el usuario y no por el sistema
            if (e.Exception is FormatException && e.ColumnIndex >= 0)
            {
                DataGridViewCell celda = dgvCategoria.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellValue = celda.Value != null ? celda.Value.ToString() : string.Empty;

                if (string.IsNullOrWhiteSpace(cellValue))
                {
                    // Restaura el valor original de la celda
                    celda.Value = valorOriginal;
                }
                else
                {
                    // Restaura el valor original de la celda
                    celda.Value = valorOriginal;
                }

                e.ThrowException = false;
            }
            sGestorMensajes.Advertencia.MostrarMensajeCeldaVacia();
        }

        private void dgvCategoriesList_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
           // bindingSourceCategories.Sort = dgvCategoria.SortString;
        }

        private void dgvCategoriesList_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            //bindingSourceCategories.Filter = dgvCategoria.FilterString;
        }

        private void actualizarFilasTotales()
        {
            lblFilasTotales.Text = "Total de categoría: " + cATEGORIABindingSource.List.Count;
        }

        private void bindingSourceCategories_ListChanged(object sender, ListChangedEventArgs e)
        {
            actualizarFilasTotales();
        }

        private void dgvCategoriesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // // // // // // INTERFAZ // // // // // //

    }
}
