using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Controles;
using Sistema.Controles.Logica;



namespace Sistema.Vista
{
    
    public partial class PrincipalForm : Form
    {
        // Instancias de las clases de Control
        Shortcuts shortcuts = new Shortcuts();
        EstanteLogica shelfLogic = new EstanteLogica();
        CategoriaLogica categoryLogic = new CategoriaLogica();
        MedicamentoLogica medicineLogic = new MedicamentoLogica();
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {        
            lblNumEstantes.Text = shelfLogic.GetTotalShelvesCount().ToString();
            lblNumCategorias.Text = categoryLogic.GetTotalCategoriesCount().ToString();
            lblNumMedicamentos.Text = medicineLogic.GetTotalMedicinesCount().ToString();
                     
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            shortcuts.LimpiarTextoHastaelEspacio(txtBuscar, e);
        }

       
    }
}
