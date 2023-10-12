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
using Sistema.Models;
using Sistema.Controles.Logica;
using System.Windows.Navigation;
using Sistema.Services;

namespace Sistema.Vista
{
    public partial class NuevoMedicamentoForm : Form
    {
        private Point mouseDownLocation;
        Shortcuts shortcuts = new Shortcuts();
        Controladora controladora = Controladora.GetInstance;

        private CategoriaLogica categoryLogic = new CategoriaLogica();
        private EstanteLogica shelfLogic = new EstanteLogica();
        private LoteLogica loteLogica = new LoteLogica();
        private MedicamentoLogica medicamentoLogica = new MedicamentoLogica();
        private CacheManagerList cacheManagerList = new CacheManagerList();

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

        private void loadCMBData()
        {         
            // Obtener lista de nombres de estantes y categorías para cargar los combobox
            
            List<string> shelvesList = cacheManagerList.ShelvesListModel.Select(shelf => shelf.Nombre).ToList();
            List<string> categoryList = cacheManagerList.CategoryListModel.Select(category => category.Nombre).ToList();
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

            if (isMedicineNameValid && isStockValid && isUnitPriceValid)
            {
                // Creamos un nuevo Lote con los datos ingresados por el usuario
                LotesModel lote = new LotesModel();
                lote.Nombre_Medicamento = txtNombreMedicamento.Text;
                lote.Numero_Lote = txtLoteMedicamento.Text;
                lote.Stock = Convert.ToInt32(txtStockMedicamento.Text);
                lote.FechaVencimiento = dtaVencimientoMedicamento.Value;

                // Agregamos el Lote a la base de datos
                bool loteResult = loteLogica.AddLote(lote);

                if (loteResult)
                {
                    // Creamos un nuevo Medicamento con los datos ingresados por el usuario
                    MedicamentosModel medicine = new MedicamentosModel();
                    // Utilizar Nombre de medicamento, Numero de lote y Stock para obtener el ID del lote
                    MessageBox.Show(lote.LoteID.ToString());
                    
                    //medicine.LoteID = lote.LoteID;
                    // Utilizamos el nombre del combo box para obtener el ID de la categoría
                    medicine.CategoriaID = cacheManagerList.CategoryListModel.Where(category => category.Nombre == cmbCatMedicamento.Text).Select(category => category.CategoriaID).FirstOrDefault();
                    medicine.EstanteID = cacheManagerList.ShelvesListModel.Where(shelf => shelf.Nombre == cmbEstanteMedicamento.Text).Select(shelf => shelf.EstanteID).FirstOrDefault();
                    // Utilizamos un condicional ternario para saber si es decimal o int
                    medicine.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitMedicamento.Text);
                    
                    // Agregamos el Medicamento a la base de datos
                    bool medicineResult = medicamentoLogica.AddMedicine(medicine);

                    if (medicineResult)
                    {
                        DialogResult result = MessageBox.Show("¡Se agregó el medicamento exitosamente!\n¿Desea agregar un nuevo medicamento?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            // Limpiar los campos
                            controladora.ClearTextBoxT(txtNombreMedicamento, txtLoteMedicamento, txtStockMedicamento, txtPrecioUnitMedicamento);
                            cmbCatMedicamento.SelectedIndex = 0;
                            cmbEstanteMedicamento.SelectedIndex = 0;
                            // Enfocar el cursor en el primer campo
                            pnlNombreMedicamento.Focus();
                            txtNombreMedicamento.Focus();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Por favor, rellene los campos obligatorios!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
