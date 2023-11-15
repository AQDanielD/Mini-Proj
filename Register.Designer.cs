namespace Mini_Proj
{
    partial class Register
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtFName = new TextBox();
            txtSName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnPasswordView = new Button();
            btnConfirmPasswordView = new Button();
            btnCreate = new Button();
            errUsername = new ErrorProvider(components);
            errEmail = new ErrorProvider(components);
            errPassword = new ErrorProvider(components);
            errPasswordMatch = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errPasswordMatch).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(283, 56);
            label1.Name = "label1";
            label1.Size = new Size(216, 63);
            label1.TabIndex = 0;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = SystemColors.Desktop;
            txtUsername.Location = new Point(269, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(236, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = SystemColors.Desktop;
            txtEmail.Location = new Point(269, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(235, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtFName
            // 
            txtFName.ForeColor = SystemColors.Desktop;
            txtFName.Location = new Point(268, 198);
            txtFName.Name = "txtFName";
            txtFName.PlaceholderText = "First name";
            txtFName.Size = new Size(236, 23);
            txtFName.TabIndex = 3;
            // 
            // txtSName
            // 
            txtSName.ForeColor = SystemColors.Desktop;
            txtSName.Location = new Point(269, 227);
            txtSName.Name = "txtSName";
            txtSName.PlaceholderText = "Second Name";
            txtSName.Size = new Size(236, 23);
            txtSName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.Desktop;
            txtPassword.Location = new Point(269, 256);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(236, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.ForeColor = SystemColors.Desktop;
            txtConfirmPassword.Location = new Point(269, 285);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(236, 23);
            txtConfirmPassword.TabIndex = 6;
            // 
            // btnPasswordView
            // 
            btnPasswordView.BackColor = SystemColors.GradientInactiveCaption;
            btnPasswordView.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnPasswordView.FlatStyle = FlatStyle.Flat;
            btnPasswordView.Location = new Point(510, 257);
            btnPasswordView.Name = "btnPasswordView";
            btnPasswordView.Size = new Size(25, 24);
            btnPasswordView.TabIndex = 7;
            btnPasswordView.UseVisualStyleBackColor = false;
            btnPasswordView.MouseDown += btnPasswordView_MouseDown;
            btnPasswordView.MouseUp += btnPasswordView_MouseUp;
            // 
            // btnConfirmPasswordView
            // 
            btnConfirmPasswordView.BackColor = SystemColors.GradientInactiveCaption;
            btnConfirmPasswordView.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnConfirmPasswordView.FlatStyle = FlatStyle.Flat;
            btnConfirmPasswordView.Location = new Point(510, 285);
            btnConfirmPasswordView.Name = "btnConfirmPasswordView";
            btnConfirmPasswordView.Size = new Size(25, 23);
            btnConfirmPasswordView.TabIndex = 8;
            btnConfirmPasswordView.UseVisualStyleBackColor = false;
            btnConfirmPasswordView.MouseDown += btnConfirmPasswordView_MouseDown;
            btnConfirmPasswordView.MouseUp += btnConfirmPasswordView_MouseUp;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(322, 314);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(131, 29);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // errUsername
            // 
            errUsername.ContainerControl = this;
            // 
            // errEmail
            // 
            errEmail.ContainerControl = this;
            // 
            // errPassword
            // 
            errPassword.ContainerControl = this;
            // 
            // errPasswordMatch
            // 
            errPasswordMatch.ContainerControl = this;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(btnConfirmPasswordView);
            Controls.Add(btnPasswordView);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtSName);
            Controls.Add(txtFName);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)errUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)errEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)errPasswordMatch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtFName;
        private TextBox txtSName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnPasswordView;
        private Button btnConfirmPasswordView;
        private Button btnCreate;
        private ErrorProvider errUsername;
        private ErrorProvider errEmail;
        private ErrorProvider errPassword;
        private ErrorProvider errPasswordMatch;
    }
}