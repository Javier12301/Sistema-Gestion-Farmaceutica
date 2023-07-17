using Guna.UI.WinForms;
using Sistema.Controles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sistema
{
    public class Controladora
    {
        PaletaColores paleta = new PaletaColores();

        public void linkLabel()
        {
            System.Diagnostics.Process.Start("mailto:javierramirez1230123@gmail.com");
        }

        //Se contralará toda las funciones del ojo de contraseña
        public void mostrarPassword(GunaLineTextBox txtPassword)
        {
            txtPassword.PasswordChar = (char)0;
        }

        public void ocultarPassword(GunaLineTextBox txtPassword)
        {
            txtPassword.PasswordChar = '*';
        }

        public bool verificarCredenciales(GunaLineTextBox txtUser, GunaLineTextBox txtPassword)
        {
            //Será utilizado para registrar nuevos usuarios, con esto podremos especificar los caracteres que se podrán utilizar
            bool correoValido = verificarCorreoG(txtUser);
            bool passwordValido = verificarPassword(txtPassword);
            //Verificar credenciales
            if (correoValido && passwordValido)
            {
                if(txtUser.Text == "Admin12301@gmail.com" && txtPassword.Text == "Admin12301")
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            {

                return false;
            }

        }

        // Función en caso de utilizar un TextBox Guna
        public bool verificarCorreoG(GunaLineTextBox txtUser)
        {
            bool correoValido = false;
            if (txtUser.Text.Contains("@") && txtUser.Text.Contains("."))
            {
                correoValido = true;
            }
            else
            {
                txtUser.LineColor = paleta.ColorError;
            }
            return correoValido;
        }
        // Función en caso de utilizar un TextBox normal
        public bool verificarCorreoT(TextBoxBase txtUser, ErrorProvider errorActivador)
        {
            bool correoValido = false;
            if (txtUser.Text.Contains("@") && txtUser.Text.Contains("."))
            {
                errorActivador.SetError(txtUser, "");
                correoValido = true;
            }
            else
            {
                errorActivador.SetError(txtUser, "Correo invalido, por favor no se olvide de los @,.,com,org,etc.");
            }
            return correoValido;
        }

        private bool verificarPassword(GunaLineTextBox txtPassword)
        {
            bool passwordValido = false;
            //Las contraseñas de cada empelado tendrán como obligación tener más de 8 caracteres.
            if (txtPassword.Text.Length >= 8)
            {
                passwordValido = true;
            }
            else
            {
                txtPassword.LineColor = paleta.ColorError;
            }
            return passwordValido;
        }

        //comprobara cualquier campo de texto vacio
        public bool verificarTextboxG(GunaLineTextBox txtbox)
        {
            if (!string.IsNullOrWhiteSpace(txtbox.Text))
            {
                
                //No está vacio
                txtbox.LineColor = paleta.ColorActive;
                return true;
            }
            else
            {
                //Está vacio
                txtbox.LineColor = paleta.ColorError;
                return false;
            }
        }
        //Comprobara cualquier campo de texto vacio TextBox normales no guna
        public bool verificarTextboxT(TextBoxBase txtbox, ErrorProvider errorActivador)
        {
            errorActivador.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            if (!string.IsNullOrWhiteSpace(txtbox.Text))
            {
                //No está vacio
                
                errorActivador.SetError(txtbox, "");
                return true;
            }
            else
            {
                //Está vacio
                errorActivador.SetError(txtbox, "Campo obligatorio");
                return false;
            }
        }
         
        
    }
}
