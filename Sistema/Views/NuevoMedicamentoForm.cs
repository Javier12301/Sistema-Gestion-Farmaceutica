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
using System.Data.SqlClient;
using Sistema.Models;
using Sistema.Controles.Logica;
using System.Windows.Navigation;
using System.Data.Entity.Infrastructure;
using Sistema.Controles.Interfaz;
using Sistema.Views.Modales;

namespace Sistema.Vista
{
    public partial class NuevoMedicamentoForm : Form
    {
        private Point mouseDownLocation;
        Shortcuts shortcuts = new Shortcuts();
        Controladora controladora = Controladora.ObtenerInstancia;

        private bool medicineSave { get; set; }
        //private CategoriaLogica lCategoria = new CategoriaLogica();
        private EstanteLogica shelfLogic = new EstanteLogica();
        private ProveedorLogica supplierLogic = new ProveedorLogica();
        private MedicamentoLogica lMedicina = new MedicamentoLogica();
        private MessageBoxManager sGestorMensajes = MessageBoxManager.ObtenerInstancia;
        // Listas para almacenar datos de la base de datos, ESTANTE, CATEGORIA, PROVEEDOR
        private List<ESTANTE> shelvesList { get; set; }
        private List<CATEGORIA> categoryList { get; set; }
        private List<PROVEEDOR> supplierList { get; set; }
        // Lista para almacenar datos de la base de datos, MEDICAMENTO
        private MEDICAMENTO medicineToEdit { get; set; }



        public NuevoMedicamentoForm(MEDICAMENTO medicine)
        {
            InitializeComponent();
            medicineToEdit = medicine;
            medicineSave = false;
        }

        private void nuevoMedicamento_Load(object sender, EventArgs e)
        {
            cmbProveedorM.Enabled = false;
            loadCMBData();
            if (medicineToEdit != null)
            {
                setMedicineToEdit();
                btnbuscar.Enabled = true;
                btnbuscar.Visible = true;
            }
        }


