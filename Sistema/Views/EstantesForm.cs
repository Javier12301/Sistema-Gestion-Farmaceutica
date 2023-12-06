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
        Controladora controladora = Controladora.ObtenerInstancia;
        PaletaColores paleta = PaletaColores.ObtenerInstancia;
        EstanteLogica shelfLogic = new EstanteLogica();
        ObservadorDataGridView dgvObserver = new ObservadorDataGridView();
        MessageBoxManager sGestorMensajes = MessageBoxManager.ObtenerInstancia;

        private bool botonModificarPresionado { get; set; } = false;


        public EstantesForm()
        {
            InitializeComponent();
        }

        private void Estantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDBDataSet.ESTANTE' Puede moverla o quitarla según sea necesario.
            loadShelvesData();
            btnGuardarG.Enabled = false;
            alternarModoEdicion();
            // Acomodar tamaño de la celda selectora de filas
            dgvShelvesList.RowHeadersWidth = 30;
            actualizarFilasTotales();
        }

        private void txtNumE_KeyPress(object sender, KeyPressEventArgs e)
        {
            controladora.SoloNumeros(e);
        }

        // Método para obtener los datos del datagridview

        private void loadShelvesData()
        {
            try
            {
                //this.eSTANTETableAdapter.Fill(this.farmaciaDBDataSet.ESTANTE);
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
                btnModifyG.Image = Properties.Resources.EditingIcon;
                btnModifyG.BaseColor = paleta.ColorBotonModificarActivo;
                dgvShelvesList.ReadOnly = false;
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
                botonModificarPresionado = true;
                btnModifyG.Image = Properties.Resources.PencilIcon;
                btnModifyG.BaseColor = paleta.ColorBotonModificarDeshabilitado;

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
                    DialogResult respuestaUsuario = MessageBox.Show("Has realizado modificaciones y estás agregando un nuevo proveedor. ¿Deseas guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuestaUsuario == DialogResult.Yes)
                    {
                        // Guarda los cambios.                      
                        updateShelfData(true);
                        addShelf();
                        txtNombreE.Focus();
                    }
                    else
                    {
                        // Restaura los datos originales.
                        addShelf();
                        loadShelvesData();
                        txtNombreE.Focus();
                    }
                }
                else
                {
                    addShelf();
                    txtNombreE.Focus();
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

        private void addShelf()
        {
            // Model
            ESTANTE shelves = new ESTANTE();
            //Validaciones
            bool isShelfNameValid = controladora.VerificarTextBoxG(txtNombreE);
            bool isShelfNumberValid = controladora.VerificarTextBoxG(txtNumE);
            bool isShelfSectorValid = controladora.VerificarTextBoxG(txtSectorE);
            if (isShelfNameValid && isShelfNumberValid && isShelfSectorValid)
            {
                // Se utiliza la instancia de la clase Estante
                shelves.Nombre = txtNombreE.Text;
                shelves.Sector = txtSectorE.Text;

                bool result = shelfLogic.AddShelf(shelves);
                if (result)
                {
                    MessageBox.Show("Se agrego correctamente un nuevo estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Se limpian los campos
                    controladora.LimpiarTextBoxG(txtNombreE, txtNumE, txtSectorE);
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
                MessageBox.Show("¡Por favor, complete los campos obligatorios!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // // // // // //// /// AGREGAR ESTANTE /// /// //// ///


        // Variable para almacenar las filas modificadas
        Dictionary<int, DataGridViewRow> filasModificadas = new Dictionary<int, DataGridViewRow>();

        private void btnGuardarG_Click(object sender, EventArgs e)
        {
            updateShelfData(true);
        }
        private void updateShelfData(bool actualizarDGV)
        {
            ESTANTE shelf = new ESTANTE();
            int celdasModificadas = 0; // Variable para contar las filas modificadas

            try
            {
                foreach (KeyValuePair<int, DataGridViewRow> fila in filasModificadas)
                {
                    shelf.EstanteID = Convert.ToInt32(fila.Value.Cells[0].Value);
                    shelf.Nombre = Convert.ToString(fila.Value.Cells[1].Value);
                    shelf.Sector = Convert.ToString(fila.Value.Cells[3].Value);

                    bool result = shelfLogic.ModifyShelf(shelf);
                    if (result)
                    {
                        celdasModificadas++; // Incrementa el contador de estantes modificados
                    }
                }

                // Limpia el diccionario y deshabilita el botón
                filasModificadas.Clear();
                controladora.IsDatagridViewModified = false;
                btnGuardarG.Enabled = false;

                // Mensaje de notificación dinámico
                showMessageShelfModify(celdasModificadas);
                // Recargar los datos después de procesar todas las filas modificadas
                if (actualizarDGV)
                {
                    loadShelvesData();
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


        // Mensajes Dinámicos
        // Mensaje de Estantes modificados
        private void showMessageShelfModify(int celdasModificadas)
        {
            if (celdasModificadas > 0)
            {
                string mensaje;
                if (celdasModificadas == 1)
                {
                    mensaje = "Se modificó correctamente 1 estante.";
                }
                else
                {
                    mensaje = $"Se modificaron correctamente {celdasModificadas} estantes.";
                }
                MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnModifyG_Click(object sender, EventArgs e)
        {
            alternarModoEdicion();
        }


        // // // // // // ELIMINAR ESTANTES // // // // // //
        // Función para retornar una lista con los nombres de los estantes seleccionados
        private object valorOriginal { get; set; }


        private List<string> getSelectedShelvesNames()
        {
            if (dgvShelvesList.SelectedRows.Count > 0)
            {

                // Lista para almacenar los nombres de los estantes seleccionados
                List<string> shelfNames = new List<string>();
                // Iterar sobre las filas seleccionadas
                foreach (DataGridViewRow fila in dgvShelvesList.SelectedRows.Cast<DataGridViewRow>().Reverse())
                {
                    int selectedShelfID = Convert.ToInt32(fila.Cells["dgvcID"].Value);
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
        private string mensajeConfirmacionEliminar()
        {
            string mensaje = "";
            if (dgvShelvesList.SelectedRows.Count > 1)
            {
                // Lista para almacenar los nombres de los estantes seleccionados
                List<string> shelfNames = getSelectedShelvesNames();
                for (int i = 0; i < shelfNames.Count; i++)
                {
                    shelfNames[i] = $"- {shelfNames[i]}";
                }
                mensaje = "¿Está seguro que desea eliminar los siguientes estantes?\n\n" + string.Join("\n", shelfNames);
            }
            else if (dgvShelvesList.SelectedRows.Count == 1)
            {
                string shelfName = getSelectedShelvesNames()[0];
                mensaje = "¿Está seguro que desea eliminar el estante: \"" + shelfName + "\"?";
            }
            return mensaje;
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
                    DialogResult respuestaUsuario = MessageBox.Show("¿Desea guardar los cambios antes de eliminar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuestaUsuario == DialogResult.Yes)
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

        private void deleteSelectedShelf()
        {
            if (dgvShelvesList.SelectedRows.Count > 0)
            {
                int shelvesCount = dgvShelvesList.SelectedRows.Count;
                string mensaje = mensajeConfirmacionEliminar();
                DialogResult userConfirmation = MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow fila in dgvShelvesList.SelectedRows)
                    {
                        // condicional multiples SelectedRows
                        int selectedShelfID = Convert.ToInt32(fila.Cells[0].Value);
                        bool eliminacionResultado = shelfLogic.DeleteShelf(selectedShelfID); ;
                        if (!eliminacionResultado)
                        {
                            MessageBox.Show("La operación ha sido cancelada.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }                     
                    }
                    sGestorMensajes.Informacion.MostrarMensajeEliminacion(shelvesCount, "estante");
                    // Mensaje de notificación dinámico // Poner siempre en singular el nombre del elemento
                }
                else
                {
                    MessageBox.Show("La operación ha sido cancelada.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
            txtNombreE.LineColor = paleta.ColorDeshabilitado;
        }

        private void txtNumE_Enter(object sender, EventArgs e)
        {
            txtNumE.LineColor = paleta.ColorDeshabilitado;
        }

        private void txtSectorE_Enter(object sender, EventArgs e)
        {
            txtSectorE.LineColor = paleta.ColorDeshabilitado;
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

            DataGridViewRow fila = dgvShelvesList.Rows[e.RowIndex];
            DataGridViewCell celda = fila.Cells[e.ColumnIndex];

            // Obtener el valor original de la celda
            valorOriginal = celda.Value != null ? celda.Value : null;
        }




        private void dtaViewEstante_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // obtener valor de celda a modificar
            DataGridViewRow fila = dgvShelvesList.Rows[e.RowIndex];
            DataGridViewCell celda = fila.Cells[e.ColumnIndex];

            // Verifica si el valor es un espacio en blanco o una cadena vacía, y si la celda está en la columna de números de estante
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

        private void dtaViewEstante_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Verifica si el error es causado por el usuario
            if (e.Exception is FormatException && e.ColumnIndex >= 0)
            {
                DataGridViewCell celda = dgvShelvesList.Rows[e.RowIndex].Cells[e.ColumnIndex];
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

        private void actualizarFilasTotales()
        {
            lblTotalRow.Text = "Total de Estantes: " + bindingSourceShelves.List.Count;
        }

        private void bindingSourceShelves_ListChanged(object sender, ListChangedEventArgs e)
        {
            // Actualiza el contador de estantes
            actualizarFilasTotales();

        }
        //  // // // //
    }
}
