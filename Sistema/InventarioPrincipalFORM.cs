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


namespace Sistema
{
    public partial class InventarioPrincipalFORM : Form
    {
        public InventarioPrincipalFORM()
        {
            InitializeComponent();
        }
        //Globales
        Shortcuts shortcuts = new Shortcuts();

        private void InventarioPrincipalFORM_Load(object sender, EventArgs e)
        {
            lblSize.Text = this.Size.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InventarioPrincipalFORM_ClientSizeChanged(object sender, EventArgs e)
        {
            lblSize.Text = this.Size.ToString();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //Activar Shortcuts de limpiar texto hasta el espacio
            shortcuts.ClearTextUntilSpace(txtSearch, e);
        }
    }
}
