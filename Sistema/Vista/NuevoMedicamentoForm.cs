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
using Sistema.Database.Modelo;
using System.Data.SqlClient;
using Sistema.Modelo;
using Sistema.Controles.Logica;
using System.Windows.Navigation;

namespace Sistema.Vista
{
    public partial class NuevoMedicamentoForm : Form
    {
        private Point mouseDownLocation;
        Shortcuts shortcuts = new Shortcuts();
        Controladora controladora = new Controladora();

        CategoriaLogica categoryLogic = new CategoriaLogica();
        EstanteLogica shelfLogic = new EstanteLogica();
        LoteLogica loteLogica = new LoteLogica();
        MedicamentoLogica medicamentoLogica = new MedicamentoLogica();

        public NuevoMedicamentoForm()
        {
            InitializeComponent();
        }

        private void nuevoMedicamento_Load(object sender, EventArgs e)
        {

            //ComboBox predeterminados
            cmbCatMedicamento.SelectedIndex = 0;
            cmbEstanteMedicamento.SelectedIndex = 0;
            loadCMBData();
        }


        // Variables List Models privadas para hacer get
        private List<EstantesModel> _shelvesListModel;
        private List<CategoriasModel> _categoryListModel;

        public List<EstantesModel> ShelvesListModel
        {
            get
            {
                if (_shelvesListModel == null)
                {
                    _shelvesListModel = shelfLogic.GetShelves();
                }
                return _shelvesListModel;
            }
            set
            {
                _shelvesListModel = value;
            }
        }

        public List<CategoriasModel> CategoryListModel
        {
            get
            {
                if (_categoryListModel == null)
                {
                    _categoryListModel = categoryLogic.GetCategories();
                }
                return _categoryListModel;
            }
            set
            {
                _categoryListModel = value;
            }
        }
        // // // // // Las variables  buscan evitar  recursión infinitas en los Get y Set // // //


        private void loadCMBData()
        {         
            // Obtener lista de nombres de estantes y categorías para cargar los combobox
            List<string> shelvesList = ShelvesListModel.Select(shelf => shelf.Nombre).ToList();
            List<string> categoryList = CategoryListModel.Select(category => category.Nombre).ToList();
            // Insertar en la primera posición de la lista
            categoryList.Insert(0, "Seleccionar Categoría.");
            shelvesList.Insert(0, "Seleccionar Estante.");
            // Cargar combobox
            cmbCatMedicamento.DataSource = categoryList;
            cmbEstanteMedicamento.DataSource = shelvesList;
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

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {

            bool isMedicineNameValid = controladora.VerifyTextBoxT(txtNombreMedicamento, errorProvider);
            bool isStockValid = controladora.VerifyTextBoxT(txtStockMedicamento, errorProvider);
            bool isUnitPriceValid = controladora.VerifyTextBoxT(txtPrecioUnitMedicamento, errorProvider);
            // Verificar si el precio unitario es decimal o entero
            

            if (isMedicineNameValid && isStockValid && isUnitPriceValid)
            {
                // Creamos un nuevo Lote con los datos ingresados por el usuario
                LotesModel lote = new LotesModel();
                lote.Nombre_Medicamento = txtNombreMedicamento.Text;
                lote.LoteID = Convert.ToInt32(txtLoteMedicamento.Text);
                lote.Stock = Convert.ToInt32(txtStockMedicamento.Text);
                lote.FechaVencimiento = dtaVencimientoMedicamento.Value;
                // Creamos un nuevo Medicamento con los datos ingresados por el usuario

                MedicamentosModel medicine = new MedicamentosModel();     
                medicine.LoteID = Convert.ToInt32(txtLoteMedicamento.Text);
                // Utilizar el nombre del combo box para obtener el ID de la categoría
                medicine.CategoriaID = CategoryListModel.Where(category => category.Nombre == cmbCatMedicamento.Text).Select(category => category.CategoriaID).FirstOrDefault();
                medicine.EstanteID = ShelvesListModel.Where(shelf => shelf.Nombre == cmbEstanteMedicamento.Text).Select(shelf => shelf.EstanteID).FirstOrDefault();
                // se utilizará un condicional ternario para saber si es decimal o int
                medicine.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitMedicamento.Text);
                // Agregamos el Lote y el Medicamento a la base de datos
                bool loteResult = loteLogica.AddLote(lote);
                

                


                
            }
            else
            {
                MessageBox.Show("¡Por favor, rellene los campos obligatorios!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //try
            //{

            //    bool loteResultado = loteLogica.agregarLote(lote);
            //    bool medicamentoResultado = medicamentoLogica.agregarMedicamento(medicamento);
            //    if(loteResultado && medicamentoResultado)
            //    {
            //        DialogResult result = MessageBox.Show("¡Se agrego el medicamento exitosamente!\n¿Desea agregar un nuevo medicamento?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (result == DialogResult.Yes)
            //        {
            //            txtNombreMedicamento.Text = "";
            //            cmbCatMedicamento.SelectedIndex = 0;
            //            cmbEstanteMedicamento.SelectedIndex = 0;
            //            txtStockMedicamento.Text = "";
            //            txtPrecioUnitMedicamento.Text = "";
            //            pnlNombreMedicamento.Focus();
            //            txtNombreMedicamento.Focus();
            //        }
            //        else if (result == DialogResult.No)
            //        {
            //            this.Close();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo agregar el medicamento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //}catch(SqlException)
            //{
            //    throw;
            //}

        }

        private void validacionCamposObligatorios(object sender, CancelEventArgs e)
        {
            TextBox txtSender = (TextBox)sender;
            if(string.IsNullOrWhiteSpace(txtSender.Text))
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
    }
}
