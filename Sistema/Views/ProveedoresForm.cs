using Sistema.Controles.Interfaz;
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
using Sistema.Controles.Logica;
using Sistema.Models;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace Sistema.Views
{
    public partial class ProveedoresForm : Form
    {
        Controladora controladora = Controladora.ObtenerInstancia;
        Shortcuts shortcuts = new Shortcuts();
        PaletaColores paleta = PaletaColores.ObtenerInstancia;
        // Se crea una instancia de la clase proveedor
        ProveedorLogica supplierLogic = new ProveedorLogica();
        ObservadorDataGridView dgvObserver = new ObservadorDataGridView();
        MessageBoxManager sGestorMensajes = MessageBoxManager.ObtenerInstancia;

        private bool botonModificarPresionado { get; set; } = false;
        private object valorOriginal { get; set; }

        public ProveedoresForm()
        {
            InitializeComponent();
        }

        private void ProveedoresForm_Load(object sender, EventArgs e)
        {
            loadSupplierData();
            alternarModoEdicion();
            dgvSupplierList.RowHeadersWidth = 30;
            actualizarFilasTotales();
        }

        private void loadSupplierData()
        {
            try
            {
                //this.pROVEEDORTableAdapter.Fill(this.farmaciaDBDataSet.PROVEEDOR);
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
                dgvSupplierList.ReadOnly = false;
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
                        updateSupplierData(true);

                    }
                    else
                    {
                        // Restaura los datos originales.
                        loadSupplierData();
                    }
                    controladora.IsDatagridViewModified = false;
                }

                // Desactivar el modo edición del datagridview
                botonModificarPresionado = true;
                btnModifyG.Image = Properties.Resources.PencilIcon;
                btnModifyG.BaseColor = paleta.ColorBotonModificarDeshabilitado;

                dgvSupplierList.ReadOnly = true;
            }
        }

        // // // // // // AGREGAR PROVEEDOR // // // // // //

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
                        updateSupplierData(true);
                        addSuplier();
                        txtNombreP_G.Focus();
                    }
                    else
                    {
                        // Restaura los datos originales.
                        addSuplier();
                        loadSupplierData();
                        txtNombreP_G.Focus();
                    }
                }
                else
                {
                    addSuplier();
                    txtNombreP_G.Focus();
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

        private void addSuplier()
        {
            // Model Proveedor
            PROVEEDOR supplier = new PROVEEDOR();
            // TXTBOX Obligatorios de completar: Razon social, Nro.Documento y Dirección
            bool isSupplierNameValid = controladora.VerificarTextBoxG(txtNombreP_G);
            bool isSupplierDocumentValid = controladora.VerificarTextBoxG(txtDocumentoP_G);
            bool isSupplierAddressValid = controladora.VerificarTextBoxG(txtDireccionP_G);
            if (isSupplierNameValid && isSupplierDocumentValid && isSupplierAddressValid)
            {
                // Se utiliza la instancia de la clase proveedor
                supplier.RazonSocial = txtNombreP_G.Text;
                supplier.Documento = txtDocumentoP_G.Text;
                supplier.Direccion = txtDireccionP_G.Text;
                // Se comprueba si se ingreso un número de teléfono o no, si no se ingreso se guarda un guión como valor por defecto.
                supplier.TelefonoProveedor = (string.IsNullOrWhiteSpace(txtTelefonoP_G.Text)) ? "-" : txtTelefonoP_G.Text;
                supplier.Correo = (string.IsNullOrEmpty(txtCorreoP_G.Text)) ? "-" : txtCorreoP_G.Text;

                bool result = supplierLogic.AddSupplier(supplier);
                if (result)
                {
                    MessageBox.Show("Se agrego correctamente el proveedor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Se limpian los campos
                    controladora.LimpiarTextBoxG(txtNombreP_G, txtDocumentoP_G, txtDireccionP_G, txtTelefonoP_G, txtCorreoP_G);
                    loadSupplierData();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el proveedor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else

            {
                MessageBox.Show("¡Por favor, complete los campos obligatorios!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // /// /// // // // AGREGAR PROVEEDOR // // // // // //

        // // // // // // MODIFICAR PROVEEDOR // // // // // //
        Dictionary<int, DataGridViewRow> filasModificadas = new Dictionary<int, DataGridViewRow>();
        private void btnGuardarG_Click(object sender, EventArgs e)
        {
            updateSupplierData(true);
        }

        private void btnModifyG_Click(object sender, EventArgs e)
        {
            alternarModoEdicion();
        }

        private void updateSupplierData(bool actualizarDGV)
        {
            try
            {
                PROVEEDOR supplier = new PROVEEDOR();
                int celdasModificadas = 0; // Variable para contar las filas modificadas
                foreach (KeyValuePair<int, DataGridViewRow> fila in filasModificadas)
                {
                    supplier.ProveedorID = Convert.ToInt32(fila.Value.Cells[0].Value);
                    supplier.RazonSocial = Convert.ToString(fila.Value.Cells[1].Value);
                    supplier.Documento = Convert.ToString(fila.Value.Cells[2].Value);
                    supplier.Direccion = Convert.ToString(fila.Value.Cells[3].Value);
                    supplier.TelefonoProveedor = Convert.ToString(fila.Value.Cells[4].Value);
                    supplier.Correo = Convert.ToString(fila.Value.Cells[5].Value);

                    bool result = supplierLogic.ModifySupplier(supplier);
                    if (result)
                    {
                        celdasModificadas++; // Incrementa el contador de proveedor modificados
                    }
                }

                // Limpia el diccionario y deshabilita el botón
                filasModificadas.Clear();
                controladora.IsDatagridViewModified = false;
                btnGuardarG.Enabled = false;

                // Mensaje de notificación dinámico // Poner siempre en singular el nombre del elemento
                sGestorMensajes.Informacion.MostrarMensajeModificacion(celdasModificadas, "proveedor");
                // Recargar los datos después de procesar todas las filas modificadas
                if (actualizarDGV)
                {
                    loadSupplierData();
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

        // // // // // // ELIMINAR PROVEEDOR // // // // // //

        // Función para retornar una lista con los nombres de los proveedores seleccionados
        private List<string> getSelectedSupplier()
        {
            if (dgvSupplierList.SelectedRows.Count > 0)
            {
                // Lista para almacenar los nombres de las proveedor seleccionadas
                List<string> selectedSupplier = new List<string>();
                // Se recorren las filas seleccionadas
                foreach (DataGridViewRow fila in dgvSupplierList.SelectedRows.Cast<DataGridViewRow>().Reverse())
                {
                    int selectedSupplierID = Convert.ToInt32(fila.Cells["dgvcID"].Value);
                    // Se utiliza el id para obtener el objeto categoria y luego obtenemos el nombre
                    string supplierName = supplierLogic.GetSupplier(selectedSupplierID).RazonSocial.ToString();
                    selectedSupplier.Add(supplierName);
                }
                return selectedSupplier;
            }
            else
            {
                return null;
            }
        }

        // Obtener mensaje confirmación para eliminar proveedor
        private string mensajeConfirmacionEliminar()
        {
            string mensaje = "";
            // Significa que se selecciono más de una categoria
            if (dgvSupplierList.SelectedRows.Count > 1)
            {
                // Lista para almacenar los nombres de los proveedores seleccionados
                List<string> supplierNames = getSelectedSupplier();
                for (int i = 0; i < supplierNames.Count; i++)
                {
                    supplierNames[i] = $"- {supplierNames[i]}";
                }
                mensaje = "¿Está seguro que desea eliminar los siguientes proveedores?\n\n" + string.Join("\n", supplierNames);
            }
            else if (dgvSupplierList.SelectedRows.Count == 1)
            {
                // Significa que se selecciono una categoria
                string supplierName = getSelectedSupplier()[0];
                mensaje = "¿Está seguro que desea eliminar el proveedor: \"" + supplierName + "\"?";
            }
            return mensaje;
        }


        private void btnEliminarG_Click(object sender, EventArgs e)
        {
            try
            {
                if (controladora.IsDatagridViewModified)
                {
                    // preguntar al usuario si desea guardar los cambios antes de eliminar
                    DialogResult respuestaUsuario = MessageBox.Show("¿Desea guardar los cambios antes de eliminar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuestaUsuario == DialogResult.Yes)
                    {
                        updateSupplierData(false);
                        deleteSelectedSuppliers();
                    }
                    else
                    {
                        deleteSelectedSuppliers();
                    }
                }
                else
                {
                    deleteSelectedSuppliers();
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

        private void deleteSelectedSuppliers()
        {
            if (dgvSupplierList.SelectedRows.Count > 0)
            {
                int supplierCount = dgvSupplierList.SelectedRows.Count;

                string mensaje = mensajeConfirmacionEliminar();
                DialogResult userConfirmation = MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow fila in dgvSupplierList.SelectedRows)
                    {
                        // condicional multiples SelectedRows
                        int selectedSupplierID = Convert.ToInt32(fila.Cells[0].Value);
                        bool eliminacionResultado = supplierLogic.DeleteSupplier(selectedSupplierID);
                        if (!eliminacionResultado)
                        {
                            MessageBox.Show("La operación ha sido cancelada.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    sGestorMensajes.Informacion.MostrarMensajeEliminacion(supplierCount, "proveedor");

                    // Mensaje de notificación dinámico // Poner siempre en singular el nombre del elemento
                }
                else
                {
                    MessageBox.Show("La operación ha sido cancelada.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Se actualiza el datagridview
                loadSupplierData();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar la categoria.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
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

        // // // // // INTERFAZ // // // // //


        private void txtNombreP_Enter(object sender, EventArgs e)
        {
            //txtNombreP.LineColor = paleta.ColorDeshabilitado;
        }

        private void txtDireccionP_Enter(object sender, EventArgs e)
        {
            //txtDireccionP.LineColor = paleta.ColorDeshabilitado;
        }

        private void txtTelefonoP_Enter(object sender, EventArgs e)
        {
            //txtTelefonoP.LineColor = paleta.ColorDeshabilitado;
        }



        private void dgvSupplierList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // obtener valor de celda a modificar
            DataGridViewRow fila = dgvSupplierList.Rows[e.RowIndex];
            DataGridViewCell celda = fila.Cells[e.ColumnIndex];

            // Verifica si la celda está en la columna de descripción o correo
            if ((celda.OwningColumn.Name == "dgvcTelefonoP" || celda.OwningColumn.Name == "dgvcCorreoP") && celda.Value == null)
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


        private void dgvSupplierList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvSupplierList.Rows[e.RowIndex];
            DataGridViewCell celda = fila.Cells[e.ColumnIndex];

            // Obtener el valor original de la celda
            valorOriginal = celda.Value != null ? celda.Value : null;
        }

        private void dgvSupplierList_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            bindingSourceSupplier.Sort = dgvSupplierList.SortString;

        }

        private void dgvSupplierList_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            bindingSourceSupplier.Filter = dgvSupplierList.FilterString;

        }

        private void actualizarFilasTotales()
        {
            lblTotalRow.Text = "Total de proveedores: " + bindingSourceSupplier.List.Count;
        }

        private void bindingSourceSupplier_ListChanged(object sender, ListChangedEventArgs e)
        {
            actualizarFilasTotales();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }
        // // // // // INTERFAZ // // // // //
    }
}
