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
            this.pnlForm = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvMedicineList = new Zuby.ADGV.AdvancedDataGridView();
            this.dgvcCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNombreM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCantidadM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcVtoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSectorE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNumeroE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
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
            this.tsdMostrarCol = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiCod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNumL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNombreM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCantidadM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVencimientoM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNombreE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNombreC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSectorE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNumeroE = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcelG = new Guna.UI.WinForms.GunaButton();
            this.btnPrintG = new Guna.UI.WinForms.GunaButton();
            this.btnPDFG = new Guna.UI.WinForms.GunaButton();
            this.pnlForm.SuspendLayout();
            this.toolStrip1.SuspendLayout();

            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
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
            // dgvMedicineList
            // 
            this.dgvMedicineList.AllowUserToAddRows = false;
            this.dgvMedicineList.AllowUserToDeleteRows = false;
            this.dgvMedicineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicineList.AutoGenerateColumns = false;
            this.dgvMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcCod,
            this.dgvcLote,
            this.dgvcNombreM,
            this.dgvcCantidadM,
            this.dgvcVtoM,
            this.dgvcNombreC,
            this.dgvcNombreE,
            this.dgvcSectorE,
            this.dgvcNumeroE});
            this.dgvMedicineList.FilterAndSortEnabled = true;
            this.dgvMedicineList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvMedicineList.Location = new System.Drawing.Point(12, 83);
            this.dgvMedicineList.Name = "dgvMedicineList";
            this.dgvMedicineList.ReadOnly = true;
            this.dgvMedicineList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvMedicineList.Size = new System.Drawing.Size(677, 346);
            this.dgvMedicineList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvMedicineList.TabIndex = 36;
            this.dgvMedicineList.TabStop = false;
            this.dgvMedicineList.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvMedicineList_SortStringChanged);
            this.dgvMedicineList.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvMedicineList_FilterStringChanged);
            // 
            // dgvcCod
            // 
            this.dgvcCod.DataPropertyName = "Codigo";
            this.dgvcCod.HeaderText = "Codigo";
            this.dgvcCod.MinimumWidth = 22;
            this.dgvcCod.Name = "dgvcCod";
            this.dgvcCod.ReadOnly = true;
            this.dgvcCod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcLote
            // 
            this.dgvcLote.DataPropertyName = "Lote";
            this.dgvcLote.HeaderText = "Lote";
            this.dgvcLote.MinimumWidth = 22;
            this.dgvcLote.Name = "dgvcLote";
            this.dgvcLote.ReadOnly = true;
            this.dgvcLote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcNombreM
            // 
            this.dgvcNombreM.DataPropertyName = "Descripcion";
            this.dgvcNombreM.HeaderText = "Nombre";
            this.dgvcNombreM.MinimumWidth = 22;
            this.dgvcNombreM.Name = "dgvcNombreM";
            this.dgvcNombreM.ReadOnly = true;
            this.dgvcNombreM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcCantidadM
            // 
            this.dgvcCantidadM.DataPropertyName = "Cantidad";
            this.dgvcCantidadM.HeaderText = "Cantidad";
            this.dgvcCantidadM.MinimumWidth = 22;
            this.dgvcCantidadM.Name = "dgvcCantidadM";
            this.dgvcCantidadM.ReadOnly = true;
            this.dgvcCantidadM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcVtoM
            // 
            this.dgvcVtoM.DataPropertyName = "Vencimiento";
            this.dgvcVtoM.HeaderText = "Vencimiento";
            this.dgvcVtoM.MinimumWidth = 22;
            this.dgvcVtoM.Name = "dgvcVtoM";
            this.dgvcVtoM.ReadOnly = true;
            this.dgvcVtoM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcNombreC
            // 
            this.dgvcNombreC.DataPropertyName = "Categoria";
            this.dgvcNombreC.HeaderText = "Categoria";
            this.dgvcNombreC.MinimumWidth = 22;
            this.dgvcNombreC.Name = "dgvcNombreC";
            this.dgvcNombreC.ReadOnly = true;
            this.dgvcNombreC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcNombreE
            // 
            this.dgvcNombreE.DataPropertyName = "Nombre estante";
            this.dgvcNombreE.HeaderText = "Nombre estante";
            this.dgvcNombreE.MinimumWidth = 22;
            this.dgvcNombreE.Name = "dgvcNombreE";
            this.dgvcNombreE.ReadOnly = true;
            this.dgvcNombreE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcSectorE
            // 
            this.dgvcSectorE.DataPropertyName = "Sector";
            this.dgvcSectorE.HeaderText = "Sector";
            this.dgvcSectorE.MinimumWidth = 22;
            this.dgvcSectorE.Name = "dgvcSectorE";
            this.dgvcSectorE.ReadOnly = true;
            this.dgvcSectorE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcNumeroE
            // 
            this.dgvcNumeroE.DataPropertyName = "Numero estante";
            this.dgvcNumeroE.HeaderText = "Numero estante";
            this.dgvcNumeroE.MinimumWidth = 22;
            this.dgvcNumeroE.Name = "dgvcNumeroE";
            this.dgvcNumeroE.ReadOnly = true;
            this.dgvcNumeroE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // bindingSourceMedicine
            // 
         
            // 
            // viewSGF
            // 
           
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.flowLayoutPanel1.Controls.Add(this.btnPrintG);
            this.flowLayoutPanel1.Controls.Add(this.btnPDFG);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(322, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 41);
            this.flowLayoutPanel1.TabIndex = 53;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Location = new System.Drawing.Point(147, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 35);
            this.panel3.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(54, 6);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(143, 23);
            this.txtBuscar.TabIndex = 53;
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
            this.btnEliminar.Size = new System.Drawing.Size(97, 45);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.btnModificar.Size = new System.Drawing.Size(97, 45);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
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
            this.btnAgregar.Size = new System.Drawing.Size(97, 45);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // medicamentoModelTableAdapter
            // 
            // 
            // asdfasdfToolStripMenuItem
            // 
            this.asdfasdfToolStripMenuItem.Name = "asdfasdfToolStripMenuItem";
            this.asdfasdfToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asdfasdfToolStripMenuItem.Text = "asdfasdf";
            // 
            // tsdMostrarCol
            // 
            this.tsdMostrarCol.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCod,
            this.tsmiNumL,
            this.tsmiNombreM,
            this.tsmiCantidadM,
            this.tsmiVencimientoM,
            this.tsmiNombreE,
            this.tsmiNombreC,
            this.tsmiSectorE,
            this.tsmiNumeroE});
            this.tsdMostrarCol.Image = ((System.Drawing.Image)(resources.GetObject("tsdMostrarCol.Image")));
            this.tsdMostrarCol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdMostrarCol.Name = "tsdMostrarCol";
            this.tsdMostrarCol.Size = new System.Drawing.Size(134, 25);
            this.tsdMostrarCol.Text = "Mostrar Columnas";
            // 
            // tsmiCod
            // 
            this.tsmiCod.Checked = true;
            this.tsmiCod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCod.Name = "tsmiCod";
            this.tsmiCod.Size = new System.Drawing.Size(175, 22);
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
            this.tsmiNumL.Size = new System.Drawing.Size(175, 22);
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
            this.tsmiNombreM.Size = new System.Drawing.Size(175, 22);
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
            this.tsmiCantidadM.Size = new System.Drawing.Size(175, 22);
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
            this.tsmiVencimientoM.Size = new System.Drawing.Size(175, 22);
            this.tsmiVencimientoM.Tag = "vencimientoMTAG";
            this.tsmiVencimientoM.Text = "Vencimiento";
            this.tsmiVencimientoM.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiVencimientoM.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNombreE
            // 
            this.tsmiNombreE.Checked = true;
            this.tsmiNombreE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreE.Name = "tsmiNombreE";
            this.tsmiNombreE.Size = new System.Drawing.Size(175, 22);
            this.tsmiNombreE.Tag = "nombreETAG";
            this.tsmiNombreE.Text = "Nombre de Estante";
            this.tsmiNombreE.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiNombreE.Click += new System.EventHandler(this.tsmiButtons_Click);
            // 
            // tsmiNombreC
            // 
            this.tsmiNombreC.Checked = true;
            this.tsmiNombreC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreC.Name = "tsmiNombreC";
            this.tsmiNombreC.Size = new System.Drawing.Size(175, 22);
            this.tsmiNombreC.Tag = "nombreCTAG";
            this.tsmiNombreC.Text = "Categoría";
            this.tsmiNombreC.CheckedChanged += new System.EventHandler(this.tsmiButtons_CheckedChanged);
            this.tsmiNombreC.Click += new System.EventHandler(this.tsmiButtons_Click);
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
            // btnPrintG
            // 
            this.btnPrintG.AnimationHoverSpeed = 0.07F;
            this.btnPrintG.AnimationSpeed = 0.03F;
            this.btnPrintG.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintG.BaseColor = System.Drawing.Color.DarkOrange;
            this.btnPrintG.BorderColor = System.Drawing.Color.Black;
            this.btnPrintG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintG.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintG.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintG.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintG.Image")));
            this.btnPrintG.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrintG.Location = new System.Drawing.Point(51, 3);
            this.btnPrintG.Name = "btnPrintG";
            this.btnPrintG.OnHoverBaseColor = System.Drawing.Color.Orange;
            this.btnPrintG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrintG.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrintG.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnPrintG.OnHoverImage")));
            this.btnPrintG.OnPressedColor = System.Drawing.Color.DarkOrange;
            this.btnPrintG.Radius = 10;
            this.btnPrintG.Size = new System.Drawing.Size(42, 32);
            this.btnPrintG.TabIndex = 46;
            this.btnPrintG.TabStop = false;
            this.btnPrintG.Text = "Imprimir";
            this.btnPrintG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPDFG
            // 
            this.btnPDFG.AnimationHoverSpeed = 0.07F;
            this.btnPDFG.AnimationSpeed = 0.03F;
            this.btnPDFG.BackColor = System.Drawing.Color.Transparent;
            this.btnPDFG.BaseColor = System.Drawing.Color.Firebrick;
            this.btnPDFG.BorderColor = System.Drawing.Color.Black;
            this.btnPDFG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPDFG.FocusedColor = System.Drawing.Color.Empty;
            this.btnPDFG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDFG.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPDFG.Image = ((System.Drawing.Image)(resources.GetObject("btnPDFG.Image")));
            this.btnPDFG.ImageSize = new System.Drawing.Size(22, 22);
            this.btnPDFG.Location = new System.Drawing.Point(99, 3);
            this.btnPDFG.Name = "btnPDFG";
            this.btnPDFG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnPDFG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPDFG.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPDFG.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnPDFG.OnHoverImage")));
            this.btnPDFG.OnPressedColor = System.Drawing.Color.DarkRed;
            this.btnPDFG.Radius = 10;
            this.btnPDFG.Size = new System.Drawing.Size(42, 32);
            this.btnPDFG.TabIndex = 45;
            this.btnPDFG.TabStop = false;
            this.btnPDFG.Text = "PDF";
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
        private Guna.UI.WinForms.GunaButton btnPrintG;
        private Guna.UI.WinForms.GunaButton btnPDFG;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreE;
        private System.Windows.Forms.ToolStripMenuItem tsmiSectorE;
        private System.Windows.Forms.ToolStripMenuItem tsmiNumeroE;
        private System.Windows.Forms.ToolStripMenuItem asdfasdfToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNombreM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCantidadM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcVtoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSectorE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNumeroE;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalRow;
    }
}