        private void loadCMBData()
        {
            try
            {
                // Cargar ComboBox con datos de la base de datos
                shelvesList = shelfLogic.GetShelves(true);
                //categoryList = lCategoria.ObtenerCategorias(true);
                supplierList = supplierLogic.GetSuppliers(true);

                // con Select solo buscamos obtener el nombre de cada estante, categoria y proveedor
                List<string> shelvesNames = shelvesList.Select(shelf => shelf.Nombre).ToList();
                List<string> categoryNames = categoryList.Select(category => category.Nombre).ToList();
                List<string> supplierNames = supplierList.Select(supplier => supplier.RazonSocial).ToList();

                // Insertar en la primera posición de la lista
                shelvesNames.Insert(0, "Seleccionar Estante...");
                categoryNames.Insert(0, "Seleccionar Categoría...");
                supplierNames.Insert(0, "Seleccionar Proveedor...");
                // Cambiar nombres a los items por defecto
                shelvesNames[1] = "Estante por defecto";
                categoryNames[1] = "Categoría por defecto";
                supplierNames[1] = "Proveedor por defecto";
                // Combobox de Estado solo tiene dos opciones, Activo y No Activo
                cmbEstadoM.Items.Add("Seleccionar Estado...");
                cmbEstadoM.Items.Add("Activo");
                cmbEstadoM.Items.Add("No Activo");
                cmbEstadoM.SelectedIndex = 0;
                // Cargar combobox
                cmbEstanteM.DataSource = shelvesNames;
                cmbCategoriaM.DataSource = categoryNames;
                cmbProveedorM.DataSource = supplierNames;
                setComboBox();
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

        // // // // // /// /// AGREGAR MEDICAMENTO /// // // // // /// ///

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (medicineToEdit != null)
            {
                updateMedicineData();
            }
            else
            {
                addMedicine();
            }
        }

        // Agregar Medicamento Nuevo
        private void addMedicine()
        {
            try
            {
                MEDICAMENTO medicine = new MEDICAMENTO();
                bool isCodValid = controladora.VerificarTextBoxT(txtCodBarrasM, errorProvider);
                bool isMedicineNamedValid = controladora.VerificarTextBoxT(txtNombreM, errorProvider);
                bool isLoteValid = controladora.VerificarTextBoxT(txtLoteM, errorProvider);
                // Obligatoriamente se debe seleccionar el estado del medicamento
                bool isStateSelected = controladora.VerificarComboBox(cmbEstadoM, errorProvider, lblEstado);
                // si isStateSelected es false, se prende el errorProvider
                if (isCodValid && isMedicineNamedValid && isLoteValid && isStateSelected)
                {
                    // Utilizamos la instancia de MEDICAMENTO para asignar los valores
                    medicine.Codigo = txtCodBarrasM.Text;
                    medicine.Nombre = txtNombreM.Text;
                    medicine.Lote = txtLoteM.Text;
                    medicine.FechaVencimiento = dtaVencimiento.Value;
                    // A través de condiciones ternarias verificamos los combobox, si el usuario no selecciona nada, se asigna el valor por defecto
                    string selectedShelf = cmbEstanteM.SelectedItem.ToString();
                    string selectedCategory = cmbCategoriaM.SelectedItem.ToString();
                    string selectedSupplier = cmbProveedorM.SelectedItem.ToString();
                    // Utilizamos LINQ para obtener el ID de cada elemento seleccionado
                    medicine.EstanteID = shelvesList.Where(shelf => shelf.Nombre == selectedShelf).Select(shelf => shelf.EstanteID).FirstOrDefault();
                    medicine.CategoriaID = categoryList.Where(category => category.Nombre == selectedCategory).Select(category => category.CategoriaID).FirstOrDefault();
                    medicine.ProveedorID = supplierList.Where(supplier => supplier.RazonSocial == selectedSupplier).Select(supplier => supplier.ProveedorID).FirstOrDefault();
                    medicine.Estado = cmbEstadoM.SelectedItem.ToString() == "Activo" ? true : false;
                    // Ahora comprobamos los checkbox refrigerado y bajo receta, en la base de dato están establecidos como bit
                    medicine.Refrigerado = chkRefrigeado.Checked;
                    medicine.BajoReceta = chkBajoReceta.Checked;
                    medicine.Stock = txtStock.Text == "" ? 0 : Convert.ToInt32(txtStock.Text);
                    medicine.PrecioCompra = txtCosto.Text == "" ? 0 : Convert.ToDecimal(txtCosto.Text);
                    medicine.PrecioVenta = txtPrecio.Text == "" ? 0 : Convert.ToDecimal(txtPrecio.Text);
                    // Establecemos la fecha de creación del medicamento 
                    medicine.FechaRegistro = DateTime.Now;
                    // Comprobar si los datos fueron cargados y las id de cada combobox seleccionada son validas, crear un string con todo los datos cargados y que tengan salto de linea                              
                    bool result = lMedicina.AddMedicine(medicine);
                    if (result)
                    {
                        MessageBox.Show("Se agrego correctamente un medicamento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        medicineSave = true;
                        // Preguntar si desea agregar otro medicamento
                        DialogResult dialogResult = MessageBox.Show("¿Desea agregar otro medicamento?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            // Se limpian los campos
                            clearFields();
                        }
                        else
                        {
                            // Cerrar el formulario
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el medicamento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("¡Por favor, complete los campos obligatorios!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);                  
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


        // // // // // /// /// AGREGAR MEDICAMENTO /// // // // // /// ///

        // // // // // /// /// MODIFICAR MEDICAMENTO /// // // // // /// ///
        private void updateMedicineData()
        {
            try
            {
                MEDICAMENTO medicine = new MEDICAMENTO();
                bool isCodValid = controladora.VerificarTextBoxT(txtCodBarrasM, errorProvider);
                bool isMedicineNamedValid = controladora.VerificarTextBoxT(txtNombreM, errorProvider);
                bool isLoteValid = controladora.VerificarTextBoxT(txtLoteM, errorProvider);
                bool isStateSelected = controladora.VerificarComboBox(cmbEstadoM, errorProvider, lblEstado);
                if (isCodValid && isMedicineNamedValid && isLoteValid && isStateSelected)
                {
                    // Utilizamos la instancia de MEDICAMENTO para asignar los valores
                    medicine.MedicamentoID = medicineToEdit.MedicamentoID;
                    medicine.Codigo = txtCodBarrasM.Text;
                    medicine.Nombre = txtNombreM.Text;
                    medicine.Lote = txtLoteM.Text;
                    medicine.FechaVencimiento = dtaVencimiento.Value;
                    // A través de condiciones ternarias verificamos los combobox, si el usuario no selecciona nada, se asigna el valor por defecto
                    string selectedShelf = cmbEstanteM.SelectedItem.ToString();
                    string selectedCategory = cmbCategoriaM.SelectedItem.ToString();
                    string selectedSupplier = cmbProveedorM.SelectedItem.ToString();
                    // Utilizamos LINQ para obtener el ID de cada elemento seleccionado
                    medicine.EstanteID = shelvesList.Where(shelf => shelf.Nombre == selectedShelf).Select(shelf => shelf.EstanteID).FirstOrDefault();
                    medicine.CategoriaID = categoryList.Where(category => category.Nombre == selectedCategory).Select(category => category.CategoriaID).FirstOrDefault();
                    medicine.ProveedorID = supplierList.Where(supplier => supplier.RazonSocial == selectedSupplier).Select(supplier => supplier.ProveedorID).FirstOrDefault();
                    medicine.Estado = cmbEstadoM.SelectedItem.ToString() == "Activo" ? true : false;
                    // Ahora comprobamos los checkbox refrigerado y bajo receta, en la base de dato están establecidos como bit
                    medicine.Refrigerado = chkRefrigeado.Checked;
                    medicine.BajoReceta = chkBajoReceta.Checked;
                    medicine.Stock = txtStock.Text == "" ? 0 : Convert.ToInt32(txtStock.Text);
                    medicine.PrecioCompra = txtCosto.Text == "" ? 0 : Convert.ToDecimal(txtCosto.Text);
                    medicine.PrecioVenta = txtPrecio.Text == "" ? 0 : Convert.ToDecimal(txtPrecio.Text);
                    // Comprobar si los datos fueron cargados y las id de cada combobox seleccionada son validas, crear un string con todo los datos cargados y que tengan salto de linea                              
                    bool result = lMedicina.ModifyMedicine(medicine);
                    if (result)
                    {
                        MessageBox.Show("Se modifico correctamente el medicamento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        medicineSave = true;
                        // Preguntar si desea agregar otro medicamento
                        DialogResult dialogResult = MessageBox.Show("¿Desea modificar otro medicamento?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            // Abrir formulario para buscar medicamentos
                            openModalForm();

                        }
                        else
                        {
                            // Cerrar el formulario
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el medicamento", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        // // // // // /// /// MODIFICAR MEDICAMENTO /// // // // // /// ///


        // // // // /// /// INTERFAZ /// /// / // // // // /// ///

        // Comprobar si ID es 0, si es así seleccionar el primer elemento del combobox

        private void setMedicineToEdit()
        {
            try
            {
                if (medicineToEdit != null)
                {
                    // Cargar los datos del medicamento seleccionado
                    txtCodBarrasM.Text = medicineToEdit.Codigo;
                    txtNombreM.Text = medicineToEdit.Nombre;
                    txtLoteM.Text = medicineToEdit.Lote;
                    dtaVencimiento.Value = medicineToEdit.FechaVencimiento.Value;
                    // Cargar los checkbox
                    chkRefrigeado.Checked = medicineToEdit.Refrigerado.Value;
                    chkBajoReceta.Checked = medicineToEdit.BajoReceta.Value;
                    txtStock.Text = medicineToEdit.Stock.ToString();
                    txtCosto.Text = medicineToEdit.PrecioCompra.ToString();
                    txtPrecio.Text = medicineToEdit.PrecioVenta.ToString();
                    setComboBox();
                    // Comprobar a traves de condiciones ternarias si los valores de Precio compra y Precio venta son mayores a 0
                    // Si son mayores a 0 activarlas si son 0 desactivarlas
                    txtCosto.Enabled = medicineToEdit.PrecioCompra > 0 ? true : false;
                    txtPrecio.Enabled = medicineToEdit.PrecioVenta > 0 ? true : false;
                    // Verificar si el medicamento tiene un proveedor, si no tiene deshabilitar el cmbProveedor
                    // Para cargar un proveedor, el usuario debe registrar la compra del medicamento
                    cmbProveedorM.Enabled = medicineToEdit.ProveedorID.Value != 0 ? true : false;
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

        // Obtener ganancia totales
        // Utilizar función textChanged
        private void txtGanancias_TextChanged(object sender, EventArgs e)
        {
            getTotalProfits();
        }

        private void getTotalProfits()
        {
            try
            {
                // Utilizando la ecuación de -> Ganancia total = (Precio Venta - Precio Compra) * Stock
                // Obtenemos el valor de ganancia total
                decimal precioCompra = txtCosto.Text == "" ? 0 : Convert.ToDecimal(txtCosto.Text);
                decimal precioVenta = txtPrecio.Text == "" ? 0 : Convert.ToDecimal(txtPrecio.Text);
                int stock = txtStock.Text == "" ? 0 : Convert.ToInt32(txtStock.Text);
                // Calcular la ganancia total
                decimal totalProfits = (precioVenta - precioCompra) * stock;
                txtGanancia.Text = totalProfits.ToString();
            }
            catch (Exception)
            {
                // Otras excepciones no manejadas
                sGestorMensajes.Error.MostrarErrorInesperado();
            }
        }

        // Cargar combobox según el modo de operación del formulario o sea agregar o modificar
        private void setComboBox()
        {
            if (medicineToEdit != null)
            {
                // Con este método se cargan los combobox con los datos de la base de datos utilizando la ID de cada elemento
                SetComboBoxItem(cmbEstanteM, Convert.ToInt32(medicineToEdit.EstanteID), shelvesList, shelf => shelf.EstanteID, shelf => shelf.Nombre);
                SetComboBoxItem(cmbCategoriaM, Convert.ToInt32(medicineToEdit.CategoriaID), categoryList, category => category.CategoriaID, category => category.Nombre);
                SetComboBoxItem(cmbProveedorM, Convert.ToInt32(medicineToEdit.ProveedorID), supplierList, supplier => supplier.ProveedorID, supplier => supplier.RazonSocial);
                // Para el caso de los combobox estados, solo se revisa si está en true o false, seleccionará el item "Activo" o "No Activo"
                cmbEstadoM.SelectedItem = medicineToEdit.Estado == true ? "Activo" : "No Activo";
            }
        }

        private void SetComboBoxItem<T>(ComboBox comboBox, int itemId, IEnumerable<T> itemList, Func<T, int> idSelector, Func<T, string> nameSelector)
        {
            // Si la ID del estante, cateogíra o proveedor es 0, seleccionar el primer elemento del combobox 
            // el primer combobox es el por defecto
            if (itemId == 0)
            {
                comboBox.SelectedIndex = 1;
            }
            else
            {
                // Caso contrario seleccionar el elemento que corresponde a la ID
                var selectedItem = itemList.Where(item => idSelector(item) == itemId).Select(nameSelector).FirstOrDefault();
                comboBox.SelectedItem = selectedItem;
            }
        }

        private void pnlControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - mouseDownLocation.X;
                int deltaY = e.Y - mouseDownLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void pnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }
        // // // // /// /// INTERFAZ /// /// / // // // // /// ///

        // Función para limpiar campos en ingles
        private void clearFields()
        {
            // Messagebox preguntando si está seguro de limpiar los campos
            DialogResult respuestaUsuario = MessageBox.Show("¿Desea limpiar los campos?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaUsuario == DialogResult.Yes)
            {
                controladora.LimpiarTextBoxT(txtCodBarrasM, txtNombreM, txtLoteM);
                cmbEstanteM.SelectedIndex = 0;
                cmbCategoriaM.SelectedIndex = 0;
                cmbProveedorM.SelectedIndex = 0;
                cmbEstadoM.SelectedIndex = 0;
                // Unchecked las propiedades
                chkBajoReceta.Checked = false;
                chkRefrigeado.Checked = false;
            }
        }




        private void validacionCamposObligatorios(object sender, CancelEventArgs e)
        {
            TextBox txtSender = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txtSender.Text))
            {

                errorProvider.SetError(txtSender, "Campo obligatorio");
            }

            else
            {

                errorProvider.SetError(txtSender, null);
            }

        }

        //Shortcut Limpiador
        private void limpiarHastaElEspacio(object sender, KeyEventArgs e)
        {
            TextBox txtSender = (TextBox)sender;
            shortcuts.LimpiarTextoHastaelEspacio(txtSender, e);
        }
        // Control de entrada de datos con números
        private void txtNumericos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si el carácter no es un número
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            openModalForm();
        }

        private void openModalForm()
        {
            using (var modal = new mdMedicamento())
            {
                var result = modal.ShowDialog();
                // Obtenemos instancia MEDICAMENTO de la ventana modal
                if (result == DialogResult.OK)
                {
                    int medicineID = modal.medicine.MedicamentoID;
                    // Crear string con todo los valores de medicineToEdit para un messagebox
                    MEDICAMENTO selectedMedicine = lMedicina.GetMedicine(medicineID);
                    medicineToEdit = selectedMedicine;
                    setMedicineToEdit();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (medicineSave)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }

        private void NuevoMedicamentoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(medicineSave)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
