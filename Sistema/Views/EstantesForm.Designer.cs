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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstantesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.btnGuardarG = new Guna.UI.WinForms.GunaButton();
            this.btnEliminarG = new Guna.UI.WinForms.GunaButton();
            this.lblListE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtaViewEstante = new System.Windows.Forms.DataGridView();
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
            this.dtaIDEstante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaNombreEstante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaNumEstante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaSectorEstante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaViewEstante)).BeginInit();
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
            this.lblCategorias.Location = new System.Drawing.Point(4, 2);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(85, 39);
            this.lblCategorias.TabIndex = 6;
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
            this.pnlList.Controls.Add(this.btnGuardarG);
            this.pnlList.Controls.Add(this.btnEliminarG);
            this.pnlList.Controls.Add(this.lblListE);
            this.pnlList.Controls.Add(this.pictureBox1);
            this.pnlList.Controls.Add(this.dtaViewEstante);
            this.pnlList.Location = new System.Drawing.Point(299, 6);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(286, 325);
            this.pnlList.TabIndex = 8;
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
            this.btnGuardarG.Location = new System.Drawing.Point(152, 2);
            this.btnGuardarG.Name = "btnGuardarG";
            this.btnGuardarG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.btnGuardarG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardarG.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardarG.OnHoverImage = null;
            this.btnGuardarG.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(131)))), ((int)(((byte)(173)))));
            this.btnGuardarG.Radius = 8;
            this.btnGuardarG.Size = new System.Drawing.Size(93, 25);
            this.btnGuardarG.TabIndex = 23;
            this.btnGuardarG.Text = "Guardar";
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
            this.btnEliminarG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(34)))), ((int)(((byte)(67)))));
            this.btnEliminarG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarG.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarG.OnHoverImage = null;
            this.btnEliminarG.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(30)))), ((int)(((byte)(59)))));
            this.btnEliminarG.Radius = 5;
            this.btnEliminarG.Size = new System.Drawing.Size(34, 25);
            this.btnEliminarG.TabIndex = 22;
            this.btnEliminarG.Click += new System.EventHandler(this.btnEliminarG_Click);
            this.btnEliminarG.MouseEnter += new System.EventHandler(this.btnEliminarG_MouseEnter);
            this.btnEliminarG.MouseLeave += new System.EventHandler(this.btnEliminarG_MouseLeave);
            // 
            // lblListE
            // 
            this.lblListE.AutoSize = true;
            this.lblListE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListE.Location = new System.Drawing.Point(5, 6);
            this.lblListE.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblListE.Name = "lblListE";
            this.lblListE.Size = new System.Drawing.Size(130, 21);
            this.lblListE.TabIndex = 20;
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
            // dtaViewEstante
            // 
            this.dtaViewEstante.AllowUserToAddRows = false;
            this.dtaViewEstante.AllowUserToDeleteRows = false;
            this.dtaViewEstante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaViewEstante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaViewEstante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtaViewEstante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaViewEstante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtaIDEstante,
            this.dtaNombreEstante,
            this.dtaNumEstante,
            this.dtaSectorEstante});
            this.dtaViewEstante.Location = new System.Drawing.Point(2, 36);
            this.dtaViewEstante.Margin = new System.Windows.Forms.Padding(5, 3, 1, 3);
            this.dtaViewEstante.Name = "dtaViewEstante";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaViewEstante.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtaViewEstante.Size = new System.Drawing.Size(279, 282);
            this.dtaViewEstante.TabIndex = 21;
            this.dtaViewEstante.TabStop = false;
            this.dtaViewEstante.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaViewEstante_CellEndEdit);
            this.dtaViewEstante.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaViewEstante_CellEnter);
            this.dtaViewEstante.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtaViewEstante_DataError);
            this.dtaViewEstante.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtaViewEstante_EditingControlShowing);
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
            this.panel1.TabIndex = 9;
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
            this.lblTitlePnl.TabIndex = 26;
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
            this.lblNombreE.Size = new System.Drawing.Size(51, 15);
            this.lblNombreE.TabIndex = 27;
            this.lblNombreE.Text = "Nombre";
            // 
            // lblNumE
            // 
            this.lblNumE.AutoSize = true;
            this.lblNumE.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumE.Location = new System.Drawing.Point(4, 97);
            this.lblNumE.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblNumE.Name = "lblNumE";
            this.lblNumE.Size = new System.Drawing.Size(92, 15);
            this.lblNumE.TabIndex = 29;
            this.lblNumE.Text = "Número Estante";
            // 
            // lblSectorE
            // 
            this.lblSectorE.AutoSize = true;
            this.lblSectorE.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectorE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSectorE.Location = new System.Drawing.Point(4, 154);
            this.lblSectorE.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblSectorE.Name = "lblSectorE";
            this.lblSectorE.Size = new System.Drawing.Size(41, 15);
            this.lblSectorE.TabIndex = 31;
            this.lblSectorE.Text = "Sector";
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
            // dtaIDEstante
            // 
            this.dtaIDEstante.FillWeight = 54.82233F;
            this.dtaIDEstante.HeaderText = "ID";
            this.dtaIDEstante.Name = "dtaIDEstante";
            this.dtaIDEstante.ReadOnly = true;
            // 
            // dtaNombreEstante
            // 
            this.dtaNombreEstante.FillWeight = 115.0592F;
            this.dtaNombreEstante.HeaderText = "Nombre";
            this.dtaNombreEstante.Name = "dtaNombreEstante";
            // 
            // dtaNumEstante
            // 
            this.dtaNumEstante.FillWeight = 115.0592F;
            this.dtaNumEstante.HeaderText = "Número de estante";
            this.dtaNumEstante.Name = "dtaNumEstante";
            // 
            // dtaSectorEstante
            // 
            this.dtaSectorEstante.FillWeight = 115.0592F;
            this.dtaSectorEstante.HeaderText = "Sector";
            this.dtaSectorEstante.Name = "dtaSectorEstante";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaViewEstante)).EndInit();
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
        private System.Windows.Forms.DataGridView dtaViewEstante;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaIDEstante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaNombreEstante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaNumEstante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaSectorEstante;
    }
}