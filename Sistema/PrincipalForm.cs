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
        private Form formularioActivo;
        private GunaButton botonActual;
        Shortcuts shortcuts = new Shortcuts();
        // Obtener Controladora Que tiene Singleton
        Controladora controladora = Controladora.ObtenerInstancia;
        ObservadorDataGridView dgvObserver = new ObservadorDataGridView();
        private bool expandirBarraLateral { get; set; } = true;
        private Image originalBotonImagen { get; set; }

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            //Al iniciar el sistema, se abrirá el formulario principal.
            abrirFormularioHijo(new Vista.PrincipalForm(), btnPrincipal);
            activarBoton(btnPrincipal);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Controlar colores de los botones de la barra de navegación
        private void activarBoton(GunaButton btnSender)
        {
            if (btnSender != null)
            {
                if (botonActual != (GunaButton)btnSender)
                {
                    // Desactiva el botón previamente activado
                    if (botonActual != null)
                    {
                        desactivarBoton(botonActual);
                    }

                    botonActual = (GunaButton)btnSender;
                    botonActual.BaseColor = Color.FromArgb(38, 125, 166);
                    botonActual.ForeColor = Color.White;
                    // Almacena la imagen original del botón
                    originalBotonImagen = botonActual.Image;
                    // Almacena la imagen de Hover del botón, que es blanca por defecto
                    botonActual.Image = botonActual.OnHoverImage;
                    // Cambia la fuente del botón activo
                    botonActual.Font = new System.Drawing.Font("Segoe UI", 10F);
                }
            }
        }

        private void desactivarBoton(GunaButton boton)
        {
            boton.BaseColor = Color.FromArgb(252, 252, 252);
            boton.ForeColor = Color.Black;
            boton.Image = originalBotonImagen;
            boton.Font = new System.Drawing.Font("Segoe UI", 10F);
        }


        /*private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //Activar Shortcuts de limpiar texto hasta el espacio
            shortcuts.ClearTextUntilSpace(txtSearch, e);
        }*/


        //Abrir formularios en el panel Main utilizando el formulario principal
        private void abrirFormularioHijo(Form formularioHijo, GunaButton btnSender)
        {
            // Si el DataGridView ha sido modificado, preguntar al usuario si desea guardar los cambios
            if (controladora.IsDatagridViewModified)
            {
                DialogResult resultado = MessageBox.Show("Has realizado algunos cambios que no se han guardado.\n¿Estás seguro de que deseas salir?", "Cambios no guardados", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.No)
                {
                    // Si el usuario elige "No", no cierra el formulario activo ni abre uno nuevo.
                    return;
                }
            }

            // Si el DataGridView no ha sido modificado o si el usuario eligió "Sí" en el cuadro de diálogo, proceder a cerrar el formulario activo y abrir uno nuevo
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            // Resaltar botón 
            activarBoton(btnSender);

            // Configuración de los botones de la barra de navegación
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill; // Rellenar el panel Main
            this.pnlMenu.Controls.Add(formularioHijo); // Agregar formulario al panel Main
            this.pnlMenu.Tag = formularioHijo;
            formularioHijo.BringToFront(); // Traer formulario al frente

            // Se ha abierto un nuevo formulario
            controladora.IsDatagridViewModified = false;
            formularioHijo.Show(); // Mostrar formulario    
        }



        //Botones de la barra de navegacion
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Vista.PrincipalForm(), btnPrincipal);
        }

        private void btnEstantes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new EstantesForm(), btnEstantes);

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new CategoriaForm(), btnCategorias);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ProveedoresForm(), btnProveedores);
        }

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new MedicamentosForm(), btnMedicamentos);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ClientesForm(), btnClientes);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ComprasForm(), btnCompras);
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
            
            if (expandirBarraLateral)
            {
                // Si se toca el botón de menu se minimiza el sidebar
                pnlBarraLateral.Width -= 10;
                pnlMenu.Width += 10;
                if (pnlBarraLateral.Width == pnlBarraLateral.MinimumSize.Width)
                {
                    expandirBarraLateral = false;
                    timerBararLateral.Stop();
                }
            }
            else
            {
                pnlBarraLateral.Width += 10;
                pnlMenu.Width -= 10;
                if (pnlBarraLateral.Width == pnlBarraLateral.MaximumSize.Width)
                {
                    expandirBarraLateral = true;
                    timerBararLateral.Stop();
                }
            }
        }

        private void btnResizingMenu_Click(object sender, EventArgs e)
        {
            timerBararLateral.Start();
            if(pnlDescInventario.Visible && pnlDescControl.Visible)
            {
                pnlDescInventario.Visible = false;
                pnlDescRegistro.Visible = false;
                pnlDescControl.Visible = false;

            }
            else
            {
                pnlDescInventario.Visible = true;
                pnlDescRegistro.Visible = true;
                pnlDescControl.Visible = true;
            }
            
        }

        private void PrincipalForm_SizeChanged(object sender, EventArgs e)
        {
            lblSize.Text = this.Size.ToString();
        }

       
    }
}
