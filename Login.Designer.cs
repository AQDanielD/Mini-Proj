namespace Mini_Proj
{
    partial class Login
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
            lblLogin = new Label();
            txtUsernameEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnForgot = new Button();
            errLogin = new Label();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("MV Boli", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(322, 54);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(148, 63);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsernameEmail
            // 
            txtUsernameEmail.BackColor = SystemColors.InactiveCaption;
            txtUsernameEmail.BorderStyle = BorderStyle.FixedSingle;
            txtUsernameEmail.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsernameEmail.Location = new Point(187, 152);
            txtUsernameEmail.Name = "txtUsernameEmail";
            txtUsernameEmail.PlaceholderText = "Username/Email";
            txtUsernameEmail.Size = new Size(404, 27);
            txtUsernameEmail.TabIndex = 1;
            txtUsernameEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaption;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(187, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(404, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.InactiveCaption;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(187, 247);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.InactiveCaption;
            btnRegister.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(512, 247);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(79, 30);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnForgot
            // 
            btnForgot.BackColor = SystemColors.InactiveCaption;
            btnForgot.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnForgot.FlatStyle = FlatStyle.Flat;
            btnForgot.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnForgot.Location = new Point(355, 247);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(77, 30);
            btnForgot.TabIndex = 7;
            btnForgot.Text = "Forgot";
            btnForgot.UseVisualStyleBackColor = false;
            btnForgot.Click += btnForgot_Click;
            // 
            // errLogin
            // 
            errLogin.AutoSize = true;
            errLogin.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            errLogin.ForeColor = Color.Red;
            errLogin.Location = new Point(305, 132);
            errLogin.Name = "errLogin";
            errLogin.Size = new Size(165, 17);
            errLogin.TabIndex = 8;
            errLogin.Text = "Your credentials are wrong!\r\n";
            errLogin.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(errLogin);
            Controls.Add(btnForgot);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsernameEmail);
            Controls.Add(lblLogin);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtUsernameEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnForgot;
        private Label errLogin;
    }
}