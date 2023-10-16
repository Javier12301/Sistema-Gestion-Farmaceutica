namespace Sistema.Vista
{
    partial class CategoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreCat = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblTitlePnl = new System.Windows.Forms.Label();
            this.pctLineSeparator = new System.Windows.Forms.PictureBox();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblDescE = new System.Windows.Forms.Label();
            this.txtDescripcionCat = new System.Windows.Forms.TextBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModifyG = new Guna.UI.WinForms.GunaButton();
            this.dgvCategoriesList = new Zuby.ADGV.AdvancedDataGridView();
            this.dgvcCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceCategories = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaGestionFarmaceuticaDataSet = new Sistema.SistemaGestionFarmaceuticaDataSet();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.btnGuardarG = new Guna.UI.WinForms.GunaButton();
            this.btnEliminarG = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.categoriasModelTableAdapter = new Sistema.SistemaGestionFarmaceuticaDataSetTableAdapters.CategoriasModelTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineSeparator)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaGestionFarmaceuticaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNombreCat);
            this.panel1.Controls.Add(this.lblTitlePnl);
            this.panel1.Controls.Add(this.pctLineSeparator);
            this.panel1.Controls.Add(this.lblNombreE);
            this.panel1.Controls.Add(this.lblDescE);
            this.panel1.Controls.Add(this.txtDescripcionCat);
            this.panel1.Controls.Add(this.pnlButton);
            this.panel1.Location = new System.Drawing.Point(9, 42);
            this.panel1.MaximumSize = new System.Drawing.Size(278, 300);
            this.panel1.MinimumSize = new System.Drawing.Size(278, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 286);
            this.panel1.TabIndex = 0;
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.BackColor = System.Drawing.Color.White;
            this.txtNombreCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCat.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtNombreCat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreCat.LineColor = System.Drawing.Color.LightGray;
            this.txtNombreCat.Location = new System.Drawing.Point(3, 61);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.PasswordChar = '\0';
            this.txtNombreCat.Size = new System.Drawing.Size(269, 26);
            this.txtNombreCat.TabIndex = 1;
            this.txtNombreCat.Enter += new System.EventHandler(this.txtNombreCat_Enter);
            // 
            // lblTitlePnl
            // 
            this.lblTitlePnl.AutoSize = true;
            this.lblTitlePnl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitlePnl.Location = new System.Drawing.Point(3, 5);
            this.lblTitlePnl.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblTitlePnl.Name = "lblTitlePnl";
            this.lblTitlePnl.Size = new System.Drawing.Size(131, 21);
            this.lblTitlePnl.TabIndex = 26;
            this.lblTitlePnl.Text = "Nueva Categoría";
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
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreE.Location = new System.Drawing.Point(4, 43);
            this.lblNombreE.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(51, 15);
            this.lblNombreE.TabIndex = 27;
            this.lblNombreE.Text = "Nombre";
            // 
            // lblDescE
            // 
            this.lblDescE.AutoSize = true;
            this.lblDescE.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescE.Location = new System.Drawing.Point(4, 97);
            this.lblDescE.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblDescE.Name = "lblDescE";
            this.lblDescE.Size = new System.Drawing.Size(70, 15);
            this.lblDescE.TabIndex = 29;
            this.lblDescE.Text = "Descripción";
            // 
            // txtDescripcionCat
            // 
            this.txtDescripcionCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDescripcionCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCat.Location = new System.Drawing.Point(3, 117);
            this.txtDescripcionCat.Margin = new System.Windows.Forms.Padding(10, 6, 3, 0);
            this.txtDescripcionCat.Multiline = true;
            this.txtDescripcionCat.Name = "txtDescripcionCat";
            this.txtDescripcionCat.Size = new System.Drawing.Size(269, 106);
            this.txtDescripcionCat.TabIndex = 2;
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlButton.Controls.Add(this.btnAgregar);
            this.pnlButton.Location = new System.Drawing.Point(2, 226);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(272, 55);
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
            this.btnAgregar.Location = new System.Drawing.Point(64, 7);
            this.btnAgregar.MaximumSize = new System.Drawing.Size(151, 40);
            this.btnAgregar.MinimumSize = new System.Drawing.Size(151, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 40);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(154)))));
            this.lblTitle.Location = new System.Drawing.Point(2, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 39);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Categorías";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnModifyG);
            this.panel2.Controls.Add(this.dgvCategoriesList);
            this.panel2.Controls.Add(this.lblTotalRow);
            this.panel2.Controls.Add(this.btnGuardarG);
            this.panel2.Controls.Add(this.btnEliminarG);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(298, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 325);
            this.panel2.TabIndex = 21;
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
            this.btnModifyG.TabIndex = 36;
            this.btnModifyG.Click += new System.EventHandler(this.btnModifyG_Click);
            // 
            // dgvCategoriesList
            // 
            this.dgvCategoriesList.AllowUserToAddRows = false;
            this.dgvCategoriesList.AllowUserToDeleteRows = false;
            this.dgvCategoriesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategoriesList.AutoGenerateColumns = false;
            this.dgvCategoriesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoriesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcCategoryID,
            this.dgvcCategoryName,
            this.dgvcCategoryDescription});
            this.dgvCategoriesList.DataSource = this.bindingSourceCategories;
            this.dgvCategoriesList.FilterAndSortEnabled = true;
            this.dgvCategoriesList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvCategoriesList.Location = new System.Drawing.Point(5, 36);
            this.dgvCategoriesList.Name = "dgvCategoriesList";
            this.dgvCategoriesList.ReadOnly = true;
            this.dgvCategoriesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCategoriesList.Size = new System.Drawing.Size(272, 256);
            this.dgvCategoriesList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvCategoriesList.TabIndex = 35;
            this.dgvCategoriesList.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvCategoriesList_SortStringChanged);
            this.dgvCategoriesList.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvCategoriesList_FilterStringChanged);
            this.dgvCategoriesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriesList_CellClick);
            this.dgvCategoriesList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriesList_CellEndEdit);
            this.dgvCategoriesList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriesList_CellEnter);
            this.dgvCategoriesList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCategoriesList_DataError);
            // 
            // dgvcCategoryID
            // 
            this.dgvcCategoryID.DataPropertyName = "CategoriaID";
            this.dgvcCategoryID.HeaderText = "ID";
            this.dgvcCategoryID.MinimumWidth = 22;
            this.dgvcCategoryID.Name = "dgvcCategoryID";
            this.dgvcCategoryID.ReadOnly = true;
            this.dgvcCategoryID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcCategoryName
            // 
            this.dgvcCategoryName.DataPropertyName = "Nombre";
            this.dgvcCategoryName.HeaderText = "Nombre";
            this.dgvcCategoryName.MinimumWidth = 22;
            this.dgvcCategoryName.Name = "dgvcCategoryName";
            this.dgvcCategoryName.ReadOnly = true;
            this.dgvcCategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcCategoryDescription
            // 
            this.dgvcCategoryDescription.DataPropertyName = "Descripcion";
            this.dgvcCategoryDescription.HeaderText = "Descripcion";
            this.dgvcCategoryDescription.MinimumWidth = 22;
            this.dgvcCategoryDescription.Name = "dgvcCategoryDescription";
            this.dgvcCategoryDescription.ReadOnly = true;
            this.dgvcCategoryDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // bindingSourceCategories
            // 
            this.bindingSourceCategories.DataMember = "CategoriasModel";
            this.bindingSourceCategories.DataSource = this.sistemaGestionFarmaceuticaDataSet;
            this.bindingSourceCategories.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSourceCategories_ListChanged);
            // 
            // sistemaGestionFarmaceuticaDataSet
            // 
            this.sistemaGestionFarmaceuticaDataSet.DataSetName = "SistemaGestionFarmaceuticaDataSet";
            this.sistemaGestionFarmaceuticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTotalRow
            // 
            this.lblTotalRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRow.AutoSize = true;
            this.lblTotalRow.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalRow.Location = new System.Drawing.Point(138, 298);
            this.lblTotalRow.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblTotalRow.Name = "lblTotalRow";
            this.lblTotalRow.Size = new System.Drawing.Size(100, 19);
            this.lblTotalRow.TabIndex = 34;
            this.lblTotalRow.Text = "Filas Totales: n";
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
            this.btnGuardarG.TabIndex = 23;
            this.btnGuardarG.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnEliminarG.TabIndex = 22;
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
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lista de Categorías";
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
            // categoriasModelTableAdapter
            // 
            this.categoriasModelTableAdapter.ClearBeforeFill = true;
            // 
            // CategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(589, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriaForm";
            this.Text = "agregarCategorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineSeparator)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaGestionFarmaceuticaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitlePnl;
        private System.Windows.Forms.PictureBox pctLineSeparator;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblDescE;
        private System.Windows.Forms.TextBox txtDescripcionCat;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaLineTextBox txtNombreCat;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnModifyG;
        private Zuby.ADGV.AdvancedDataGridView dgvCategoriesList;
        private System.Windows.Forms.Label lblTotalRow;
        private Guna.UI.WinForms.GunaButton btnGuardarG;
        private Guna.UI.WinForms.GunaButton btnEliminarG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private SistemaGestionFarmaceuticaDataSet sistemaGestionFarmaceuticaDataSet;
        private System.Windows.Forms.BindingSource bindingSourceCategories;
        private SistemaGestionFarmaceuticaDataSetTableAdapters.CategoriasModelTableAdapter categoriasModelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCategoryDescription;
    }
}