using Guna.UI.WinForms;
using Sistema.Controles;
using Sistema.Controles.Interfaz;
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
        // Singleton Controladora
        private static Controladora instance = null;
        private Controladora()
        {
        }
        public static Controladora GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controladora();
                }
                return instance;
            }
        }
        // // // Singleton // // //
        PaletaColores colorPalette = new PaletaColores();

        public void OpenMailLink()
        {
            System.Diagnostics.Process.Start("mailto:javierramirez1230123@gmail.com");
        }

        // Solo número e ignora espacios y permite borrado en textbox
        public void OnlyNumbers(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Se contralará toda las funciones del ojo de contraseña
        public void ShowPassword(GunaLineTextBox txtPassword)
        {
            txtPassword.PasswordChar = (char)0;
        }

        public void HidePassword(GunaLineTextBox txtPassword)
        {
            txtPassword.PasswordChar = '*';
        }

        public bool VerifyCredentials(GunaLineTextBox txtUser, GunaLineTextBox txtPassword)
        {
            //Será utilizado para registrar nuevos usuarios, con esto podremos especificar los caracteres que se podrán utilizar
            bool isEmailValid = VerifyEmailG(txtUser);
            bool isPasswordValid = VerifyPassword(txtPassword);
            //Verificar credenciales
            if (isEmailValid && isPasswordValid)
            {
                if (txtUser.Text == "Admin12301@gmail.com" && txtPassword.Text == "Admin12301")
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
        public bool VerifyEmailG(GunaLineTextBox txtUser)
        {
            bool isEmailValid = false;
            if (txtUser.Text.Contains("@") && txtUser.Text.Contains("."))
            {
                isEmailValid = true;
            }
            else
            {
                txtUser.LineColor = colorPalette.ColorError;
            }
            return isEmailValid;
        }
        // Función en caso de utilizar un TextBox normal
        public bool VerifyEmailT(TextBoxBase txtUser, ErrorProvider errorActivator)
        {
            bool isEmailValid = false;
            if (txtUser.Text.Contains("@") && txtUser.Text.Contains("."))
            {
                errorActivator.SetError(txtUser, "");
                isEmailValid = true;
            }
            else
            {
                errorActivator.SetError(txtUser, "Correo invalido, por favor no se olvide de los @,.,com,org,etc.");
            }
            return isEmailValid;
        }

        private bool VerifyPassword(GunaLineTextBox txtPassword)
        {
            bool isPasswordValid = false;
            //Las contraseñas de cada empelado tendrán como obligación tener más de 8 caracteres.
            if (txtPassword.Text.Length >= 8)
            {
                isPasswordValid = true;
            }
            else
            {
                txtPassword.LineColor = colorPalette.ColorError;
            }
            return isPasswordValid;
        }

        //comprobara cualquier campo de texto vacio
        public bool VerifyTextBoxG(GunaLineTextBox txtbox)
        {
            if (!string.IsNullOrWhiteSpace(txtbox.Text))
            {

                //No está vacio
                txtbox.LineColor = colorPalette.ColorActive;
                return true;
            }
            else
            {
                //Está vacio
                txtbox.LineColor = colorPalette.ColorError;
                return false;
            }
        }
        //Comprobara cualquier campo de texto vacio TextBox normales no guna
        public bool VerifyTextBoxT(TextBoxBase txtbox, ErrorProvider errorActivator)
        {
            errorActivator.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            if (!string.IsNullOrWhiteSpace(txtbox.Text))
            {
                //No está vacio

                errorActivator.SetError(txtbox, "");
                return true;
            }
            else
            {
                //Está vacio
                errorActivator.SetError(txtbox, "Campo obligatorio");
                return false;
            }
        }

        // controladora de DataGridView
        public void CheckEmptyDataGridView(DataGridView _dtagridview, string IDColumn)
        {
            if (_dtagridview.Rows.Count <= 1)
            {
                if (_dtagridview.Rows.Count == 0 || string.IsNullOrEmpty(_dtagridview.Rows[0].Cells[IDColumn].Value?.ToString()))
                {
                    _dtagridview.Enabled = false;
                }
                else
                {
                    _dtagridview.Enabled = true;
                }
            }
            else
            {
                _dtagridview.Enabled = true;
            }
        }

        // Controladora para limpiar los campos de texto GunaLine
        public void ClearTextBoxG(params GunaLineTextBox[] textBoxes)
        {
            foreach (GunaLineTextBox txtbox in textBoxes)
            {
                txtbox.Text = "";
            }

        }

        // Controladora para limpiar los campos de texto TextBox normales
        public void ClearTextBoxT(params TextBoxBase[] textBoxes)
        {
            foreach (TextBoxBase txtbox in textBoxes)
            {
                txtbox.Text = "";
            }
        }

        // Manejo de observador para comprobar si el usuario modifico datagridview
        private bool isDatagridViewModified = false;
        private List<IObserverDataGridView> observers = new List<IObserverDataGridView>();

        public bool IsDatagridViewModified
        {
            get { return isDatagridViewModified; }
            set
            {
                if (value != isDatagridViewModified)
                {
                    isDatagridViewModified = value;
                    NotifyObservers();
                }
            }
        }

        public void Attach(IObserverDataGridView observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserverDataGridView observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(isDatagridViewModified);
            }
        }

        // // // // // // // // // // // //

    }
}
