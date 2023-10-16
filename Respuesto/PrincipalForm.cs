﻿using Sistema.Controles;
using Sistema.Controles.Interfaz;
using Sistema.Vista;
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
        private Button currentButton;
        Shortcuts shortcuts = new Shortcuts();
        // Obtener Controladora Que tiene Singleton
        Controladora controladora = Controladora.GetInstance;
        ObservadorDataGridView dgvObserver = new ObservadorDataGridView();

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
        private void activateButton(Button btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    disableButton();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(234, 234, 234);
                    currentButton.ForeColor = Color.Black;
                    //Fuente diseñada para el botón activo
                    currentButton.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        // Controlar colores de los botones de la barra de navegación //Código de stackOVERFLOW
        private void disableButton()
        {

            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(252, 252, 252);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        /*private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //Activar Shortcuts de limpiar texto hasta el espacio
            shortcuts.ClearTextUntilSpace(txtSearch, e);
        }*/


        //Abrir formularios en el panel Main utilizando el formulario principal
        private void OpenchildForm(Form childForm, Button btnSender)
        {
            // Si el DataGridView ha sido modificado, preguntar al usuario si desea guardar los cambios
            if (controladora.IsDatagridViewModified)
            {
                DialogResult result = MessageBox.Show("Has realizado cambios que no se han guardado \n         ¿Estás seguro de que deseas salir?", "Cambios no guardados", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            this.panelMain.Controls.Add(childForm); // Agregar formulario al panel Main
            this.panelMain.Tag = childForm;
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
            OpenchildForm(new Vista.EstantesForm(), btnEstantes);

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Vista.CategoriaForm(), btnCategoria);
        }

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Vista.MedicamentosForm(), btnMedicamentos);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Vista.ClientesForm(), btnClientes);
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
    }
}
