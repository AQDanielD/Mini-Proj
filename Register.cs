using Npgsql;
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
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnPasswordView_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnConfirmPasswordView_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = false;
        }

        private void btnConfirmPasswordView_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        Random RNG = new Random();

        public class UserReg
        {
            public string Username = "";
            public string Email = "";
            public string Fname = "";
            public string Sname = "";
            public int Password;
        }
        public static string cs = "Host=ragged-mummy-11407.8nj.cockroachlabs.cloud;Port=26257;Database=HomeWorkBud;Username=aq232596_aquinas_ac_;Password=72eg0Wd7zpeV1TLCwAqr2A;SSL Mode=Prefer;Trust Server Certificate=true";
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                err.Visible = false;
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

                int UsernameCount = 0;

                using (var conn = new NpgsqlConnection(cs))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand("SELECT COUNT(*) as username_count FROM Users WHERE Username = @value1", conn))
                    {
                        cmd.Parameters.AddWithValue("value1", txtUsername.Text);
                        UsernameCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    conn.Close();
                }

                if (UsernameCount != 0)
                {
                    errDupUsername.Visible = true;
                }
                else { errDupUsername.Visible = false; }




                if (txtUsername.Text == "" || txtEmail.Text == "" || txtFName.Text == "" || txtSName.Text == "" || txtPassword.Text == "")
                {
                    err2.Visible = true;
                }
                if (txtEmail.Text.Contains("@") == false)
                {
                    errInvalidEmail.Visible = true;
                }
                else
                {
                    errInvalidEmail.Visible = false;
                    err2.Visible = false;
                    if (count > 0 && txtPassword.Text.Length >= 8 && txtPassword.Text != "")
                    {
                        using (var conn = new NpgsqlConnection(cs))
                        {
                            conn.Open();
                            using (var cmd = new NpgsqlCommand("INSERT INTO Users(Username,Email,Fname,Sname,Password,key) VALUES(@value1,@value2,@value3,@value4,@value5,@Value6)", conn))
                            {
                                txtPassword.Text = txtPassword.Text.GetHashCode().ToString();
                                cmd.Parameters.AddWithValue("value1", txtUsername.Text);
                                cmd.Parameters.AddWithValue("value2", txtEmail.Text);
                                cmd.Parameters.AddWithValue("value3", txtFName.Text);
                                cmd.Parameters.AddWithValue("value4", txtSName.Text);
                                cmd.Parameters.AddWithValue("value5", txtPassword.Text);
                                cmd.Parameters.AddWithValue("value6", RNG.Next(100000,1000000));
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Login login = new())
            {
                login.ShowDialog();
            }
            this.Close();
        }
    }
}
