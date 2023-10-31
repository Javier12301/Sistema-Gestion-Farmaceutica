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
            this.btnModifyG = new Guna.UI.WinForms.GunaButton();
            this.dgvSupplierList = new Zuby.ADGV.AdvancedDataGridView();
            this.dgvcSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSupplierDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSupplierPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSupplier = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaGestionFarmaceuticaDataSet = new Sistema.SistemaGestionFarmaceuticaDataSet();
            this.btnGuardarG = new Guna.UI.WinForms.GunaButton();
            this.btnEliminarG = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTelefonoP = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtDireccionP = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtNombreP = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblTitlePnl = new System.Windows.Forms.Label();
            this.pctLineSeparator = new System.Windows.Forms.PictureBox();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblDireccionP = new System.Windows.Forms.Label();
            this.lblTelefonoP = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.proveedoresModelTableAdapter = new Sistema.SistemaGestionFarmaceuticaDataSetTableAdapters.ProveedoresModelTableAdapter();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaGestionFarmaceuticaDataSet)).BeginInit();
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
            this.panel2.TabIndex = 6;
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
            this.btnModifyG.TabIndex = 8;
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
            this.dgvSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcSupplierID,
            this.dgvcSupplierName,
            this.dgvcSupplierDirection,
            this.dgvcSupplierPhoneNumber});
            this.dgvSupplierList.DataSource = this.bindingSourceSupplier;
            this.dgvSupplierList.FilterAndSortEnabled = true;
            this.dgvSupplierList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvSupplierList.Location = new System.Drawing.Point(5, 36);
            this.dgvSupplierList.Name = "dgvSupplierList";
            this.dgvSupplierList.ReadOnly = true;
            this.dgvSupplierList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSupplierList.Size = new System.Drawing.Size(272, 256);
            this.dgvSupplierList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvSupplierList.TabIndex = 35;
            this.dgvSupplierList.TabStop = false;
            this.dgvSupplierList.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvSupplierList_SortStringChanged);
            this.dgvSupplierList.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvSupplierList_FilterStringChanged);
            this.dgvSupplierList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierList_CellClick);
            this.dgvSupplierList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierList_CellEndEdit);
            this.dgvSupplierList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierList_CellEnter);
            // 
            // dgvcSupplierID
            // 
            this.dgvcSupplierID.DataPropertyName = "ProveedorID";
            this.dgvcSupplierID.HeaderText = "ID";
            this.dgvcSupplierID.MinimumWidth = 22;
            this.dgvcSupplierID.Name = "dgvcSupplierID";
            this.dgvcSupplierID.ReadOnly = true;
            this.dgvcSupplierID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcSupplierName
            // 
            this.dgvcSupplierName.DataPropertyName = "Nombre";
            this.dgvcSupplierName.HeaderText = "Nombre";
            this.dgvcSupplierName.MinimumWidth = 22;
            this.dgvcSupplierName.Name = "dgvcSupplierName";
            this.dgvcSupplierName.ReadOnly = true;
            this.dgvcSupplierName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcSupplierDirection
            // 
            this.dgvcSupplierDirection.DataPropertyName = "Direccion";
            this.dgvcSupplierDirection.HeaderText = "Direccion";
            this.dgvcSupplierDirection.MinimumWidth = 22;
            this.dgvcSupplierDirection.Name = "dgvcSupplierDirection";
            this.dgvcSupplierDirection.ReadOnly = true;
            this.dgvcSupplierDirection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcSupplierPhoneNumber
            // 
            this.dgvcSupplierPhoneNumber.DataPropertyName = "Telefono";
            this.dgvcSupplierPhoneNumber.HeaderText = "Telefono";
            this.dgvcSupplierPhoneNumber.MinimumWidth = 22;
            this.dgvcSupplierPhoneNumber.Name = "dgvcSupplierPhoneNumber";
            this.dgvcSupplierPhoneNumber.ReadOnly = true;
            this.dgvcSupplierPhoneNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // bindingSourceSupplier
            // 
            this.bindingSourceSupplier.DataMember = "ProveedoresModel";
            this.bindingSourceSupplier.DataSource = this.sistemaGestionFarmaceuticaDataSet;
            this.bindingSourceSupplier.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSourceSupplier_ListChanged);
            // 
            // sistemaGestionFarmaceuticaDataSet
            // 
            this.sistemaGestionFarmaceuticaDataSet.DataSetName = "SistemaGestionFarmaceuticaDataSet";
            this.sistemaGestionFarmaceuticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnGuardarG.TabIndex = 7;
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
            this.btnEliminarG.TabIndex = 9;
            this.btnEliminarG.Click += new System.EventHandler(this.btnEliminarG_Click);
            this.btnEliminarG.MouseEnter += new System.EventHandler(this.btnEliminarG_MouseEnter);
            this.btnEliminarG.MouseLeave += new System.EventHandler(this.btnEliminarG_MouseLeave);
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
            this.label1.TabIndex = 20;
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
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Proveedores";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTelefonoP);
            this.panel1.Controls.Add(this.txtDireccionP);
            this.panel1.Controls.Add(this.txtNombreP);
            this.panel1.Controls.Add(this.lblTitlePnl);
            this.panel1.Controls.Add(this.pctLineSeparator);
            this.panel1.Controls.Add(this.lblNombreP);
            this.panel1.Controls.Add(this.lblDireccionP);
            this.panel1.Controls.Add(this.lblTelefonoP);
            this.panel1.Controls.Add(this.pnlButton);
            this.panel1.Location = new System.Drawing.Point(9, 42);
            this.panel1.MaximumSize = new System.Drawing.Size(278, 286);
            this.panel1.MinimumSize = new System.Drawing.Size(278, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 286);
            this.panel1.TabIndex = 1;
            // 
            // txtTelefonoP
            // 
            this.txtTelefonoP.BackColor = System.Drawing.Color.White;
            this.txtTelefonoP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoP.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtTelefonoP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefonoP.LineColor = System.Drawing.Color.LightGray;
            this.txtTelefonoP.Location = new System.Drawing.Point(4, 171);
            this.txtTelefonoP.Name = "txtTelefonoP";
            this.txtTelefonoP.PasswordChar = '\0';
            this.txtTelefonoP.Size = new System.Drawing.Size(269, 26);
            this.txtTelefonoP.TabIndex = 3;
            this.txtTelefonoP.Enter += new System.EventHandler(this.txtTelefonoP_Enter);
            // 
            // txtDireccionP
            // 
            this.txtDireccionP.BackColor = System.Drawing.Color.White;
            this.txtDireccionP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccionP.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtDireccionP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccionP.LineColor = System.Drawing.Color.LightGray;
            this.txtDireccionP.Location = new System.Drawing.Point(4, 117);
            this.txtDireccionP.Name = "txtDireccionP";
            this.txtDireccionP.PasswordChar = '\0';
            this.txtDireccionP.Size = new System.Drawing.Size(269, 26);
            this.txtDireccionP.TabIndex = 2;
            this.txtDireccionP.Enter += new System.EventHandler(this.txtDireccionP_Enter);
            // 
            // txtNombreP
            // 
            this.txtNombreP.BackColor = System.Drawing.Color.White;
            this.txtNombreP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreP.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtNombreP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreP.LineColor = System.Drawing.Color.LightGray;
            this.txtNombreP.Location = new System.Drawing.Point(4, 63);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.PasswordChar = '\0';
            this.txtNombreP.Size = new System.Drawing.Size(269, 26);
            this.txtNombreP.TabIndex = 1;
            this.txtNombreP.Enter += new System.EventHandler(this.txtNombreP_Enter);
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
            this.lblTitlePnl.TabIndex = 26;
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
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreP.Location = new System.Drawing.Point(4, 43);
            this.lblNombreP.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(51, 15);
            this.lblNombreP.TabIndex = 1;
            this.lblNombreP.Text = "Nombre";
            // 
            // lblDireccionP
            // 
            this.lblDireccionP.AutoSize = true;
            this.lblDireccionP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDireccionP.Location = new System.Drawing.Point(4, 97);
            this.lblDireccionP.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblDireccionP.Name = "lblDireccionP";
            this.lblDireccionP.Size = new System.Drawing.Size(58, 15);
            this.lblDireccionP.TabIndex = 3;
            this.lblDireccionP.Text = "Dirección";
            // 
            // lblTelefonoP
            // 
            this.lblTelefonoP.AutoSize = true;
            this.lblTelefonoP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefonoP.Location = new System.Drawing.Point(4, 154);
            this.lblTelefonoP.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblTelefonoP.Name = "lblTelefonoP";
            this.lblTelefonoP.Size = new System.Drawing.Size(112, 15);
            this.lblTelefonoP.TabIndex = 5;
            this.lblTelefonoP.Text = "Teléfono (Opcional)";
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlButton.Controls.Add(this.btnAgregar);
            this.pnlButton.Location = new System.Drawing.Point(2, 218);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(272, 53);
            this.pnlButton.TabIndex = 33;
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
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // proveedoresModelTableAdapter
            // 
            this.proveedoresModelTableAdapter.ClearBeforeFill = true;
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
            this.lblTotalRow.TabIndex = 36;
            this.lblTotalRow.Text = "Filas Totales: n";
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
            ((System.ComponentModel.ISupportInitialize)(this.sistemaGestionFarmaceuticaDataSet)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLineTextBox txtTelefonoP;
        private Guna.UI.WinForms.GunaLineTextBox txtDireccionP;
        private Guna.UI.WinForms.GunaLineTextBox txtNombreP;
        private System.Windows.Forms.Label lblTitlePnl;
        private System.Windows.Forms.PictureBox pctLineSeparator;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblDireccionP;
        private System.Windows.Forms.Label lblTelefonoP;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnAgregar;
        private SistemaGestionFarmaceuticaDataSet sistemaGestionFarmaceuticaDataSet;
        private System.Windows.Forms.BindingSource bindingSourceSupplier;
        private SistemaGestionFarmaceuticaDataSetTableAdapters.ProveedoresModelTableAdapter proveedoresModelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSupplierDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSupplierPhoneNumber;
        private System.Windows.Forms.Label lblTotalRow;
    }
}