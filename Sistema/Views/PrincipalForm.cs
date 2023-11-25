using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Controles;
using Sistema.Controles.Interfaz;
using Sistema.Controles.Logica;



namespace Sistema.Vista
{
    
    public partial class PrincipalForm : Form
    {
        // Instancias de las clases de Control
        Shortcuts shortcuts = new Shortcuts();
        EstanteLogica shelfLogic = new EstanteLogica();
        CategoriaLogica categoryLogic = new CategoriaLogica();
        ProductoLogica productLogic = new ProductoLogica();
        MedicamentoLogica medicineLogic = new MedicamentoLogica();

        MessageBoxManager messageManager = MessageBoxManager.GetInstance;
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener cantidad total de estantes, categorias y medicamentos excepto los que tienen ID 0
                lblNumEstantes.Text = shelfLogic.GetTotalShelvesCount().ToString();
                lblNumCategorias.Text = categoryLogic.GetTotalCategoriesCount().ToString();
                lblNumMedicamentos.Text = medicineLogic.GetTotalMedicinesCount().ToString();
                lblNumeroProductos.Text = productLogic.GetTotalProductCount().ToString();
            }
            catch (DbUpdateException)
            {
                messageManager.ShowDatabaseUpdateError();
            }
            catch (SqlException)
            {
                messageManager.ShowSqlError();
            }
            catch (Exception)
            {
                messageManager.ShowUnexpectedError();
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            shortcuts.LimpiarTextoHastaelEspacio(txtBuscar, e);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
