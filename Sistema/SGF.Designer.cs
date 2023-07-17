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
            this.ojoMostrarContraseña = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtUser = new Guna.UI.WinForms.GunaLineTextBox();
            this.lnkLabel = new System.Windows.Forms.LinkLabel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlNavLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMainLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ojoMostrarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnlNavLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainLogin
            // 
            this.pnlMainLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMainLogin.Controls.Add(this.button1);
            this.pnlMainLogin.Controls.Add(this.ojoMostrarContraseña);
            this.pnlMainLogin.Controls.Add(this.iconPictureBox2);
            this.pnlMainLogin.Controls.Add(this.iconPictureBox1);
            this.pnlMainLogin.Controls.Add(this.txtPassword);
            this.pnlMainLogin.Controls.Add(this.txtUser);
            this.pnlMainLogin.Controls.Add(this.lnkLabel);
            this.pnlMainLogin.Controls.Add(this.lblDescription);
            this.pnlMainLogin.Controls.Add(this.btnForgotPassword);
            this.pnlMainLogin.Controls.Add(this.btnLogin);
            this.pnlMainLogin.Controls.Add(this.label3);
            this.pnlMainLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMainLogin.Location = new System.Drawing.Point(0, 64);
            this.pnlMainLogin.Name = "pnlMainLogin";
            this.pnlMainLogin.Size = new System.Drawing.Size(335, 244);
            this.pnlMainLogin.TabIndex = 0;
            // 
            // ojoMostrarContraseña
            // 
            this.ojoMostrarContraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ojoMostrarContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ojoMostrarContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.ojoMostrarContraseña.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ojoMostrarContraseña.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.ojoMostrarContraseña.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.ojoMostrarContraseña.IconSize = 31;
            this.ojoMostrarContraseña.Location = new System.Drawing.Point(297, 101);
            this.ojoMostrarContraseña.Name = "ojoMostrarContraseña";
            this.ojoMostrarContraseña.Size = new System.Drawing.Size(35, 31);
            this.ojoMostrarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ojoMostrarContraseña.TabIndex = 40;
            this.ojoMostrarContraseña.TabStop = false;
            this.ojoMostrarContraseña.Click += new System.EventHandler(this.ojoMostrarContraseña_Click);
            this.ojoMostrarContraseña.MouseLeave += new System.EventHandler(this.ojoMostrarContraseña_MouseLeave);
            this.ojoMostrarContraseña.MouseHover += new System.EventHandler(this.ojoMostrarContraseña_MouseHover);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 25;
            this.iconPictureBox2.Location = new System.Drawing.Point(5, 104);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(25, 26);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 39;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(5, 64);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 26);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 38;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.LineColor = System.Drawing.Color.LightGray;
            this.txtPassword.Location = new System.Drawing.Point(32, 102);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(267, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Admin12301";
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogin_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.Animated = true;
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(168)))), ((int)(((byte)(225)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.LineColor = System.Drawing.Color.LightGray;
            this.txtUser.Location = new System.Drawing.Point(32, 62);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.Size = new System.Drawing.Size(298, 30);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Admin12301@gmail.com";
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogin_KeyPress);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.ojoMostrarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnlNavLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainLogin;
        private System.Windows.Forms.Panel pnlNavLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblDescription;
        private LinkLabel lnkLabel;
        private Guna.UI.WinForms.GunaLineTextBox txtUser;
        private Guna.UI.WinForms.GunaLineTextBox txtPassword;
        private FontAwesome.Sharp.IconPictureBox ojoMostrarContraseña;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

