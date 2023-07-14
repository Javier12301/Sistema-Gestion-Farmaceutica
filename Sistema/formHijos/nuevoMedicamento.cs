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
    public partial class nuevoMedicamento : Form
    {
        private Point mouseDownLocation;
        public nuevoMedicamento()
        {
            InitializeComponent();
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
            bool txtNombre = !string.IsNullOrEmpty(txtNombreMedicamento.Text);            
            bool txtPrecioUniMedicamento = !string.IsNullOrEmpty(txtPrecioUnitMedicamento.Text);
            bool txtCantidadMedicamento = !string.IsNullOrEmpty(txtStockMedicamento.Text);
            if(txtNombre && txtPrecioUniMedicamento && txtCantidadMedicamento)
            {
                // create messagebox that save event yes and no
                DialogResult result = MessageBox.Show("¡Se agrego el medicamento exitosamente!\n¿Desea agregar un nuevo medicamento?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    txtNombreMedicamento.Text = "";
                    txtPrecioUnitMedicamento.Text = "";
                    txtStockMedicamento.Text = "";
                    pnlNombreMedicamento.Focus();
                    txtNombreMedicamento.Focus();
                    
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }              
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void validacionCamposObligatorios(object sender, CancelEventArgs e)
        {
            TextBox txtSender = (TextBox)sender;
            if(string.IsNullOrEmpty(txtSender.Text))
            {
                
                errorProvider.SetError(txtSender, "Campo obligatorio");
            }
            else
            {
                
                errorProvider.SetError(txtSender, null);
            }
           
        }
    }
}
