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
            textBox1 = new TextBox();
            lblUserEmail = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(187, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserEmail.Location = new Point(331, 144);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(130, 21);
            lblUserEmail.TabIndex = 2;
            lblUserEmail.Text = "Username/Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(355, 194);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaption;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(187, 218);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(404, 23);
            txtPassword.TabIndex = 4;
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
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(355, 247);
            button1.Name = "button1";
            button1.Size = new Size(77, 30);
            button1.TabIndex = 7;
            button1.Text = "Forgot";
            button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUserEmail);
            Controls.Add(textBox1);
            Controls.Add(lblLogin);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox textBox1;
        private Label lblUserEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button button1;
    }
}