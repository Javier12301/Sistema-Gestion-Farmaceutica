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
            this.cmbEstadoCat = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombreCat = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblTitlePnl = new System.Windows.Forms.Label();
            this.pctLineSeparator = new System.Windows.Forms.PictureBox();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblDescE = new System.Windows.Forms.Label();
            this.txtDescripcionCat = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFilasTotales = new System.Windows.Forms.Label();
            this.btnModificarG = new Guna.UI.WinForms.GunaButton();
            this.dgvCategoria = new Zuby.ADGV.AdvancedDataGridView();
            this.dgvcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaDBDataSet = new Sistema.FarmaciaDBDataSet();
            this.btnGuardarG = new Guna.UI.WinForms.GunaButton();
            this.btnEliminarG = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cATEGORIATableAdapter = new Sistema.FarmaciaDBDataSetTableAdapters.CATEGORIATableAdapter();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineSeparator)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlButton);
            this.panel1.Controls.Add(this.cmbEstadoCat);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.txtNombreCat);
            this.panel1.Controls.Add(this.lblTitlePnl);
            this.panel1.Controls.Add(this.pctLineSeparator);
            this.panel1.Controls.Add(this.lblNombreE);
            this.panel1.Controls.Add(this.lblDescE);
            this.panel1.Controls.Add(this.txtDescripcionCat);
            this.panel1.Location = new System.Drawing.Point(9, 42);
            this.panel1.MaximumSize = new System.Drawing.Size(278, 300);
            this.panel1.MinimumSize = new System.Drawing.Size(278, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 270);
            this.panel1.TabIndex = 0;
            // 
            // cmbEstadoCat
            // 
            this.cmbEstadoCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbEstadoCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoCat.FormattingEnabled = true;
            this.cmbEstadoCat.IntegralHeight = false;
            this.cmbEstadoCat.ItemHeight = 21;
            this.cmbEstadoCat.Location = new System.Drawing.Point(3, 170);
            this.cmbEstadoCat.Name = "cmbEstadoCat";
            this.cmbEstadoCat.Size = new System.Drawing.Size(269, 29);
            this.cmbEstadoCat.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstado.Location = new System.Drawing.Point(4, 152);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado";
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
            this.lblTitlePnl.TabIndex = 0;
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
            this.lblNombreE.Size = new System.Drawing.Size(59, 15);
            this.lblNombreE.TabIndex = 0;
            this.lblNombreE.Text = "Nombre *";
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
            this.lblDescE.TabIndex = 0;
            this.lblDescE.Text = "Descripción";
            // 
            // txtDescripcionCat
            // 
            this.txtDescripcionCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCat.Location = new System.Drawing.Point(3, 117);
            this.txtDescripcionCat.Margin = new System.Windows.Forms.Padding(10, 6, 3, 0);
            this.txtDescripcionCat.Name = "txtDescripcionCat";
            this.txtDescripcionCat.Size = new System.Drawing.Size(269, 25);
            this.txtDescripcionCat.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(154)))));
            this.lblTitulo.Location = new System.Drawing.Point(2, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(113, 39);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Categorías";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.btnModificarG);
            this.panel2.Controls.Add(this.dgvCategoria);
            this.panel2.Controls.Add(this.btnGuardarG);
            this.panel2.Controls.Add(this.btnEliminarG);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(298, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 325);
            this.panel2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lblFilasTotales);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 294);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(108, 25);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // lblFilasTotales
            // 
            this.lblFilasTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilasTotales.AutoSize = true;
            this.lblFilasTotales.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilasTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFilasTotales.Location = new System.Drawing.Point(5, 6);
            this.lblFilasTotales.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblFilasTotales.Name = "lblFilasTotales";
            this.lblFilasTotales.Size = new System.Drawing.Size(100, 19);
            this.lblFilasTotales.TabIndex = 12;
            this.lblFilasTotales.Text = "Filas Totales: n";
            // 
            // btnModificarG
            // 
            this.btnModificarG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarG.Animated = true;
            this.btnModificarG.AnimationHoverSpeed = 0.07F;
            this.btnModificarG.AnimationSpeed = 0.03F;
            this.btnModificarG.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarG.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(104)))));
            this.btnModificarG.BorderColor = System.Drawing.Color.Black;
            this.btnModificarG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificarG.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificarG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificarG.ForeColor = System.Drawing.Color.White;
            this.btnModificarG.Image = global::Sistema.Properties.Resources.PencilIcon;
            this.btnModificarG.ImageSize = new System.Drawing.Size(15, 15);
            this.btnModificarG.Location = new System.Drawing.Point(206, 2);
            this.btnModificarG.Name = "btnModificarG";
            this.btnModificarG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(104)))));
            this.btnModificarG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificarG.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificarG.OnHoverImage = null;
            this.btnModificarG.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.btnModificarG.Radius = 8;
            this.btnModificarG.Size = new System.Drawing.Size(35, 25);
            this.btnModificarG.TabIndex = 8;
            this.btnModificarG.Click += new System.EventHandler(this.btnModifyG_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategoria.AutoGenerateColumns = false;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCategoria.ColumnHeadersHeight = 30;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcID,
            this.dgvcNombre,
            this.dgvcDescripcion,
            this.dgvcEstado,
            this.dgvcFechaRegistro});
            this.dgvCategoria.DataSource = this.cATEGORIABindingSource;
            this.dgvCategoria.FilterAndSortEnabled = true;
            this.dgvCategoria.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvCategoria.Location = new System.Drawing.Point(5, 36);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCategoria.Size = new System.Drawing.Size(272, 256);
            this.dgvCategoria.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvCategoria.TabIndex = 10;
            this.dgvCategoria.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvCategoriesList_SortStringChanged);
            this.dgvCategoria.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvCategoriesList_FilterStringChanged);
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriesList_CellClick);
            this.dgvCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriesList_CellContentClick);
            this.dgvCategoria.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriesList_CellEndEdit);
            this.dgvCategoria.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriesList_CellEnter);
            this.dgvCategoria.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCategoriesList_DataError);
            // 
            // dgvcID
            // 
            this.dgvcID.DataPropertyName = "CategoriaID";
            this.dgvcID.HeaderText = "CategoriaID";
            this.dgvcID.MinimumWidth = 22;
            this.dgvcID.Name = "dgvcID";
            this.dgvcID.ReadOnly = true;
            this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcID.Visible = false;
            // 
            // dgvcNombre
            // 
            this.dgvcNombre.DataPropertyName = "Nombre";
            this.dgvcNombre.HeaderText = "Nombre";
            this.dgvcNombre.MinimumWidth = 22;
            this.dgvcNombre.Name = "dgvcNombre";
            this.dgvcNombre.ReadOnly = true;
            this.dgvcNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcDescripcion
            // 
            this.dgvcDescripcion.DataPropertyName = "Descripcion";
            this.dgvcDescripcion.HeaderText = "Descripcion";
            this.dgvcDescripcion.MinimumWidth = 22;
            this.dgvcDescripcion.Name = "dgvcDescripcion";
            this.dgvcDescripcion.ReadOnly = true;
            this.dgvcDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcEstado
            // 
            this.dgvcEstado.DataPropertyName = "Estado";
            this.dgvcEstado.HeaderText = "Estado";
            this.dgvcEstado.MinimumWidth = 22;
            this.dgvcEstado.Name = "dgvcEstado";
            this.dgvcEstado.ReadOnly = true;
            this.dgvcEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcFechaRegistro
            // 
            this.dgvcFechaRegistro.DataPropertyName = "FechaRegistro";
            this.dgvcFechaRegistro.HeaderText = "FechaRegistro";
            this.dgvcFechaRegistro.MinimumWidth = 22;
            this.dgvcFechaRegistro.Name = "dgvcFechaRegistro";
            this.dgvcFechaRegistro.ReadOnly = true;
            this.dgvcFechaRegistro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcFechaRegistro.Visible = false;
            // 
            // cATEGORIABindingSource
            // 
            this.cATEGORIABindingSource.DataMember = "CATEGORIA";
            this.cATEGORIABindingSource.DataSource = this.farmaciaDBDataSet;
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
            this.label1.TabIndex = 0;
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
            // cATEGORIATableAdapter
            // 
            this.cATEGORIATableAdapter.ClearBeforeFill = true;
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlButton.Controls.Add(this.btnAgregar);
            this.pnlButton.Location = new System.Drawing.Point(2, 210);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(272, 55);
            this.pnlButton.TabIndex = 26;
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
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // CategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(589, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriaForm";
            this.Text = "agregarCategorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineSeparator)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitlePnl;
        private System.Windows.Forms.PictureBox pctLineSeparator;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblDescE;
        private System.Windows.Forms.TextBox txtDescripcionCat;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI.WinForms.GunaLineTextBox txtNombreCat;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnModificarG;
        private Zuby.ADGV.AdvancedDataGridView dgvCategoria;
        private System.Windows.Forms.Label lblFilasTotales;
        private Guna.UI.WinForms.GunaButton btnGuardarG;
        private Guna.UI.WinForms.GunaButton btnEliminarG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbEstadoCat;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FarmaciaDBDataSet farmaciaDBDataSet;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private FarmaciaDBDataSetTableAdapters.CATEGORIATableAdapter cATEGORIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFechaRegistro;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnAgregar;
    }
}