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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dtaViewMedicamentos = new System.Windows.Forms.DataGridView();
            this.dtaCodB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaNameMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaNombreCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaNombreEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaNumEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaViewMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlForm.Controls.Add(this.btnAddMedicine);
            this.pnlForm.Controls.Add(this.label12);
            this.pnlForm.Controls.Add(this.dtaViewMedicamentos);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(702, 299);
            this.pnlForm.TabIndex = 9;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddMedicine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMedicine.Location = new System.Drawing.Point(7, 32);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(145, 31);
            this.btnAddMedicine.TabIndex = 1;
            this.btnAddMedicine.Text = "Agregar Medicamento";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
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
            this.label12.Text = "MedicamentosForm";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtaViewMedicamentos
            // 
            this.dtaViewMedicamentos.AllowUserToAddRows = false;
            this.dtaViewMedicamentos.AllowUserToDeleteRows = false;
            this.dtaViewMedicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaViewMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaViewMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaViewMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtaCodB,
            this.dtaLote,
            this.dtaNameMedicamento,
            this.dtaStock,
            this.dtaVencimiento,
            this.dtaNombreCat,
            this.dtaNombreEst,
            this.dtaSector,
            this.dtaNumEst});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaViewMedicamentos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtaViewMedicamentos.Location = new System.Drawing.Point(7, 69);
            this.dtaViewMedicamentos.Name = "dtaViewMedicamentos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaViewMedicamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtaViewMedicamentos.Size = new System.Drawing.Size(688, 226);
            this.dtaViewMedicamentos.TabIndex = 7;
            // 
            // dtaCodB
            // 
            this.dtaCodB.HeaderText = "Código";
            this.dtaCodB.Name = "dtaCodB";
            // 
            // dtaLote
            // 
            this.dtaLote.HeaderText = "Lote";
            this.dtaLote.Name = "dtaLote";
            // 
            // dtaNameMedicamento
            // 
            this.dtaNameMedicamento.HeaderText = "Descripción";
            this.dtaNameMedicamento.Name = "dtaNameMedicamento";
            // 
            // dtaStock
            // 
            this.dtaStock.HeaderText = "Cantidad";
            this.dtaStock.Name = "dtaStock";
            // 
            // dtaVencimiento
            // 
            this.dtaVencimiento.HeaderText = "Vto.";
            this.dtaVencimiento.Name = "dtaVencimiento";
            // 
            // dtaNombreCat
            // 
            this.dtaNombreCat.HeaderText = "Categoría";
            this.dtaNombreCat.Name = "dtaNombreCat";
            // 
            // dtaNombreEst
            // 
            this.dtaNombreEst.HeaderText = "Nombre Est.";
            this.dtaNombreEst.Name = "dtaNombreEst";
            // 
            // dtaSector
            // 
            this.dtaSector.HeaderText = "Sector";
            this.dtaSector.Name = "dtaSector";
            // 
            // dtaNumEst
            // 
            this.dtaNumEst.HeaderText = "Num. Est.";
            this.dtaNumEst.Name = "dtaNumEst";
            // 
            // MedicamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 299);
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicamentosForm";
            this.Tag = "MedicamentosForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            this.pnlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaViewMedicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtaViewMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaCodB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaNameMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaNombreCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaNombreEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaNumEst;
    }
}