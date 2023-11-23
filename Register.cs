using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Proj
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnPasswordView_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = default;
        }

        private void btnPasswordView_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnConfirmPasswordView_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmPassword.PasswordChar = default;
        }

        private void btnConfirmPasswordView_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmPassword.PasswordChar = '*';
        }

        public class UserReg
        {
            public string Username = "";
            public string Email = "";
            public string Fname = "";
            public string Sname = "";
            public int Password;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                UserReg reg = new UserReg();
                reg.Username = txtUsername.Text;
                reg.Email = txtEmail.Text;
                reg.Fname = txtFName.Text;
                reg.Sname = txtSName.Text;
                reg.Password = txtPassword.Text.GetHashCode();
                byte[] asciiBytes = Encoding.ASCII.GetBytes(txtPassword.Text);
                int count = 0;
                for (int i = 0; i < txtPassword.Text.Length; i++)
                {
                    if ((33 <= asciiBytes[i] && asciiBytes[i] <= 47) || (58 <= asciiBytes[i] && asciiBytes[i] <= 64))
                    {
                        count++;
                    }
                    
                }

                if (txtUsername.Text == "" || txtEmail.Text == "" || txtFName.Text == "" || txtSName.Text == "" || txtPassword.Text == "")
                {
                    err2.Visible = true;
                }
                else
                {
                    if (count > 0)
                    {

                        this.Hide();
                        using (Login login = new())
                        {
                            login.ShowDialog();
                        }
                        this.Close();
                    }
                    else
                    {
                        err.Visible = true;
                    }
                }

            }
            else
            {
                err.Visible = true;
            }
        }

        

        private void CreateValidation()
        {
            bool valid = false;


        }
    }
}
