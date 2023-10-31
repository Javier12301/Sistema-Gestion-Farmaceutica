namespace Sistema.Vista
{
    partial class NuevoMedicamentoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoMedicamentoForm));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.gunaControlCerrar = new Guna.UI.WinForms.GunaControlBox();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtaVencimientoMedicamento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPrecioUnitMedicamento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtStockMedicamento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLoteMedicamento = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbEstanteMedicamento = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbCatMedicamento = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlNombreMedicamento = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlNombreMedicamento.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.pnlControl.Size = new System.Drawing.Size(364, 32);
            this.pnlControl.TabIndex = 0;
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
            this.gunaControlCerrar.Location = new System.Drawing.Point(319, 0);
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
            this.lblNombreForm.Size = new System.Drawing.Size(136, 17);
            this.lblNombreForm.TabIndex = 3;
            this.lblNombreForm.Tag = "";
            this.lblNombreForm.Text = "Nuevo Medicamento";
            this.lblNombreForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseDown);
            this.lblNombreForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseMove);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 400;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAgregarMedicamento);
            this.panel8.Location = new System.Drawing.Point(3, 374);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(341, 55);
            this.panel8.TabIndex = 21;
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnAgregarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarMedicamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(83, 3);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(180, 49);
            this.btnAgregarMedicamento.TabIndex = 12;
            this.btnAgregarMedicamento.Text = "Agregar";
            this.btnAgregarMedicamento.UseVisualStyleBackColor = false;
            this.btnAgregarMedicamento.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtaVencimientoMedicamento);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 313);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(341, 55);
            this.panel7.TabIndex = 8;
            // 
            // dtaVencimientoMedicamento
            // 
            this.dtaVencimientoMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtaVencimientoMedicamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtaVencimientoMedicamento.Location = new System.Drawing.Point(9, 25);
            this.dtaVencimientoMedicamento.Name = "dtaVencimientoMedicamento";
            this.dtaVencimientoMedicamento.Size = new System.Drawing.Size(316, 25);
            this.dtaVencimientoMedicamento.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha de vencimiento";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPrecioUnitMedicamento);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.txtStockMedicamento);
            this.panel5.Location = new System.Drawing.Point(3, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 55);
            this.panel5.TabIndex = 8;
            // 
            // txtPrecioUnitMedicamento
            // 
            this.txtPrecioUnitMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioUnitMedicamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecioUnitMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPrecioUnitMedicamento.Location = new System.Drawing.Point(175, 25);
            this.txtPrecioUnitMedicamento.Name = "txtPrecioUnitMedicamento";
            this.txtPrecioUnitMedicamento.Size = new System.Drawing.Size(150, 25);
            this.txtPrecioUnitMedicamento.TabIndex = 10;
            this.txtPrecioUnitMedicamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.limpiarHastaElEspacio);
            this.txtPrecioUnitMedicamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumericos_KeyPress);
            this.txtPrecioUnitMedicamento.Validating += new System.ComponentModel.CancelEventHandler(this.validacionCamposObligatorios);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Stock";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(171, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 20);
            this.label18.TabIndex = 22;
            this.label18.Text = "Precio Unitario";
            // 
            // txtStockMedicamento
            // 
            this.txtStockMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockMedicamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStockMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtStockMedicamento.Location = new System.Drawing.Point(7, 25);
            this.txtStockMedicamento.Name = "txtStockMedicamento";
            this.txtStockMedicamento.Size = new System.Drawing.Size(150, 25);
            this.txtStockMedicamento.TabIndex = 9;
            this.txtStockMedicamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.limpiarHastaElEspacio);
            this.txtStockMedicamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumericos_KeyPress);
            this.txtStockMedicamento.Validating += new System.ComponentModel.CancelEventHandler(this.validacionCamposObligatorios);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLoteMedicamento);
            this.panel1.Controls.Add(this.lblLote);
            this.panel1.Location = new System.Drawing.Point(3, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 55);
            this.panel1.TabIndex = 6;
            // 
            // txtLoteMedicamento
            // 
            this.txtLoteMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoteMedicamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoteMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLoteMedicamento.Location = new System.Drawing.Point(7, 24);
            this.txtLoteMedicamento.Name = "txtLoteMedicamento";
            this.txtLoteMedicamento.Size = new System.Drawing.Size(318, 25);
            this.txtLoteMedicamento.TabIndex = 7;
            // 
            // lblLote
            // 
            this.lblLote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblLote.Location = new System.Drawing.Point(3, 4);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(143, 22);
            this.lblLote.TabIndex = 18;
            this.lblLote.Text = "Número Lote";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbEstanteMedicamento);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(3, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 55);
            this.panel4.TabIndex = 4;
            // 
            // cmbEstanteMedicamento
            // 
            this.cmbEstanteMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstanteMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstanteMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbEstanteMedicamento.FormattingEnabled = true;
            this.cmbEstanteMedicamento.Items.AddRange(new object[] {
            "Seleccionar Estante"});
            this.cmbEstanteMedicamento.Location = new System.Drawing.Point(7, 24);
            this.cmbEstanteMedicamento.Name = "cmbEstanteMedicamento";
            this.cmbEstanteMedicamento.Size = new System.Drawing.Size(318, 25);
            this.cmbEstanteMedicamento.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(3, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 20);
            this.label17.TabIndex = 18;
            this.label17.Text = "Seleccionar Estante";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbCatMedicamento);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(3, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 55);
            this.panel3.TabIndex = 2;
            // 
            // cmbCatMedicamento
            // 
            this.cmbCatMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCatMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCatMedicamento.FormattingEnabled = true;
            this.cmbCatMedicamento.Items.AddRange(new object[] {
            "Seleccionar Categoría"});
            this.cmbCatMedicamento.Location = new System.Drawing.Point(7, 26);
            this.cmbCatMedicamento.Name = "cmbCatMedicamento";
            this.cmbCatMedicamento.Size = new System.Drawing.Size(318, 25);
            this.cmbCatMedicamento.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(3, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Seleccionar Categoría";
            // 
            // pnlNombreMedicamento
            // 
            this.pnlNombreMedicamento.Controls.Add(this.label16);
            this.pnlNombreMedicamento.Controls.Add(this.txtNombreMedicamento);
            this.pnlNombreMedicamento.Location = new System.Drawing.Point(3, 3);
            this.pnlNombreMedicamento.Name = "pnlNombreMedicamento";
            this.pnlNombreMedicamento.Size = new System.Drawing.Size(341, 60);
            this.pnlNombreMedicamento.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(3, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "Nombre de Medicamento";
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreMedicamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNombreMedicamento.Location = new System.Drawing.Point(7, 27);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(318, 25);
            this.txtNombreMedicamento.TabIndex = 1;
            this.txtNombreMedicamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.limpiarHastaElEspacio);
            this.txtNombreMedicamento.Validating += new System.ComponentModel.CancelEventHandler(this.validacionCamposObligatorios);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.flowLayoutPanel1.Controls.Add(this.pnlNombreMedicamento);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 276);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // NuevoMedicamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(364, 308);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "NuevoMedicamentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Medicamento";
            this.Load += new System.EventHandler(this.nuevoMedicamento_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlNombreMedicamento.ResumeLayout(false);
            this.pnlNombreMedicamento.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblNombreForm;
        private Guna.UI.WinForms.GunaControlBox gunaControlCerrar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlNombreMedicamento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbCatMedicamento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbEstanteMedicamento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLoteMedicamento;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPrecioUnitMedicamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtStockMedicamento;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtaVencimientoMedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAgregarMedicamento;
    }
}