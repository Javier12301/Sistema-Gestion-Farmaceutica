using Guna.UI.WinForms;
using Sistema.Controles;
using Sistema.Controles.Interfaz;
using Sistema.Vista;
using Sistema.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sistema
{
    public partial class PrincipalForm : Form
    {
        //Fields
        private Form activeForm;
        private GunaButton currentButton;
        Shortcuts shortcuts = new Shortcuts();
        // Obtener Controladora Que tiene Singleton
        Controladora controladora = Controladora.GetInstance;
        ObservadorDataGridView dgvObserver = new ObservadorDataGridView();
        private bool sidebarExpand { get; set; } = true;
        private Image originalButtonImage { get; set; }

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            //Al iniciar el sistema, se abrirá el formulario principal.
            OpenchildForm(new Vista.PrincipalForm(), btnPrincipal);
            activateButton(btnPrincipal);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Controlar colores de los botones de la barra de navegación
        private void activateButton(GunaButton btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (GunaButton)btnSender)
                {
                    // Desactiva el botón previamente activado
                    if (currentButton != null)
                    {
                        disableButton(currentButton);
                    }

                    currentButton = (GunaButton)btnSender;
                    currentButton.BaseColor = Color.FromArgb(38, 125, 166);
                    currentButton.ForeColor = Color.White;
                    // Almacena la imagen original del botón
                    originalButtonImage = currentButton.Image;
                    // Almacena la imagen de Hover del botón, que es blanca por defecto
                    currentButton.Image = currentButton.OnHoverImage;
                    // Cambia la fuente del botón activo
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 10F);
                }
            }
        }

        private void disableButton(GunaButton button)
        {
            button.BaseColor = Color.FromArgb(252, 252, 252);
            button.ForeColor = Color.Black;
            button.Image = originalButtonImage;
            button.Font = new System.Drawing.Font("Segoe UI", 10F);
        }


        /*private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //Activar Shortcuts de limpiar texto hasta el espacio
            shortcuts.ClearTextUntilSpace(txtSearch, e);
        }*/


        //Abrir formularios en el panel Main utilizando el formulario principal
        private void OpenchildForm(Form childForm, GunaButton btnSender)
        {
            // Si el DataGridView ha sido modificado, preguntar al usuario si desea guardar los cambios
            if (controladora.IsDatagridViewModified)
            {
                DialogResult result = MessageBox.Show("Has realizado algunos cambios que no se han guardado.\n¿Estás seguro de que deseas salir?", "Cambios no guardados", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    // Si el usuario elige "No", no cierra el formulario activo ni abre uno nuevo.
                    return;
                }
            }

            // Si el DataGridView no ha sido modificado o si el usuario eligió "Sí" en el cuadro de diálogo, proceder a cerrar el formulario activo y abrir uno nuevo
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Resaltar botón 
            activateButton(btnSender);

            // Configuración de los botones de la barra de navegación
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // Rellenar el panel Main
            this.pnlMenu.Controls.Add(childForm); // Agregar formulario al panel Main
            this.pnlMenu.Tag = childForm;
            childForm.BringToFront(); // Traer formulario al frente

            // Se ha abierto un nuevo formulario
            controladora.IsDatagridViewModified = false;
            childForm.Show(); // Mostrar formulario    
        }



        //Botones de la barra de navegacion
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Vista.PrincipalForm(), btnPrincipal);
        }

        private void btnEstantes_Click(object sender, EventArgs e)
        {
            OpenchildForm(new EstantesForm(), btnEstantes);

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            OpenchildForm(new CategoriaForm(), btnCategorias);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenchildForm(new ProveedoresForm(), btnProveedores);
        }

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            OpenchildForm(new MedicamentosForm(), btnMedicamentos);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenchildForm(new ClientesForm(), btnClientes);
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {

        }


        //Controles de cerrar sesión y salir del sistema.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //Al presionar X en este formulario, se cerrará el sistema.
        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        // Evento Timer para expandir y contraer el sidebar
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            
            if (sidebarExpand)
            {
                // Si se toca el botón de menu se minimiza el sidebar
                sidebarContainer.Width -= 10;
                pnlMenu.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                pnlMenu.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnResizingMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            if(pnlDescInventario.Visible && pnlDescControl.Visible)
            {
                pnlDescInventario.Visible = false;
                pnlDescControl.Visible = false;
            }
            else
            {
                pnlDescInventario.Visible = true;
                pnlDescControl.Visible = true;
            }
            
        }

        private void PrincipalForm_SizeChanged(object sender, EventArgs e)
        {
            lblSize.Text = this.Size.ToString();
        }

       
    }
}
