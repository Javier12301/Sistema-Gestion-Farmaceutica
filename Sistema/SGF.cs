using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema;
using Sistema.Controles;

namespace Sistema
{
    public partial class SGF : Form
    {
        public SGF()
        {
            InitializeComponent();
            
        }

        //Global
        Controladora controladora = new Controladora();
        Shortcuts shortcuts = new Shortcuts();
        //Variable booleana para controlar el estado del ojo, por defecto lo mejor es false
        bool showPassword = false;
        //Colores utilizado
        Color btnForgotPasswordHover = ColorTranslator.FromHtml("#4BAAF9");
        Color btnForgotPasswordLeave = ColorTranslator.FromHtml("#0078D7");

        private void SGF_Load(object sender, EventArgs e)
        {
            //Se inicializa el ojo de contraseña
            if (showPassword)
            {
                ojoMostrarContraseña.IconFont = FontAwesome.Sharp.IconFont.Solid;
                controladora.mostrarPassword(txtPassword);
                showPassword = false;
            }
            else
            {
                ojoMostrarContraseña.IconFont = FontAwesome.Sharp.IconFont.Regular;
                controladora.ocultarPassword(txtPassword);
                showPassword = true;
            }
            
        }

        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                controladora.linkLabel();
            }
            catch
            {
                MessageBox.Show("Se ha producido un error al intentar abrir el enlace.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Controles del icono de OJO para mostrar contraseñas
        private void ojoMostrarContraseña_MouseHover(object sender, EventArgs e)
        {
            ojoMostrarContraseña.IconFont = FontAwesome.Sharp.IconFont.Solid;
        }

        private void ojoMostrarContraseña_MouseLeave(object sender, EventArgs e)
        {
            ojoMostrarContraseña.IconFont = FontAwesome.Sharp.IconFont.Regular;
        }

        private void ojoMostrarContraseña_Click(object sender, EventArgs e)
        {
            if (showPassword)
            {
                showPassword=false;
                controladora.mostrarPassword(txtPassword);
                ojoMostrarContraseña.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
            else
            {
                showPassword = true;
                controladora.ocultarPassword(txtPassword);
                ojoMostrarContraseña.IconFont = FontAwesome.Sharp.IconFont.Regular;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool verificar = controladora.verificarCredenciales(txtUser, txtPassword);
            if (verificar)
            {
                formHijosPrincipalFORM formHijosPrincipalFORM = new formHijosPrincipalFORM();
                this.Hide();
                if (formHijosPrincipalFORM.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Ingresar al sistema presionando enter
        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                bool verificar = controladora.verificarCredenciales(txtUser, txtPassword);
                if (verificar)
                {
                    formHijosPrincipalFORM formHijosPrincipalFORM = new formHijosPrincipalFORM();
                    this.Hide();
                    if (formHijosPrincipalFORM.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void btnForgotPassword_MouseHover(object sender, EventArgs e)
        {
            btnForgotPassword.ForeColor = btnForgotPasswordHover;
        }

        private void btnForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            btnForgotPassword.ForeColor = btnForgotPasswordLeave;
        }

        
    }
}
