namespace Sistema.Vista
{
    partial class MedicamentosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicamentosForm));
            this.pnlForm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilas = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dtaHastaVTO = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtaDesdeVTO = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.cmbEstado = new Guna.UI.WinForms.GunaComboBox();
            this.dgvMedicineList = new Zuby.ADGV.AdvancedDataGridView();
            this.vistaInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsdMostrarCol = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmenuMedicamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiID = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNumL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNombreM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCantidadM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVencimientoM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVentaM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompraM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstadoM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuEstante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNombreE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNumeroE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSectorE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNombreP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNombreC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdImportar = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdExportar = new System.Windows.Forms.ToolStripDropDownButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.asdfasdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numEstanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoríaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlForm.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaInventarioBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.panel3);
            this.pnlForm.Controls.Add(this.cmbEstado);
            this.pnlForm.Controls.Add(this.dgvMedicineList);
            this.pnlForm.Controls.Add(this.toolStrip1);
            this.pnlForm.Controls.Add(this.panel1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(770, 483);
            this.pnlForm.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.cmbFiltro);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbFilas);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.dtaHastaVTO);
            this.panel3.Controls.Add(this.lblHasta);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.dtaDesdeVTO);
            this.panel3.Controls.Add(this.lblDesde);
            this.panel3.Location = new System.Drawing.Point(6, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 30);
            this.panel3.TabIndex = 83;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(6, 5);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(96, 23);
            this.cmbFiltro.TabIndex = 84;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(648, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Filas:";
            // 
            // cmbFilas
            // 
            this.cmbFilas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilas.FormattingEnabled = true;
            this.cmbFilas.Location = new System.Drawing.Point(687, 6);
            this.cmbFilas.Name = "cmbFilas";
            this.cmbFilas.Size = new System.Drawing.Size(74, 21);
            this.cmbFilas.TabIndex = 74;
            this.cmbFilas.TextChanged += new System.EventHandler(this.cmbFilas_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 18;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(301, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(25, 23);
            this.iconButton1.TabIndex = 92;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dtaHastaVTO
            // 
            this.dtaHastaVTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaHastaVTO.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtaHastaVTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaHastaVTO.Location = new System.Drawing.Point(544, 5);
            this.dtaHastaVTO.Name = "dtaHastaVTO";
            this.dtaHastaVTO.Size = new System.Drawing.Size(96, 22);
            this.dtaHastaVTO.TabIndex = 90;
            this.dtaHastaVTO.ValueChanged += new System.EventHandler(this.dtaDesdeVTO_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHasta.Location = new System.Drawing.Point(499, 10);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 13);
            this.lblHasta.TabIndex = 89;
            this.lblHasta.Text = "Hasta:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(108, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(187, 23);
            this.txtBuscar.TabIndex = 86;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtaDesdeVTO
            // 
            this.dtaDesdeVTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaDesdeVTO.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtaDesdeVTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaDesdeVTO.Location = new System.Drawing.Point(395, 5);
            this.dtaDesdeVTO.Name = "dtaDesdeVTO";
            this.dtaDesdeVTO.Size = new System.Drawing.Size(96, 22);
            this.dtaDesdeVTO.TabIndex = 88;
            this.dtaDesdeVTO.ValueChanged += new System.EventHandler(this.dtaDesdeVTO_ValueChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDesde.Location = new System.Drawing.Point(347, 10);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(42, 13);
            this.lblDesde.TabIndex = 87;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.Visible = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstado.BaseColor = System.Drawing.Color.White;
            this.cmbEstado.BorderColor = System.Drawing.Color.White;
            this.cmbEstado.BorderSize = 1;
            this.cmbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstado.DropDownHeight = 100;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.ItemHeight = 28;
            this.cmbEstado.Location = new System.Drawing.Point(3, 58);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(141)))), ((int)(((byte)(251)))));
            this.cmbEstado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbEstado.Radius = 10;
            this.cmbEstado.Size = new System.Drawing.Size(227, 34);
            this.cmbEstado.TabIndex = 81;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // dgvMedicineList
            // 
            this.dgvMedicineList.AllowUserToAddRows = false;
            this.dgvMedicineList.AllowUserToDeleteRows = false;
            this.dgvMedicineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicineList.AutoGenerateColumns = false;
            this.dgvMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicineList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicineList.ColumnHeadersHeight = 42;
            this.dgvMedicineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codDataGridViewTextBoxColumn,
            this.loteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.vTODataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.precioCompraDataGridViewTextBoxColumn,
            this.estanteDataGridViewTextBoxColumn,
            this.sectorDataGridViewTextBoxColumn,
            this.numEstanteDataGridViewTextBoxColumn,
            this.categoríaDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.dgvcEstado});
            this.dgvMedicineList.DataSource = this.vistaInventarioBindingSource;
            this.dgvMedicineList.FilterAndSortEnabled = true;
            this.dgvMedicineList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvMedicineList.Location = new System.Drawing.Point(2, 93);
            this.dgvMedicineList.Name = "dgvMedicineList";
            this.dgvMedicineList.ReadOnly = true;
            this.dgvMedicineList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicineList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicineList.Size = new System.Drawing.Size(758, 333);
            this.dgvMedicineList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvMedicineList.TabIndex = 78;
            this.dgvMedicineList.TabStop = false;
            this.dgvMedicineList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicineList_CellClick);
            this.dgvMedicineList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicineList_CellDoubleClick);
            // 
            // vistaInventarioBindingSource
            // 

            // 
            // farmaciaDBDataSet
            // 

            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tsdMostrarCol,
            this.tsdImportar,
            this.tsdExportar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(770, 28);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(154)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(142, 25);
            this.toolStripLabel1.Text = "Medicamentos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsdMostrarCol
            // 
            this.tsdMostrarCol.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuMedicamento,
            this.tsmenuEstante,
            this.tsmiNombreP,
            this.tsmiNombreC});
            this.tsdMostrarCol.Image = ((System.Drawing.Image)(resources.GetObject("tsdMostrarCol.Image")));
            this.tsdMostrarCol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdMostrarCol.Name = "tsdMostrarCol";
            this.tsdMostrarCol.Size = new System.Drawing.Size(134, 25);
            this.tsdMostrarCol.Text = "Mostrar Columnas";
            // 
            // tsmenuMedicamento
            // 
            this.tsmenuMedicamento.Checked = true;
            this.tsmenuMedicamento.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmenuMedicamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiID,
            this.tsmiCod,
            this.tsmiNumL,
            this.tsmiNombreM,
            this.tsmiCantidadM,
            this.tsmiVencimientoM,
            this.tsmiVentaM,
            this.tsmiCompraM,
            this.tsmiEstadoM});
            this.tsmenuMedicamento.Name = "tsmenuMedicamento";
            this.tsmenuMedicamento.Size = new System.Drawing.Size(148, 22);
            this.tsmenuMedicamento.Tag = "medicamentoMenuTAG";
            this.tsmenuMedicamento.Text = "Medicamento";
            this.tsmenuMedicamento.CheckedChanged += new System.EventHandler(this.tsmiMenuCheckChanged);
            this.tsmenuMedicamento.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiID
            // 
            this.tsmiID.Checked = true;
            this.tsmiID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiID.Name = "tsmiID";
            this.tsmiID.Size = new System.Drawing.Size(153, 22);
            this.tsmiID.Tag = "idTAG";
            this.tsmiID.Text = "ID";
            this.tsmiID.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiID.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiCod
            // 
            this.tsmiCod.Checked = true;
            this.tsmiCod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCod.Name = "tsmiCod";
            this.tsmiCod.Size = new System.Drawing.Size(153, 22);
            this.tsmiCod.Tag = "codigoTAG";
            this.tsmiCod.Text = "Código";
            this.tsmiCod.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiCod.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNumL
            // 
            this.tsmiNumL.Checked = true;
            this.tsmiNumL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNumL.Name = "tsmiNumL";
            this.tsmiNumL.Size = new System.Drawing.Size(153, 22);
            this.tsmiNumL.Tag = "loteTAG";
            this.tsmiNumL.Text = "Lote";
            this.tsmiNumL.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiNumL.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNombreM
            // 
            this.tsmiNombreM.Checked = true;
            this.tsmiNombreM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreM.Name = "tsmiNombreM";
            this.tsmiNombreM.Size = new System.Drawing.Size(153, 22);
            this.tsmiNombreM.Tag = "nombreMTAG";
            this.tsmiNombreM.Text = "Nombre";
            this.tsmiNombreM.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiNombreM.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiCantidadM
            // 
            this.tsmiCantidadM.Checked = true;
            this.tsmiCantidadM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCantidadM.Name = "tsmiCantidadM";
            this.tsmiCantidadM.Size = new System.Drawing.Size(153, 22);
            this.tsmiCantidadM.Tag = "cantidadMTAG";
            this.tsmiCantidadM.Text = "Cantidad";
            this.tsmiCantidadM.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiCantidadM.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiVencimientoM
            // 
            this.tsmiVencimientoM.Checked = true;
            this.tsmiVencimientoM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiVencimientoM.Name = "tsmiVencimientoM";
            this.tsmiVencimientoM.Size = new System.Drawing.Size(153, 22);
            this.tsmiVencimientoM.Tag = "vencimientoMTAG";
            this.tsmiVencimientoM.Text = "Vencimiento";
            this.tsmiVencimientoM.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiVencimientoM.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiVentaM
            // 
            this.tsmiVentaM.Checked = true;
            this.tsmiVentaM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiVentaM.Name = "tsmiVentaM";
            this.tsmiVentaM.Size = new System.Drawing.Size(153, 22);
            this.tsmiVentaM.Tag = "precioVentaMTAG";
            this.tsmiVentaM.Text = "Precio Venta";
            this.tsmiVentaM.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiVentaM.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiCompraM
            // 
            this.tsmiCompraM.Checked = true;
            this.tsmiCompraM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCompraM.Name = "tsmiCompraM";
            this.tsmiCompraM.Size = new System.Drawing.Size(153, 22);
            this.tsmiCompraM.Tag = "precioCompraMTAG";
            this.tsmiCompraM.Text = "Precio Compra";
            this.tsmiCompraM.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiCompraM.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiEstadoM
            // 
            this.tsmiEstadoM.Checked = true;
            this.tsmiEstadoM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiEstadoM.Name = "tsmiEstadoM";
            this.tsmiEstadoM.Size = new System.Drawing.Size(153, 22);
            this.tsmiEstadoM.Tag = "estadoMTAG";
            this.tsmiEstadoM.Text = "Estado";
            this.tsmiEstadoM.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiEstadoM.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmenuEstante
            // 
            this.tsmenuEstante.Checked = true;
            this.tsmenuEstante.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmenuEstante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNombreE,
            this.tsmiNumeroE,
            this.tsmiSectorE});
            this.tsmenuEstante.Name = "tsmenuEstante";
            this.tsmenuEstante.ShowShortcutKeys = false;
            this.tsmenuEstante.Size = new System.Drawing.Size(148, 22);
            this.tsmenuEstante.Tag = "estanteMenuTAG";
            this.tsmenuEstante.Text = "Estante";
            this.tsmenuEstante.CheckedChanged += new System.EventHandler(this.tsmiMenuCheckChanged);
            this.tsmenuEstante.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNombreE
            // 
            this.tsmiNombreE.Checked = true;
            this.tsmiNombreE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreE.Name = "tsmiNombreE";
            this.tsmiNombreE.Size = new System.Drawing.Size(175, 22);
            this.tsmiNombreE.Tag = "nombreETAG";
            this.tsmiNombreE.Text = "Nombre";
            this.tsmiNombreE.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiNombreE.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNumeroE
            // 
            this.tsmiNumeroE.Checked = true;
            this.tsmiNumeroE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNumeroE.Name = "tsmiNumeroE";
            this.tsmiNumeroE.Size = new System.Drawing.Size(175, 22);
            this.tsmiNumeroE.Tag = "numeroETAG";
            this.tsmiNumeroE.Text = "Numero de Estante";
            this.tsmiNumeroE.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiNumeroE.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiSectorE
            // 
            this.tsmiSectorE.Checked = true;
            this.tsmiSectorE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiSectorE.Name = "tsmiSectorE";
            this.tsmiSectorE.Size = new System.Drawing.Size(175, 22);
            this.tsmiSectorE.Tag = "sectorETAG";
            this.tsmiSectorE.Text = "Sector";
            this.tsmiSectorE.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiSectorE.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNombreP
            // 
            this.tsmiNombreP.Checked = true;
            this.tsmiNombreP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreP.Name = "tsmiNombreP";
            this.tsmiNombreP.Size = new System.Drawing.Size(148, 22);
            this.tsmiNombreP.Tag = "nombrePTAG";
            this.tsmiNombreP.Text = "Proveedor";
            this.tsmiNombreP.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiNombreP.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNombreC
            // 
            this.tsmiNombreC.Checked = true;
            this.tsmiNombreC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreC.Name = "tsmiNombreC";
            this.tsmiNombreC.Size = new System.Drawing.Size(148, 22);
            this.tsmiNombreC.Tag = "nombreCTAG";
            this.tsmiNombreC.Text = "Categoría";
            this.tsmiNombreC.CheckedChanged += new System.EventHandler(this.tsmiSubmenuCheckChanged);
            this.tsmiNombreC.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsdImportar
            // 
            this.tsdImportar.Image = ((System.Drawing.Image)(resources.GetObject("tsdImportar.Image")));
            this.tsdImportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdImportar.Name = "tsdImportar";
            this.tsdImportar.Size = new System.Drawing.Size(82, 25);
            this.tsdImportar.Text = "Importar";
            // 
            // tsdExportar
            // 
            this.tsdExportar.Image = ((System.Drawing.Image)(resources.GetObject("tsdExportar.Image")));
            this.tsdExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdExportar.Name = "tsdExportar";
            this.tsdExportar.Size = new System.Drawing.Size(80, 25);
            this.tsdExportar.Text = "Exportar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 52);
            this.panel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.lblTotalRow);
            this.panel4.Location = new System.Drawing.Point(626, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 36);
            this.panel4.TabIndex = 38;
            // 
            // lblTotalRow
            // 
            this.lblTotalRow.AutoEllipsis = true;
            this.lblTotalRow.AutoSize = true;
            this.lblTotalRow.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalRow.Location = new System.Drawing.Point(10, 6);
            this.lblTotalRow.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblTotalRow.Name = "lblTotalRow";
            this.lblTotalRow.Size = new System.Drawing.Size(122, 19);
            this.lblTotalRow.TabIndex = 36;
            this.lblTotalRow.Text = "Filas Totales: 1000";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(11)))), ((int)(((byte)(53)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(230, 4);
            this.btnEliminar.MaximumSize = new System.Drawing.Size(97, 46);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 36);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(163)))), ((int)(((byte)(80)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(153)))), ((int)(((byte)(72)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(184)))), ((int)(((byte)(89)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(120, 4);
            this.btnModificar.MaximumSize = new System.Drawing.Size(97, 46);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 36);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(11, 4);
            this.btnAgregar.MaximumSize = new System.Drawing.Size(97, 46);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 36);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // asdfasdfToolStripMenuItem
            // 
            this.asdfasdfToolStripMenuItem.Name = "asdfasdfToolStripMenuItem";
            this.asdfasdfToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asdfasdfToolStripMenuItem.Text = "asdfasdf";
            // 
            // vistaInventarioTableAdapter
            // 
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "Cod_";
            this.codDataGridViewTextBoxColumn.HeaderText = "Cod";
            this.codDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            this.codDataGridViewTextBoxColumn.ReadOnly = true;
            this.codDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // loteDataGridViewTextBoxColumn
            // 
            this.loteDataGridViewTextBoxColumn.DataPropertyName = "Lote";
            this.loteDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.loteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.loteDataGridViewTextBoxColumn.Name = "loteDataGridViewTextBoxColumn";
            this.loteDataGridViewTextBoxColumn.ReadOnly = true;
            this.loteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // vTODataGridViewTextBoxColumn
            // 
            this.vTODataGridViewTextBoxColumn.DataPropertyName = "VTO";
            this.vTODataGridViewTextBoxColumn.HeaderText = "VTO";
            this.vTODataGridViewTextBoxColumn.MinimumWidth = 22;
            this.vTODataGridViewTextBoxColumn.Name = "vTODataGridViewTextBoxColumn";
            this.vTODataGridViewTextBoxColumn.ReadOnly = true;
            this.vTODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "Precio Venta";
            this.precioVentaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            this.precioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioVentaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // precioCompraDataGridViewTextBoxColumn
            // 
            this.precioCompraDataGridViewTextBoxColumn.DataPropertyName = "PrecioCompra";
            this.precioCompraDataGridViewTextBoxColumn.HeaderText = "Precio Compra";
            this.precioCompraDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.precioCompraDataGridViewTextBoxColumn.Name = "precioCompraDataGridViewTextBoxColumn";
            this.precioCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioCompraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // estanteDataGridViewTextBoxColumn
            // 
            this.estanteDataGridViewTextBoxColumn.DataPropertyName = "Estante";
            this.estanteDataGridViewTextBoxColumn.HeaderText = "Estante";
            this.estanteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.estanteDataGridViewTextBoxColumn.Name = "estanteDataGridViewTextBoxColumn";
            this.estanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.estanteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // sectorDataGridViewTextBoxColumn
            // 
            this.sectorDataGridViewTextBoxColumn.DataPropertyName = "Sector";
            this.sectorDataGridViewTextBoxColumn.HeaderText = "Sector";
            this.sectorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.sectorDataGridViewTextBoxColumn.Name = "sectorDataGridViewTextBoxColumn";
            this.sectorDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // numEstanteDataGridViewTextBoxColumn
            // 
            this.numEstanteDataGridViewTextBoxColumn.DataPropertyName = "Num_ Estante";
            this.numEstanteDataGridViewTextBoxColumn.HeaderText = "Nro. Estante";
            this.numEstanteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.numEstanteDataGridViewTextBoxColumn.Name = "numEstanteDataGridViewTextBoxColumn";
            this.numEstanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numEstanteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // categoríaDataGridViewTextBoxColumn
            // 
            this.categoríaDataGridViewTextBoxColumn.DataPropertyName = "Categoría";
            this.categoríaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categoríaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.categoríaDataGridViewTextBoxColumn.Name = "categoríaDataGridViewTextBoxColumn";
            this.categoríaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoríaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.proveedorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcEstado
            // 
            this.dgvcEstado.DataPropertyName = "Estado";
            this.dgvcEstado.HeaderText = "Estado";
            this.dgvcEstado.MinimumWidth = 22;
            this.dgvcEstado.Name = "dgvcEstado";
            this.dgvcEstado.ReadOnly = true;
            this.dgvcEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // MedicamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 483);
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicamentosForm";
            this.Tag = "MedicamentosForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaInventarioBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsdMostrarCol;
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreC;
        private System.Windows.Forms.ToolStripMenuItem asdfasdfToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalRow;
        private System.Windows.Forms.ToolStripMenuItem tsmenuEstante;
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreE;
        private System.Windows.Forms.ToolStripMenuItem tsmiNumeroE;
        private System.Windows.Forms.ToolStripMenuItem tsmiSectorE;
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreP;
        private System.Windows.Forms.ToolStripMenuItem tsmenuMedicamento;
        private System.Windows.Forms.ToolStripMenuItem tsmiID;
        private System.Windows.Forms.ToolStripMenuItem tsmiCod;
        private System.Windows.Forms.ToolStripMenuItem tsmiNumL;
        private System.Windows.Forms.ToolStripMenuItem tsmiCantidadM;
        private System.Windows.Forms.ToolStripMenuItem tsmiVencimientoM;
        private System.Windows.Forms.ToolStripMenuItem tsmiVentaM;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompraM;
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreM;
        private System.Windows.Forms.ToolStripDropDownButton tsdImportar;
        private System.Windows.Forms.ToolStripDropDownButton tsdExportar;
        private System.Windows.Forms.BindingSource vistaInventarioBindingSource;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstadoM;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private Guna.UI.WinForms.GunaComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbFilas;
        private Zuby.ADGV.AdvancedDataGridView dgvMedicineList;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker dtaHastaVTO;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtaDesdeVTO;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numEstanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoríaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcEstado;
    }
}