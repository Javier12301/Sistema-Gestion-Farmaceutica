namespace Sistema.Views
{
    partial class ComprasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasForm));
            this.pnlForm = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.dgvMedicineList = new Zuby.ADGV.AdvancedDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExcelG = new Guna.UI.WinForms.GunaButton();
            this.btnPrintG = new Guna.UI.WinForms.GunaButton();
            this.btnPDFG = new Guna.UI.WinForms.GunaButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilas = new System.Windows.Forms.ComboBox();
            this.lblTitlePnl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.pnlForm.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).BeginInit();
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
            this.pnlForm.Size = new System.Drawing.Size(639, 391);
            this.pnlForm.TabIndex = 11;
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
            this.toolStrip1.Size = new System.Drawing.Size(639, 28);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(154)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(168, 25);
            this.toolStripLabel1.Text = "Registrar Compra";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
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
            // 
            // tsmiNumL
            // 
            this.tsmiNumL.Checked = true;
            this.tsmiNumL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNumL.Name = "tsmiNumL";
            this.tsmiNumL.Size = new System.Drawing.Size(175, 22);
            this.tsmiNumL.Tag = "loteTAG";
            this.tsmiNumL.Text = "Lote";
            // 
            // tsmiNombreM
            // 
            this.tsmiNombreM.Checked = true;
            this.tsmiNombreM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreM.Name = "tsmiNombreM";
            this.tsmiNombreM.Size = new System.Drawing.Size(175, 22);
            this.tsmiNombreM.Tag = "nombreMTAG";
            this.tsmiNombreM.Text = "Nombre";
            // 
            // tsmiCantidadM
            // 
            this.tsmiCantidadM.Checked = true;
            this.tsmiCantidadM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCantidadM.Name = "tsmiCantidadM";
            this.tsmiCantidadM.Size = new System.Drawing.Size(175, 22);
            this.tsmiCantidadM.Tag = "cantidadMTAG";
            this.tsmiCantidadM.Text = "Cantidad";
            // 
            // tsmiVencimientoM
            // 
            this.tsmiVencimientoM.Checked = true;
            this.tsmiVencimientoM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiVencimientoM.Name = "tsmiVencimientoM";
            this.tsmiVencimientoM.Size = new System.Drawing.Size(175, 22);
            this.tsmiVencimientoM.Tag = "vencimientoMTAG";
            this.tsmiVencimientoM.Text = "Vencimiento";
            // 
            // tsmiNombreE
            // 
            this.tsmiNombreE.Checked = true;
            this.tsmiNombreE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreE.Name = "tsmiNombreE";
            this.tsmiNombreE.Size = new System.Drawing.Size(175, 22);
            this.tsmiNombreE.Tag = "nombreETAG";
            this.tsmiNombreE.Text = "Nombre de Estante";
            // 
            // tsmiNombreC
            // 
            this.tsmiNombreC.Checked = true;
            this.tsmiNombreC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNombreC.Name = "tsmiNombreC";
            this.tsmiNombreC.Size = new System.Drawing.Size(175, 22);
            this.tsmiNombreC.Tag = "nombreCTAG";
            this.tsmiNombreC.Text = "Categoría";
            // 
            // tsmiSectorE
            // 
            this.tsmiSectorE.Checked = true;
            this.tsmiSectorE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiSectorE.Name = "tsmiSectorE";
            this.tsmiSectorE.Size = new System.Drawing.Size(175, 22);
            this.tsmiSectorE.Tag = "sectorETAG";
            this.tsmiSectorE.Text = "Sector";
            // 
            // tsmiNumeroE
            // 
            this.tsmiNumeroE.Checked = true;
            this.tsmiNumeroE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNumeroE.Name = "tsmiNumeroE";
            this.tsmiNumeroE.Size = new System.Drawing.Size(175, 22);
            this.tsmiNumeroE.Tag = "numeroETAG";
            this.tsmiNumeroE.Text = "Numero de Estante";
            // 
            // dgvMedicineList
            // 
            this.dgvMedicineList.AllowUserToAddRows = false;
            this.dgvMedicineList.AllowUserToDeleteRows = false;
            this.dgvMedicineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicineList.FilterAndSortEnabled = true;
            this.dgvMedicineList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvMedicineList.Location = new System.Drawing.Point(12, 83);
            this.dgvMedicineList.Name = "dgvMedicineList";
            this.dgvMedicineList.ReadOnly = true;
            this.dgvMedicineList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvMedicineList.Size = new System.Drawing.Size(616, 266);
            this.dgvMedicineList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgvMedicineList.TabIndex = 36;
            this.dgvMedicineList.TabStop = false;
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
            this.panel2.Size = new System.Drawing.Size(616, 44);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(261, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 41);
            this.flowLayoutPanel1.TabIndex = 53;
            this.flowLayoutPanel1.WrapContents = false;
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 52);
            this.panel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.lblTotalRow);
            this.panel4.Location = new System.Drawing.Point(490, 13);
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
            // ComprasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 391);
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprasForm";
            this.Text = "ComprasForm";
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).EndInit();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsdMostrarCol;
        private System.Windows.Forms.ToolStripMenuItem tsmiCod;
        private System.Windows.Forms.ToolStripMenuItem tsmiNumL;
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreM;
        private System.Windows.Forms.ToolStripMenuItem tsmiCantidadM;
        private System.Windows.Forms.ToolStripMenuItem tsmiVencimientoM;
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreE;
        private System.Windows.Forms.ToolStripMenuItem tsmiNombreC;
        private System.Windows.Forms.ToolStripMenuItem tsmiSectorE;
        private System.Windows.Forms.ToolStripMenuItem tsmiNumeroE;
        private Zuby.ADGV.AdvancedDataGridView dgvMedicineList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaButton btnExcelG;
        private Guna.UI.WinForms.GunaButton btnPrintG;
        private Guna.UI.WinForms.GunaButton btnPDFG;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilas;
        private System.Windows.Forms.Label lblTitlePnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalRow;
    }
}