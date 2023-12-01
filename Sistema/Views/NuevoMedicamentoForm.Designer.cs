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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodBarrasM = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoteM = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbEstanteM = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmbCategoriaM = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmbProveedorM = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkBajoReceta = new System.Windows.Forms.CheckBox();
            this.chkRefrigeado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
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
            this.pnlControl.Size = new System.Drawing.Size(463, 32);
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
            this.gunaControlCerrar.Location = new System.Drawing.Point(418, 0);
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
            this.lblNombreForm.Size = new System.Drawing.Size(159, 17);
            this.lblNombreForm.TabIndex = 3;
            this.lblNombreForm.Tag = "";
            this.lblNombreForm.Text = "Detalle de Medicamento";
            this.lblNombreForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseDown);
            this.lblNombreForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseMove);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 400;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.errorProvider.SetIconAlignment(this.btnGuardar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(358, 382);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 31);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 347);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 341);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtCodBarrasM);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 60);
            this.panel3.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Enabled = false;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 16;
            this.btnbuscar.Location = new System.Drawing.Point(116, 6);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(25, 20);
            this.btnbuscar.TabIndex = 88;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Visible = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código de barras";
            // 
            // txtCodBarrasM
            // 
            this.txtCodBarrasM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodBarrasM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodBarrasM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCodBarrasM.Location = new System.Drawing.Point(7, 27);
            this.txtCodBarrasM.Name = "txtCodBarrasM";
            this.txtCodBarrasM.Size = new System.Drawing.Size(195, 25);
            this.txtCodBarrasM.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtNombreM);
            this.panel6.Location = new System.Drawing.Point(228, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(219, 60);
            this.panel6.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre de Medicamento";
            // 
            // txtNombreM
            // 
            this.txtNombreM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNombreM.Location = new System.Drawing.Point(6, 27);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(198, 25);
            this.txtNombreM.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtLoteM);
            this.panel4.Location = new System.Drawing.Point(3, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 60);
            this.panel4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(5, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lote";
            // 
            // txtLoteM
            // 
            this.txtLoteM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtLoteM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoteM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLoteM.Location = new System.Drawing.Point(7, 27);
            this.txtLoteM.Name = "txtLoteM";
            this.txtLoteM.Size = new System.Drawing.Size(195, 25);
            this.txtLoteM.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.Controls.Add(this.dtaVencimiento);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(228, 69);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(219, 60);
            this.panel7.TabIndex = 7;
            // 
            // dtaVencimiento
            // 
            this.dtaVencimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtaVencimiento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtaVencimiento.Location = new System.Drawing.Point(6, 27);
            this.dtaVencimiento.Name = "dtaVencimiento";
            this.dtaVencimiento.Size = new System.Drawing.Size(205, 25);
            this.dtaVencimiento.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha de Vencimiento";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.cmbEstanteM);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(3, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 60);
            this.panel2.TabIndex = 9;
            // 
            // cmbEstanteM
            // 
            this.cmbEstanteM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstanteM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbEstanteM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbEstanteM.FormattingEnabled = true;
            this.cmbEstanteM.Items.AddRange(new object[] {
            "Seleccionar Estante"});
            this.cmbEstanteM.Location = new System.Drawing.Point(7, 30);
            this.cmbEstanteM.Name = "cmbEstanteM";
            this.cmbEstanteM.Size = new System.Drawing.Size(205, 25);
            this.cmbEstanteM.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(5, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Seleccionar Estante";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.Controls.Add(this.cmbCategoriaM);
            this.panel8.Controls.Add(this.label32);
            this.panel8.Location = new System.Drawing.Point(228, 135);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(219, 60);
            this.panel8.TabIndex = 11;
            // 
            // cmbCategoriaM
            // 
            this.cmbCategoriaM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCategoriaM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbCategoriaM.FormattingEnabled = true;
            this.cmbCategoriaM.Items.AddRange(new object[] {
            "Seleccionar Categoría"});
            this.cmbCategoriaM.Location = new System.Drawing.Point(7, 30);
            this.cmbCategoriaM.Name = "cmbCategoriaM";
            this.cmbCategoriaM.Size = new System.Drawing.Size(205, 25);
            this.cmbCategoriaM.TabIndex = 12;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label32.Location = new System.Drawing.Point(5, 7);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(137, 17);
            this.label32.TabIndex = 0;
            this.label32.Text = "Seleccionar Categoría";
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel9.Controls.Add(this.cmbProveedorM);
            this.panel9.Controls.Add(this.label33);
            this.panel9.Location = new System.Drawing.Point(3, 201);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(219, 60);
            this.panel9.TabIndex = 13;
            // 
            // cmbProveedorM
            // 
            this.cmbProveedorM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedorM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbProveedorM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbProveedorM.FormattingEnabled = true;
            this.cmbProveedorM.Items.AddRange(new object[] {
            "Seleccionar Proveedor"});
            this.cmbProveedorM.Location = new System.Drawing.Point(7, 30);
            this.cmbProveedorM.Name = "cmbProveedorM";
            this.cmbProveedorM.Size = new System.Drawing.Size(205, 25);
            this.cmbProveedorM.TabIndex = 14;
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label33.Location = new System.Drawing.Point(5, 7);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(142, 17);
            this.label33.TabIndex = 0;
            this.label33.Text = "Seleccionar Proveedor";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.chkBajoReceta);
            this.panel5.Controls.Add(this.chkRefrigeado);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(228, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 60);
            this.panel5.TabIndex = 15;
            // 
            // chkBajoReceta
            // 
            this.chkBajoReceta.AutoSize = true;
            this.chkBajoReceta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBajoReceta.Location = new System.Drawing.Point(19, 39);
            this.chkBajoReceta.Name = "chkBajoReceta";
            this.chkBajoReceta.Size = new System.Drawing.Size(86, 17);
            this.chkBajoReceta.TabIndex = 17;
            this.chkBajoReceta.Text = "Bajo Receta";
            this.chkBajoReceta.UseVisualStyleBackColor = true;
            // 
            // chkRefrigeado
            // 
            this.chkRefrigeado.AutoSize = true;
            this.chkRefrigeado.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRefrigeado.Location = new System.Drawing.Point(19, 22);
            this.chkRefrigeado.Name = "chkRefrigeado";
            this.chkRefrigeado.Size = new System.Drawing.Size(87, 17);
            this.chkRefrigeado.TabIndex = 16;
            this.chkRefrigeado.Text = "Refrigerado";
            this.chkRefrigeado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Propiedades";
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.Controls.Add(this.txtGanancia);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.txtCosto);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.txtStock);
            this.panel11.Controls.Add(this.label34);
            this.panel11.Controls.Add(this.txtPrecio);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Location = new System.Drawing.Point(3, 267);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(444, 67);
            this.panel11.TabIndex = 18;
            // 
            // txtGanancia
            // 
            this.txtGanancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGanancia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGanancia.Enabled = false;
            this.txtGanancia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGanancia.Location = new System.Drawing.Point(335, 36);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(94, 25);
            this.txtGanancia.TabIndex = 21;
            this.txtGanancia.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(230, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ganancia Total:";
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCosto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCosto.Enabled = false;
            this.txtCosto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCosto.Location = new System.Drawing.Point(286, 5);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(143, 25);
            this.txtCosto.TabIndex = 19;
            this.txtCosto.Text = "0";
            this.txtCosto.TextChanged += new System.EventHandler(this.txtGanancias_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(230, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Costo:";
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtStock.Location = new System.Drawing.Point(69, 5);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(143, 25);
            this.txtStock.TabIndex = 18;
            this.txtStock.Text = "0";
            this.txtStock.TextChanged += new System.EventHandler(this.txtGanancias_TextChanged);
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label34.Location = new System.Drawing.Point(17, 8);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(46, 17);
            this.label34.TabIndex = 0;
            this.label34.Text = "Stock:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPrecio.Location = new System.Drawing.Point(69, 36);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(143, 25);
            this.txtPrecio.TabIndex = 20;
            this.txtPrecio.Text = "0";
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtGanancias_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(11)))), ((int)(((byte)(53)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(137)))), ((int)(((byte)(180)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(140, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 31);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Green;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(163)))), ((int)(((byte)(80)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(250, 382);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 31);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // NuevoMedicamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(463, 416);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "NuevoMedicamentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Medicamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevoMedicamentoForm_FormClosed);
            this.Load += new System.EventHandler(this.nuevoMedicamento_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblNombreForm;
        private Guna.UI.WinForms.GunaControlBox gunaControlCerrar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodBarrasM;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoteM;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtaVencimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbEstanteM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cmbCategoriaM;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cmbProveedorM;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkBajoReceta;
        private System.Windows.Forms.CheckBox chkRefrigeado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private FontAwesome.Sharp.IconButton btnbuscar;
    }
}