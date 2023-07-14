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

namespace Sistema.formHijos
{
    public partial class Categorias : Form
    {
        Controladora controladora = new Controladora();
        Shortcuts shortcuts = new Shortcuts();
        PaletaColores paleta = new PaletaColores();
        public Categorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool txtBoolNombreCategoria = controladora.verificarTextboxG(txtNombreCat);
            if (txtBoolNombreCategoria)
            {
                MessageBox.Show("Se agrego corectamente una nueva categoría.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Por favor, complete los campos!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombreCat_Enter(object sender, EventArgs e)
        {
            txtNombreCat.LineColor = paleta.ColorDisabled;
        }
    }
}
