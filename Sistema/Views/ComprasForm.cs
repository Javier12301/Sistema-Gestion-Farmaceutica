using Sistema.Controles.Interfaz;
using Sistema.Controles.Logica;
using Sistema.Models;
using Sistema.Views.Modales;
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

namespace Sistema.Views
{
    public partial class ComprasForm : Form
    {
        MessageBoxManager messageManager = MessageBoxManager.GetInstance;
        ProveedorLogica supplierLogic = new ProveedorLogica();
        MedicamentoLogica medicineLogic = new MedicamentoLogica();
        ProductoLogica productLogic = new ProductoLogica();

        public ComprasForm()
        {
            InitializeComponent();
        }

        private void ComprasForm_Load(object sender, EventArgs e)
        {
            // Cargar fecha con formato largo
            txtfecha.Text = DateTime.Now.ToLongDateString();
        }

        // // /// /// INTERFAZ /// /// /// //

        private void btnbuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PROVEEDOR supplier = new PROVEEDOR();
                    int proveedorID = modal.supplier.ProveedorID;
                    // Crear instancia
                    PROVEEDOR selectedSupplier = supplierLogic.GetSupplier(proveedorID);
                    supplier = selectedSupplier;
                    setSupplier(supplier);
                }
            }
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            using (var modal = new mdBuscarItem())
            {
                try
                {
                    var result = modal.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //Comprobar si se recibió un Medicamento o un Producto
                        if (modal.SelectedItemType == mdBuscarItem.ItemType.Medicamento)
                        {
                            int medicineID = modal.itemID;
                            //Crear instancia
                            MEDICAMENTO selectedMedicine = medicineLogic.GetMedicine(medicineID);
                            setItem(selectedMedicine);
                        }
                        else if (modal.SelectedItemType == mdBuscarItem.ItemType.Producto)
                        {
                            int productID = modal.itemID;
                            PRODUCTO selectedProduct = productLogic.GetProduct(productID);
                            setItem(selectedProduct);
                        }
                    }
                }
                catch (DbUpdateException)
                {
                    // Excepción relacionada con problemas de actualización en la base de datos
                    messageManager.ShowDatabaseUpdateError();

                    // Loguear dbEx si es necesario para fines de depuración
                }
                catch (SqlException)
                {
                    // Excepción relacionada con errores de SQL
                    messageManager.ShowSqlError();
                    // Loguear sqlEx si es necesario para fines de depuración
                }
                catch (Exception)
                {
                    // Otras excepciones no manejadas
                    messageManager.ShowUnexpectedError();
                    // Loguear ex si es necesario para fines de depuración
                }

            }
        }


        // // /// /// ESTABLECER DATOS DESPUES DE REALIZAR BUSQUEDA A TRAVÉS DE MODAL /// /// /// //
        private void setSupplier(PROVEEDOR supplier)
        {
            try
            {
                if (supplier != null)
                {
                    txtdocproveedor.Text = supplier.Documento;
                    txtnombreproveedor.Text = supplier.RazonSocial;
                }
                else
                {
                    txtdocproveedor.Text = "";
                    txtnombreproveedor.Text = "";
                }
            }
            catch (Exception)
            {
                messageManager.ShowUnexpectedError();
            }
        }

        private void setItem(object item)
        {
            // Verificar que el objeto recibido no sea nulo
            if (item != null)
            {
                if (item is MEDICAMENTO medicine)
                {
                    txtcodproducto.Text = medicine.Codigo;
                    txtproducto.Text = medicine.Nombre;
                    txtcodproducto.BackColor = Color.Honeydew;
                }
                else if (item is PRODUCTO product)
                {

                    txtcodproducto.Text = product.Codigo;
                    txtproducto.Text = product.Nombre;
                    txtcodproducto.BackColor = Color.Honeydew;
                }
            }
            else
            {
                txtproducto.Text = "";
                txtcodproducto.BackColor = Color.MistyRose;
            }

        }

        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                // Buscar código de barras en la base de datos
                string barcode = txtcodproducto.Text;
                // Crear instancias
                PRODUCTO product = productLogic.GetProductByCode(barcode);
                MEDICAMENTO medicine = medicineLogic.GetMedicineByCode(barcode);
                // Comprobar si se encontró un producto o un medicamento
                if (product != null)
                {
                    // Establecer datos del producto
                    setItem(product);
                }
                else if (medicine != null)
                {
                    // Establecer datos del medicamento
                    setItem(medicine);
                }
                else
                {
                    setItem(null);
                }
            }
        }

        // // /// /// FIN ESTABLECER DATOS DESPUES DE REALIZAR BUSQUEDA A TRAVÉS DE MODAL /// /// /// //


        // // /// INTERFAZ /// /// //
    }
}
