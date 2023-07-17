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

namespace Sistema.formHijos
{

    public partial class Medicamentos : Form
    {
        Categoria categoria = new Categoria();
        Estante estante = new Estante();
        CategoriaLogica categoriaLogica = new CategoriaLogica();
        EstanteLogica estanteLogica = new EstanteLogica();
        
        public Medicamentos()
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
        {
            List<string> listaCategoria = categoriaLogica.obtenerNombresCategorias();
            List<string> listaEstante = estanteLogica.obtenerNombresEstantes();

            // Cargar combobox filtros
            cmbFilteCat.DataSource = listaCategoria;
            cmbFilterEst.DataSource = listaEstante;
            // Display Member
            cmbFilteCat.DisplayMember = "Nombre";
            cmbFilterEst.DisplayMember = "Nombre";

        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            formHijos.nuevoMedicamento formAgregarMedicamento = new formHijos.nuevoMedicamento();
            formAgregarMedicamento.ShowDialog();
        }

        
    }
}
