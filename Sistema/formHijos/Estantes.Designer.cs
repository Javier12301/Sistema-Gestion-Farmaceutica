namespace Sistema.Inventario
{
    partial class Estantes
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
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbListEstante = new System.Windows.Forms.GroupBox();
            this.dtaListEstante = new System.Windows.Forms.DataGridView();
            this.shelfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfNumeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selfNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlgpbEstanteFORM = new System.Windows.Forms.Panel();
            this.gpbNewEstante = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gpbListEstante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaListEstante)).BeginInit();
            this.pnlgpbEstanteFORM.SuspendLayout();
            this.gpbNewEstante.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(154)))));
            this.label12.Location = new System.Drawing.Point(10, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 39);
            this.label12.TabIndex = 6;
            this.label12.Text = "Estantes";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gpbListEstante);
            this.panel1.Location = new System.Drawing.Point(212, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 290);
            this.panel1.TabIndex = 5;
            // 
            // gpbListEstante
            // 
            this.gpbListEstante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbListEstante.BackColor = System.Drawing.Color.White;
            this.gpbListEstante.Controls.Add(this.dtaListEstante);
            this.gpbListEstante.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpbListEstante.Location = new System.Drawing.Point(2, 3);
            this.gpbListEstante.Name = "gpbListEstante";
            this.gpbListEstante.Size = new System.Drawing.Size(359, 282);
            this.gpbListEstante.TabIndex = 0;
            this.gpbListEstante.TabStop = false;
            this.gpbListEstante.Text = "Lista de Estantes";
            // 
            // dtaListEstante
            // 
            this.dtaListEstante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaListEstante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtaListEstante.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtaListEstante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtaListEstante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shelfName,
            this.shelfNumeric,
            this.selfNumero});
            this.dtaListEstante.Location = new System.Drawing.Point(7, 27);
            this.dtaListEstante.Name = "dtaListEstante";
            this.dtaListEstante.Size = new System.Drawing.Size(346, 249);
            this.dtaListEstante.TabIndex = 0;
            // 
            // shelfName
            // 
            this.shelfName.HeaderText = "Nombre";
            this.shelfName.Name = "shelfName";
            this.shelfName.Width = 90;
            // 
            // shelfNumeric
            // 
            this.shelfNumeric.HeaderText = "Sector";
            this.shelfNumeric.Name = "shelfNumeric";
            this.shelfNumeric.Width = 78;
            // 
            // selfNumero
            // 
            this.selfNumero.HeaderText = "Núm. estante";
            this.selfNumero.Name = "selfNumero";
            this.selfNumero.Width = 126;
            // 
            // pnlgpbEstanteFORM
            // 
            this.pnlgpbEstanteFORM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlgpbEstanteFORM.BackColor = System.Drawing.Color.White;
            this.pnlgpbEstanteFORM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlgpbEstanteFORM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlgpbEstanteFORM.Controls.Add(this.gpbNewEstante);
            this.pnlgpbEstanteFORM.Location = new System.Drawing.Point(7, 51);
            this.pnlgpbEstanteFORM.Name = "pnlgpbEstanteFORM";
            this.pnlgpbEstanteFORM.Size = new System.Drawing.Size(199, 250);
            this.pnlgpbEstanteFORM.TabIndex = 4;
            // 
            // gpbNewEstante
            // 
            this.gpbNewEstante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbNewEstante.BackColor = System.Drawing.Color.White;
            this.gpbNewEstante.Controls.Add(this.btnLogin);
            this.gpbNewEstante.Controls.Add(this.label11);
            this.gpbNewEstante.Controls.Add(this.textBox3);
            this.gpbNewEstante.Controls.Add(this.label10);
            this.gpbNewEstante.Controls.Add(this.textBox2);
            this.gpbNewEstante.Controls.Add(this.label9);
            this.gpbNewEstante.Controls.Add(this.textBox1);
            this.gpbNewEstante.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpbNewEstante.Location = new System.Drawing.Point(2, 3);
            this.gpbNewEstante.Name = "gpbNewEstante";
            this.gpbNewEstante.Size = new System.Drawing.Size(193, 242);
            this.gpbNewEstante.TabIndex = 0;
            this.gpbNewEstante.TabStop = false;
            this.gpbNewEstante.Text = "Nuevo Estante";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(50, 202);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 34);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Agregar";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(14, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Número de estante";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(28, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 27);
            this.textBox3.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(14, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Sector";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(28, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 27);
            this.textBox2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(14, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(28, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 27);
            this.textBox1.TabIndex = 0;
            // 
            // Estantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 313);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlgpbEstanteFORM);
            this.Name = "Estantes";
            this.Text = "Estantes";
            this.panel1.ResumeLayout(false);
            this.gpbListEstante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaListEstante)).EndInit();
            this.pnlgpbEstanteFORM.ResumeLayout(false);
            this.gpbNewEstante.ResumeLayout(false);
            this.gpbNewEstante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbListEstante;
        private System.Windows.Forms.DataGridView dtaListEstante;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfNumeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn selfNumero;
        private System.Windows.Forms.Panel pnlgpbEstanteFORM;
        private System.Windows.Forms.GroupBox gpbNewEstante;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}