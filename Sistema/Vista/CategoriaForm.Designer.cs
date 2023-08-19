namespace Sistema.Vista
{
    partial class CategoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreCat = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblTitlePnl = new System.Windows.Forms.Label();
            this.pctLineSeparator = new System.Windows.Forms.PictureBox();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblDescE = new System.Windows.Forms.Label();
            this.txtDescripcionCat = new System.Windows.Forms.TextBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlList = new System.Windows.Forms.Panel();
            this.btnEliminarG = new Guna.UI.WinForms.GunaButton();
            this.btnGuardarG = new Guna.UI.WinForms.GunaButton();
            this.lblListE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtaViewCategoria = new System.Windows.Forms.DataGridView();
            this.dtaIDCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaDescripcionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineSeparator)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaViewCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNombreCat);
            this.panel1.Controls.Add(this.lblTitlePnl);
            this.panel1.Controls.Add(this.pctLineSeparator);
            this.panel1.Controls.Add(this.lblNombreE);
            this.panel1.Controls.Add(this.lblDescE);
            this.panel1.Controls.Add(this.txtDescripcionCat);
            this.panel1.Controls.Add(this.pnlButton);
            this.panel1.Location = new System.Drawing.Point(9, 42);
            this.panel1.MaximumSize = new System.Drawing.Size(278, 300);
            this.panel1.MinimumSize = new System.Drawing.Size(278, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 286);
            this.panel1.TabIndex = 0;
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.BackColor = System.Drawing.Color.White;
            this.txtNombreCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCat.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtNombreCat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreCat.LineColor = System.Drawing.Color.LightGray;
            this.txtNombreCat.Location = new System.Drawing.Point(3, 61);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.PasswordChar = '\0';
            this.txtNombreCat.Size = new System.Drawing.Size(269, 26);
            this.txtNombreCat.TabIndex = 1;
            this.txtNombreCat.Enter += new System.EventHandler(this.txtNombreCat_Enter);
            // 
            // lblTitlePnl
            // 
            this.lblTitlePnl.AutoSize = true;
            this.lblTitlePnl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitlePnl.Location = new System.Drawing.Point(3, 5);
            this.lblTitlePnl.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblTitlePnl.Name = "lblTitlePnl";
            this.lblTitlePnl.Size = new System.Drawing.Size(131, 21);
            this.lblTitlePnl.TabIndex = 26;
            this.lblTitlePnl.Text = "Nueva Categoría";
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
            // lblDescE
            // 
            this.lblDescE.AutoSize = true;
            this.lblDescE.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescE.Location = new System.Drawing.Point(4, 97);
            this.lblDescE.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblDescE.Name = "lblDescE";
            this.lblDescE.Size = new System.Drawing.Size(70, 15);
            this.lblDescE.TabIndex = 29;
            this.lblDescE.Text = "Descripción";
            // 
            // txtDescripcionCat
            // 
            this.txtDescripcionCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDescripcionCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCat.Location = new System.Drawing.Point(3, 117);
            this.txtDescripcionCat.Margin = new System.Windows.Forms.Padding(10, 6, 3, 0);
            this.txtDescripcionCat.Multiline = true;
            this.txtDescripcionCat.Name = "txtDescripcionCat";
            this.txtDescripcionCat.Size = new System.Drawing.Size(269, 106);
            this.txtDescripcionCat.TabIndex = 2;
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlButton.Controls.Add(this.btnAgregar);
            this.pnlButton.Location = new System.Drawing.Point(2, 226);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(272, 55);
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
            this.btnAgregar.Location = new System.Drawing.Point(64, 7);
            this.btnAgregar.MaximumSize = new System.Drawing.Size(151, 40);
            this.btnAgregar.MinimumSize = new System.Drawing.Size(151, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 40);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlList.Controls.Add(this.btnEliminarG);
            this.pnlList.Controls.Add(this.btnGuardarG);
            this.pnlList.Controls.Add(this.lblListE);
            this.pnlList.Controls.Add(this.pictureBox1);
            this.pnlList.Controls.Add(this.dtaViewCategoria);
            this.pnlList.Location = new System.Drawing.Point(299, 6);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(286, 325);
            this.pnlList.TabIndex = 4;
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
            this.btnEliminarG.TabIndex = 21;
            this.btnEliminarG.Click += new System.EventHandler(this.btnEliminarG_Click);
            this.btnEliminarG.MouseEnter += new System.EventHandler(this.btnEliminarG_MouseEnter);
            this.btnEliminarG.MouseLeave += new System.EventHandler(this.btnEliminarG_MouseLeave);
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
            this.btnGuardarG.TabIndex = 11;
            this.btnGuardarG.Text = "Guardar";
            this.btnGuardarG.Click += new System.EventHandler(this.btnGuardarG_Click);
            // 
            // lblListE
            // 
            this.lblListE.AutoSize = true;
            this.lblListE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListE.Location = new System.Drawing.Point(5, 6);
            this.lblListE.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblListE.Name = "lblListE";
            this.lblListE.Size = new System.Drawing.Size(141, 21);
            this.lblListE.TabIndex = 20;
            this.lblListE.Text = "Lista de Categoría";
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
            // dtaViewCategoria
            // 
            this.dtaViewCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaViewCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaViewCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtaIDCategoria,
            this.dtaNombreCategoria,
            this.dtaDescripcionCategoria});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaViewCategoria.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtaViewCategoria.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtaViewCategoria.Location = new System.Drawing.Point(2, 36);
            this.dtaViewCategoria.Margin = new System.Windows.Forms.Padding(5, 3, 1, 3);
            this.dtaViewCategoria.Name = "dtaViewCategoria";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaViewCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtaViewCategoria.Size = new System.Drawing.Size(279, 282);
            this.dtaViewCategoria.TabIndex = 5;
            this.dtaViewCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaViewCategoria_CellClick);
            this.dtaViewCategoria.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaViewCategoria_CellEndEdit);
            // 
            // dtaIDCategoria
            // 
            this.dtaIDCategoria.FillWeight = 45.68528F;
            this.dtaIDCategoria.HeaderText = "ID";
            this.dtaIDCategoria.Name = "dtaIDCategoria";
            this.dtaIDCategoria.ReadOnly = true;
            // 
            // dtaNombreCategoria
            // 
            this.dtaNombreCategoria.FillWeight = 127.1574F;
            this.dtaNombreCategoria.HeaderText = "Nombre";
            this.dtaNombreCategoria.Name = "dtaNombreCategoria";
            // 
            // dtaDescripcionCategoria
            // 
            this.dtaDescripcionCategoria.FillWeight = 127.1574F;
            this.dtaDescripcionCategoria.HeaderText = "Descripción";
            this.dtaDescripcionCategoria.Name = "dtaDescripcionCategoria";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(154)))));
            this.lblTitle.Location = new System.Drawing.Point(2, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 39);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Categorías";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(589, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categorias";
            this.Text = "agregarCategorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineSeparator)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaViewCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitlePnl;
        private System.Windows.Forms.PictureBox pctLineSeparator;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblDescE;
        private System.Windows.Forms.TextBox txtDescripcionCat;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblListE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtaViewCategoria;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaLineTextBox txtNombreCat;
        private Guna.UI.WinForms.GunaButton btnGuardarG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaIDCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaNombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaDescripcionCategoria;
        private Guna.UI.WinForms.GunaButton btnEliminarG;
    }
}