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

namespace Sistema.formHijos
{
    public partial class Estantes : Form
    {
        Controladora controladora = new Controladora();
        PaletaColores paleta = new PaletaColores();
        public Estantes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validaciones
            bool txtNombreEstante = controladora.verificarTextbox(txtNombreE);
            bool txtNumEstante = controladora.verificarTextbox(txtNumE);
            bool txtSectorEstante = controladora.verificarTextbox(txtSectorE);
            if (txtNombreEstante && txtNumEstante && txtSectorEstante)
            {
                MessageBox.Show("Se agrego corectamente");
            }
            else
            {
                MessageBox.Show("Por favor complete los campos!");
            }
            
            
            
            
            //Falta conectar DB


        }

        private void txtNombreE_Enter(object sender, EventArgs e)
        {
            txtNombreE.LineColor = paleta.ColorDisabled;
        }

        private void txtNumE_Enter(object sender, EventArgs e)
        {
            txtNumE.LineColor = paleta.ColorDisabled;
        }

        private void txtSectorE_Enter(object sender, EventArgs e)
        {
            txtSectorE.LineColor = paleta.ColorDisabled;
        }
    }
}
