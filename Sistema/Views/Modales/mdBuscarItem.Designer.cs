namespace Sistema.Views.Modales
{
    partial class mdBuscarItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.gunaControlCerrar = new Guna.UI.WinForms.GunaControlBox();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tpMedicamento = new System.Windows.Forms.TabPage();
            this.btnCancelarMedicamento = new System.Windows.Forms.Button();
            this.btnSeleccionarMedicamento = new System.Windows.Forms.Button();
            this.dgvDataMedicamento = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoríaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaDBDataSet = new Sistema.FarmaciaDBDataSet();
            this.btnbuscarMedicamento = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarMedicamento = new FontAwesome.Sharp.IconButton();
            this.txtBusquedaMedicamento = new System.Windows.Forms.TextBox();
            this.cmbFiltroMedicamento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tpProducto = new System.Windows.Forms.TabPage();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.dgvDataProducto = new System.Windows.Forms.DataGridView();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarProducto = new FontAwesome.Sharp.IconButton();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.cmbFiltroProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vistaInventarioTableAdapter = new Sistema.FarmaciaDBDataSetTableAdapters.VistaInventarioTableAdapter();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOTableAdapter = new Sistema.FarmaciaDBDataSetTableAdapters.PRODUCTOTableAdapter();
            this.productoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estanteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControl.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tpMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaInventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).BeginInit();
            this.tpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.pnlControl.Controls.Add(this.gunaControlCerrar);
            this.pnlControl.Controls.Add(this.lblNombreForm);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(510, 32);
            this.pnlControl.TabIndex = 2;
            this.pnlControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseDown);
            this.pnlControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseMove);
            // 
            // gunaControlCerrar
            // 
            this.gunaControlCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlCerrar.AnimationHoverSpeed = 0.07F;
            this.gunaControlCerrar.AnimationSpeed = 0.03F;
            this.gunaControlCerrar.IconColor = System.Drawing.Color.White;
            this.gunaControlCerrar.IconSize = 15F;
            this.gunaControlCerrar.Location = new System.Drawing.Point(465, 0);
            this.gunaControlCerrar.Name = "gunaControlCerrar";
            this.gunaControlCerrar.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.gunaControlCerrar.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlCerrar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaControlCerrar.Size = new System.Drawing.Size(45, 32);
            this.gunaControlCerrar.TabIndex = 4;
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreForm.Location = new System.Drawing.Point(7, 8);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(80, 17);
            this.lblNombreForm.TabIndex = 3;
            this.lblNombreForm.Tag = "";
            this.lblNombreForm.Text = "Buscar Item";
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tpMedicamento);
            this.tbControl.Controls.Add(this.tpProducto);
            this.tbControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControl.Location = new System.Drawing.Point(0, 28);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(510, 376);
            this.tbControl.TabIndex = 3;
            this.tbControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbControl_Selected);
            // 
            // tpMedicamento
            // 
            this.tpMedicamento.Controls.Add(this.btnCancelarMedicamento);
            this.tpMedicamento.Controls.Add(this.btnSeleccionarMedicamento);
            this.tpMedicamento.Controls.Add(this.dgvDataMedicamento);
            this.tpMedicamento.Controls.Add(this.btnbuscarMedicamento);
            this.tpMedicamento.Controls.Add(this.btnLimpiarMedicamento);
            this.tpMedicamento.Controls.Add(this.txtBusquedaMedicamento);
            this.tpMedicamento.Controls.Add(this.cmbFiltroMedicamento);
            this.tpMedicamento.Controls.Add(this.label11);
            this.tpMedicamento.Controls.Add(this.label10);
            this.tpMedicamento.Location = new System.Drawing.Point(4, 24);
            this.tpMedicamento.Name = "tpMedicamento";
            this.tpMedicamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedicamento.Size = new System.Drawing.Size(502, 348);
            this.tpMedicamento.TabIndex = 0;
            this.tpMedicamento.Text = "Medicamento";
            this.tpMedicamento.UseVisualStyleBackColor = true;
            // 
            // btnCancelarMedicamento
            // 
            this.btnCancelarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(11)))), ((int)(((byte)(53)))));
            this.btnCancelarMedicamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarMedicamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnCancelarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarMedicamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarMedicamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarMedicamento.Location = new System.Drawing.Point(280, 312);
            this.btnCancelarMedicamento.Name = "btnCancelarMedicamento";
            this.btnCancelarMedicamento.Size = new System.Drawing.Size(104, 31);
            this.btnCancelarMedicamento.TabIndex = 87;
            this.btnCancelarMedicamento.Text = "Cancelar";
            this.btnCancelarMedicamento.UseVisualStyleBackColor = false;
            this.btnCancelarMedicamento.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionarMedicamento
            // 
            this.btnSeleccionarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnSeleccionarMedicamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeleccionarMedicamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnSeleccionarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarMedicamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionarMedicamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeleccionarMedicamento.Location = new System.Drawing.Point(390, 312);
            this.btnSeleccionarMedicamento.Name = "btnSeleccionarMedicamento";
            this.btnSeleccionarMedicamento.Size = new System.Drawing.Size(103, 31);
            this.btnSeleccionarMedicamento.TabIndex = 86;
            this.btnSeleccionarMedicamento.Text = "Seleccionar";
            this.btnSeleccionarMedicamento.UseVisualStyleBackColor = false;
            this.btnSeleccionarMedicamento.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvDataMedicamento
            // 
            this.dgvDataMedicamento.AllowUserToAddRows = false;
            this.dgvDataMedicamento.AllowUserToDeleteRows = false;
            this.dgvDataMedicamento.AutoGenerateColumns = false;
            this.dgvDataMedicamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataMedicamento.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataMedicamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataMedicamento.ColumnHeadersHeight = 35;
            this.dgvDataMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codDataGridViewTextBoxColumn,
            this.loteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.estanteDataGridViewTextBoxColumn,
            this.categoríaDataGridViewTextBoxColumn});
            this.dgvDataMedicamento.DataSource = this.vistaInventarioBindingSource;
            this.dgvDataMedicamento.Location = new System.Drawing.Point(10, 80);
            this.dgvDataMedicamento.MultiSelect = false;
            this.dgvDataMedicamento.Name = "dgvDataMedicamento";
            this.dgvDataMedicamento.ReadOnly = true;
            this.dgvDataMedicamento.RowHeadersWidth = 20;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDataMedicamento.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataMedicamento.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDataMedicamento.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDataMedicamento.RowTemplate.Height = 28;
            this.dgvDataMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataMedicamento.Size = new System.Drawing.Size(483, 230);
            this.dgvDataMedicamento.TabIndex = 85;
            this.dgvDataMedicamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "Cod_";
            this.codDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            this.codDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loteDataGridViewTextBoxColumn
            // 
            this.loteDataGridViewTextBoxColumn.DataPropertyName = "Lote";
            this.loteDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.loteDataGridViewTextBoxColumn.Name = "loteDataGridViewTextBoxColumn";
            this.loteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estanteDataGridViewTextBoxColumn
            // 
            this.estanteDataGridViewTextBoxColumn.DataPropertyName = "Estante";
            this.estanteDataGridViewTextBoxColumn.HeaderText = "Estante";
            this.estanteDataGridViewTextBoxColumn.Name = "estanteDataGridViewTextBoxColumn";
            this.estanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoríaDataGridViewTextBoxColumn
            // 
            this.categoríaDataGridViewTextBoxColumn.DataPropertyName = "Categoría";
            this.categoríaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categoríaDataGridViewTextBoxColumn.Name = "categoríaDataGridViewTextBoxColumn";
            this.categoríaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vistaInventarioBindingSource
            // 
            this.vistaInventarioBindingSource.DataMember = "VistaInventario";
            this.vistaInventarioBindingSource.DataSource = this.farmaciaDBDataSet;
            // 
            // farmaciaDBDataSet
            // 
            this.farmaciaDBDataSet.DataSetName = "FarmaciaDBDataSet";
            this.farmaciaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnbuscarMedicamento
            // 
            this.btnbuscarMedicamento.BackColor = System.Drawing.Color.White;
            this.btnbuscarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarMedicamento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarMedicamento.ForeColor = System.Drawing.Color.Black;
            this.btnbuscarMedicamento.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarMedicamento.IconColor = System.Drawing.Color.Black;
            this.btnbuscarMedicamento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarMedicamento.IconSize = 16;
            this.btnbuscarMedicamento.Location = new System.Drawing.Point(381, 43);
            this.btnbuscarMedicamento.Name = "btnbuscarMedicamento";
            this.btnbuscarMedicamento.Size = new System.Drawing.Size(42, 23);
            this.btnbuscarMedicamento.TabIndex = 83;
            this.btnbuscarMedicamento.UseVisualStyleBackColor = false;
            this.btnbuscarMedicamento.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // btnLimpiarMedicamento
            // 
            this.btnLimpiarMedicamento.BackColor = System.Drawing.Color.White;
            this.btnLimpiarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarMedicamento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarMedicamento.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarMedicamento.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarMedicamento.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarMedicamento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarMedicamento.IconSize = 18;
            this.btnLimpiarMedicamento.Location = new System.Drawing.Point(429, 43);
            this.btnLimpiarMedicamento.Name = "btnLimpiarMedicamento";
            this.btnLimpiarMedicamento.Size = new System.Drawing.Size(42, 23);
            this.btnLimpiarMedicamento.TabIndex = 84;
            this.btnLimpiarMedicamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarMedicamento.UseVisualStyleBackColor = false;
            this.btnLimpiarMedicamento.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtBusquedaMedicamento
            // 
            this.txtBusquedaMedicamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaMedicamento.Location = new System.Drawing.Point(212, 43);
            this.txtBusquedaMedicamento.Name = "txtBusquedaMedicamento";
            this.txtBusquedaMedicamento.Size = new System.Drawing.Size(163, 23);
            this.txtBusquedaMedicamento.TabIndex = 82;
            this.txtBusquedaMedicamento.TextChanged += new System.EventHandler(this.txtBuscarItem_TextChanged);
            // 
            // cmbFiltroMedicamento
            // 
            this.cmbFiltroMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroMedicamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroMedicamento.FormattingEnabled = true;
            this.cmbFiltroMedicamento.Location = new System.Drawing.Point(90, 43);
            this.cmbFiltroMedicamento.Name = "cmbFiltroMedicamento";
            this.cmbFiltroMedicamento.Size = new System.Drawing.Size(116, 23);
            this.cmbFiltroMedicamento.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 79;
            this.label11.Text = "Buscar por:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 5);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.label10.Size = new System.Drawing.Size(483, 72);
            this.label10.TabIndex = 80;
            this.label10.Text = "Lista de Medicamento";
            // 
            // tpProducto
            // 
            this.tpProducto.Controls.Add(this.btnCancelarProducto);
            this.tpProducto.Controls.Add(this.btnSeleccionarProducto);
            this.tpProducto.Controls.Add(this.dgvDataProducto);
            this.tpProducto.Controls.Add(this.btnBuscarProducto);
            this.tpProducto.Controls.Add(this.btnLimpiarProducto);
            this.tpProducto.Controls.Add(this.txtBuscarProducto);
            this.tpProducto.Controls.Add(this.cmbFiltroProducto);
            this.tpProducto.Controls.Add(this.label1);
            this.tpProducto.Controls.Add(this.label2);
            this.tpProducto.Location = new System.Drawing.Point(4, 24);
            this.tpProducto.Name = "tpProducto";
            this.tpProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tpProducto.Size = new System.Drawing.Size(502, 348);
            this.tpProducto.TabIndex = 1;
            this.tpProducto.Text = "Producto";
            this.tpProducto.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(11)))), ((int)(((byte)(53)))));
            this.btnCancelarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnCancelarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarProducto.Location = new System.Drawing.Point(280, 312);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(104, 31);
            this.btnCancelarProducto.TabIndex = 96;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = false;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnSeleccionarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeleccionarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnSeleccionarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(390, 312);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(103, 31);
            this.btnSeleccionarProducto.TabIndex = 95;
            this.btnSeleccionarProducto.Text = "Seleccionar";
            this.btnSeleccionarProducto.UseVisualStyleBackColor = false;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvDataProducto
            // 
            this.dgvDataProducto.AllowUserToAddRows = false;
            this.dgvDataProducto.AllowUserToDeleteRows = false;
            this.dgvDataProducto.AutoGenerateColumns = false;
            this.dgvDataProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataProducto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataProducto.ColumnHeadersHeight = 35;
            this.dgvDataProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productoIDDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1,
            this.estanteIDDataGridViewTextBoxColumn,
            this.categoriaIDDataGridViewTextBoxColumn});
            this.dgvDataProducto.DataSource = this.pRODUCTOBindingSource;
            this.dgvDataProducto.Location = new System.Drawing.Point(10, 80);
            this.dgvDataProducto.MultiSelect = false;
            this.dgvDataProducto.Name = "dgvDataProducto";
            this.dgvDataProducto.ReadOnly = true;
            this.dgvDataProducto.RowHeadersWidth = 20;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDataProducto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataProducto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDataProducto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDataProducto.RowTemplate.Height = 28;
            this.dgvDataProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataProducto.Size = new System.Drawing.Size(483, 230);
            this.dgvDataProducto.TabIndex = 94;
            this.dgvDataProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 16;
            this.btnBuscarProducto.Location = new System.Drawing.Point(381, 43);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(42, 23);
            this.btnBuscarProducto.TabIndex = 92;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.BackColor = System.Drawing.Color.White;
            this.btnLimpiarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarProducto.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarProducto.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarProducto.IconSize = 18;
            this.btnLimpiarProducto.Location = new System.Drawing.Point(429, 43);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(42, 23);
            this.btnLimpiarProducto.TabIndex = 93;
            this.btnLimpiarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarProducto.UseVisualStyleBackColor = false;
            this.btnLimpiarProducto.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(212, 43);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(163, 23);
            this.txtBuscarProducto.TabIndex = 91;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarItem_TextChanged);
            // 
            // cmbFiltroProducto
            // 
            this.cmbFiltroProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroProducto.FormattingEnabled = true;
            this.cmbFiltroProducto.Location = new System.Drawing.Point(90, 43);
            this.cmbFiltroProducto.Name = "cmbFiltroProducto";
            this.cmbFiltroProducto.Size = new System.Drawing.Size(116, 23);
            this.cmbFiltroProducto.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 88;
            this.label1.Text = "Buscar por:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.label2.Size = new System.Drawing.Size(483, 72);
            this.label2.TabIndex = 89;
            this.label2.Text = "Lista de Producto";
            // 
            // vistaInventarioTableAdapter
            // 
            this.vistaInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource.DataSource = this.farmaciaDBDataSet;
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // productoIDDataGridViewTextBoxColumn
            // 
            this.productoIDDataGridViewTextBoxColumn.DataPropertyName = "ProductoID";
            this.productoIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productoIDDataGridViewTextBoxColumn.Name = "productoIDDataGridViewTextBoxColumn";
            this.productoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // estanteIDDataGridViewTextBoxColumn
            // 
            this.estanteIDDataGridViewTextBoxColumn.DataPropertyName = "EstanteID";
            this.estanteIDDataGridViewTextBoxColumn.HeaderText = "Estante";
            this.estanteIDDataGridViewTextBoxColumn.Name = "estanteIDDataGridViewTextBoxColumn";
            this.estanteIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaIDDataGridViewTextBoxColumn
            // 
            this.categoriaIDDataGridViewTextBoxColumn.DataPropertyName = "CategoriaID";
            this.categoriaIDDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categoriaIDDataGridViewTextBoxColumn.Name = "categoriaIDDataGridViewTextBoxColumn";
            this.categoriaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mdBuscarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 407);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdBuscarItem";
            this.Text = "mdBuscarItem";
            this.Load += new System.EventHandler(this.mdBuscarItem_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tpMedicamento.ResumeLayout(false);
            this.tpMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaInventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).EndInit();
            this.tpProducto.ResumeLayout(false);
            this.tpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private Guna.UI.WinForms.GunaControlBox gunaControlCerrar;
        private System.Windows.Forms.Label lblNombreForm;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tpMedicamento;
        private System.Windows.Forms.Button btnCancelarMedicamento;
        private System.Windows.Forms.Button btnSeleccionarMedicamento;
        private System.Windows.Forms.DataGridView dgvDataMedicamento;
        private FontAwesome.Sharp.IconButton btnbuscarMedicamento;
        private FontAwesome.Sharp.IconButton btnLimpiarMedicamento;
        private System.Windows.Forms.TextBox txtBusquedaMedicamento;
        private System.Windows.Forms.ComboBox cmbFiltroMedicamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tpProducto;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.DataGridView dgvDataProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private FontAwesome.Sharp.IconButton btnLimpiarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.ComboBox cmbFiltroProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FarmaciaDBDataSet farmaciaDBDataSet;
        private System.Windows.Forms.BindingSource vistaInventarioBindingSource;
        private FarmaciaDBDataSetTableAdapters.VistaInventarioTableAdapter vistaInventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoríaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        private FarmaciaDBDataSetTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estanteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaIDDataGridViewTextBoxColumn;
    }
}