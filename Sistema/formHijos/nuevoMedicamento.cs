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
    public partial class nuevoMedicamento : Form
    {
        private Point mouseDownLocation;
        Shortcuts shortcuts = new Shortcuts();
        Controladora controladora = new Controladora();
        public nuevoMedicamento()
        {
            InitializeComponent();
        }

        private void nuevoMedicamento_Load(object sender, EventArgs e)
        {
            //ComboBox predeterminados
            cmbCatMedicamento.SelectedIndex = 0;
            cmbEstanteMedicamento.SelectedIndex = 0;
            //
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
            bool txtBoolNombre = controladora.verificarTextboxT(txtNombreMedicamento, errorProvider);
            bool txtBoolStock = controladora.verificarTextboxT(txtStockMedicamento, errorProvider);
            bool txtBoolPrecioUnit = controladora.verificarTextboxT(txtPrecioUnitMedicamento, errorProvider);

            if (txtBoolNombre && txtBoolPrecioUnit && txtBoolStock)
            {
                DialogResult result = MessageBox.Show("¡Se agrego el medicamento exitosamente!\n¿Desea agregar un nuevo medicamento?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    txtNombreMedicamento.Text = "";
                    cmbCatMedicamento.SelectedIndex = 0;
                    cmbEstanteMedicamento.SelectedIndex = 0;
                    txtStockMedicamento.Text = "";
                    txtPrecioUnitMedicamento.Text = "";
                    pnlNombreMedicamento.Focus();
                    txtNombreMedicamento.Focus();
                }else if(result == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("¡Por favor, rellene los campos obligatorios!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //Shortcut Limpiador
        private void limpiarHastaElEspacio(object sender, KeyEventArgs e)
        {
            TextBox txtSender = (TextBox)sender;        
            shortcuts.LimpiarTextoHastaelEspacio(txtSender, e);
        }
        // Control de entrada de datos con números
        private void txtNumericos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si el carácter no es un número
            }
        }
    }
}
