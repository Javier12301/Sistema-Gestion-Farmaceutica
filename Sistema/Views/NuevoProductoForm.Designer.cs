namespace Sistema.Views
{
    partial class NuevoProductoForm
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
            this.pnlControl = new System.Windows.Forms.Panel();
            this.gunaControlCerrar = new Guna.UI.WinForms.GunaControlBox();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNombreMedicamento = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbCatProducto = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbEstanteProducto = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescripcionP = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPrecioUniP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtStockP = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.pnlControl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlNombreMedicamento.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.pnlControl.TabIndex = 1;
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
            this.lblNombreForm.Size = new System.Drawing.Size(108, 17);
            this.lblNombreForm.TabIndex = 3;
            this.lblNombreForm.Tag = "";
            this.lblNombreForm.Text = "Nuevo Producto";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.flowLayoutPanel1.Controls.Add(this.pnlNombreMedicamento);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 276);
            this.flowLayoutPanel1.TabIndex = 7;
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
            this.label16.Size = new System.Drawing.Size(156, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "Nombre de Producto";
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
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbCatProducto);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(3, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 55);
            this.panel3.TabIndex = 2;
            // 
            // cmbCatProducto
            // 
            this.cmbCatProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCatProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCatProducto.FormattingEnabled = true;
            this.cmbCatProducto.Items.AddRange(new object[] {
            "Seleccionar Categoría"});
            this.cmbCatProducto.Location = new System.Drawing.Point(7, 26);
            this.cmbCatProducto.Name = "cmbCatProducto";
            this.cmbCatProducto.Size = new System.Drawing.Size(318, 25);
            this.cmbCatProducto.TabIndex = 3;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbEstanteProducto);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(3, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 55);
            this.panel4.TabIndex = 4;
            // 
            // cmbEstanteProducto
            // 
            this.cmbEstanteProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstanteProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstanteProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbEstanteProducto.FormattingEnabled = true;
            this.cmbEstanteProducto.Items.AddRange(new object[] {
            "Seleccionar Estante"});
            this.cmbEstanteProducto.Location = new System.Drawing.Point(7, 24);
            this.cmbEstanteProducto.Name = "cmbEstanteProducto";
            this.cmbEstanteProducto.Size = new System.Drawing.Size(318, 25);
            this.cmbEstanteProducto.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescripcionP);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Location = new System.Drawing.Point(3, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 107);
            this.panel1.TabIndex = 6;
            // 
            // txtDescripcionP
            // 
            this.txtDescripcionP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcionP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescripcionP.Location = new System.Drawing.Point(22, 26);
            this.txtDescripcionP.Multiline = true;
            this.txtDescripcionP.Name = "txtDescripcionP";
            this.txtDescripcionP.Size = new System.Drawing.Size(305, 71);
            this.txtDescripcionP.TabIndex = 7;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(3, 4);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(189, 74);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripción del Producto";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPrecioUniP);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.txtStockP);
            this.panel5.Location = new System.Drawing.Point(3, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 55);
            this.panel5.TabIndex = 8;
            // 
            // txtPrecioUniP
            // 
            this.txtPrecioUniP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioUniP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecioUniP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPrecioUniP.Location = new System.Drawing.Point(175, 25);
            this.txtPrecioUniP.Name = "txtPrecioUniP";
            this.txtPrecioUniP.Size = new System.Drawing.Size(150, 25);
            this.txtPrecioUniP.TabIndex = 10;
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
            // txtStockP
            // 
            this.txtStockP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStockP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtStockP.Location = new System.Drawing.Point(7, 25);
            this.txtStockP.Name = "txtStockP";
            this.txtStockP.Size = new System.Drawing.Size(150, 25);
            this.txtStockP.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAgregarMedicamento);
            this.panel8.Location = new System.Drawing.Point(3, 365);
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
            // 
            // NuevoProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(364, 308);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "NuevoProductoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Producto";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlNombreMedicamento.ResumeLayout(false);
            this.pnlNombreMedicamento.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private Guna.UI.WinForms.GunaControlBox gunaControlCerrar;
        private System.Windows.Forms.Label lblNombreForm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlNombreMedicamento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbCatProducto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbEstanteProducto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescripcionP;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPrecioUniP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtStockP;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAgregarMedicamento;
    }
}