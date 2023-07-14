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
    
    public partial class Principal : Form
    {
        Shortcuts shortcuts = new Shortcuts();
        public Principal()
        {
            InitializeComponent();
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
