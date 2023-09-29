﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema;
using Sistema.Controles;
using Sistema.Controles.Logica;
using Sistema.Database;
using Sistema.Models;

namespace Sistema
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        //Global
        Controladora controladora = new Controladora();
        Shortcuts shortcuts = new Shortcuts();
        //Variable booleana para controlar el estado del ojo, por defecto lo mejor es false
        private bool passwordVisible { get; set; } = false;
        //Colores utilizado
        private Color btnForgotPasswordHover { get; } = ColorTranslator.FromHtml("#4BAAF9");
        private Color btnForgotPasswordLeave { get; } = ColorTranslator.FromHtml("#0078D7");

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Se inicializa el ojo de contraseña
            if (passwordVisible)
            {
                btnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
                controladora.ShowPassword(txtPassword);
                passwordVisible = false;
            }
            else
            {
                btnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Regular;
                controladora.HidePassword(txtPassword);
                passwordVisible = true;
            }
            
        }

        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                controladora.OpenMailLink();
            }
            catch
            {
                MessageBox.Show("Se ha producido un error al intentar abrir el enlace.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Controles del icono de OJO para mostrar contraseñas
        private void btnShowPassword_MouseHover(object sender, EventArgs e)
        {
            btnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
        }

        private void btnShowPassword_MouseLeave(object sender, EventArgs e)
        {
            btnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Regular;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                passwordVisible=false;
                controladora.ShowPassword(txtPassword);
                btnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
            else
            {
                passwordVisible = true;
                controladora.HidePassword(txtPassword);
                btnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Regular;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool verificar = controladora.VerifyCredentials(txtUser, txtPassword);
            if (verificar)
            {
                PrincipalForm PrincipalForm = new PrincipalForm();
                this.Hide();
                if (PrincipalForm.ShowDialog() == DialogResult.Cancel)
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
                bool verificar = controladora.VerifyCredentials(txtUser, txtPassword);
                if (verificar)
                {
                    
                    PrincipalForm PrincipalForm = new PrincipalForm();
                    this.Hide();
                    if (PrincipalForm.ShowDialog() == DialogResult.Cancel)
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