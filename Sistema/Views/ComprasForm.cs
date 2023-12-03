using Bunifu.Framework.Lib;
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
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;

namespace Sistema.Views
{
    public partial class ComprasForm : Form
    {
        MessageBoxManager messageManager = MessageBoxManager.GetInstance;
        ProveedorLogica supplierLogic = new ProveedorLogica();
        MedicamentoLogica medicineLogic = new MedicamentoLogica();
        CompraLogica purchaseLogic = new CompraLogica();
        ProductoLogica productLogic = new ProductoLogica();
        Controladora controladora = Controladora.GetInstance;

        object itemSelected { get; set; }
        PROVEEDOR selectedSupplier { get; set; } = null;

        public ComprasForm()
        {
            InitializeComponent();
        }

        private void ComprasForm_Load(object sender, EventArgs e)
        {
            // Cargar fecha con formato largo
            cbotipodocumento.Items.Add("Boleta");
            cbotipodocumento.Items.Add("Factura");
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;
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
                    supplier = supplierLogic.GetSupplier(proveedorID);
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
                    selectedSupplier = supplier;
                    txtdocproveedor.Text = supplier.Documento;
                    txtnombreproveedor.Text = supplier.RazonSocial;
                }
                else
                {
                    selectedSupplier = null;
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
                    itemSelected = medicine;
                    txtcodproducto.Text = medicine.Codigo;
                    txtproducto.Text = medicine.Nombre;
                    txtcodproducto.BackColor = Color.Honeydew;
                }
                else if (item is PRODUCTO product)
                {
                    itemSelected = product;
                    txtcodproducto.Text = product.Codigo;
                    txtproducto.Text = product.Nombre;
                    txtcodproducto.BackColor = Color.Honeydew;
                }
            }
            else
            {
                itemSelected = null;
                txtproducto.Text = "";
                txtcodproducto.BackColor = Color.MistyRose;
            }

        }

        private void txtcodproducto_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
      
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Comprobar si hay proveedores y preguntar si desea agregar el item sin proveedor
            if (selectedSupplier == null)
            {
                DialogResult result = MessageBox.Show("No se ha seleccionado un proveedor. ¿Desea agregar el item sin proveedor?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            if (itemSelected != null)
            {
                bool isDecimalPrecioCompra = controladora.CheckDecimalFormatPrice(txtPrecioCompra, errorProvider);
                bool isDecimalPrecioVenta = controladora.CheckDecimalFormatPrice(txtPrecioVenta, errorProvider);
                if (isDecimalPrecioCompra && isDecimalPrecioVenta)
                {
                    bool itemExists = false;
                    // obtenemos el ID del item seleccionado y a traves de if verificamos si es un producto o un medicamento
                    int itemID = 0;
                    if (itemSelected is MEDICAMENTO medicine)
                    {
                        itemID = medicine.MedicamentoID;
                        foreach (DataGridViewRow row in dgvData.Rows)
                        {
                            if (row.Cells["dgvcMedicamentoID"].Value.ToString() == itemID.ToString())
                            {
                                itemExists = true;
                                break;
                            }
                        }
                        // si el item no se encuentra en la lista, se agrega
                        if (!itemExists)
                        {
                            addItemToDataGridView(medicine);
                        }
                        else
                        {
                            // Mensage de que ya se encuentra en la lista y pregunta si desea actualizar cantidad y precio 
                            // que se encuentra en la lista
                            DialogResult result = MessageBox.Show("El medicamento ya se encuentra en la lista, ¿desea actualizar la cantidad y los precios?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                // Actualizar cantidad y precio
                                updateItemInDataGridView(medicine);
                            }
                        }
                    }
                    else if (itemSelected is PRODUCTO product)
                    {
                        itemID = product.ProductoID;
                        foreach (DataGridViewRow row in dgvData.Rows)
                        {
                            if (row.Cells["dgvcProductoID"].Value.ToString() == itemID.ToString())
                            {
                                itemExists = true;
                                break;
                            }
                        }
                        // si el item no se encuentra en la lista, se agrega
                        if (!itemExists)
                        {
                            addItemToDataGridView(product);
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("El producto ya se encuentra en la lista, ¿desea actualizar la cantidad y los precios?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                // Actualizar cantidad y precio
                                updateItemInDataGridView(product);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Formato de moneda incorrecto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto o medicamento", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addItemToDataGridView(object item)
        {
            try
            {
                // Decimal Precio Compra y Precio Venta
                decimal precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                decimal precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                // Verificar si el proveedor es nulo o no usamos un condicional ternario
                int supplierID = selectedSupplier == null ? 0 : selectedSupplier.ProveedorID;
                string supplierName = selectedSupplier == null ? "N/A" : selectedSupplier.RazonSocial;
                
                if (item != null)
                {
                    if (item is MEDICAMENTO medicine)
                    {
                        dgvData.Rows.Add(new object[]
                        {
                        medicine.MedicamentoID,
                        0,
                        supplierID,
                        medicine.Nombre,
                        precioCompra.ToString("0.00"),
                        precioVenta.ToString("0.00"),
                        txtCantidad.Value.ToString(),
                        (txtCantidad.Value * precioCompra).ToString("0.00"),
                        supplierName,
                        true
                        });
                        calculateTotal();
                        cleanFields();
                        txtcodproducto.Focus();
                    }
                    else if (item is PRODUCTO product)
                    {
                        dgvData.Rows.Add(new object[]
                        {
                        0,
                        product.ProductoID,
                        supplierID,
                        product.Nombre,
                        precioCompra.ToString("0.00"),
                        precioVenta.ToString("0.00"),
                        txtCantidad.Value.ToString(),
                        (txtCantidad.Value * precioCompra).ToString("0.00"),
                        supplierName,
                        false
                        });
                        calculateTotal();
                        cleanFields();
                        txtcodproducto.Focus();
                    }
                }
                else
                {
                    itemSelected = null;
                    txtproducto.Text = "";
                    txtcodproducto.BackColor = Color.MistyRose;
                }
            }
            catch (Exception)
            {
                messageManager.ShowUnexpectedError();
            }

        }

        private void updateItemInDataGridView(object item)
        {
            try
            {
                decimal precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                decimal precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);

                if (item != null)
                {
                    DataGridViewRow rowToUpdate = null;
                    int columnIndexID = -1;
                    int itemID = 0;

                    if (item is MEDICAMENTO medicine)
                    {
                        columnIndexID = dgvData.Columns["dgvcMedicamentoID"].Index;
                        itemID = medicine.MedicamentoID;
                    }
                    else if (item is PRODUCTO product)
                    {
                        columnIndexID = dgvData.Columns["dgvcProductoID"].Index;
                        itemID = product.ProductoID;
                    }

                    // Buscar la fila que contiene el ID del item
                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        if (row.Cells[columnIndexID].Value.ToString() == itemID.ToString())
                        {
                            rowToUpdate = row;
                            break;
                        }
                    }

                    if (rowToUpdate != null)
                    {
                        // Actualizar cantidad y precios en la fila encontrada
                        rowToUpdate.Cells["dgvcCantidad"].Value = txtCantidad.Value.ToString();
                        rowToUpdate.Cells["dgvcPrecioCompra"].Value = precioCompra.ToString("0.00");
                        rowToUpdate.Cells["dgvcPrecioVenta"].Value = precioVenta.ToString("0.00");
                        rowToUpdate.Cells["dgvcSubtotal"].Value = (txtCantidad.Value * precioCompra).ToString("0.00");
                        // Actualizar el proveedor
                        rowToUpdate.Cells["dgvcProveedorID"].Value = selectedSupplier.ProveedorID;
                        rowToUpdate.Cells["dgvcProveedorRazonSocial"].Value = selectedSupplier.RazonSocial;
                        calculateTotal();
                        cleanFields();
                        txtcodproducto.Focus();
                    }
                }
                else
                {
                    itemSelected = null;
                    txtproducto.Text = "";
                    txtcodproducto.BackColor = Color.MistyRose;
                }
            }
            catch (Exception)
            {
                messageManager.ShowUnexpectedError();
            }
        }

        // Calcular total
        private void calculateTotal()
        {
            decimal total = 0;
            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["dgvcSubTotal"].Value.ToString());
                }
            }
            txtTotalPagar.Text = total.ToString();
        }

        private void cleanFields()
        {
            controladora.ClearTextBoxT(txtcodproducto, txtproducto, txtPrecioCompra, txtPrecioVenta);
            txtcodproducto.BackColor = Color.White;
            txtCantidad.Value = 1;
            txtfecha.Text = DateTime.Now.ToLongDateString();
            itemSelected = null;
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Se creará un botón en la última columna del datagridview para eliminar el item seleccionado
            if (e.ColumnIndex == 8)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Propiedades de la imagen para dibujar en el datagridview
                var w = Properties.Resources.DeleteRed.Width;
                var h = Properties.Resources.DeleteRed.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.DeleteRed, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvData.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    int indice = e.RowIndex;

                    if (indice >= 0)
                    {
                        dgvData.Rows.RemoveAt(indice);
                        calculateTotal();
                    }
                }
            }
            catch (Exception)
            {
                messageManager.ShowUnexpectedError();
            }

        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            controladora.OnlyNumberAndDecimalPoint(txtPrecioCompra, e);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            controladora.OnlyNumberAndDecimalPoint(txtPrecioVenta, e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verificar si la tabla no está vacía
            if (dgvData.Rows.Count > 0)
            {
                // Creamos un data table para guardar los datos de la compra
                DataTable dt = new DataTable();
                dt.Columns.Add("MedicamentoID");
                dt.Columns.Add("ProductoID");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("PrecioCompra");
                dt.Columns.Add("PrecioVenta");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("SubTotal");
                // Esta es una columna checkbox
                dt.Columns.Add("esMedicamento");

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    dt.Rows.Add(
                        new object[]
                        {
                            row.Cells["dgvcMedicamentoID"].Value.ToString(),
                            row.Cells["dgvcProductoID"].Value.ToString(),
                            row.Cells["dgvcNombre"].Value.ToString(),
                            row.Cells["dgvcPrecioCompra"].Value.ToString(),
                            row.Cells["dgvcPrecioVenta"].Value.ToString(),
                            row.Cells["dgvcCantidad"].Value.ToString(),
                            row.Cells["dgvcSubTotal"].Value.ToString(),
                            row.Cells["dgvcEsMedicamento"].Value.ToString()
                        });
                }
                // Creamos el numero de registro con un formato 00000{numero}
                int correlativeID = purchaseLogic.GetCorrelativePurchaseID();
                string documentNumber = string.Format("{0:00000}", correlativeID);

                // Creamos el objeto compra
                //CompraID INT IDENTITY PRIMARY KEY,
                //UsuarioID INT REFERENCES USUARIO(UsuarioID),
                //ProveedorID INT REFERENCES PROVEEDOR(ProveedorID),
                //TipoDocumento VARCHAR(50),
                //NumeroDocumento VARCHAR(50),
                //MontoTotal DECIMAL(10,2),
                //FechaRegistro DATETIME DEFAULT GETDATE()
                //COMPRA purchase_detail = new COMPRA()
                //{
                //    // Arreglar cuando se termine el modulo de seguridad
                   
                    
                //}

            }
            else
            {
                MessageBox.Show("Debe agregar al menos un producto para registrar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        // // /// /// FIN ESTABLECER DATOS DESPUES DE REALIZAR BUSQUEDA A TRAVÉS DE MODAL /// /// /// //


        // // /// INTERFAZ /// /// //
    }
}
