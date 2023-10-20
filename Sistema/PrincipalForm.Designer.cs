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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuG = new Guna.UI.WinForms.GunaButton();
            this.lblNameEmpresa = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.lblMailUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrincipal = new Guna.UI.WinForms.GunaButton();
            this.pnlDescInventario = new System.Windows.Forms.Panel();
            this.lblDescriptionInventorario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCategorias = new Guna.UI.WinForms.GunaButton();
            this.btnEstantes = new Guna.UI.WinForms.GunaButton();
            this.btnProveedores = new Guna.UI.WinForms.GunaButton();
            this.btnMedicamentos = new Guna.UI.WinForms.GunaButton();
            this.btnProductos = new Guna.UI.WinForms.GunaButton();
            this.btnClientes = new Guna.UI.WinForms.GunaButton();
            this.pnlDescControl = new System.Windows.Forms.Panel();
            this.lblDescriptionControls = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAjustes = new Guna.UI.WinForms.GunaButton();
            this.btnLogOut = new Guna.UI.WinForms.GunaButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.SeparatorInventory = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblSize = new System.Windows.Forms.Label();
            this.pnlMAIN.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.sidebarContainer.SuspendLayout();
            this.pnlDescInventario.SuspendLayout();
            this.pnlDescControl.SuspendLayout();
            this.pnlMenu.SuspendLayout();
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
            this.pnlMAIN.Size = new System.Drawing.Size(818, 412);
            this.pnlMAIN.TabIndex = 0;
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
            this.pnlHeader.Size = new System.Drawing.Size(818, 50);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Tag = "pnlContainer";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(596, 1);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(818, 362);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.sidebarContainer.Controls.Add(this.btnPrincipal);
            this.sidebarContainer.Controls.Add(this.pnlDescInventario);
            this.sidebarContainer.Controls.Add(this.btnCategorias);
            this.sidebarContainer.Controls.Add(this.btnEstantes);
            this.sidebarContainer.Controls.Add(this.btnProveedores);
            this.sidebarContainer.Controls.Add(this.btnMedicamentos);
            this.sidebarContainer.Controls.Add(this.btnProductos);
            this.sidebarContainer.Controls.Add(this.btnClientes);
            this.sidebarContainer.Controls.Add(this.pnlDescControl);
            this.sidebarContainer.Controls.Add(this.btnAjustes);
            this.sidebarContainer.Controls.Add(this.btnLogOut);
            this.sidebarContainer.Location = new System.Drawing.Point(3, 3);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(185, 0);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(43, 362);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sidebarContainer.Size = new System.Drawing.Size(185, 362);
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
            this.btnPrincipal.Text = " Principal";
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // pnlDescInventario
            // 
            this.pnlDescInventario.Controls.Add(this.lblDescriptionInventorario);
            this.pnlDescInventario.Location = new System.Drawing.Point(3, 39);
            this.pnlDescInventario.Name = "pnlDescInventario";
            this.pnlDescInventario.Size = new System.Drawing.Size(181, 20);
            this.pnlDescInventario.TabIndex = 26;
            // 
            // lblDescriptionInventorario
            // 
            this.lblDescriptionInventorario.AutoEllipsis = true;
            this.lblDescriptionInventorario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDescriptionInventorario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescriptionInventorario.Location = new System.Drawing.Point(1, 2);
            this.lblDescriptionInventorario.Name = "lblDescriptionInventorario";
            this.lblDescriptionInventorario.Size = new System.Drawing.Size(81, 17);
            this.lblDescriptionInventorario.TabIndex = 0;
            this.lblDescriptionInventorario.Text = "INVENTARIO";
            this.lblDescriptionInventorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnCategorias.Location = new System.Drawing.Point(3, 65);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnCategorias.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCategorias.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCategorias.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnCategorias.OnHoverImage")));
            this.btnCategorias.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnCategorias.Radius = 15;
            this.btnCategorias.Size = new System.Drawing.Size(181, 28);
            this.btnCategorias.TabIndex = 21;
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
            this.btnEstantes.Location = new System.Drawing.Point(3, 99);
            this.btnEstantes.Name = "btnEstantes";
            this.btnEstantes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnEstantes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEstantes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEstantes.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnEstantes.OnHoverImage")));
            this.btnEstantes.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnEstantes.Radius = 15;
            this.btnEstantes.Size = new System.Drawing.Size(181, 28);
            this.btnEstantes.TabIndex = 22;
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
            this.btnProveedores.Location = new System.Drawing.Point(3, 133);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnProveedores.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProveedores.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProveedores.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.OnHoverImage")));
            this.btnProveedores.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnProveedores.Radius = 15;
            this.btnProveedores.Size = new System.Drawing.Size(181, 28);
            this.btnProveedores.TabIndex = 23;
            this.btnProveedores.Text = " Proveedores";
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
            this.btnMedicamentos.Location = new System.Drawing.Point(3, 167);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnMedicamentos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMedicamentos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMedicamentos.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnMedicamentos.OnHoverImage")));
            this.btnMedicamentos.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnMedicamentos.Radius = 15;
            this.btnMedicamentos.Size = new System.Drawing.Size(181, 28);
            this.btnMedicamentos.TabIndex = 24;
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
            this.btnProductos.Location = new System.Drawing.Point(3, 201);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnProductos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProductos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProductos.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.OnHoverImage")));
            this.btnProductos.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnProductos.Radius = 15;
            this.btnProductos.Size = new System.Drawing.Size(181, 28);
            this.btnProductos.TabIndex = 25;
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
            this.btnClientes.Location = new System.Drawing.Point(3, 235);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnClientes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClientes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClientes.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.OnHoverImage")));
            this.btnClientes.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnClientes.Radius = 15;
            this.btnClientes.Size = new System.Drawing.Size(181, 28);
            this.btnClientes.TabIndex = 28;
            this.btnClientes.Text = " Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlDescControl
            // 
            this.pnlDescControl.Controls.Add(this.lblDescriptionControls);
            this.pnlDescControl.Location = new System.Drawing.Point(3, 269);
            this.pnlDescControl.Name = "pnlDescControl";
            this.pnlDescControl.Size = new System.Drawing.Size(181, 20);
            this.pnlDescControl.TabIndex = 27;
            // 
            // lblDescriptionControls
            // 
            this.lblDescriptionControls.AutoSize = true;
            this.lblDescriptionControls.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionControls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescriptionControls.Location = new System.Drawing.Point(2, 4);
            this.lblDescriptionControls.Name = "lblDescriptionControls";
            this.lblDescriptionControls.Size = new System.Drawing.Size(70, 13);
            this.lblDescriptionControls.TabIndex = 0;
            this.lblDescriptionControls.Text = "CONTROLES";
            this.lblDescriptionControls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnAjustes.Location = new System.Drawing.Point(3, 295);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnAjustes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAjustes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAjustes.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnAjustes.OnHoverImage")));
            this.btnAjustes.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnAjustes.Radius = 15;
            this.btnAjustes.Size = new System.Drawing.Size(181, 28);
            this.btnAjustes.TabIndex = 29;
            this.btnAjustes.Text = " Ajustes";
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
            this.btnLogOut.Location = new System.Drawing.Point(3, 329);
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
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlMenu.Controls.Add(this.SeparatorInventory);
            this.pnlMenu.Location = new System.Drawing.Point(196, 5);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMenu.MinimumSize = new System.Drawing.Size(600, 362);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnlMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlMenu.Size = new System.Drawing.Size(617, 362);
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
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(342, 17);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(35, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "label1";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(818, 412);
            this.Controls.Add(this.pnlMAIN);
            this.MinimumSize = new System.Drawing.Size(834, 451);
            this.Name = "PrincipalForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing);
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.SizeChanged += new System.EventHandler(this.PrincipalForm_SizeChanged);
            this.pnlMAIN.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.sidebarContainer.ResumeLayout(false);
            this.pnlDescInventario.ResumeLayout(false);
            this.pnlDescControl.ResumeLayout(false);
            this.pnlDescControl.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlDescInventario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescriptionInventorario;
        private Guna.UI.WinForms.GunaButton btnCategorias;
        private Guna.UI.WinForms.GunaButton btnEstantes;
        private Guna.UI.WinForms.GunaButton btnProveedores;
        private Guna.UI.WinForms.GunaButton btnMedicamentos;
        private Guna.UI.WinForms.GunaButton btnProductos;
        private Guna.UI.WinForms.GunaButton btnClientes;
        private System.Windows.Forms.Panel pnlDescControl;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescriptionControls;
        private Guna.UI.WinForms.GunaButton btnAjustes;
        private Guna.UI.WinForms.GunaButton btnLogOut;
        private System.Windows.Forms.Label lblSize;
    }
}