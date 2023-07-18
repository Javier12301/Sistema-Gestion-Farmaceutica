using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Controles;
using Sistema.Database.Logica;

namespace Sistema.formHijos
{
    
    public partial class Principal : Form
    {
        Shortcuts shortcuts = new Shortcuts();
        EstanteLogica estanteLogica = new EstanteLogica();
        CategoriaLogica categoriaLogica = new CategoriaLogica();
        MedicamentoLogica medicamentoLogica = new MedicamentoLogica();
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblNumEstantes.Text = estanteLogica.obtenerCantidadEstantes().ToString();
            lblNumCategorias.Text = categoriaLogica.obtenerCantidadCategorias().ToString();
            lblNumMedicamentos.Text = medicamentoLogica.obtenerCantidadMedicamentos().ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            shortcuts.LimpiarTextoHastaelEspacio(txtBuscar, e);
        }

       
    }
}
