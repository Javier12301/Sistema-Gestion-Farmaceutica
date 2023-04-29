﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema;



namespace Sistema
{
    public partial class SGF : Form
    {
        public SGF()
        {
            InitializeComponent();
            
        }

        //Global
        Controladora controladora = new Sistema.Controladora();
        //Variable booleana para controlar el estado del ojo, por defecto lo mejor es false
        bool showPassword = false;
        //Variable de colores en hexadecimal
         //Colores de lineas de textos
        Color colorDisabled = ColorTranslator.FromHtml("#CCCCCC");
        Color colorActive = ColorTranslator.FromHtml("#5AA8E1");
        Color colorError = ColorTranslator.FromHtml("#FF4136");
        //Colores utilizado
        Color btnForgotPasswordHover = ColorTranslator.FromHtml("#4BAAF9");
        Color btnForgotPasswordLeave = ColorTranslator.FromHtml("#0078D7");

        private void SGF_Load(object sender, EventArgs e)
        {
            //Se inicializa el ojo de contraseña
            if (showPassword)
            {          
                lblEyePassword.Font = new Font("Font Awesome 6 Free Solid", Font.Height, FontStyle.Bold);
                controladora.showPassword(txtPassword);
                showPassword = false;
            }
            else
            {
                lblEyePassword.Font = new Font("Font Awesome 6 Free Regular", 15.75F, FontStyle.Regular);
                controladora.hidePassword(txtPassword);
                showPassword = true;
            }
            //Se inicializan las propiedades de algunos componentes
            pctLineUser.BackColor = colorDisabled;
            pctLinePassword.BackColor = colorDisabled;

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

        private void lblEyePassword_MouseHover(object sender, EventArgs e)
        {
            lblEyePassword.Font = new Font("Font Awesome 6 Free Solid", Font.Height, FontStyle.Bold);
        }

        private void lblEyePassword_MouseLeave(object sender, EventArgs e)
        {
            lblEyePassword.Font = new Font("Font Awesome 6 Free Regular", 15.75F, FontStyle.Regular);
        }

        private void lblEyePassword_Click(object sender, EventArgs e)
        {
            if (showPassword)
            {
                showPassword = false;
                controladora.showPassword(txtPassword);
                lblEyePassword.Font = new Font("Font Awesome 6 Free Solid", Font.Height, FontStyle.Bold);
            }
            else
            {
                showPassword = true;
                controladora.hidePassword(txtPassword);
                lblEyePassword.Font = new Font("Font Awesome 6 Free Regular", 15.75F, FontStyle.Regular);
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            pctLineUser.BackColor = colorActive;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            pctLineUser.BackColor = colorDisabled;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            pctLinePassword.BackColor = colorActive;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            pctLinePassword.BackColor = colorDisabled;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool verificar = controladora.verificarCredenciales(txtUser, txtPassword, colorError, pctLineUser, pctLinePassword);
            if (verificar)
            {
                MessageBox.Show("Credenciales correctas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                bool verificar = controladora.verificarCredenciales(txtUser, txtPassword, colorError, pctLineUser, pctLinePassword);
                if (verificar)
                {
                    MessageBox.Show("Credenciales correctas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void txtUser_KeyDown_1(object sender, KeyEventArgs e)
        {

            TextBox txtSelected = sender as TextBox;
            //Shortcut para eliminar palabras con ctrl + backspace
            if ((e.KeyCode == Keys.Back) && e.Control)
            {
                e.SuppressKeyPress = true;
                int selStart = txtSelected.SelectionStart;
                while (selStart > 0 && txtSelected.Text.Substring(selStart - 1, 1) == " ")
                {
                    selStart--;
                }
                int prevSpacePos = -1;
                if (selStart != 0)
                {
                    prevSpacePos = txtSelected.Text.LastIndexOfAny(new char[] { ' ', '@', '.' }, selStart - 1);
                }
                txtSelected.Select(prevSpacePos + 1, txtSelected.SelectionStart - prevSpacePos - 1);
                txtSelected.SelectedText = "";
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
