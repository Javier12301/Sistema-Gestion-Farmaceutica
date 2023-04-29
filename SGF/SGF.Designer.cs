namespace SGF
{
    partial class SGF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            lblNavLogin = new Label();
            panel1 = new Panel();
            lnkLabel = new LinkLabel();
            lblDescription = new Label();
            btnForgotPassword = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUser = new TextBox();
            lblUser = new Label();
            lblMainLogin = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 125, 166);
            panel2.Controls.Add(lblNavLogin);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 66);
            panel2.TabIndex = 1;
            // 
            // lblNavLogin
            // 
            lblNavLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNavLogin.ForeColor = SystemColors.Control;
            lblNavLogin.Location = new Point(7, 6);
            lblNavLogin.Name = "lblNavLogin";
            lblNavLogin.Size = new Size(326, 55);
            lblNavLogin.TabIndex = 0;
            lblNavLogin.Text = "Bienvenido al sistema de gestión farmacéutica";
            lblNavLogin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lnkLabel);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(btnForgotPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(lblMainLogin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 242);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lnkLabel
            // 
            lnkLabel.ActiveLinkColor = Color.AliceBlue;
            lnkLabel.AutoSize = true;
            lnkLabel.Location = new Point(64, 215);
            lnkLabel.Name = "lnkLabel";
            lnkLabel.Size = new Size(184, 15);
            lnkLabel.TabIndex = 13;
            lnkLabel.TabStop = true;
            lnkLabel.Text = "javierramirez1230123@gmail.com";
            lnkLabel.LinkClicked += lnkLabel_LinkClicked;
            // 
            // lblDescription
            // 
            lblDescription.ForeColor = SystemColors.ButtonShadow;
            lblDescription.Location = new Point(5, 193);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(175, 45);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Desarrollado por Javier Ramírez.\r\nContacto:";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnForgotPassword.FlatStyle = FlatStyle.Flat;
            btnForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnForgotPassword.ForeColor = SystemColors.Highlight;
            btnForgotPassword.Location = new Point(134, 143);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(184, 30);
            btnForgotPassword.TabIndex = 11;
            btnForgotPassword.Text = "¿Olvidaste tu contraseña?";
            btnForgotPassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(38, 125, 166);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(38, 125, 166);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(7, 143);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 30);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(32, 102);
            txtPassword.MaximumSize = new Size(400, 30);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(294, 26);
            txtPassword.TabIndex = 9;
            txtPassword.Tag = "txtPassword";
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Font Awesome 6 Free Solid", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.FromArgb(90, 168, 225);
            lblPassword.Location = new Point(5, 102);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(25, 26);
            lblPassword.TabIndex = 8;
            lblPassword.Tag = "txtPassword";
            lblPassword.Text = "lock";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(32, 64);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(294, 26);
            txtUser.TabIndex = 7;
            txtUser.Tag = "txtUser";
            // 
            // lblUser
            // 
            lblUser.BackColor = Color.White;
            lblUser.Font = new Font("Font Awesome 6 Free Regular", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.FromArgb(90, 168, 225);
            lblUser.Location = new Point(5, 64);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(25, 26);
            lblUser.TabIndex = 4;
            lblUser.Tag = "txtUser";
            lblUser.Text = "user";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMainLogin
            // 
            lblMainLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainLogin.ForeColor = Color.FromArgb(90, 168, 225);
            lblMainLogin.Location = new Point(12, 6);
            lblMainLogin.Name = "lblMainLogin";
            lblMainLogin.Size = new Size(301, 55);
            lblMainLogin.TabIndex = 1;
            lblMainLogin.Text = "Iniciar Sesión";
            lblMainLogin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SGF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(335, 308);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "SGF";
            Text = "SGF";
            Load += SGF_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblNavLogin;
        private Panel panel1;
        private Label lblMainLogin;
        private Label lblUser;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUser;
        private Button btnForgotPassword;
        private Button btnLogin;
        private LinkLabel lnkLabel;
        private Label lblDescription;
    }
}