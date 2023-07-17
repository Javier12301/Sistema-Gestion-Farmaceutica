namespace Sistema.formHijos
{
    partial class Medicamentos
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
            this.pnlForm = new System.Windows.Forms.Panel();
            this.gnaFiltros = new Guna.UI.WinForms.GunaGroupBox();
            this.cmbGEstantes = new Guna.UI.WinForms.GunaCheckBox();
            this.cmbGCategorias = new Guna.UI.WinForms.GunaCheckBox();
            this.lblGFiltros = new Guna.UI.WinForms.GunaLabel();
            this.cmbFilterEst = new System.Windows.Forms.ComboBox();
            this.cmbFilteCat = new System.Windows.Forms.ComboBox();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtaLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaNameMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaNumEstante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaNombreCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaSecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm.SuspendLayout();
            this.gnaFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlForm.Controls.Add(this.gnaFiltros);
            this.pnlForm.Controls.Add(this.cmbFilterEst);
            this.pnlForm.Controls.Add(this.cmbFilteCat);
            this.pnlForm.Controls.Add(this.btnAgregarMedicamento);
            this.pnlForm.Controls.Add(this.btnSearch);
            this.pnlForm.Controls.Add(this.label12);
            this.pnlForm.Controls.Add(this.txtSearch);
            this.pnlForm.Controls.Add(this.dataGridView1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(573, 299);
            this.pnlForm.TabIndex = 9;
            // 
            // gnaFiltros
            // 
            this.gnaFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gnaFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gnaFiltros.BaseColor = System.Drawing.Color.White;
            this.gnaFiltros.BorderColor = System.Drawing.Color.Snow;
            this.gnaFiltros.Controls.Add(this.cmbGEstantes);
            this.gnaFiltros.Controls.Add(this.cmbGCategorias);
            this.gnaFiltros.Controls.Add(this.lblGFiltros);
            this.gnaFiltros.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.gnaFiltros.LineLeft = 10;
            this.gnaFiltros.LineTop = 0;
            this.gnaFiltros.Location = new System.Drawing.Point(381, 35);
            this.gnaFiltros.Name = "gnaFiltros";
            this.gnaFiltros.Size = new System.Drawing.Size(186, 31);
            this.gnaFiltros.TabIndex = 9;
            this.gnaFiltros.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cmbGEstantes
            // 
            this.cmbGEstantes.BaseColor = System.Drawing.Color.White;
            this.cmbGEstantes.CheckedOffColor = System.Drawing.Color.Gray;
            this.cmbGEstantes.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.cmbGEstantes.FillColor = System.Drawing.Color.White;
            this.cmbGEstantes.Location = new System.Drawing.Point(117, 12);
            this.cmbGEstantes.Name = "cmbGEstantes";
            this.cmbGEstantes.Size = new System.Drawing.Size(74, 20);
            this.cmbGEstantes.TabIndex = 11;
            this.cmbGEstantes.Tag = "estantesTAG";
            this.cmbGEstantes.Text = "Estantes";
            this.cmbGEstantes.CheckedChanged += new System.EventHandler(this.cmbCheck_Changed);
            // 
            // cmbGCategorias
            // 
            this.cmbGCategorias.BaseColor = System.Drawing.Color.White;
            this.cmbGCategorias.CheckedOffColor = System.Drawing.Color.Gray;
            this.cmbGCategorias.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.cmbGCategorias.FillColor = System.Drawing.Color.White;
            this.cmbGCategorias.Location = new System.Drawing.Point(13, 12);
            this.cmbGCategorias.Name = "cmbGCategorias";
            this.cmbGCategorias.Size = new System.Drawing.Size(85, 20);
            this.cmbGCategorias.TabIndex = 10;
            this.cmbGCategorias.Tag = "categoriasTAG";
            this.cmbGCategorias.Text = "Categorias";
            this.cmbGCategorias.CheckedChanged += new System.EventHandler(this.cmbCheck_Changed);
            // 
            // lblGFiltros
            // 
            this.lblGFiltros.AutoSize = true;
            this.lblGFiltros.BackColor = System.Drawing.Color.Transparent;
            this.lblGFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGFiltros.Location = new System.Drawing.Point(78, 0);
            this.lblGFiltros.Name = "lblGFiltros";
            this.lblGFiltros.Size = new System.Drawing.Size(41, 15);
            this.lblGFiltros.TabIndex = 9;
            this.lblGFiltros.Text = "Filtros";
            // 
            // cmbFilterEst
            // 
            this.cmbFilterEst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterEst.DropDownHeight = 150;
            this.cmbFilterEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterEst.DropDownWidth = 120;
            this.cmbFilterEst.FormattingEnabled = true;
            this.cmbFilterEst.IntegralHeight = false;
            this.cmbFilterEst.Items.AddRange(new object[] {
            "Selecionar Estante."});
            this.cmbFilterEst.Location = new System.Drawing.Point(287, 32);
            this.cmbFilterEst.Name = "cmbFilterEst";
            this.cmbFilterEst.Size = new System.Drawing.Size(91, 21);
            this.cmbFilterEst.TabIndex = 4;
            // 
            // cmbFilteCat
            // 
            this.cmbFilteCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilteCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilteCat.DropDownWidth = 120;
            this.cmbFilteCat.FormattingEnabled = true;
            this.cmbFilteCat.Items.AddRange(new object[] {
            "Seleccionar categoria."});
            this.cmbFilteCat.Location = new System.Drawing.Point(190, 32);
            this.cmbFilteCat.Name = "cmbFilteCat";
            this.cmbFilteCat.Size = new System.Drawing.Size(91, 21);
            this.cmbFilteCat.TabIndex = 3;
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnAgregarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarMedicamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(7, 32);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(145, 31);
            this.btnAgregarMedicamento.TabIndex = 1;
            this.btnAgregarMedicamento.Text = "Agregar Medicamento";
            this.btnAgregarMedicamento.UseVisualStyleBackColor = false;
            this.btnAgregarMedicamento.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(499, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 25);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(154)))));
            this.label12.Location = new System.Drawing.Point(7, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 26);
            this.label12.TabIndex = 3;
            this.label12.Text = "Medicamentos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(190, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 26);
            this.txtSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtaLote,
            this.dtaNameMedicamento,
            this.Lote,
            this.dtaNumEstante,
            this.dtaNombreCat,
            this.dtaSecto,
            this.dtaSector,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(7, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 226);
            this.dataGridView1.TabIndex = 7;
            // 
            // dtaLote
            // 
            this.dtaLote.HeaderText = "Lote";
            this.dtaLote.Name = "dtaLote";
            // 
            // dtaNameMedicamento
            // 
            this.dtaNameMedicamento.HeaderText = "Nombre";
            this.dtaNameMedicamento.Name = "dtaNameMedicamento";
            // 
            // Lote
            // 
            this.Lote.HeaderText = "Cantidad";
            this.Lote.Name = "Lote";
            // 
            // dtaNumEstante
            // 
            this.dtaNumEstante.HeaderText = "Vto.";
            this.dtaNumEstante.Name = "dtaNumEstante";
            // 
            // dtaNombreCat
            // 
            this.dtaNombreCat.HeaderText = "Categoría";
            this.dtaNombreCat.Name = "dtaNombreCat";
            // 
            // dtaSecto
            // 
            this.dtaSecto.HeaderText = "Nombre Est.";
            this.dtaSecto.Name = "dtaSecto";
            // 
            // dtaSector
            // 
            this.dtaSector.HeaderText = "Sector";
            this.dtaSector.Name = "dtaSector";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Num. Est.";
            this.Column1.Name = "Column1";
            // 
            // Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 299);
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medicamentos";
            this.Tag = "Medicamentos";
            this.Text = "SGF";
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.gnaFiltros.ResumeLayout(false);
            this.gnaFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.ComboBox cmbFilterEst;
        private System.Windows.Forms.ComboBox cmbFilteCat;
        private System.Windows.Forms.Button btnAgregarMedicamento;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaNameMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaNumEstante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaNombreCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaSecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Guna.UI.WinForms.GunaGroupBox gnaFiltros;
        private Guna.UI.WinForms.GunaLabel lblGFiltros;
        private Guna.UI.WinForms.GunaCheckBox cmbGEstantes;
        private Guna.UI.WinForms.GunaCheckBox cmbGCategorias;
    }
}