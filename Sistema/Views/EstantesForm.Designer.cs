namespace Sistema.Vista
{
    partial class EstantesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstantesForm));
            this.lblCategorias = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.btnModifyG = new Guna.UI.WinForms.GunaButton();
            this.dgvShelvesList = new Zuby.ADGV.AdvancedDataGridView();
            this.bindingSourceShelves = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaDBDataSet = new Sistema.FarmaciaDBDataSet();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.btnGuardarG = new Guna.UI.WinForms.GunaButton();
            this.btnEliminarG = new Guna.UI.WinForms.GunaButton();
            this.lblListE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSectorE = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtNumE = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtNombreE = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblTitlePnl = new System.Windows.Forms.Label();
            this.pctLineSeparator = new System.Windows.Forms.PictureBox();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblNumE = new System.Windows.Forms.Label();
            this.lblSectorE = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.eSTANTETableAdapter = new Sistema.FarmaciaDBDataSetTableAdapters.ESTANTETableAdapter();
            this.dgvcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNumeroE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSectorE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelvesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceShelves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineSeparator)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategorias
            // 
            this.lblCategorias.BackColor = System.Drawing.Color.Transparent;
            this.lblCategorias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(154)))));
            this.lblCategorias.Location = new System.Drawing.Point(7, 11);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(85, 39);
            this.lblCategorias.TabIndex = 0;
            this.lblCategorias.Text = "EstantesForm";
            this.lblCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlList.Controls.Add(this.btnModifyG);
            this.pnlList.Controls.Add(this.dgvShelvesList);
            this.pnlList.Controls.Add(this.lblTotalRow);
            this.pnlList.Controls.Add(this.btnGuardarG);
            this.pnlList.Controls.Add(this.btnEliminarG);
            this.pnlList.Controls.Add(this.lblListE);
            this.pnlList.Controls.Add(this.pictureBox1);
            this.pnlList.Location = new System.Drawing.Point(299, 4);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(286, 325);
            this.pnlList.TabIndex = 0;
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
            this.btnModifyG.TabIndex = 6;
            this.btnModifyG.Click += new System.EventHandler(this.btnModifyG_Click);
            // 
            // dgvShelvesList
            // 
            this.dgvShelvesList.AllowUserToAddRows = false;
            this.dgvShelvesList.AllowUserToDeleteRows = false;
            this.dgvShelvesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShelvesList.AutoGenerateColumns = false;
            this.dgvShelvesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShelvesList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShelvesList.ColumnHeadersHeight = 30;
            this.dgvShelvesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcID,
            this.dgvcNombreE,
            this.dgvcNumeroE,
            this.dgvcSectorE});
            this.dgvShelvesList.DataSource = this.bindingSourceShelves;
            this.dgvShelvesList.FilterAndSortEnabled = true;
            this.dgvShelvesList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvShelvesList.Location = new System.Drawing.Point(5, 36);
            this.dgvShelvesList.Name = "dgvShelvesList";
            this.dgvShelvesList.ReadOnly = true;
            this.dgvShelvesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvShelvesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShelvesList.Size = new System.Drawing.Size(272, 256);
            this.dgvShelvesList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvShelvesList.TabIndex = 35;
            this.dgvShelvesList.TabStop = false;
            this.dgvShelvesList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaViewEstante_CellEndEdit);
            this.dgvShelvesList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaViewEstante_CellEnter);
            this.dgvShelvesList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtaViewEstante_DataError);
            this.dgvShelvesList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtaViewEstante_EditingControlShowing);
            // 
            // bindingSourceShelves
            // 
            this.bindingSourceShelves.DataMember = "ESTANTE";
            this.bindingSourceShelves.DataSource = this.farmaciaDBDataSet;
            // 
            // farmaciaDBDataSet
            // 
            this.farmaciaDBDataSet.DataSetName = "FarmaciaDBDataSet";
            this.farmaciaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnGuardarG.TabIndex = 5;
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
            this.btnEliminarG.TabIndex = 7;
            this.btnEliminarG.Click += new System.EventHandler(this.btnEliminarG_Click);
            this.btnEliminarG.MouseEnter += new System.EventHandler(this.btnEliminarG_MouseEnter);
            this.btnEliminarG.MouseLeave += new System.EventHandler(this.btnEliminarG_MouseLeave);
            // 
            // lblListE
            // 
            this.lblListE.AutoSize = true;
            this.lblListE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListE.Location = new System.Drawing.Point(-2, 6);
            this.lblListE.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblListE.Name = "lblListE";
            this.lblListE.Size = new System.Drawing.Size(130, 21);
            this.lblListE.TabIndex = 0;
            this.lblListE.Text = "Lista de Estantes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 2);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "txtUser";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSectorE);
            this.panel1.Controls.Add(this.txtNumE);
            this.panel1.Controls.Add(this.txtNombreE);
            this.panel1.Controls.Add(this.lblTitlePnl);
            this.panel1.Controls.Add(this.pctLineSeparator);
            this.panel1.Controls.Add(this.lblNombreE);
            this.panel1.Controls.Add(this.lblNumE);
            this.panel1.Controls.Add(this.lblSectorE);
            this.panel1.Controls.Add(this.pnlButton);
            this.panel1.Location = new System.Drawing.Point(9, 42);
            this.panel1.MaximumSize = new System.Drawing.Size(278, 286);
            this.panel1.MinimumSize = new System.Drawing.Size(278, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 286);
            this.panel1.TabIndex = 0;
            // 
            // txtSectorE
            // 
            this.txtSectorE.BackColor = System.Drawing.Color.White;
            this.txtSectorE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSectorE.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtSectorE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSectorE.LineColor = System.Drawing.Color.LightGray;
            this.txtSectorE.Location = new System.Drawing.Point(4, 171);
            this.txtSectorE.Name = "txtSectorE";
            this.txtSectorE.PasswordChar = '\0';
            this.txtSectorE.Size = new System.Drawing.Size(269, 26);
            this.txtSectorE.TabIndex = 3;
            this.txtSectorE.Enter += new System.EventHandler(this.txtSectorE_Enter);
            // 
            // txtNumE
            // 
            this.txtNumE.BackColor = System.Drawing.Color.White;
            this.txtNumE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumE.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtNumE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumE.LineColor = System.Drawing.Color.LightGray;
            this.txtNumE.Location = new System.Drawing.Point(4, 117);
            this.txtNumE.Name = "txtNumE";
            this.txtNumE.PasswordChar = '\0';
            this.txtNumE.Size = new System.Drawing.Size(269, 26);
            this.txtNumE.TabIndex = 2;
            this.txtNumE.Enter += new System.EventHandler(this.txtNumE_Enter);
            this.txtNumE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumE_KeyPress);
            // 
            // txtNombreE
            // 
            this.txtNombreE.BackColor = System.Drawing.Color.White;
            this.txtNombreE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreE.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtNombreE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreE.LineColor = System.Drawing.Color.LightGray;
            this.txtNombreE.Location = new System.Drawing.Point(4, 63);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.PasswordChar = '\0';
            this.txtNombreE.Size = new System.Drawing.Size(269, 26);
            this.txtNombreE.TabIndex = 1;
            this.txtNombreE.Enter += new System.EventHandler(this.txtNombreE_Enter);
            // 
            // lblTitlePnl
            // 
            this.lblTitlePnl.AutoSize = true;
            this.lblTitlePnl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitlePnl.Location = new System.Drawing.Point(3, 5);
            this.lblTitlePnl.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblTitlePnl.Name = "lblTitlePnl";
            this.lblTitlePnl.Size = new System.Drawing.Size(115, 21);
            this.lblTitlePnl.TabIndex = 0;
            this.lblTitlePnl.Text = "Nuevo Estante";
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
            // lblNumE
            // 
            this.lblNumE.AutoSize = true;
            this.lblNumE.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumE.Location = new System.Drawing.Point(4, 97);
            this.lblNumE.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblNumE.Name = "lblNumE";
            this.lblNumE.Size = new System.Drawing.Size(100, 15);
            this.lblNumE.TabIndex = 0;
            this.lblNumE.Text = "Número Estante *";
            // 
            // lblSectorE
            // 
            this.lblSectorE.AutoSize = true;
            this.lblSectorE.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectorE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSectorE.Location = new System.Drawing.Point(4, 154);
            this.lblSectorE.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblSectorE.Name = "lblSectorE";
            this.lblSectorE.Size = new System.Drawing.Size(49, 15);
            this.lblSectorE.TabIndex = 0;
            this.lblSectorE.Text = "Sector *";
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
            // eSTANTETableAdapter
            // 
            this.eSTANTETableAdapter.ClearBeforeFill = true;
            // 
            // dgvcID
            // 
            this.dgvcID.DataPropertyName = "EstanteID";
            this.dgvcID.FillWeight = 42.6396F;
            this.dgvcID.HeaderText = "ID";
            this.dgvcID.MinimumWidth = 22;
            this.dgvcID.Name = "dgvcID";
            this.dgvcID.ReadOnly = true;
            this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcID.Visible = false;
            // 
            // dgvcNombreE
            // 
            this.dgvcNombreE.DataPropertyName = "Nombre";
            this.dgvcNombreE.FillWeight = 119.1201F;
            this.dgvcNombreE.HeaderText = "Nombre";
            this.dgvcNombreE.MinimumWidth = 22;
            this.dgvcNombreE.Name = "dgvcNombreE";
            this.dgvcNombreE.ReadOnly = true;
            this.dgvcNombreE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcNumeroE
            // 
            this.dgvcNumeroE.DataPropertyName = "Numero";
            this.dgvcNumeroE.FillWeight = 119.1201F;
            this.dgvcNumeroE.HeaderText = "Numero";
            this.dgvcNumeroE.MinimumWidth = 22;
            this.dgvcNumeroE.Name = "dgvcNumeroE";
            this.dgvcNumeroE.ReadOnly = true;
            this.dgvcNumeroE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcSectorE
            // 
            this.dgvcSectorE.DataPropertyName = "Sector";
            this.dgvcSectorE.FillWeight = 119.1201F;
            this.dgvcSectorE.HeaderText = "Sector";
            this.dgvcSectorE.MinimumWidth = 22;
            this.dgvcSectorE.Name = "dgvcSectorE";
            this.dgvcSectorE.ReadOnly = true;
            this.dgvcSectorE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // EstantesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(589, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.lblCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstantesForm";
            this.Text = "EstantesForm";
            this.Load += new System.EventHandler(this.Estantes_Load);
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelvesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceShelves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineSeparator)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblListE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitlePnl;
        private System.Windows.Forms.PictureBox pctLineSeparator;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblNumE;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblSectorE;
        private Guna.UI.WinForms.GunaLineTextBox txtNombreE;
        private Guna.UI.WinForms.GunaLineTextBox txtSectorE;
        private Guna.UI.WinForms.GunaLineTextBox txtNumE;
        private Guna.UI.WinForms.GunaButton btnEliminarG;
        private Guna.UI.WinForms.GunaButton btnGuardarG;
        private System.Windows.Forms.Label lblTotalRow;
        private Zuby.ADGV.AdvancedDataGridView dgvShelvesList;
        private Guna.UI.WinForms.GunaButton btnModifyG;
        private FarmaciaDBDataSet farmaciaDBDataSet;
        private System.Windows.Forms.BindingSource bindingSourceShelves;
        private FarmaciaDBDataSetTableAdapters.ESTANTETableAdapter eSTANTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNumeroE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSectorE;
    }
}