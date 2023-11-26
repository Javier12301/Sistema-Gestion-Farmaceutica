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
        private MedicamentoLogica medicamentoLogica = new MedicamentoLogica();
        private MessageBoxManager messageManager = MessageBoxManager.GetInstance;
        // Listas para almacenar datos de la base de datos, ESTANTE, CATEGORIA, PROVEEDOR
        private List<ESTANTE> shelvesList { get; set; }
        private List<CATEGORIA> categoryList { get; set; }
        private List<PROVEEDOR> supplierList { get; set; }


        public NuevoMedicamentoForm()
        {
            InitializeComponent();
        }

        private void nuevoMedicamento_Load(object sender, EventArgs e)
        {

            //ComboBox predeterminados
            cmbEstanteM.SelectedIndex = 0;
            cmbCategoriaM.SelectedIndex = 0;
            cmbProveedorM.SelectedIndex = 0;
            loadCMBData();
        }

        private void loadCMBData()
        {
            try
            {
                // Cargar ComboBox con datos de la base de datos
                shelvesList = shelfLogic.GetShelves();
                categoryList = categoryLogic.GetCategories();
                supplierList = supplierLogic.GetSuppliers();

                // con Select solo buscamos obtener el nombre de cada estante, categoria y proveedor
                List<string> shelvesNames = shelvesList.Select(shelf => shelf.Nombre).ToList();
                List<string> categoryNames = categoryList.Select(category => category.Nombre).ToList();
                List<string> supplierNames = supplierList.Select(supplier => supplier.RazonSocial).ToList();

                // Insertar en la primera posición de la lista
                shelvesNames.Insert(0, "Seleccionar Estante...");
                categoryNames.Insert(0, "Seleccionar Categoría...");
                supplierNames.Insert(0, "Seleccionar Proveedor...");
                // Cargar combobox
                cmbEstanteM.DataSource = shelvesNames;
                cmbCategoriaM.DataSource = categoryNames;
                cmbProveedorM.DataSource = supplierNames;
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
            addMedicine();

        }

        // Agregar Medicamento Nuevo
        private void addMedicine()
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
                string selectedShelf = cmbEstanteM.SelectedIndex == 0 ? "Seleccionar Estante..." : cmbEstanteM.SelectedItem.ToString();
                string selectedCategory = cmbCategoriaM.SelectedIndex == 0 ? "Seleccionar Categoría..." : cmbCategoriaM.SelectedItem.ToString();
                string selectedSupplier = cmbProveedorM.SelectedIndex == 0 ? "Seleccionar Proveedor..." : cmbProveedorM.SelectedItem.ToString();
                // Utilizamos LINQ para obtener el ID de cada elemento seleccionado
                medicine.EstanteID = shelvesList.Where(shelf => shelf.Nombre == selectedShelf).Select(shelf => shelf.EstanteID).FirstOrDefault();
                medicine.CategoriaID = categoryList.Where(category => category.Nombre == selectedCategory).Select(category => category.CategoriaID).FirstOrDefault();
                medicine.ProveedorID = supplierList.Where(supplier => supplier.RazonSocial == selectedSupplier).Select(supplier => supplier.ProveedorID).FirstOrDefault();
                // Ahora comprobamos los checkbox refrigerado y bajo receta, en la base de dato están establecidos como bit
                medicine.Refrigerado = chkRefrigeado.Checked;
                medicine.BajoReceta = chkBajoReceta.Checked;
                // Todavía no guardamos, testeamos si la lógica está funcionando
                string medicineData = $"Nombre: {medicine.Nombre}\nCódigo: {medicine.Codigo}\nLote: {medicine.Lote}\nEstante: {medicine.EstanteID}\nCategoría: {medicine.CategoriaID}\nProveedor: {medicine.ProveedorID}\nRefrigerado: {medicine.Refrigerado}\nBajo Receta: {medicine.BajoReceta}";
                MessageBox.Show(medicineData);
                


                //if (loteResult)
                //{
                //    // Creamos un nuevo Medicamento con los datos ingresados por el usuario
                //    MedicamentosModel medicine = new MedicamentosModel();
                //    // Utilizar Nombre de medicamento, Numero de lote y Stock para obtener el ID del lote
                //    MessageBox.Show(lote.LoteID.ToString());

                //    //medicine.LoteID = lote.LoteID;
                //    // Utilizamos el nombre del combo box para obtener el ID de la categoría
                //    medicine.CategoriaID = cacheManagerList.CategoryListModel.Where(category => category.Nombre == cmbCatMedicamento.Text).Select(category => category.CategoriaID).FirstOrDefault();
                //    medicine.EstanteID = cacheManagerList.ShelvesListModel.Where(shelf => shelf.Nombre == cmbEstanteMedicamento.Text).Select(shelf => shelf.EstanteID).FirstOrDefault();
                //    // Utilizamos un condicional ternario para saber si es decimal o int
                //    medicine.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitMedicamento.Text);

                //    // Agregamos el Medicamento a la base de datos
                //    bool medicineResult = medicamentoLogica.AddMedicine(medicine);

                //    if (medicineResult)
                //    {
                //        DialogResult result = MessageBox.Show("¡Se agregó el medicamento exitosamente!\n¿Desea agregar un nuevo medicamento?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //        if (result == DialogResult.Yes)
                //        {
                //            // Limpiar los campos
                //            controladora.ClearTextBoxT(txtNombreMedicamento, txtLoteMedicamento, txtStockMedicamento, txtPrecioUnitMedicamento);
                //            cmbCatMedicamento.SelectedIndex = 0;
                //            cmbEstanteMedicamento.SelectedIndex = 0;
                //            // Enfocar el cursor en el primer campo
                //            pnlNombreMedicamento.Focus();
                //            txtNombreMedicamento.Focus();
                //        }
                //        else
                //        {
                //            this.Close();
                //        }
                //    }
                //}
            }
            else
            {
                MessageBox.Show("¡Por favor, rellene los campos obligatorios!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Modificar Medicamento

        // // // // // /// /// AGREGAR MEDICAMENTO /// // // // // /// ///




        // // // // /// /// INTERFAZ /// /// / // // // // /// ///
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
            // Se limpiarán todo los campos cargados
            // Primero se verificará si el campo de código de barras está habilitado, si está deshabilitado
            // es porque el usuario está modificando un medicamento, por lo tanto no se limpiará el campo de código de barras
            if (txtCodBarrasM.Enabled)
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


    }
}
