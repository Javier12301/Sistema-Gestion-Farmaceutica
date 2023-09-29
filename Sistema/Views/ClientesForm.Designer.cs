namespace Sistema.Vista
{
    partial class ClientesForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtaGridClientes = new System.Windows.Forms.DataGridView();
            this.dtaNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaDNICliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaFNacimientoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaGeneroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaEmailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaTelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaDireccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaCategoriaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.btnAgregarCliente);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.dtaGridClientes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 338);
            this.panel3.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(358, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.Text = "Selec. Categoría";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(206, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Selec. Género";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarCliente.Location = new System.Drawing.Point(7, 32);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(145, 31);
            this.btnAgregarCliente.TabIndex = 12;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(515, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(154)))));
            this.label12.Location = new System.Drawing.Point(2, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 26);
            this.label12.TabIndex = 3;
            this.label12.Text = "ClientesForm";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(206, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 26);
            this.txtSearch.TabIndex = 10;
            // 
            // dtaGridClientes
            // 
            this.dtaGridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtaNombreCliente,
            this.dtaDNICliente,
            this.dtaFNacimientoCliente,
            this.dtaGeneroCliente,
            this.dtaEmailCliente,
            this.dtaTelefonoCliente,
            this.dtaDireccionCliente,
            this.dtaCategoriaCliente});
            this.dtaGridClientes.Location = new System.Drawing.Point(7, 69);
            this.dtaGridClientes.Name = "dtaGridClientes";
            this.dtaGridClientes.Size = new System.Drawing.Size(575, 265);
            this.dtaGridClientes.TabIndex = 9;
            // 
            // dtaNombreCliente
            // 
            this.dtaNombreCliente.HeaderText = "Nombre";
            this.dtaNombreCliente.Name = "dtaNombreCliente";
            // 
            // dtaDNICliente
            // 
            this.dtaDNICliente.HeaderText = "DNI";
            this.dtaDNICliente.Name = "dtaDNICliente";
            // 
            // dtaFNacimientoCliente
            // 
            this.dtaFNacimientoCliente.HeaderText = "Fecha Nacimiento";
            this.dtaFNacimientoCliente.Name = "dtaFNacimientoCliente";
            // 
            // dtaGeneroCliente
            // 
            this.dtaGeneroCliente.HeaderText = "Género";
            this.dtaGeneroCliente.Name = "dtaGeneroCliente";
            // 
            // dtaEmailCliente
            // 
            this.dtaEmailCliente.HeaderText = "Email";
            this.dtaEmailCliente.Name = "dtaEmailCliente";
            // 
            // dtaTelefonoCliente
            // 
            this.dtaTelefonoCliente.HeaderText = "Teléfono";
            this.dtaTelefonoCliente.Name = "dtaTelefonoCliente";
            // 
            // dtaDireccionCliente
            // 
            this.dtaDireccionCliente.HeaderText = "Dirección";
            this.dtaDireccionCliente.Name = "dtaDireccionCliente";
            this.dtaDireccionCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtaCategoriaCliente
            // 
            this.dtaCategoriaCliente.HeaderText = "Categoría";
            this.dtaCategoriaCliente.Name = "dtaCategoriaCliente";
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 338);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtaGridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaDNICliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaFNacimientoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaGeneroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaEmailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaTelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaDireccionCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaCategoriaCliente;
    }
}