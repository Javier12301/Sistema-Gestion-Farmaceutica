﻿namespace Sistema.formHijos
{
    partial class nuevoMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoMedicamento));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.gunaControlCerrar = new Guna.UI.WinForms.GunaControlBox();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNombreMedicamento = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbCatMedicamento = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbEstanteMedicamento = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStockMedicamento = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateVencimientoMedicamento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioUnitMedicamento = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlControl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlNombreMedicamento.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.flowLayoutPanel1.Controls.Add(this.pnlNombreMedicamento);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
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
            this.txtNombreMedicamento.Size = new System.Drawing.Size(307, 25);
            this.txtNombreMedicamento.TabIndex = 1;
            this.txtNombreMedicamento.Validating += new System.ComponentModel.CancelEventHandler(this.validacionCamposObligatorios);
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
            this.cmbCatMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCatMedicamento.FormattingEnabled = true;
            this.cmbCatMedicamento.Location = new System.Drawing.Point(7, 26);
            this.cmbCatMedicamento.Name = "cmbCatMedicamento";
            this.cmbCatMedicamento.Size = new System.Drawing.Size(307, 25);
            this.cmbCatMedicamento.TabIndex = 3;
            this.cmbCatMedicamento.Text = "Seleccionar Categoria";
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
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Categoria";
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
            this.cmbEstanteMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbEstanteMedicamento.FormattingEnabled = true;
            this.cmbEstanteMedicamento.Location = new System.Drawing.Point(7, 24);
            this.cmbEstanteMedicamento.Name = "cmbEstanteMedicamento";
            this.cmbEstanteMedicamento.Size = new System.Drawing.Size(307, 25);
            this.cmbEstanteMedicamento.TabIndex = 5;
            this.cmbEstanteMedicamento.Text = "Seleccionar Estante";
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
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPrecioUnitMedicamento);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.txtStockMedicamento);
            this.panel5.Location = new System.Drawing.Point(3, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 55);
            this.panel5.TabIndex = 6;
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
            // txtStockMedicamento
            // 
            this.txtStockMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockMedicamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStockMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtStockMedicamento.Location = new System.Drawing.Point(7, 25);
            this.txtStockMedicamento.Name = "txtStockMedicamento";
            this.txtStockMedicamento.Size = new System.Drawing.Size(139, 25);
            this.txtStockMedicamento.TabIndex = 7;
            this.txtStockMedicamento.Validating += new System.ComponentModel.CancelEventHandler(this.validacionCamposObligatorios);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dateVencimientoMedicamento);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 252);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(341, 55);
            this.panel7.TabIndex = 8;
            // 
            // dateVencimientoMedicamento
            // 
            this.dateVencimientoMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateVencimientoMedicamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVencimientoMedicamento.Location = new System.Drawing.Point(9, 25);
            this.dateVencimientoMedicamento.Name = "dateVencimientoMedicamento";
            this.dateVencimientoMedicamento.Size = new System.Drawing.Size(305, 25);
            this.dateVencimientoMedicamento.TabIndex = 9;
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
            // txtPrecioUnitMedicamento
            // 
            this.txtPrecioUnitMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioUnitMedicamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecioUnitMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPrecioUnitMedicamento.Location = new System.Drawing.Point(175, 25);
            this.txtPrecioUnitMedicamento.Name = "txtPrecioUnitMedicamento";
            this.txtPrecioUnitMedicamento.Size = new System.Drawing.Size(139, 25);
            this.txtPrecioUnitMedicamento.TabIndex = 11;
            this.txtPrecioUnitMedicamento.Validating += new System.ComponentModel.CancelEventHandler(this.validacionCamposObligatorios);
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
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAgregarMedicamento);
            this.panel8.Location = new System.Drawing.Point(3, 313);
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
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 400;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // nuevoMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(364, 308);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "nuevoMedicamento";
            this.Text = "Nuevo Medicamento";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlNombreMedicamento.ResumeLayout(false);
            this.pnlNombreMedicamento.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStockMedicamento;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dateVencimientoMedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioUnitMedicamento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAgregarMedicamento;
        private System.Windows.Forms.Label lblNombreForm;
        private Guna.UI.WinForms.GunaControlBox gunaControlCerrar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}