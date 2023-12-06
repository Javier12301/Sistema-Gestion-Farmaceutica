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

namespace Sistema.Vista
{
    public partial class NuevoClienteForm : Form
    {
        private Point mouseDownLocation;
        Controladora controladora = Controladora.ObtenerInstancia;
        public NuevoClienteForm()
        {
            InitializeComponent();
        }

        private void nuevoCliente_Load(object sender, EventArgs e)
        {
            //ComboBox Predeterminados
            cmbGeneroCliente.SelectedIndex = 0;
            cmbTipoCliente.SelectedIndex = 0;
            //
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
            if (string.IsNullOrWhiteSpace(txtSender.Text))
            {
                errorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

                errorProvider.SetError(txtSender, "Campo obligatorio");
            }
            else
            {
                errorProvider.SetError(txtSender, null);
            }

        }

        // Control de entrada de datos con números
        private void txtNumericos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si el carácter no es un número
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //  Comprobar caracteres vacios
            bool txtBoolNombre = controladora.VerificarTextBoxT(txtNombreCliente, errorProvider);
            bool txtBoolApellido = controladora.VerificarTextBoxT(txtApellidoCliente, errorProvider);
            bool txtBoolDNI = controladora.VerificarTextBoxT(txtDNICliente, errorProvider);
            
            //opcional
            bool txtBoolMail = true;
            //En caso de que el farmaceutico desee agregar el correo electronico del cliente, se deberá verificar que sea un correo valido
            if (!string.IsNullOrWhiteSpace(txtMailCliente.Text))
            {
                txtBoolMail = controladora.VerificarCorreoT(txtMailCliente, errorProvider);
                
            }
            // // // // // // // //
            if (txtBoolNombre && txtBoolApellido && txtBoolDNI && txtBoolMail)
            {

                DialogResult result = MessageBox.Show("¡Se agrego el cliente exitosamente!\n¿Desea agregar un nuevo cliente?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    txtNombreCliente.Text = "";
                    txtApellidoCliente.Text = "";
                    txtDNICliente.Text = "";
                    txtDireccionCliente.Text = "";
                    txtTelefonoCliente.Text = "";
                    cmbGeneroCliente.SelectedIndex = 0;
                    cmbTipoCliente.SelectedIndex = 0;
                    pnlNombreClientes.Focus();
                    txtNombreCliente.Focus();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("¡Por favor, rellene los campos obligatorios!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
