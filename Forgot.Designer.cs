namespace Mini_Proj
{
    partial class Forgot
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
            label1 = new Label();
            txtEmailUsername = new TextBox();
            btnConfirm = new Button();
            btnBack = new Button();
            errInvalid = new Label();
            txtKey = new TextBox();
            btnKeyConfirm = new Button();
            errKey = new Label();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            errPassword = new Label();
            btnConfirmPassword = new Button();
            errPassword8Char = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(305, 56);
            label1.Name = "label1";
            label1.Size = new Size(172, 63);
            label1.TabIndex = 0;
            label1.Text = "Forgot";
            // 
            // txtEmailUsername
            // 
            txtEmailUsername.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailUsername.Location = new Point(223, 147);
            txtEmailUsername.Name = "txtEmailUsername";
            txtEmailUsername.PlaceholderText = "Email/Username";
            txtEmailUsername.Size = new Size(327, 27);
            txtEmailUsername.TabIndex = 1;
            txtEmailUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.InactiveCaption;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.ForeColor = SystemColors.ActiveCaptionText;
            btnConfirm.Location = new Point(352, 191);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(77, 29);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientActiveCaption;
            btnBack.FlatAppearance.BorderColor = SystemColors.GradientActiveCaption;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("MV Boli", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(-1, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 51);
            btnBack.TabIndex = 3;
            btnBack.Text = "<-Return";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // errInvalid
            // 
            errInvalid.AutoSize = true;
            errInvalid.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            errInvalid.ForeColor = Color.Red;
            errInvalid.Location = new Point(305, 127);
            errInvalid.Name = "errInvalid";
            errInvalid.Size = new Size(163, 17);
            errInvalid.TabIndex = 4;
            errInvalid.Text = "Username/Email not found!";
            errInvalid.Visible = false;
            // 
            // txtKey
            // 
            txtKey.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtKey.Location = new Point(223, 147);
            txtKey.Name = "txtKey";
            txtKey.PlaceholderText = "Key";
            txtKey.Size = new Size(327, 27);
            txtKey.TabIndex = 5;
            txtKey.Visible = false;
            // 
            // btnKeyConfirm
            // 
            btnKeyConfirm.BackColor = SystemColors.InactiveCaption;
            btnKeyConfirm.FlatAppearance.BorderColor = Color.Black;
            btnKeyConfirm.FlatStyle = FlatStyle.Flat;
            btnKeyConfirm.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKeyConfirm.ForeColor = SystemColors.ActiveCaptionText;
            btnKeyConfirm.Location = new Point(352, 191);
            btnKeyConfirm.Name = "btnKeyConfirm";
            btnKeyConfirm.Size = new Size(77, 29);
            btnKeyConfirm.TabIndex = 6;
            btnKeyConfirm.Text = "Confirm";
            btnKeyConfirm.UseVisualStyleBackColor = false;
            btnKeyConfirm.Visible = false;
            btnKeyConfirm.Click += btnKeyConfirm_Click;
            // 
            // errKey
            // 
            errKey.AutoSize = true;
            errKey.BackColor = SystemColors.GradientActiveCaption;
            errKey.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            errKey.ForeColor = Color.Red;
            errKey.Location = new Point(352, 127);
            errKey.Name = "errKey";
            errKey.Size = new Size(74, 17);
            errKey.TabIndex = 7;
            errKey.Text = "Invalid Key!";
            errKey.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(223, 147);
            txtPassword.MaxLength = 36;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(327, 27);
            txtPassword.TabIndex = 8;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Visible = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(223, 180);
            txtConfirmPassword.MaxLength = 36;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(327, 27);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.TextAlign = HorizontalAlignment.Center;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.Visible = false;
            // 
            // errPassword
            // 
            errPassword.AutoSize = true;
            errPassword.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            errPassword.ForeColor = Color.Red;
            errPassword.Location = new Point(305, 127);
            errPassword.Name = "errPassword";
            errPassword.Size = new Size(151, 17);
            errPassword.TabIndex = 10;
            errPassword.Text = "Passwords to not match!";
            errPassword.Visible = false;
            // 
            // btnConfirmPassword
            // 
            btnConfirmPassword.BackColor = SystemColors.InactiveCaption;
            btnConfirmPassword.FlatStyle = FlatStyle.Flat;
            btnConfirmPassword.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmPassword.ForeColor = Color.Black;
            btnConfirmPassword.Location = new Point(335, 213);
            btnConfirmPassword.Name = "btnConfirmPassword";
            btnConfirmPassword.Size = new Size(105, 30);
            btnConfirmPassword.TabIndex = 11;
            btnConfirmPassword.Text = "Confirm";
            btnConfirmPassword.UseVisualStyleBackColor = false;
            btnConfirmPassword.Visible = false;
            btnConfirmPassword.Click += btnConfirmPassword_Click;
            // 
            // errPassword8Char
            // 
            errPassword8Char.AutoSize = true;
            errPassword8Char.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            errPassword8Char.ForeColor = Color.Red;
            errPassword8Char.Location = new Point(180, 256);
            errPassword8Char.Name = "errPassword8Char";
            errPassword8Char.RightToLeft = RightToLeft.No;
            errPassword8Char.Size = new Size(435, 17);
            errPassword8Char.TabIndex = 12;
            errPassword8Char.Text = "Password needs to contain atleast 8 Characters and one special character!";
            errPassword8Char.TextAlign = ContentAlignment.MiddleLeft;
            errPassword8Char.Visible = false;
            // 
            // Forgot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(errPassword8Char);
            Controls.Add(btnConfirmPassword);
            Controls.Add(errPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(errKey);
            Controls.Add(btnKeyConfirm);
            Controls.Add(txtKey);
            Controls.Add(errInvalid);
            Controls.Add(btnBack);
            Controls.Add(btnConfirm);
            Controls.Add(txtEmailUsername);
            Controls.Add(label1);
            ForeColor = Color.CornflowerBlue;
            Name = "Forgot";
            Text = "Forgot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmailUsername;
        private Button btnConfirm;
        private Button btnBack;
        private Label errInvalid;
        private TextBox txtKey;
        private Button btnKeyConfirm;
        private Label errKey;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label errPassword;
        private Button btnConfirmPassword;
        private Label errPassword8Char;
    }
}