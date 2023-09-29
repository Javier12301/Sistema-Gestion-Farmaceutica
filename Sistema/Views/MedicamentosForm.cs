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
using Sistema.Database.Logica;
using Guna.UI.WinForms;
using System.Data.SqlClient;

namespace Sistema.Vista
{

    public partial class MedicamentosForm : Form
    {
        CategoriaForm categoria = new CategoriaForm();
        Estante estante = new Estante();
        CategoriaLogica categoriaLogica = new CategoriaLogica();
        EstanteLogica estanteLogica = new EstanteLogica();
        MedicamentoLogica medicamentoLogica = new MedicamentoLogica();
        Controladora controladora = new Controladora();
        public MedicamentosForm()
        {
            InitializeComponent();
        }
            
        private void Medicamentos_Load(object sender, EventArgs e)
        {
            // inicializar combo box index 0
            cmbFilteCat.SelectedIndex = 0;
            cmbFilterEst.SelectedIndex = 0;
            // desactivar filtros checkbox
            cmbFilteCat.Enabled = false;
            cmbFilterEst.Enabled = false;
            // Cargar combobox filtros
            cargarFiltros();
            // Cargar datos en el datagridview
            loadMedicine();
        }

        // Cargar datos en el datagridview
        private BindingSource bindingSourceMedicine;

        private void loadMedicine()
        {
            /*
            try
            {
                List<Medicamento> listaMedicamentos = medicamentoLogica.obtenerMedicamentoParaDataGridView();
                bindingSourceMedicamentos = new BindingSource(listaMedicamentos, null);

                // configurar las columnas del datagridview
                dtaLote.DataPropertyName = "LoteID";
                dtaNameMedicamento.DataPropertyName = "Nombre_Medicamento";
                dtaCantidad.DataPropertyName = "Stock";
                dtaVencimiento.DataPropertyName = "FechaVencimiento";
                // configurar columnas de CategoriaForm y Estante
                // CategoriaForm
                dtaNombreCat.DataPropertyName = "CategoriaNombre";
                // EstantesForm
                dtaNombreEst.DataPropertyName = "Nombre_Estante";
                dtaSector.DataPropertyName = "Sector";
                dtaNumEst.DataPropertyName = "Numero_Estante";
             
                // Se asigna el binding source al datagridview
                dtaViewMedicamentos.DataSource = bindingSourceMedicamentos;
                // Se esconde los campos que no se quieren mostrar
                dtaViewMedicamentos.Columns["CategoriaID"].Visible = false;
                dtaViewMedicamentos.Columns["EstanteID"].Visible = false;
                dtaViewMedicamentos.Columns["PrecioUnitario"].Visible = false;
                // Verificar datagridview vacio
                controladora.CheckEmptyDataGridView(dtaViewMedicamentos, "dtaLote");
            }
            catch (SqlException)
            {
                throw;
            }
            */
        }


        private void cmbCheck_Changed(object sender, EventArgs e)
        {
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
            }
        }

        private void cargarFiltros()
        {/*
            try
            {
                List<string> listaCategoria = categoriaLogica.obtenerNombresCategorias();
                List<string> listaEstante = estanteLogica.obtenerNombresEstantes();

                // Agregar item predeterminado
                listaCategoria.Insert(0, "Seleccionar Categoría.");
                listaEstante.Insert(0, "Seleccionar Estante.");

                // Cargar combobox filtros
                cmbFilteCat.DataSource = listaCategoria;
                cmbFilterEst.DataSource = listaEstante;
                // Display Member
                cmbFilteCat.DisplayMember = "Nombre";
                cmbFilterEst.DisplayMember = "Nombre";
            }
            catch (SqlException)
            {
                throw;
            }
            */
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
