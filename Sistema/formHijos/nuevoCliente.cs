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
    public partial class nuevoCliente : Form
    {
        private Point mouseDownLocation;
        public nuevoCliente()
        {
            InitializeComponent();
        }

        private void nuevoCliente_Load(object sender, EventArgs e)
        {
           
        }
        

        // Mover formulario con el mouse al hacer click en el panel de control
        private void pnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
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
        //

        private void validacionCamposObligatorios(object sender, CancelEventArgs e)
        {
            TextBox txtSender = (TextBox)sender;
            if (string.IsNullOrEmpty(txtSender.Text))
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
