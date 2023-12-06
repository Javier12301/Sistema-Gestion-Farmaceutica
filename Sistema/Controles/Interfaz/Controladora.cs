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
        private static Controladora _instancia = null;
        private Controladora()
        {
        }
        public static Controladora ObtenerInstancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Controladora();
                }
                return _instancia;
            }
        }

        PaletaColores paleta = PaletaColores.ObtenerInstancia;

        public void AbrirEnlaceCorreo()
        {
            System.Diagnostics.Process.Start("mailto:javierramirez1230123@gmail.com");
        }

        // Solo números e ignora espacios y permite borrado en textbox
        public void SoloNumeros(KeyPressEventArgs e)
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

        // Se controlarán todas las funciones del ojo de contraseña
        public void MostrarContraseña(GunaLineTextBox txtContraseña)
        {
            txtContraseña.PasswordChar = (char)0;
        }

        public void OcultarContraseña(GunaLineTextBox txtContraseña)
        {
            txtContraseña.PasswordChar = '*';
        }

        public bool VerificarCredenciales(GunaLineTextBox txtUsuario, GunaLineTextBox txtContraseña)
        {
            // Se utilizará para registrar nuevos usuarios, con esto podremos especificar los caracteres que se podrán utilizar
            bool esCorreoValido = VerificarCorreoG(txtUsuario);
            bool esContraseñaValida = VerificarContraseña(txtContraseña);

            // Verificar credenciales
            if (esCorreoValido && esContraseñaValida)
            {
                if (txtUsuario.Text == "Admin12301@gmail.com" && txtContraseña.Text == "Admin12301")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        // Función en caso de utilizar un TextBox Guna
        public bool VerificarCorreoG(GunaLineTextBox txtUsuario)
        {
            bool esCorreoValido = txtUsuario.Text.Contains("@") && txtUsuario.Text.Contains(".");

            if (!esCorreoValido)
            {
                txtUsuario.LineColor = paleta.ColorError;
            }

            return esCorreoValido;
        }

        // Función en caso de utilizar un TextBox normal
        public bool VerificarCorreoT(TextBoxBase txtUsuario, ErrorProvider proveedorError)
        {
            bool esCorreoValido = txtUsuario.Text.Contains("@") && txtUsuario.Text.Contains(".");

            if (!esCorreoValido)
            {
                proveedorError.SetError(txtUsuario, "Correo inválido, por favor no olvides los @, ., com, org, etc.");
            }
            else
            {
                proveedorError.SetError(txtUsuario, "");
            }

            return esCorreoValido;
        }

        private bool VerificarContraseña(GunaLineTextBox txtContraseña)
        {
            bool esContraseñaValida = txtContraseña.Text.Length >= 8;

            if (!esContraseñaValida)
            {
                txtContraseña.LineColor = paleta.ColorError;
            }

            return esContraseñaValida;
        }

        // Comprobará cualquier campo de texto vacío
        public bool VerificarTextBoxG(GunaLineTextBox txtbox)
        {
            if (!string.IsNullOrWhiteSpace(txtbox.Text))
            {
                // No está vacío
                txtbox.LineColor = paleta.ColorActivo;
                return true;
            }
            else
            {
                // Está vacío
                txtbox.LineColor = paleta.ColorError;
                return false;
            }
        }

        // Comprobará cualquier campo de texto vacío TextBox normales no Guna
        public bool VerificarTextBoxT(TextBoxBase txtbox, ErrorProvider proveedorError)
        {
            proveedorError.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            if (!string.IsNullOrWhiteSpace(txtbox.Text))
            {
                // No está vacío
                proveedorError.SetError(txtbox, "");
                return true;
            }
            else
            {
                // Está vacío
                proveedorError.SetError(txtbox, "Campo obligatorio");
                return false;
            }
        }

        public bool VerificarComboBox(ComboBox combobox, ErrorProvider proveedorError, Label lbl)
        {
            if (combobox.SelectedIndex > 0)
            {
                // No está vacío
                proveedorError.SetError(lbl, "");
                return true;
            }
            else
            {
                // Está vacío
                proveedorError.SetError(lbl, "Campo obligatorio");
                return false;
            }
        }

        // Controladora de DataGridView
        public void VerificarDataGridViewVacio(DataGridView _dtagridview, string columnaID)
        {
            if (_dtagridview.Rows.Count <= 1)
            {
                if (_dtagridview.Rows.Count == 0 || string.IsNullOrEmpty(_dtagridview.Rows[0].Cells[columnaID].Value?.ToString()))
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
        public void LimpiarTextBoxG(params GunaLineTextBox[] textBoxes)
        {
            foreach (GunaLineTextBox txtbox in textBoxes)
            {
                txtbox.Text = "";
            }
        }

        // Controladora para limpiar los campos de texto TextBox normales
        public void LimpiarTextBoxT(params TextBoxBase[] textBoxes)
        {
            foreach (TextBoxBase txtbox in textBoxes)
            {
                txtbox.Text = "";
            }
        }

        public bool VerificarFormatoDecimalPrecio(TextBox textbox, ErrorProvider errorActivador)
        {
            // Intentamos convertir el texto a decimal
            if (!decimal.TryParse(textbox.Text, out decimal result))
            {
                // Si la conversión falla, establecemos el error
                errorActivador.SetError(textbox, "Formato de moneda incorrecto");
                textbox.Focus();
                return false;
            }
            else
            {
                if (textbox.Text == string.Empty)
                {
                    textbox.Text = "0";
                }
                errorActivador.SetError(textbox, "");
                return true;
            }
        }

        public void SoloNumeroYPuntoDecimal(TextBox textbox, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (textbox.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
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
