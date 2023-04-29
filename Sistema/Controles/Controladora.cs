using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sistema
{
    internal class Controladora
    {
        public void linkLabel()
        {
            System.Diagnostics.Process.Start("mailto:javierramirez1230123@gmail.com");
        }

        //Se contralará toda las funciones del ojo de contraseña
        public void showPassword(TextBox txtPassword)
        {
            txtPassword.PasswordChar = (char)0;
        }

        public void hidePassword(TextBox txtPassword)
        {
            txtPassword.PasswordChar = '*';
        }

        public bool verificarCredenciales(TextBox txtUser, TextBox txtPassword, Color colorError, PictureBox pctLineUser, PictureBox pctLinePassword)
        {
            bool correoValido = verificarCorreo(txtUser, colorError, pctLineUser);
            bool passwordValido = verificarPassword(txtPassword, colorError, pctLinePassword);
            //Verificar credenciales
            if (correoValido && passwordValido)
            {
                return true;
            }
            {

                return false;
            }

        }

        private bool verificarCorreo(TextBox txtUser, Color colorError, PictureBox pctLineUser)
        {
            bool correoValido = false;
            if (txtUser.Text.Contains("@") && txtUser.Text.Contains("."))
            {
                correoValido = true;
            }
            else
            {
                pctLineUser.BackColor = colorError;
            }
            return correoValido;
        }

        private bool verificarPassword(TextBox txtPassword, Color colorError, PictureBox pctLinePassword)
        {
            bool passwordValido = false;
            //Las contraseñas de cada empelado tendrán como obligación tener más de 8 caracteres.
            if (txtPassword.Text.Length >= 8)
            {
                passwordValido = true;
            }
            else
            {
                passwordValido = false;
                pctLinePassword.BackColor = colorError;
            }
            return passwordValido;
        }

        
    }
}
