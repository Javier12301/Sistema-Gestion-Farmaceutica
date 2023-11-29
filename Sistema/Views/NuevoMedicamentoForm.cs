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

namespace Sistema.Vista
{
    public partial class NuevoMedicamentoForm : Form
    {
        private Point mouseDownLocation;
        Shortcuts shortcuts = new Shortcuts();
        Controladora controladora = Controladora.GetInstance;

        private CategoriaLogica categoryLogic = new CategoriaLogica();
        private EstanteLogica shelfLogic = new EstanteLogica();
        private ProveedorLogica supplierLogic = new ProveedorLogica();
        private MedicamentoLogica medicineLogic = new MedicamentoLogica();
        private MessageBoxManager messageManager = MessageBoxManager.GetInstance;
        // Listas para almacenar datos de la base de datos, ESTANTE, CATEGORIA, PROVEEDOR
        private List<ESTANTE> shelvesList { get; set; }
        private List<CATEGORIA> categoryList { get; set; }
        private List<PROVEEDOR> supplierList { get; set; }
        private List<string> shelvesNames { get; set; }
        private List<string> categoryNames { get; set; }
        private List<string> supplierNames { get; set; }
        // Lista para almacenar datos de la base de datos, MEDICAMENTO
        private MEDICAMENTO medicineToEdit { get; set; }


        public NuevoMedicamentoForm(MEDICAMENTO medicine)
        {
            InitializeComponent();
            medicineToEdit = medicine;
        }

        private void nuevoMedicamento_Load(object sender, EventArgs e)
        {
            loadCMBData();
            if (medicineToEdit != null)
            {
                loadMedicineData();
            }
        }



        private void loadCMBData()
        {
            try
            {
                // Cargar ComboBox con datos de la base de datos
                shelvesList = shelfLogic.GetShelves(true);
                categoryList = categoryLogic.GetCategories(true);
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
                // Cargar combobox
                cmbEstanteM.DataSource = shelvesNames;
                cmbCategoriaM.DataSource = categoryNames;
                cmbProveedorM.DataSource = supplierNames;
                setComboBox();
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

        // // // // // /// /// AGREGAR MEDICAMENTO /// // // // // /// ///

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (medicineToEdit == null)
            {
                addMedicine();
            }
            else
            {

            }

        }

        // Agregar Medicamento Nuevo
        private void addMedicine()
        {
            try
            {
                MEDICAMENTO medicine = new MEDICAMENTO();
                bool isCodValid = controladora.VerifyTextBoxT(txtCodBarrasM, errorProvider);
                bool isMedicineNamedValid = controladora.VerifyTextBoxT(txtNombreM, errorProvider);
                bool isLoteValid = controladora.VerifyTextBoxT(txtLoteM, errorProvider);
                if (isCodValid && isMedicineNamedValid && isLoteValid)
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
                    // Ahora comprobamos los checkbox refrigerado y bajo receta, en la base de dato están establecidos como bit
                    medicine.Refrigerado = chkRefrigeado.Checked;
                    medicine.BajoReceta = chkBajoReceta.Checked;
                    // Comprobar si los datos fueron cargados y las id de cada combobox seleccionada son validas, crear un string con todo los datos cargados y que tengan salto de linea                              
                    bool result = medicineLogic.AddMedicine(medicine);
                    if (result)
                    {
                        MessageBox.Show("Se agrego correctamente un medicamento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        // // // // // /// /// AGREGAR MEDICAMENTO /// // // // // /// ///

        // // // // // /// /// MODIFICAR MEDICAMENTO /// // // // // /// ///
        private void updateMedicineData()
        {
            try
            {
                MEDICAMENTO medicine = new MEDICAMENTO();
                bool isCodValid = controladora.VerifyTextBoxT(txtCodBarrasM, errorProvider);
                bool isMedicineNamedValid = controladora.VerifyTextBoxT(txtNombreM, errorProvider);
                bool isLoteValid = controladora.VerifyTextBoxT(txtLoteM, errorProvider);
                if (isCodValid && isMedicineNamedValid && isLoteValid)
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
                    // Ahora comprobamos los checkbox refrigerado y bajo receta, en la base de dato están establecidos como bit
                    medicine.Refrigerado = chkRefrigeado.Checked;
                    medicine.BajoReceta = chkBajoReceta.Checked;
                    // Comprobar si los datos fueron cargados y las id de cada combobox seleccionada son validas, crear un string con todo los datos cargados y que tengan salto de linea                              
                    bool result = medicineLogic.ModifyMedicine(medicine);
                    if (result)
                    {
                        MessageBox.Show("Se modifico correctamente el medicamento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Preguntar si desea agregar otro medicamento
                        DialogResult dialogResult = MessageBox.Show("¿Desea modificar otro medicamento?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        MessageBox.Show("No se pudo modificar el medicamento", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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


        // // // // // /// /// MODIFICAR MEDICAMENTO /// // // // // /// ///


        // // // // /// /// INTERFAZ /// /// / // // // // /// ///
        // Cargar combobox según el modo de operación del formulario o sea agregar o modificar
        private void setComboBox()
        {
            SetComboBoxItem(cmbEstanteM, Convert.ToInt32(medicineToEdit.EstanteID), shelvesList, shelf => shelf.EstanteID, shelf => shelf.Nombre);
            SetComboBoxItem(cmbCategoriaM, Convert.ToInt32(medicineToEdit.CategoriaID), categoryList, category => category.CategoriaID, category => category.Nombre);
            SetComboBoxItem(cmbProveedorM, Convert.ToInt32(medicineToEdit.ProveedorID), supplierList, supplier => supplier.ProveedorID, supplier => supplier.RazonSocial);
        }

        private void SetComboBoxItem<T>(ComboBox comboBox, int itemId, IEnumerable<T> itemList, Func<T, int> idSelector, Func<T, string> nameSelector)
        {
            if (itemId == 0)
            {
                comboBox.SelectedIndex = 1;
            }
            else
            {
                var selectedItem = itemList.Where(item => idSelector(item) == itemId).Select(nameSelector).FirstOrDefault();
                comboBox.SelectedItem = selectedItem;
            }
        }



        // Comprobar si ID es 0, si es así seleccionar el primer elemento del combobox


        private void loadMedicineData()
        {
            try
            {
                // Cargar los datos del medicamento seleccionado
                txtCodBarrasM.Text = medicineToEdit.Codigo;
                txtNombreM.Text = medicineToEdit.Nombre;
                txtLoteM.Text = medicineToEdit.Lote;
                dtaVencimiento.Value = medicineToEdit.FechaVencimiento.Value;
                // Cargar los checkbox
                chkRefrigeado.Checked = medicineToEdit.Refrigerado.Value;
                chkBajoReceta.Checked = medicineToEdit.BajoReceta.Value;
                setComboBox();
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

        // Obtenemos el combobox index según el nombre de la categoría, proveedor o estante del medicamento, utilizamos
        // LINQ para obtener el index




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
            DialogResult userAnswer = MessageBox.Show("¿Está seguro de limpiar los campos?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userAnswer == DialogResult.Yes)
            {
                controladora.ClearTextBoxT(txtCodBarrasM, txtNombreM, txtLoteM);
                cmbEstanteM.SelectedIndex = 0;
                cmbCategoriaM.SelectedIndex = 0;
                cmbProveedorM.SelectedIndex = 0;
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


    }
}
