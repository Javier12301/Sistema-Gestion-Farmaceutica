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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicamentosForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsdMostrarCol = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiID = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNumL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNombreM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCantidadM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVencimientoM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstantesList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNombreE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNumeroE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSectorE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNombreC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNombreP = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMedicineList = new Zuby.ADGV.AdvancedDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numEstanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoríaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaDBDataSet = new Sistema.FarmaciaDBDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExcelG = new Guna.UI.WinForms.GunaButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtaHastaVTO = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtaDesdeVTO = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilas = new System.Windows.Forms.ComboBox();
            this.lblTitlePnl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.asdfasdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaInventarioTableAdapter = new Sistema.FarmaciaDBDataSetTableAdapters.VistaInventarioTableAdapter();
            this.pnlForm.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaInventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlForm.Controls.Add(this.toolStrip1);
            this.pnlForm.Controls.Add(this.dgvMedicineList);
            this.pnlForm.Controls.Add(this.panel2);
            this.pnlForm.Controls.Add(this.panel1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(700, 483);
            this.pnlForm.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tsdMostrarCol});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 28);
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
            this.tsmiID,
            this.tsmiCod,
            this.tsmiNumL,
            this.tsmiNombreM,
            this.tsmiCantidadM,
            this.tsmiVencimientoM,
            this.tsmiEstantesList,
            this.tsmiNombreC,
            this.tsmiNombreP});
            this.tsdMostrarCol.Image = ((System.Drawing.Image)(resources.GetObject("tsdMostrarCol.Image")));
            this.tsdMostrarCol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdMostrarCol.Name = "tsdMostrarCol";
            this.tsdMostrarCol.Size = new System.Drawing.Size(134, 25);
            this.tsdMostrarCol.Text = "Mostrar Columnas";
            // 
            // tsmiID
            // 
            this.tsmiID.Checked = true;
            this.tsmiID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiID.Name = "tsmiID";
            this.tsmiID.Size = new System.Drawing.Size(140, 22);
            this.tsmiID.Tag = "idTAG";
            this.tsmiID.Text = "ID";
            this.tsmiID.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiID.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiCod
            // 
            this.tsmiCod.Checked = true;
            this.tsmiCod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCod.Name = "tsmiCod";
            this.tsmiCod.Size = new System.Drawing.Size(140, 22);
            this.tsmiCod.Tag = "codigoTAG";
            this.tsmiCod.Text = "Código";
            this.tsmiCod.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiCod.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNumL
            // 
            this.tsmiNumL.Checked = true;
            this.tsmiNumL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNumL.Name = "tsmiNumL";
            this.tsmiNumL.Size = new System.Drawing.Size(140, 22);
            this.tsmiNumL.Tag = "loteTAG";
            this.tsmiNumL.Text = "Lote";
            this.tsmiNumL.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiNumL.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNombreM
            // 
            this.tsmiNombreM.Checked = true;
            this.tsmiNombreM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreM.Name = "tsmiNombreM";
            this.tsmiNombreM.Size = new System.Drawing.Size(140, 22);
            this.tsmiNombreM.Tag = "nombreMTAG";
            this.tsmiNombreM.Text = "Nombre";
            this.tsmiNombreM.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiNombreM.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiCantidadM
            // 
            this.tsmiCantidadM.Checked = true;
            this.tsmiCantidadM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCantidadM.Name = "tsmiCantidadM";
            this.tsmiCantidadM.Size = new System.Drawing.Size(140, 22);
            this.tsmiCantidadM.Tag = "cantidadMTAG";
            this.tsmiCantidadM.Text = "Cantidad";
            this.tsmiCantidadM.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiCantidadM.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiVencimientoM
            // 
            this.tsmiVencimientoM.Checked = true;
            this.tsmiVencimientoM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiVencimientoM.Name = "tsmiVencimientoM";
            this.tsmiVencimientoM.Size = new System.Drawing.Size(140, 22);
            this.tsmiVencimientoM.Tag = "vencimientoMTAG";
            this.tsmiVencimientoM.Text = "Vencimiento";
            this.tsmiVencimientoM.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiVencimientoM.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiEstantesList
            // 
            this.tsmiEstantesList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNombreE,
            this.tsmiNumeroE,
            this.tsmiSectorE});
            this.tsmiEstantesList.Name = "tsmiEstantesList";
            this.tsmiEstantesList.ShowShortcutKeys = false;
            this.tsmiEstantesList.Size = new System.Drawing.Size(140, 22);
            this.tsmiEstantesList.Tag = "nombreETAG";
            this.tsmiEstantesList.Text = "Estantes";
            // 
            // tsmiNombreE
            // 
            this.tsmiNombreE.Checked = true;
            this.tsmiNombreE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreE.Name = "tsmiNombreE";
            this.tsmiNombreE.Size = new System.Drawing.Size(175, 22);
            this.tsmiNombreE.Tag = "nombreETAG";
            this.tsmiNombreE.Text = "Nombre";
            this.tsmiNombreE.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
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
            this.tsmiNumeroE.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
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
            this.tsmiSectorE.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiSectorE.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNombreC
            // 
            this.tsmiNombreC.Checked = true;
            this.tsmiNombreC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreC.Name = "tsmiNombreC";
            this.tsmiNombreC.Size = new System.Drawing.Size(140, 22);
            this.tsmiNombreC.Tag = "nombreCTAG";
            this.tsmiNombreC.Text = "Categoría";
            this.tsmiNombreC.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiNombreC.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNombreP
            // 
            this.tsmiNombreP.Checked = true;
            this.tsmiNombreP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreP.Name = "tsmiNombreP";
            this.tsmiNombreP.Size = new System.Drawing.Size(140, 22);
            this.tsmiNombreP.Tag = "nombrePTAG";
            this.tsmiNombreP.Text = "Proveedor";
            this.tsmiNombreP.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiNombreP.Click += new System.EventHandler(this.tsmiButtons_Click);
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
            this.estanteDataGridViewTextBoxColumn,
            this.sectorDataGridViewTextBoxColumn,
            this.numEstanteDataGridViewTextBoxColumn,
            this.categoríaDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn});
            this.dgvMedicineList.DataSource = this.vistaInventarioBindingSource;
            this.dgvMedicineList.FilterAndSortEnabled = true;
            this.dgvMedicineList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvMedicineList.Location = new System.Drawing.Point(12, 83);
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
            this.dgvMedicineList.Size = new System.Drawing.Size(677, 346);
            this.dgvMedicineList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvMedicineList.TabIndex = 36;
            this.dgvMedicineList.TabStop = false;
            this.dgvMedicineList.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvMedicineList_SortStringChanged);
            this.dgvMedicineList.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvMedicineList_FilterStringChanged);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbFilas);
            this.panel2.Controls.Add(this.lblTitlePnl);
            this.panel2.Location = new System.Drawing.Point(12, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 44);
            this.panel2.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnExcelG);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(178, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(494, 41);
            this.flowLayoutPanel1.TabIndex = 53;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnExcelG
            // 
            this.btnExcelG.AnimationHoverSpeed = 0.07F;
            this.btnExcelG.AnimationSpeed = 0.03F;
            this.btnExcelG.BackColor = System.Drawing.Color.Transparent;
            this.btnExcelG.BaseColor = System.Drawing.Color.Green;
            this.btnExcelG.BorderColor = System.Drawing.Color.Black;
            this.btnExcelG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcelG.FocusedColor = System.Drawing.Color.Empty;
            this.btnExcelG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelG.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcelG.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelG.Image")));
            this.btnExcelG.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExcelG.Location = new System.Drawing.Point(3, 3);
            this.btnExcelG.Name = "btnExcelG";
            this.btnExcelG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(163)))), ((int)(((byte)(80)))));
            this.btnExcelG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExcelG.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExcelG.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnExcelG.OnHoverImage")));
            this.btnExcelG.OnPressedColor = System.Drawing.Color.Green;
            this.btnExcelG.Radius = 10;
            this.btnExcelG.Size = new System.Drawing.Size(42, 32);
            this.btnExcelG.TabIndex = 44;
            this.btnExcelG.TabStop = false;
            this.btnExcelG.Text = "Excel";
            this.btnExcelG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.dtaHastaVTO);
            this.panel3.Controls.Add(this.lblHasta);
            this.panel3.Controls.Add(this.dtaDesdeVTO);
            this.panel3.Controls.Add(this.lblDesde);
            this.panel3.Controls.Add(this.cmbFiltro);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Location = new System.Drawing.Point(51, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 35);
            this.panel3.TabIndex = 47;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Enabled = false;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(152, 6);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(253, 23);
            this.txtBuscar.TabIndex = 53;
            this.txtBuscar.Visible = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtaHastaVTO
            // 
            this.dtaHastaVTO.Enabled = false;
            this.dtaHastaVTO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtaHastaVTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaHastaVTO.Location = new System.Drawing.Point(326, 6);
            this.dtaHastaVTO.Name = "dtaHastaVTO";
            this.dtaHastaVTO.Size = new System.Drawing.Size(79, 22);
            this.dtaHastaVTO.TabIndex = 58;
            this.dtaHastaVTO.Visible = false;
            this.dtaHastaVTO.ValueChanged += new System.EventHandler(this.dtaDesdeVTO_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHasta.AutoSize = true;
            this.lblHasta.Enabled = false;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHasta.Location = new System.Drawing.Point(278, 8);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(46, 17);
            this.lblHasta.TabIndex = 57;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.Visible = false;
            // 
            // dtaDesdeVTO
            // 
            this.dtaDesdeVTO.Enabled = false;
            this.dtaDesdeVTO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtaDesdeVTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaDesdeVTO.Location = new System.Drawing.Point(198, 6);
            this.dtaDesdeVTO.Name = "dtaDesdeVTO";
            this.dtaDesdeVTO.Size = new System.Drawing.Size(79, 22);
            this.dtaDesdeVTO.TabIndex = 56;
            this.dtaDesdeVTO.Visible = false;
            this.dtaDesdeVTO.ValueChanged += new System.EventHandler(this.dtaDesdeVTO_ValueChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesde.AutoSize = true;
            this.lblDesde.Enabled = false;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDesde.Location = new System.Drawing.Point(150, 8);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 17);
            this.lblDesde.TabIndex = 55;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.Visible = false;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.DropDownWidth = 100;
            this.cmbFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(76, 6);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(73, 23);
            this.cmbFiltro.TabIndex = 38;
            this.cmbFiltro.TextChanged += new System.EventHandler(this.cmbFiltro_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(1, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Buscar por:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 16;
            this.btnbuscar.Location = new System.Drawing.Point(411, 6);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(26, 23);
            this.btnbuscar.TabIndex = 54;
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(135, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Filas";
            // 
            // cmbFilas
            // 
            this.cmbFilas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilas.FormattingEnabled = true;
            this.cmbFilas.Location = new System.Drawing.Point(61, 10);
            this.cmbFilas.Name = "cmbFilas";
            this.cmbFilas.Size = new System.Drawing.Size(74, 23);
            this.cmbFilas.TabIndex = 27;
            this.cmbFilas.TextChanged += new System.EventHandler(this.cmbFilas_TextChanged);
            this.cmbFilas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFilas_KeyPress);
            // 
            // lblTitlePnl
            // 
            this.lblTitlePnl.AutoSize = true;
            this.lblTitlePnl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitlePnl.Location = new System.Drawing.Point(5, 12);
            this.lblTitlePnl.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblTitlePnl.Name = "lblTitlePnl";
            this.lblTitlePnl.Size = new System.Drawing.Size(56, 17);
            this.lblTitlePnl.TabIndex = 26;
            this.lblTitlePnl.Text = "Mostrar";
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
            this.panel1.Size = new System.Drawing.Size(700, 52);
            this.panel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.lblTotalRow);
            this.panel4.Location = new System.Drawing.Point(556, 4);
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
            this.vistaInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // MedicamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 483);
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicamentosForm";
            this.Tag = "MedicamentosForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaInventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilas;
        private System.Windows.Forms.Label lblTitlePnl;
        private Zuby.ADGV.AdvancedDataGridView dgvMedicineList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaButton btnExcelG;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsdMostrarCol;
        private System.Windows.Forms.ToolStripMenuItem tsmiCod;
        private System.Windows.Forms.ToolStripMenuItem tsmiNumL;
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreM;
        private System.Windows.Forms.ToolStripMenuItem tsmiCantidadM;
        private System.Windows.Forms.ToolStripMenuItem tsmiVencimientoM;
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreC;
        private System.Windows.Forms.ToolStripMenuItem asdfasdfToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalRow;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstantesList;
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreE;
        private System.Windows.Forms.ToolStripMenuItem tsmiNumeroE;
        private System.Windows.Forms.ToolStripMenuItem tsmiSectorE;
        private System.Windows.Forms.ToolStripMenuItem tsmiID;
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreP;
        private FarmaciaDBDataSet farmaciaDBDataSet;
        private System.Windows.Forms.BindingSource vistaInventarioBindingSource;
        private FarmaciaDBDataSetTableAdapters.VistaInventarioTableAdapter vistaInventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numEstanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoríaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtaHastaVTO;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtaDesdeVTO;
        private System.Windows.Forms.Label lblDesde;
    }
}