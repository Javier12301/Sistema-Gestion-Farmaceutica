namespace Sistema
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMAIN = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.SeparatorInventory = new Bunifu.Framework.UI.BunifuSeparator();
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrincipal = new Guna.UI.WinForms.GunaButton();
            this.flInventarioContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDescInventario = new System.Windows.Forms.Panel();
            this.lblDescInventorario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCategorias = new Guna.UI.WinForms.GunaButton();
            this.btnEstantes = new Guna.UI.WinForms.GunaButton();
            this.btnProveedores = new Guna.UI.WinForms.GunaButton();
            this.btnMedicamentos = new Guna.UI.WinForms.GunaButton();
            this.btnProductos = new Guna.UI.WinForms.GunaButton();
            this.btnClientes = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDescRegistro = new System.Windows.Forms.Panel();
            this.lblDescRegistro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnVentas = new Guna.UI.WinForms.GunaButton();
            this.btnCompras = new Guna.UI.WinForms.GunaButton();
            this.btnReportes = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDescControl = new System.Windows.Forms.Panel();
            this.lblDescControles = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLogOut = new Guna.UI.WinForms.GunaButton();
            this.btnAjustes = new Guna.UI.WinForms.GunaButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSize = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuG = new Guna.UI.WinForms.GunaButton();
            this.lblNameEmpresa = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.lblMailUser = new System.Windows.Forms.Label();
            this.pnlMAIN.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.sidebarContainer.SuspendLayout();
            this.flInventarioContainer.SuspendLayout();
            this.pnlDescInventario.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.pnlDescRegistro.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlDescControl.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 2;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pnlMAIN
            // 
            this.pnlMAIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlMAIN.Controls.Add(this.tableLayoutPanel2);
            this.pnlMAIN.Controls.Add(this.pnlHeader);
            this.pnlMAIN.Location = new System.Drawing.Point(0, 0);
            this.pnlMAIN.Name = "pnlMAIN";
            this.pnlMAIN.Size = new System.Drawing.Size(1018, 555);
            this.pnlMAIN.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pnlMenu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sidebarContainer, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1018, 505);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlMenu.Controls.Add(this.SeparatorInventory);
            this.pnlMenu.Location = new System.Drawing.Point(193, 2);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.MinimumSize = new System.Drawing.Size(600, 362);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlMenu.Size = new System.Drawing.Size(823, 501);
            this.pnlMenu.TabIndex = 8;
            this.pnlMenu.Tag = "pnlContainer";
            // 
            // SeparatorInventory
            // 
            this.SeparatorInventory.BackColor = System.Drawing.Color.Transparent;
            this.SeparatorInventory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.SeparatorInventory.LineThickness = 1;
            this.SeparatorInventory.Location = new System.Drawing.Point(-187, 6);
            this.SeparatorInventory.Name = "SeparatorInventory";
            this.SeparatorInventory.Size = new System.Drawing.Size(181, 56);
            this.SeparatorInventory.TabIndex = 1;
            this.SeparatorInventory.Transparency = 255;
            this.SeparatorInventory.Vertical = false;
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.sidebarContainer.Controls.Add(this.btnPrincipal);
            this.sidebarContainer.Controls.Add(this.flInventarioContainer);
            this.sidebarContainer.Controls.Add(this.flowLayoutPanel3);
            this.sidebarContainer.Controls.Add(this.flowLayoutPanel2);
            this.sidebarContainer.Location = new System.Drawing.Point(3, 3);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(185, 0);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(43, 362);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sidebarContainer.Size = new System.Drawing.Size(185, 499);
            this.sidebarContainer.TabIndex = 7;
            this.sidebarContainer.Tag = "pnlContainer";
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.AnimationHoverSpeed = 0.07F;
            this.btnPrincipal.AnimationSpeed = 0.03F;
            this.btnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnPrincipal.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPrincipal.BorderColor = System.Drawing.Color.Black;
            this.btnPrincipal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrincipal.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrincipal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrincipal.ForeColor = System.Drawing.Color.Black;
            this.btnPrincipal.Image = global::Sistema.Properties.Resources.home_page;
            this.btnPrincipal.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrincipal.Location = new System.Drawing.Point(3, 3);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnPrincipal.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrincipal.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrincipal.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnPrincipal.OnHoverImage")));
            this.btnPrincipal.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnPrincipal.Radius = 15;
            this.btnPrincipal.Size = new System.Drawing.Size(181, 30);
            this.btnPrincipal.TabIndex = 19;
            this.btnPrincipal.TabStop = false;
            this.btnPrincipal.Text = " Principal";
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // flInventarioContainer
            // 
            this.flInventarioContainer.Controls.Add(this.pnlDescInventario);
            this.flInventarioContainer.Controls.Add(this.btnCategorias);
            this.flInventarioContainer.Controls.Add(this.btnEstantes);
            this.flInventarioContainer.Controls.Add(this.btnProveedores);
            this.flInventarioContainer.Controls.Add(this.btnMedicamentos);
            this.flInventarioContainer.Controls.Add(this.btnProductos);
            this.flInventarioContainer.Controls.Add(this.btnClientes);
            this.flInventarioContainer.Location = new System.Drawing.Point(3, 39);
            this.flInventarioContainer.Name = "flInventarioContainer";
            this.flInventarioContainer.Size = new System.Drawing.Size(181, 230);
            this.flInventarioContainer.TabIndex = 2;
            // 
            // pnlDescInventario
            // 
            this.pnlDescInventario.Controls.Add(this.lblDescInventorario);
            this.pnlDescInventario.Location = new System.Drawing.Point(3, 3);
            this.pnlDescInventario.Name = "pnlDescInventario";
            this.pnlDescInventario.Size = new System.Drawing.Size(181, 20);
            this.pnlDescInventario.TabIndex = 34;
            // 
            // lblDescInventorario
            // 
            this.lblDescInventorario.AutoEllipsis = true;
            this.lblDescInventorario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDescInventorario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescInventorario.Location = new System.Drawing.Point(1, 2);
            this.lblDescInventorario.Name = "lblDescInventorario";
            this.lblDescInventorario.Size = new System.Drawing.Size(81, 17);
            this.lblDescInventorario.TabIndex = 0;
            this.lblDescInventorario.Text = "INVENTARIO";
            this.lblDescInventorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCategorias
            // 
            this.btnCategorias.AnimationHoverSpeed = 0.07F;
            this.btnCategorias.AnimationSpeed = 0.03F;
            this.btnCategorias.BackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnCategorias.BorderColor = System.Drawing.Color.Black;
            this.btnCategorias.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategorias.FocusedColor = System.Drawing.Color.Empty;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCategorias.ForeColor = System.Drawing.Color.Black;
            this.btnCategorias.Image = global::Sistema.Properties.Resources.tag;
            this.btnCategorias.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCategorias.Location = new System.Drawing.Point(3, 29);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnCategorias.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCategorias.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCategorias.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnCategorias.OnHoverImage")));
            this.btnCategorias.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnCategorias.Radius = 15;
            this.btnCategorias.Size = new System.Drawing.Size(181, 28);
            this.btnCategorias.TabIndex = 29;
            this.btnCategorias.TabStop = false;
            this.btnCategorias.Text = " Categorías";
            this.btnCategorias.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnEstantes
            // 
            this.btnEstantes.AnimationHoverSpeed = 0.07F;
            this.btnEstantes.AnimationSpeed = 0.03F;
            this.btnEstantes.BackColor = System.Drawing.Color.Transparent;
            this.btnEstantes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnEstantes.BorderColor = System.Drawing.Color.Black;
            this.btnEstantes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEstantes.FocusedColor = System.Drawing.Color.Empty;
            this.btnEstantes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEstantes.ForeColor = System.Drawing.Color.Black;
            this.btnEstantes.Image = global::Sistema.Properties.Resources.rack;
            this.btnEstantes.ImageSize = new System.Drawing.Size(18, 18);
            this.btnEstantes.Location = new System.Drawing.Point(3, 63);
            this.btnEstantes.Name = "btnEstantes";
            this.btnEstantes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnEstantes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEstantes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEstantes.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnEstantes.OnHoverImage")));
            this.btnEstantes.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnEstantes.Radius = 15;
            this.btnEstantes.Size = new System.Drawing.Size(181, 28);
            this.btnEstantes.TabIndex = 30;
            this.btnEstantes.TabStop = false;
            this.btnEstantes.Text = " Estantes";
            this.btnEstantes.Click += new System.EventHandler(this.btnEstantes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.AnimationHoverSpeed = 0.07F;
            this.btnProveedores.AnimationSpeed = 0.03F;
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnProveedores.BorderColor = System.Drawing.Color.Black;
            this.btnProveedores.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProveedores.FocusedColor = System.Drawing.Color.Empty;
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProveedores.ForeColor = System.Drawing.Color.Black;
            this.btnProveedores.Image = global::Sistema.Properties.Resources.supplier;
            this.btnProveedores.ImageSize = new System.Drawing.Size(18, 18);
            this.btnProveedores.Location = new System.Drawing.Point(3, 97);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnProveedores.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProveedores.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProveedores.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.OnHoverImage")));
            this.btnProveedores.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnProveedores.Radius = 15;
            this.btnProveedores.Size = new System.Drawing.Size(181, 28);
            this.btnProveedores.TabIndex = 31;
            this.btnProveedores.TabStop = false;
            this.btnProveedores.Text = " Proveedores";
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnMedicamentos
            // 
            this.btnMedicamentos.AnimationHoverSpeed = 0.07F;
            this.btnMedicamentos.AnimationSpeed = 0.03F;
            this.btnMedicamentos.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicamentos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnMedicamentos.BorderColor = System.Drawing.Color.Black;
            this.btnMedicamentos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMedicamentos.FocusedColor = System.Drawing.Color.Empty;
            this.btnMedicamentos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMedicamentos.ForeColor = System.Drawing.Color.Black;
            this.btnMedicamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicamentos.Image")));
            this.btnMedicamentos.ImageSize = new System.Drawing.Size(18, 18);
            this.btnMedicamentos.Location = new System.Drawing.Point(3, 131);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnMedicamentos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMedicamentos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMedicamentos.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnMedicamentos.OnHoverImage")));
            this.btnMedicamentos.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnMedicamentos.Radius = 15;
            this.btnMedicamentos.Size = new System.Drawing.Size(181, 28);
            this.btnMedicamentos.TabIndex = 32;
            this.btnMedicamentos.TabStop = false;
            this.btnMedicamentos.Text = " Medicamentos";
            this.btnMedicamentos.Click += new System.EventHandler(this.btnMedicamento_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.AnimationHoverSpeed = 0.07F;
            this.btnProductos.AnimationSpeed = 0.03F;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnProductos.BorderColor = System.Drawing.Color.Black;
            this.btnProductos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProductos.FocusedColor = System.Drawing.Color.Empty;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.Image = global::Sistema.Properties.Resources.product;
            this.btnProductos.ImageSize = new System.Drawing.Size(18, 18);
            this.btnProductos.Location = new System.Drawing.Point(3, 165);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnProductos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProductos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProductos.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.OnHoverImage")));
            this.btnProductos.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnProductos.Radius = 15;
            this.btnProductos.Size = new System.Drawing.Size(181, 28);
            this.btnProductos.TabIndex = 33;
            this.btnProductos.TabStop = false;
            this.btnProductos.Text = " Productos";
            // 
            // btnClientes
            // 
            this.btnClientes.AnimationHoverSpeed = 0.07F;
            this.btnClientes.AnimationSpeed = 0.03F;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnClientes.BorderColor = System.Drawing.Color.Black;
            this.btnClientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClientes.FocusedColor = System.Drawing.Color.Empty;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageSize = new System.Drawing.Size(18, 18);
            this.btnClientes.Location = new System.Drawing.Point(3, 199);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnClientes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClientes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClientes.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.OnHoverImage")));
            this.btnClientes.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnClientes.Radius = 15;
            this.btnClientes.Size = new System.Drawing.Size(181, 28);
            this.btnClientes.TabIndex = 35;
            this.btnClientes.TabStop = false;
            this.btnClientes.Text = " Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.pnlDescRegistro);
            this.flowLayoutPanel3.Controls.Add(this.btnVentas);
            this.flowLayoutPanel3.Controls.Add(this.btnCompras);
            this.flowLayoutPanel3.Controls.Add(this.btnReportes);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 275);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(181, 125);
            this.flowLayoutPanel3.TabIndex = 33;
            // 
            // pnlDescRegistro
            // 
            this.pnlDescRegistro.Controls.Add(this.lblDescRegistro);
            this.pnlDescRegistro.Location = new System.Drawing.Point(3, 3);
            this.pnlDescRegistro.Name = "pnlDescRegistro";
            this.pnlDescRegistro.Size = new System.Drawing.Size(178, 20);
            this.pnlDescRegistro.TabIndex = 27;
            // 
            // lblDescRegistro
            // 
            this.lblDescRegistro.AutoEllipsis = true;
            this.lblDescRegistro.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDescRegistro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescRegistro.Location = new System.Drawing.Point(1, 2);
            this.lblDescRegistro.Name = "lblDescRegistro";
            this.lblDescRegistro.Size = new System.Drawing.Size(110, 11);
            this.lblDescRegistro.TabIndex = 1;
            this.lblDescRegistro.Text = "REGISTROS";
            this.lblDescRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVentas
            // 
            this.btnVentas.AnimationHoverSpeed = 0.07F;
            this.btnVentas.AnimationSpeed = 0.03F;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnVentas.BorderColor = System.Drawing.Color.Black;
            this.btnVentas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVentas.FocusedColor = System.Drawing.Color.Empty;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageSize = new System.Drawing.Size(18, 18);
            this.btnVentas.Location = new System.Drawing.Point(3, 29);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnVentas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVentas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVentas.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.OnHoverImage")));
            this.btnVentas.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnVentas.Radius = 15;
            this.btnVentas.Size = new System.Drawing.Size(181, 28);
            this.btnVentas.TabIndex = 30;
            this.btnVentas.Text = " Ventas";
            // 
            // btnCompras
            // 
            this.btnCompras.AnimationHoverSpeed = 0.07F;
            this.btnCompras.AnimationSpeed = 0.03F;
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnCompras.BorderColor = System.Drawing.Color.Black;
            this.btnCompras.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCompras.FocusedColor = System.Drawing.Color.Empty;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCompras.ForeColor = System.Drawing.Color.Black;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCompras.Location = new System.Drawing.Point(3, 63);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnCompras.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCompras.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCompras.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnCompras.OnHoverImage")));
            this.btnCompras.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnCompras.Radius = 15;
            this.btnCompras.Size = new System.Drawing.Size(181, 28);
            this.btnCompras.TabIndex = 29;
            this.btnCompras.TabStop = false;
            this.btnCompras.Text = " Compras";
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.AnimationHoverSpeed = 0.07F;
            this.btnReportes.AnimationSpeed = 0.03F;
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnReportes.BorderColor = System.Drawing.Color.Black;
            this.btnReportes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReportes.FocusedColor = System.Drawing.Color.Empty;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReportes.ForeColor = System.Drawing.Color.Black;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageSize = new System.Drawing.Size(18, 18);
            this.btnReportes.Location = new System.Drawing.Point(3, 97);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnReportes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReportes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReportes.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnReportes.OnHoverImage")));
            this.btnReportes.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnReportes.Radius = 15;
            this.btnReportes.Size = new System.Drawing.Size(181, 28);
            this.btnReportes.TabIndex = 31;
            this.btnReportes.TabStop = false;
            this.btnReportes.Text = " Reportes";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pnlDescControl);
            this.flowLayoutPanel2.Controls.Add(this.btnLogOut);
            this.flowLayoutPanel2.Controls.Add(this.btnAjustes);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 406);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(181, 115);
            this.flowLayoutPanel2.TabIndex = 32;
            // 
            // pnlDescControl
            // 
            this.pnlDescControl.Controls.Add(this.lblDescControles);
            this.pnlDescControl.Location = new System.Drawing.Point(3, 3);
            this.pnlDescControl.Name = "pnlDescControl";
            this.pnlDescControl.Size = new System.Drawing.Size(181, 20);
            this.pnlDescControl.TabIndex = 27;
            // 
            // lblDescControles
            // 
            this.lblDescControles.AutoSize = true;
            this.lblDescControles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescControles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescControles.Location = new System.Drawing.Point(2, 4);
            this.lblDescControles.Name = "lblDescControles";
            this.lblDescControles.Size = new System.Drawing.Size(70, 13);
            this.lblDescControles.TabIndex = 0;
            this.lblDescControles.Text = "CONTROLES";
            this.lblDescControles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AnimationHoverSpeed = 0.07F;
            this.btnLogOut.AnimationSpeed = 0.03F;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnLogOut.BorderColor = System.Drawing.Color.Black;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::Sistema.Properties.Resources.exit;
            this.btnLogOut.ImageSize = new System.Drawing.Size(18, 18);
            this.btnLogOut.Location = new System.Drawing.Point(3, 29);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnLogOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogOut.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogOut.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.OnHoverImage")));
            this.btnLogOut.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnLogOut.Radius = 15;
            this.btnLogOut.Size = new System.Drawing.Size(181, 28);
            this.btnLogOut.TabIndex = 30;
            this.btnLogOut.Text = " Cerrar Sesión";
            // 
            // btnAjustes
            // 
            this.btnAjustes.AnimationHoverSpeed = 0.07F;
            this.btnAjustes.AnimationSpeed = 0.03F;
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAjustes.BorderColor = System.Drawing.Color.Black;
            this.btnAjustes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjustes.FocusedColor = System.Drawing.Color.Empty;
            this.btnAjustes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAjustes.ForeColor = System.Drawing.Color.Black;
            this.btnAjustes.Image = global::Sistema.Properties.Resources.settings;
            this.btnAjustes.ImageSize = new System.Drawing.Size(18, 18);
            this.btnAjustes.Location = new System.Drawing.Point(3, 63);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnAjustes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAjustes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAjustes.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnAjustes.OnHoverImage")));
            this.btnAjustes.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnAjustes.Radius = 15;
            this.btnAjustes.Size = new System.Drawing.Size(181, 28);
            this.btnAjustes.TabIndex = 29;
            this.btnAjustes.TabStop = false;
            this.btnAjustes.Text = " Ajustes";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.pnlHeader.Controls.Add(this.lblSize);
            this.pnlHeader.Controls.Add(this.flowLayoutPanel1);
            this.pnlHeader.Controls.Add(this.tableLayoutPanel1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1018, 50);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Tag = "pnlContainer";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(342, 17);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(35, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMenuG);
            this.flowLayoutPanel1.Controls.Add(this.lblNameEmpresa);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 50);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnMenuG
            // 
            this.btnMenuG.AnimationHoverSpeed = 0.07F;
            this.btnMenuG.AnimationSpeed = 0.03F;
            this.btnMenuG.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuG.BaseColor = System.Drawing.Color.Transparent;
            this.btnMenuG.BorderColor = System.Drawing.Color.Black;
            this.btnMenuG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenuG.FocusedColor = System.Drawing.Color.Empty;
            this.btnMenuG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuG.ForeColor = System.Drawing.Color.Black;
            this.btnMenuG.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuG.Image")));
            this.btnMenuG.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMenuG.ImageSize = new System.Drawing.Size(24, 24);
            this.btnMenuG.Location = new System.Drawing.Point(3, 3);
            this.btnMenuG.Name = "btnMenuG";
            this.btnMenuG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnMenuG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuG.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuG.OnHoverImage = null;
            this.btnMenuG.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnMenuG.Radius = 15;
            this.btnMenuG.Size = new System.Drawing.Size(50, 47);
            this.btnMenuG.TabIndex = 20;
            this.btnMenuG.Click += new System.EventHandler(this.btnResizingMenu_Click);
            // 
            // lblNameEmpresa
            // 
            this.lblNameEmpresa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNameEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameEmpresa.Location = new System.Drawing.Point(59, 0);
            this.lblNameEmpresa.Name = "lblNameEmpresa";
            this.lblNameEmpresa.Size = new System.Drawing.Size(146, 50);
            this.lblNameEmpresa.TabIndex = 2;
            this.lblNameEmpresa.Text = "Farmacia";
            this.lblNameEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tableLayoutPanel1.Controls.Add(this.pcbUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMailUser, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(796, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 49);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pcbUser
            // 
            this.pcbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbUser.Image = ((System.Drawing.Image)(resources.GetObject("pcbUser.Image")));
            this.pcbUser.Location = new System.Drawing.Point(3, 3);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(51, 43);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser.TabIndex = 0;
            this.pcbUser.TabStop = false;
            this.pcbUser.Tag = "UserInfo";
            // 
            // lblMailUser
            // 
            this.lblMailUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMailUser.AutoSize = true;
            this.lblMailUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMailUser.Location = new System.Drawing.Point(63, 16);
            this.lblMailUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.lblMailUser.Name = "lblMailUser";
            this.lblMailUser.Size = new System.Drawing.Size(152, 17);
            this.lblMailUser.TabIndex = 1;
            this.lblMailUser.Tag = "UserInfo";
            this.lblMailUser.Text = "javieradmin@gmail.com";
            this.lblMailUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1018, 555);
            this.Controls.Add(this.pnlMAIN);
            this.MinimumSize = new System.Drawing.Size(1034, 594);
            this.Name = "PrincipalForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing);
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.SizeChanged += new System.EventHandler(this.PrincipalForm_SizeChanged);
            this.pnlMAIN.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.sidebarContainer.ResumeLayout(false);
            this.flInventarioContainer.ResumeLayout(false);
            this.pnlDescInventario.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.pnlDescRegistro.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pnlDescControl.ResumeLayout(false);
            this.pnlDescControl.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel pnlMAIN;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblNameEmpresa;
        private System.Windows.Forms.PictureBox pcbUser;
        private System.Windows.Forms.Label lblMailUser;
        private Guna.UI.WinForms.GunaButton btnMenuG;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuSeparator SeparatorInventory;
        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private Guna.UI.WinForms.GunaButton btnPrincipal;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.FlowLayoutPanel flInventarioContainer;
        private System.Windows.Forms.Panel pnlDescInventario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescInventorario;
        private Guna.UI.WinForms.GunaButton btnCategorias;
        private Guna.UI.WinForms.GunaButton btnEstantes;
        private Guna.UI.WinForms.GunaButton btnProveedores;
        private Guna.UI.WinForms.GunaButton btnMedicamentos;
        private Guna.UI.WinForms.GunaButton btnProductos;
        private Guna.UI.WinForms.GunaButton btnClientes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel pnlDescRegistro;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescRegistro;
        private Guna.UI.WinForms.GunaButton btnVentas;
        private Guna.UI.WinForms.GunaButton btnCompras;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel pnlDescControl;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescControles;
        private Guna.UI.WinForms.GunaButton btnLogOut;
        private Guna.UI.WinForms.GunaButton btnAjustes;
        private Guna.UI.WinForms.GunaButton btnReportes;
    }
}