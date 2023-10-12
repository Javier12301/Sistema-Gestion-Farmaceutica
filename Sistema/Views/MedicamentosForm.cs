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
using Guna.UI.WinForms;
using System.Data.SqlClient;
using Sistema.Services;
using Sistema.Models;

namespace Sistema.Vista
{

    public partial class MedicamentosForm : Form
    {
        private CategoriaLogica categoryLogic = new CategoriaLogica();
        private EstanteLogica shelfLogic = new EstanteLogica();
        private MedicamentoLogica medicineLogic = new MedicamentoLogica();
        Controladora controladora = Controladora.GetInstance;
        private CacheManagerList cacheManagerList = new CacheManagerList();

        public MedicamentosForm()
        {
            InitializeComponent();
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
        
            // Cargar combobox filtros
            //cargarFiltros();
            // Cargar datos en el datagridview
            loadMedicine();
            // Establecer nuevo tamaño al formulario
            this.Size = new Size(573, 299);
            // MENSAJE PARA FUTURO, CREAR UN FILTRO QUE PERMITA AGRANDAR EL DATAGRIDVIEW CON DATOS DE LOS MEDICAMENTOS
            // CON ESTO SE LOGRARÁ OPTIMIZAR EL TAMAÑO DEL FORMULARIO
        }

        // Cargar datos en el datagridview


        private BindingSource bindingSourceMedicine;

        private void loadMedicine()
        {
            try
            {
                //List<MedicamentosDetalle> medicineList = medicineLogic.GetAllMedicineDetails();
                //bindingSourceMedicine = new BindingSource(medicineList, null);

                // configurar las columnas del datagridview
                //FALTA ARREGLAR LOTE, TIRA EL LOTE ID, NO NÚMERO DE LOTE
                dtaLote.DataPropertyName = "Lote";
                dtaNameMedicamento.DataPropertyName = "Medicamento";
                dtaStock.DataPropertyName = "Cantidad";
                dtaVencimiento.DataPropertyName = "Vencimiento";
                // configurar columnas de CategoriaForm y Estante
                // CategoriaForm
                dtaNombreCat.DataPropertyName = "Categoria";
                // EstantesForm
                dtaNombreEst.DataPropertyName = "Estante";
                dtaSector.DataPropertyName = "Sector";
                dtaNumEst.DataPropertyName = "NumEstante";
                // Se asigna el binding source al datagridview
                dtaViewMedicamentos.DataSource = bindingSourceMedicine;
                // Se esconde los campos que no se quieren mostrar

                // Verificar datagridview vacio
                controladora.CheckEmptyDataGridView(dtaViewMedicamentos, "dtaLote");
            }
            catch (Exception ex)
            {
                throw;
            }
        }





        private void cmbCheck_Changed(object sender, EventArgs e)
        {
            /*
            GunaCheckBox check = (GunaCheckBox)sender;
            if (check.Checked)
            {
                switch (check.Tag)
                {
                    case "categoriasTAG":
                        cmbFilteCat.Enabled = true;
                        break;
                    case "estantesTAG":
                        cmbFilterEst.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (check.Tag)
                {
                    case "categoriasTAG":
                        cmbFilteCat.Enabled = false;
                        break;
                    case "estantesTAG":
                        cmbFilterEst.Enabled = false;
                        break;
                    default:
                        break;
                }
            }*/
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
            //cmbFilteCat.DataSource = categoryList;
            //cmbFilterEst.DataSource = shelvesList;
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            Vista.NuevoMedicamentoForm formAgregarMedicamento = new Vista.NuevoMedicamentoForm();
            formAgregarMedicamento.FormClosed += formAgregarMedicamento_FormClosed;
            formAgregarMedicamento.ShowDialog();
        }

        private void formAgregarMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {/*
            cargarDatosMedicamentos();*/
        }

    }
}
