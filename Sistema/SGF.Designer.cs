using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema
{
    partial class SGF
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainLogin = new System.Windows.Forms.Panel();
            this.lblEyePassword = new System.Windows.Forms.Label();
            this.lnkLabel = new System.Windows.Forms.LinkLabel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pctLineUser = new System.Windows.Forms.PictureBox();
            this.pctLinePassword = new System.Windows.Forms.PictureBox();
            this.pnlNavLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMainLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinePassword)).BeginInit();
            this.pnlNavLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainLogin
            // 
            this.pnlMainLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMainLogin.Controls.Add(this.lblEyePassword);
            this.pnlMainLogin.Controls.Add(this.lnkLabel);
            this.pnlMainLogin.Controls.Add(this.lblPassword);
            this.pnlMainLogin.Controls.Add(this.lblUser);
            this.pnlMainLogin.Controls.Add(this.lblDescription);
            this.pnlMainLogin.Controls.Add(this.btnForgotPassword);
            this.pnlMainLogin.Controls.Add(this.btnLogin);
            this.pnlMainLogin.Controls.Add(this.txtPassword);
            this.pnlMainLogin.Controls.Add(this.txtUser);
            this.pnlMainLogin.Controls.Add(this.label3);
            this.pnlMainLogin.Controls.Add(this.pctLineUser);
            this.pnlMainLogin.Controls.Add(this.pctLinePassword);
            this.pnlMainLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMainLogin.Location = new System.Drawing.Point(0, 64);
            this.pnlMainLogin.Name = "pnlMainLogin";
            this.pnlMainLogin.Size = new System.Drawing.Size(335, 244);
            this.pnlMainLogin.TabIndex = 0;
            // 
            // lblEyePassword
            // 
            this.lblEyePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblEyePassword.Font = new System.Drawing.Font("Font Awesome 6 Free Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEyePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.lblEyePassword.Location = new System.Drawing.Point(297, 101);
            this.lblEyePassword.Name = "lblEyePassword";
            this.lblEyePassword.Size = new System.Drawing.Size(35, 31);
            this.lblEyePassword.TabIndex = 14;
            this.lblEyePassword.Text = "eye";
            this.lblEyePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEyePassword.Click += new System.EventHandler(this.lblEyePassword_Click);
            this.lblEyePassword.MouseLeave += new System.EventHandler(this.lblEyePassword_MouseLeave);
            this.lblEyePassword.MouseHover += new System.EventHandler(this.lblEyePassword_MouseHover);
            // 
            // lnkLabel
            // 
            this.lnkLabel.ActiveLinkColor = System.Drawing.Color.AliceBlue;
            this.lnkLabel.AutoSize = true;
            this.lnkLabel.Location = new System.Drawing.Point(58, 215);
            this.lnkLabel.Name = "lnkLabel";
            this.lnkLabel.Size = new System.Drawing.Size(165, 13);
            this.lnkLabel.TabIndex = 13;
            this.lnkLabel.TabStop = true;
            this.lnkLabel.Text = "javierramirez1230123@gmail.com";
            this.lnkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabel_LinkClicked);
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Font Awesome 6 Free Solid", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.lblPassword.Location = new System.Drawing.Point(5, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(25, 26);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Tag = "txtPassword";
            this.lblPassword.Text = "lock";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.White;
            this.lblUser.Font = new System.Drawing.Font("Font Awesome 6 Free Regular", 12F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.lblUser.Location = new System.Drawing.Point(5, 64);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(25, 26);
            this.lblUser.TabIndex = 4;
            this.lblUser.Tag = "txtUser";
            this.lblUser.Text = "user";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDescription.Location = new System.Drawing.Point(5, 193);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(175, 45);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Desarrollado por Javier Ramírez.\r\nContacto:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnForgotPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnForgotPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnForgotPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnForgotPassword.Location = new System.Drawing.Point(134, 143);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(184, 30);
            this.btnForgotPassword.TabIndex = 4;
            this.btnForgotPassword.Text = "¿Olvidaste tu contraseña?";
            this.btnForgotPassword.UseVisualStyleBackColor = true;
            this.btnForgotPassword.MouseLeave += new System.EventHandler(this.btnForgotPassword_MouseLeave);
            this.btnForgotPassword.MouseHover += new System.EventHandler(this.btnForgotPassword_MouseHover);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(7, 143);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogin_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPassword.Location = new System.Drawing.Point(32, 102);
            this.txtPassword.MaximumSize = new System.Drawing.Size(400, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(272, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "txtPassword";
            this.txtPassword.Text = "Admin12301";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown_1);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogin_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtUser.Location = new System.Drawing.Point(32, 64);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(298, 26);
            this.txtUser.TabIndex = 1;
            this.txtUser.Tag = "txtUser";
            this.txtUser.Text = "Admin12301@gmail.com";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown_1);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogin_KeyPress);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Iniciar Sesión";
            // 
            // pctLineUser
            // 
            this.pctLineUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.pctLineUser.Location = new System.Drawing.Point(32, 71);
            this.pctLineUser.Name = "pctLineUser";
            this.pctLineUser.Size = new System.Drawing.Size(298, 22);
            this.pctLineUser.TabIndex = 15;
            this.pctLineUser.TabStop = false;
            this.pctLineUser.Tag = "txtUser";
            // 
            // pctLinePassword
            // 
            this.pctLinePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.pctLinePassword.Location = new System.Drawing.Point(32, 105);
            this.pctLinePassword.Name = "pctLinePassword";
            this.pctLinePassword.Size = new System.Drawing.Size(272, 26);
            this.pctLinePassword.TabIndex = 16;
            this.pctLinePassword.TabStop = false;
            this.pctLinePassword.Tag = "txtPassword";
            // 
            // pnlNavLogin
            // 
            this.pnlNavLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.pnlNavLogin.Controls.Add(this.label2);
            this.pnlNavLogin.Controls.Add(this.label1);
            this.pnlNavLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlNavLogin.Name = "pnlNavLogin";
            this.pnlNavLogin.Size = new System.Drawing.Size(335, 66);
            this.pnlNavLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenido al sistema de gestión farmacéutica";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al sistema de gestión farmacéutica";
            // 
            // SGF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 308);
            this.Controls.Add(this.pnlNavLogin);
            this.Controls.Add(this.pnlMainLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SGF";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SGF_Load);
            this.pnlMainLogin.ResumeLayout(false);
            this.pnlMainLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinePassword)).EndInit();
            this.pnlNavLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainLogin;
        private System.Windows.Forms.Panel pnlNavLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblDescription;
        private Label lblPassword;
        private Label lblUser;
        private LinkLabel lnkLabel;
        private Label lblEyePassword;
        private PictureBox pctLineUser;
        private PictureBox pctLinePassword;
    }
}

