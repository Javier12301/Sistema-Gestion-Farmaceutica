namespace Sistema.Views
{
    partial class ProveedoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.btnModifyG = new Guna.UI.WinForms.GunaButton();
            this.dgvSupplierList = new Zuby.ADGV.AdvancedDataGridView();
            this.bindingSourceSupplier = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaDBDataSet = new Sistema.FarmaciaDBDataSet();
            this.btnGuardarG = new Guna.UI.WinForms.GunaButton();
            this.btnEliminarG = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefonoP_G = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtDocumentoP_G = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtCorreoP_G = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtDireccionP_G = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtNombreP_G = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblTitlePnl = new System.Windows.Forms.Label();
            this.pctLineSeparator = new System.Windows.Forms.PictureBox();
            this.lblRazonSocialP = new System.Windows.Forms.Label();
            this.lblDireccionP = new System.Windows.Forms.Label();
            this.lblTelefonoP = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pROVEEDORTableAdapter = new Sistema.FarmaciaDBDataSetTableAdapters.PROVEEDORTableAdapter();
            this.dgvcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcRazonSocialP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDocumentoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDireccionP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcTelefonoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCorreoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineSeparator)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalRow);
            this.panel2.Controls.Add(this.btnModifyG);
            this.panel2.Controls.Add(this.dgvSupplierList);
            this.panel2.Controls.Add(this.btnGuardarG);
            this.panel2.Controls.Add(this.btnEliminarG);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(299, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 325);
            this.panel2.TabIndex = 8;
            // 
            // lblTotalRow
            // 
            this.lblTotalRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRow.AutoSize = true;
            this.lblTotalRow.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalRow.Location = new System.Drawing.Point(108, 298);
            this.lblTotalRow.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblTotalRow.Name = "lblTotalRow";
            this.lblTotalRow.Size = new System.Drawing.Size(100, 19);
            this.lblTotalRow.TabIndex = 0;
            this.lblTotalRow.Text = "Filas Totales: n";
            // 
            // btnModifyG
            // 
            this.btnModifyG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyG.Animated = true;
            this.btnModifyG.AnimationHoverSpeed = 0.07F;
            this.btnModifyG.AnimationSpeed = 0.03F;
            this.btnModifyG.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyG.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(104)))));
            this.btnModifyG.BorderColor = System.Drawing.Color.Black;
            this.btnModifyG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModifyG.FocusedColor = System.Drawing.Color.Empty;
            this.btnModifyG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModifyG.ForeColor = System.Drawing.Color.White;
            this.btnModifyG.Image = global::Sistema.Properties.Resources.PencilIcon;
            this.btnModifyG.ImageSize = new System.Drawing.Size(15, 15);
            this.btnModifyG.Location = new System.Drawing.Point(206, 2);
            this.btnModifyG.Name = "btnModifyG";
            this.btnModifyG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(104)))));
            this.btnModifyG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModifyG.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModifyG.OnHoverImage = null;
            this.btnModifyG.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.btnModifyG.Radius = 8;
            this.btnModifyG.Size = new System.Drawing.Size(35, 25);
            this.btnModifyG.TabIndex = 10;
            this.btnModifyG.Click += new System.EventHandler(this.btnModifyG_Click);
            // 
            // dgvSupplierList
            // 
            this.dgvSupplierList.AllowUserToAddRows = false;
            this.dgvSupplierList.AllowUserToDeleteRows = false;
            this.dgvSupplierList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupplierList.AutoGenerateColumns = false;
            this.dgvSupplierList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplierList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSupplierList.ColumnHeadersHeight = 32;
            this.dgvSupplierList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcID,
            this.dgvcRazonSocialP,
            this.dgvcDocumentoP,
            this.dgvcDireccionP,
            this.dgvcTelefonoP,
            this.dgvcCorreoP});
            this.dgvSupplierList.DataSource = this.bindingSourceSupplier;
            this.dgvSupplierList.FilterAndSortEnabled = true;
            this.dgvSupplierList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvSupplierList.Location = new System.Drawing.Point(5, 36);
            this.dgvSupplierList.Name = "dgvSupplierList";
            this.dgvSupplierList.ReadOnly = true;
            this.dgvSupplierList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSupplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplierList.Size = new System.Drawing.Size(272, 256);
            this.dgvSupplierList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvSupplierList.TabIndex = 0;
            this.dgvSupplierList.TabStop = false;
            this.dgvSupplierList.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvSupplierList_SortStringChanged);
            this.dgvSupplierList.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvSupplierList_FilterStringChanged);
            this.dgvSupplierList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierList_CellClick);
            this.dgvSupplierList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierList_CellEndEdit);
            this.dgvSupplierList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierList_CellEnter);
            // 
            // bindingSourceSupplier
            // 
            this.bindingSourceSupplier.DataMember = "PROVEEDOR";
            this.bindingSourceSupplier.DataSource = this.farmaciaDBDataSet;
            // 
            // farmaciaDBDataSet
            // 
            this.farmaciaDBDataSet.DataSetName = "FarmaciaDBDataSet";
            this.farmaciaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGuardarG
            // 
            this.btnGuardarG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarG.Animated = true;
            this.btnGuardarG.AnimationHoverSpeed = 0.07F;
            this.btnGuardarG.AnimationSpeed = 0.03F;
            this.btnGuardarG.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarG.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(131)))), ((int)(((byte)(173)))));
            this.btnGuardarG.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardarG.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardarG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardarG.ForeColor = System.Drawing.Color.White;
            this.btnGuardarG.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarG.Image")));
            this.btnGuardarG.ImageSize = new System.Drawing.Size(15, 15);
            this.btnGuardarG.Location = new System.Drawing.Point(165, 2);
            this.btnGuardarG.Name = "btnGuardarG";
            this.btnGuardarG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(141)))), ((int)(((byte)(187)))));
            this.btnGuardarG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardarG.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardarG.OnHoverImage = null;
            this.btnGuardarG.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(95)))), ((int)(((byte)(126)))));
            this.btnGuardarG.Radius = 8;
            this.btnGuardarG.Size = new System.Drawing.Size(35, 25);
            this.btnGuardarG.TabIndex = 9;
            this.btnGuardarG.Click += new System.EventHandler(this.btnGuardarG_Click);
            // 
            // btnEliminarG
            // 
            this.btnEliminarG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarG.Animated = true;
            this.btnEliminarG.AnimationHoverSpeed = 0.07F;
            this.btnEliminarG.AnimationSpeed = 0.03F;
            this.btnEliminarG.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarG.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(38)))), ((int)(((byte)(75)))));
            this.btnEliminarG.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminarG.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarG.ForeColor = System.Drawing.Color.White;
            this.btnEliminarG.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarG.Image")));
            this.btnEliminarG.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminarG.ImageSize = new System.Drawing.Size(18, 18);
            this.btnEliminarG.Location = new System.Drawing.Point(247, 2);
            this.btnEliminarG.Name = "btnEliminarG";
            this.btnEliminarG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnEliminarG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarG.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarG.OnHoverImage = null;
            this.btnEliminarG.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.btnEliminarG.Radius = 5;
            this.btnEliminarG.Size = new System.Drawing.Size(34, 25);
            this.btnEliminarG.TabIndex = 11;
            this.btnEliminarG.Click += new System.EventHandler(this.btnEliminarG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Proveedores";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 2);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "txtUser";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(154)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Proveedores";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTelefonoP_G);
            this.panel1.Controls.Add(this.txtDocumentoP_G);
            this.panel1.Controls.Add(this.lblDocumento);
            this.panel1.Controls.Add(this.txtCorreoP_G);
            this.panel1.Controls.Add(this.txtDireccionP_G);
            this.panel1.Controls.Add(this.txtNombreP_G);
            this.panel1.Controls.Add(this.lblTitlePnl);
            this.panel1.Controls.Add(this.pctLineSeparator);
            this.panel1.Controls.Add(this.lblRazonSocialP);
            this.panel1.Controls.Add(this.lblDireccionP);
            this.panel1.Controls.Add(this.lblTelefonoP);
            this.panel1.Controls.Add(this.pnlButton);
            this.panel1.Location = new System.Drawing.Point(9, 42);
            this.panel1.MaximumSize = new System.Drawing.Size(278, 286);
            this.panel1.MinimumSize = new System.Drawing.Size(278, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 286);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(148, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teléfono (Opcional)";
            // 
            // txtTelefonoP_G
            // 
            this.txtTelefonoP_G.BackColor = System.Drawing.Color.White;
            this.txtTelefonoP_G.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoP_G.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtTelefonoP_G.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefonoP_G.LineColor = System.Drawing.Color.LightGray;
            this.txtTelefonoP_G.Location = new System.Drawing.Point(151, 117);
            this.txtTelefonoP_G.Name = "txtTelefonoP_G";
            this.txtTelefonoP_G.PasswordChar = '\0';
            this.txtTelefonoP_G.Size = new System.Drawing.Size(122, 26);
            this.txtTelefonoP_G.TabIndex = 4;
            // 
            // txtDocumentoP_G
            // 
            this.txtDocumentoP_G.BackColor = System.Drawing.Color.White;
            this.txtDocumentoP_G.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumentoP_G.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtDocumentoP_G.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocumentoP_G.LineColor = System.Drawing.Color.LightGray;
            this.txtDocumentoP_G.Location = new System.Drawing.Point(151, 61);
            this.txtDocumentoP_G.Name = "txtDocumentoP_G";
            this.txtDocumentoP_G.PasswordChar = '\0';
            this.txtDocumentoP_G.Size = new System.Drawing.Size(122, 26);
            this.txtDocumentoP_G.TabIndex = 2;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDocumento.Location = new System.Drawing.Point(148, 43);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(105, 15);
            this.lblDocumento.TabIndex = 0;
            this.lblDocumento.Text = "Nro. Documento *";
            // 
            // txtCorreoP_G
            // 
            this.txtCorreoP_G.BackColor = System.Drawing.Color.White;
            this.txtCorreoP_G.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreoP_G.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtCorreoP_G.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreoP_G.LineColor = System.Drawing.Color.LightGray;
            this.txtCorreoP_G.Location = new System.Drawing.Point(4, 171);
            this.txtCorreoP_G.Name = "txtCorreoP_G";
            this.txtCorreoP_G.PasswordChar = '\0';
            this.txtCorreoP_G.Size = new System.Drawing.Size(269, 26);
            this.txtCorreoP_G.TabIndex = 5;
            // 
            // txtDireccionP_G
            // 
            this.txtDireccionP_G.BackColor = System.Drawing.Color.White;
            this.txtDireccionP_G.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccionP_G.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtDireccionP_G.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccionP_G.LineColor = System.Drawing.Color.LightGray;
            this.txtDireccionP_G.Location = new System.Drawing.Point(4, 117);
            this.txtDireccionP_G.Name = "txtDireccionP_G";
            this.txtDireccionP_G.PasswordChar = '\0';
            this.txtDireccionP_G.Size = new System.Drawing.Size(125, 26);
            this.txtDireccionP_G.TabIndex = 3;
            // 
            // txtNombreP_G
            // 
            this.txtNombreP_G.BackColor = System.Drawing.Color.White;
            this.txtNombreP_G.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreP_G.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtNombreP_G.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreP_G.LineColor = System.Drawing.Color.LightGray;
            this.txtNombreP_G.Location = new System.Drawing.Point(7, 61);
            this.txtNombreP_G.Name = "txtNombreP_G";
            this.txtNombreP_G.PasswordChar = '\0';
            this.txtNombreP_G.Size = new System.Drawing.Size(122, 26);
            this.txtNombreP_G.TabIndex = 1;
            // 
            // lblTitlePnl
            // 
            this.lblTitlePnl.AutoSize = true;
            this.lblTitlePnl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitlePnl.Location = new System.Drawing.Point(3, 5);
            this.lblTitlePnl.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblTitlePnl.Name = "lblTitlePnl";
            this.lblTitlePnl.Size = new System.Drawing.Size(139, 21);
            this.lblTitlePnl.TabIndex = 0;
            this.lblTitlePnl.Text = "Nuevo Proveedor";
            // 
            // pctLineSeparator
            // 
            this.pctLineSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pctLineSeparator.Location = new System.Drawing.Point(1, 28);
            this.pctLineSeparator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.pctLineSeparator.Name = "pctLineSeparator";
            this.pctLineSeparator.Size = new System.Drawing.Size(276, 2);
            this.pctLineSeparator.TabIndex = 25;
            this.pctLineSeparator.TabStop = false;
            this.pctLineSeparator.Tag = "txtUser";
            // 
            // lblRazonSocialP
            // 
            this.lblRazonSocialP.AutoSize = true;
            this.lblRazonSocialP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocialP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRazonSocialP.Location = new System.Drawing.Point(4, 43);
            this.lblRazonSocialP.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblRazonSocialP.Name = "lblRazonSocialP";
            this.lblRazonSocialP.Size = new System.Drawing.Size(83, 15);
            this.lblRazonSocialP.TabIndex = 0;
            this.lblRazonSocialP.Text = "Razon Social *";
            // 
            // lblDireccionP
            // 
            this.lblDireccionP.AutoSize = true;
            this.lblDireccionP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDireccionP.Location = new System.Drawing.Point(4, 97);
            this.lblDireccionP.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblDireccionP.Name = "lblDireccionP";
            this.lblDireccionP.Size = new System.Drawing.Size(66, 15);
            this.lblDireccionP.TabIndex = 0;
            this.lblDireccionP.Text = "Dirección *";
            // 
            // lblTelefonoP
            // 
            this.lblTelefonoP.AutoSize = true;
            this.lblTelefonoP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefonoP.Location = new System.Drawing.Point(4, 154);
            this.lblTelefonoP.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblTelefonoP.Name = "lblTelefonoP";
            this.lblTelefonoP.Size = new System.Drawing.Size(171, 15);
            this.lblTelefonoP.TabIndex = 0;
            this.lblTelefonoP.Text = "Dirección de Correo (Opcional)";
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlButton.Controls.Add(this.btnAgregar);
            this.pnlButton.Location = new System.Drawing.Point(2, 218);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(272, 53);
            this.pnlButton.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(64, 5);
            this.btnAgregar.MaximumSize = new System.Drawing.Size(151, 40);
            this.btnAgregar.MinimumSize = new System.Drawing.Size(151, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 38);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pROVEEDORTableAdapter
            // 
            this.pROVEEDORTableAdapter.ClearBeforeFill = true;
            // 
            // dgvcID
            // 
            this.dgvcID.DataPropertyName = "ProveedorID";
            this.dgvcID.FillWeight = 63.9594F;
            this.dgvcID.HeaderText = "ID";
            this.dgvcID.MinimumWidth = 22;
            this.dgvcID.Name = "dgvcID";
            this.dgvcID.ReadOnly = true;
            this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcID.Visible = false;
            // 
            // dgvcRazonSocialP
            // 
            this.dgvcRazonSocialP.DataPropertyName = "RazonSocial";
            this.dgvcRazonSocialP.FillWeight = 107.2082F;
            this.dgvcRazonSocialP.HeaderText = "Razon Social";
            this.dgvcRazonSocialP.MinimumWidth = 22;
            this.dgvcRazonSocialP.Name = "dgvcRazonSocialP";
            this.dgvcRazonSocialP.ReadOnly = true;
            this.dgvcRazonSocialP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcDocumentoP
            // 
            this.dgvcDocumentoP.DataPropertyName = "Documento";
            this.dgvcDocumentoP.FillWeight = 107.2082F;
            this.dgvcDocumentoP.HeaderText = "Documento";
            this.dgvcDocumentoP.MinimumWidth = 22;
            this.dgvcDocumentoP.Name = "dgvcDocumentoP";
            this.dgvcDocumentoP.ReadOnly = true;
            this.dgvcDocumentoP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcDireccionP
            // 
            this.dgvcDireccionP.DataPropertyName = "Direccion";
            this.dgvcDireccionP.FillWeight = 107.2082F;
            this.dgvcDireccionP.HeaderText = "Direccion";
            this.dgvcDireccionP.MinimumWidth = 22;
            this.dgvcDireccionP.Name = "dgvcDireccionP";
            this.dgvcDireccionP.ReadOnly = true;
            this.dgvcDireccionP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcTelefonoP
            // 
            this.dgvcTelefonoP.DataPropertyName = "TelefonoProveedor";
            this.dgvcTelefonoP.FillWeight = 107.2082F;
            this.dgvcTelefonoP.HeaderText = "Telefono";
            this.dgvcTelefonoP.MinimumWidth = 22;
            this.dgvcTelefonoP.Name = "dgvcTelefonoP";
            this.dgvcTelefonoP.ReadOnly = true;
            this.dgvcTelefonoP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcCorreoP
            // 
            this.dgvcCorreoP.DataPropertyName = "Correo";
            this.dgvcCorreoP.FillWeight = 107.2082F;
            this.dgvcCorreoP.HeaderText = "Correo";
            this.dgvcCorreoP.MinimumWidth = 22;
            this.dgvcCorreoP.Name = "dgvcCorreoP";
            this.dgvcCorreoP.ReadOnly = true;
            this.dgvcCorreoP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ProveedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProveedoresForm";
            this.Text = "ProveedoresForm";
            this.Load += new System.EventHandler(this.ProveedoresForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineSeparator)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnModifyG;
        private Zuby.ADGV.AdvancedDataGridView dgvSupplierList;
        private Guna.UI.WinForms.GunaButton btnGuardarG;
        private Guna.UI.WinForms.GunaButton btnEliminarG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalRow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox txtTelefonoP_G;
        private Guna.UI.WinForms.GunaLineTextBox txtDocumentoP_G;
        private System.Windows.Forms.Label lblDocumento;
        private Guna.UI.WinForms.GunaLineTextBox txtCorreoP_G;
        private Guna.UI.WinForms.GunaLineTextBox txtDireccionP_G;
        private Guna.UI.WinForms.GunaLineTextBox txtNombreP_G;
        private System.Windows.Forms.Label lblTitlePnl;
        private System.Windows.Forms.PictureBox pctLineSeparator;
        private System.Windows.Forms.Label lblRazonSocialP;
        private System.Windows.Forms.Label lblDireccionP;
        private System.Windows.Forms.Label lblTelefonoP;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnAgregar;
        private FarmaciaDBDataSet farmaciaDBDataSet;
        private System.Windows.Forms.BindingSource bindingSourceSupplier;
        private FarmaciaDBDataSetTableAdapters.PROVEEDORTableAdapter pROVEEDORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcRazonSocialP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDocumentoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDireccionP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTelefonoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCorreoP;
    }
}