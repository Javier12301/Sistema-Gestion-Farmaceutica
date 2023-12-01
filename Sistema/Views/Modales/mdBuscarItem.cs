using Sistema.Controles.Interfaz;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Views.Modales
{
    public partial class mdBuscarItem : Form
    {
        private Point mouseDownLocation;
        public PRODUCTO product { get; set; }
        public MEDICAMENTO medicine { get; set; }
        private MessageBoxManager messageManager = MessageBoxManager.GetInstance;
        public int itemID { get; set; }
        // MANEJO DE PROPIEDADES //
        // Tipo de propiedad que será devuelta

        public mdBuscarItem()
        {
            InitializeComponent();
        }
        public enum ItemType { Medicamento, Producto }
        public ItemType SelectedItemType { get; set; }

        private void mdBuscarItem_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDBDataSet.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.farmaciaDBDataSet.PRODUCTO);
            // Seleccionar tab page por default la primera
            tbPage_Selected();
        }

        private void tbControl_Selected(object sender, TabControlEventArgs e)
        {
            tbPage_Selected();
        }

        private void tbPage_Selected()
        {
            switch (tbControl.SelectedIndex)
            {
                case 0:
                    if (cmbFiltroMedicamento.Items.Count == 0)
                    {
                        cmbFiltroMedicamento.Items.Add("Código");
                        cmbFiltroMedicamento.Items.Add("Lote");
                        cmbFiltroMedicamento.Items.Add("Nombre");
                        cmbFiltroMedicamento.Items.Add("Estante");
                        cmbFiltroMedicamento.Items.Add("Categoría");
                        cmbFiltroMedicamento.SelectedIndex = 0;

                        // Cargar tabla de medicamentos
                        this.vistaInventarioTableAdapter.Fill(farmaciaDBDataSet.VistaInventario);
                    }

                    break;
                case 1:
                    if (cmbFiltroProducto.Items.Count == 0)
                    {
                        cmbFiltroProducto.Items.Add("Código");
                        cmbFiltroProducto.Items.Add("Nombre");
                        cmbFiltroProducto.Items.Add("Estante");
                        cmbFiltroProducto.Items.Add("Categoría");
                        cmbFiltroProducto.SelectedIndex = 0;

                        // Cargar tabla de productos
                        this.pRODUCTOTableAdapter.Fill(farmaciaDBDataSet.PRODUCTO);
                    }
                    break;
            }
        }

        private void txtBuscarItem_TextChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            filterData();
        }

        private void filterData()
        {
            switch (tbControl.SelectedIndex)
            {
                case 0:
                    this.vistaInventarioTableAdapter.Filter(farmaciaDBDataSet.VistaInventario, cmbFiltroMedicamento.Text, txtBusquedaMedicamento.Text, null, null);
                    break;
                case 1:
                    this.pRODUCTOTableAdapter.Filter(farmaciaDBDataSet.PRODUCTO, cmbFiltroProducto.Text, txtBuscarProducto.Text);
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            switch (tbControl.SelectedIndex)
            {
                case 0:
                    txtBusquedaMedicamento.Text = string.Empty;
                    break;
                case 1:
                    txtBuscarProducto.Text = string.Empty;
                    break;
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // obtener rowIndex, pero verificar cual tab está seleccionado
                switch (tbControl.SelectedIndex)
                {
                    case 0:
                        selectItem(e.RowIndex);
                        break;
                    case 1:
                        selectItem(e.RowIndex);
                        break;
                }
            }
            catch (Exception)
            {
                messageManager.ShowUnexpectedError();
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                // obtener rowIndex, pero verificar cual tab está seleccionado
                switch (tbControl.SelectedIndex)
                {
                    case 0:
                        // Verificar que se hayan seleccionado al menos una fila
                        if (dgvDataMedicamento.SelectedRows.Count > 0)
                        {
                            selectItem(dgvDataMedicamento.CurrentRow.Index);
                        }
                        else
                        {
                            MessageBox.Show("Error: No se ha seleccionado ningún medicamento.\nPor favor, seleccione al menos un medicamento de la lista antes de continuar con esta operación.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        if (dgvDataProducto.SelectedRows.Count > 0)
                        {
                            selectItem(dgvDataProducto.CurrentRow.Index);
                        }
                        else
                        {
                            MessageBox.Show("Error: No se ha seleccionado ningún producto.\nPor favor, seleccione al menos un producto de la lista antes de continuar con esta operación.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
            catch (Exception)
            {
                messageManager.ShowUnexpectedError();
            }

        }

        private void selectItem(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                switch (tbControl.SelectedIndex)
                {
                    case 0:
                        // Instanciamos el objeto Medicamento
                        medicine = new MEDICAMENTO();
                        medicine.MedicamentoID = Convert.ToInt32(dgvDataMedicamento.Rows[rowIndex].Cells[0].Value);
                        // Cerramos el formulario
                        itemID = medicine.MedicamentoID;
                        SelectedItemType = ItemType.Medicamento;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    case 1:
                        // Instanciamos el objeto Producto
                        product = new PRODUCTO();
                        product.ProductoID = Convert.ToInt32(dgvDataProducto.Rows[rowIndex].Cells[0].Value);
                        // Cerramos el formulario
                        itemID = product.ProductoID;
                        SelectedItemType = ItemType.Producto;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pnlControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - mouseDownLocation.X;
                int deltaY = e.Y - mouseDownLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void pnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        // // /// /// INTERFAZ /// /// /// //




    }
}
