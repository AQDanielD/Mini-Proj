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
    public partial class Forgot : Form
    {
        public Forgot()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Login login = new())
            {
                login.ShowDialog();
            }
            this.Close();
        }
        public static string cs = "Host=ragged-mummy-11407.8nj.cockroachlabs.cloud;Port=26257;Database=HomeWorkBud;Username=aq232596_aquinas_ac_;Password=72eg0Wd7zpeV1TLCwAqr2A;SSL Mode=Prefer;Trust Server Certificate=true";
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string val = txtEmailUsername.Text;

            int valCount = 0;

            using (var conn = new NpgsqlConnection(cs))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) as username_count FROM Users WHERE Username = @value1", conn))
                {
                    cmd.Parameters.AddWithValue("value1", txtEmailUsername.Text);
                    valCount = Convert.ToInt32(cmd.ExecuteScalar());
                }

                conn.Close();
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) as username_count FROM Users WHERE Email = @value1", conn))
                {
                    cmd.Parameters.AddWithValue("value1", txtEmailUsername.Text);
                    valCount = Convert.ToInt32(cmd.ExecuteScalar());
                }

                conn.Close();
            }

            if (valCount > 0)
            {
                btnConfirm.Visible = false;
                txtEmailUsername.Visible = false;
                errInvalid.Visible = false;
                txtKey.Visible = true;
                btnKeyConfirm.Visible = true;
            }
            else
            {
                errInvalid.Visible = true;
            }

        }

        private void btnKeyConfirm_Click(object sender, EventArgs e)
        {
            int valCount = 0;
            int valCount2 = 0;

            using (var conn = new NpgsqlConnection(cs))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT key FROM Users WHERE Username = '@Value1'", conn))
                {
                    cmd.Parameters.AddWithValue("value1", txtEmailUsername.Text);
                    valCount = Convert.ToInt32(cmd.ExecuteScalar());
                }

                conn.Close();

                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT key FROM Users WHERE Email = '@Value1'", conn))
                {
                    cmd.Parameters.AddWithValue("value1", txtEmailUsername.Text);
                    valCount2 = Convert.ToInt32(cmd.ExecuteScalar());
                }

                conn.Close();

                if (valCount.ToString() == txtKey.Text || valCount2.ToString() == txtKey.Text)
                {
                    txtKey.Visible = false;
                    btnKeyConfirm.Visible = false;
                    errKey.Visible = false;

                    txtPassword.Visible = true;
                    txtConfirmPassword.Visible = true;
                    btnConfirmPassword.Visible = true;
                }
                else
                {
                    errKey.Visible = true;
                }
            }
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(txtPassword.Text);
            int count = 0;
            for (int i = 0; i < txtPassword.Text.Length; i++)
            {
                if ((33 <= asciiBytes[i] && asciiBytes[i] <= 47) || (58 <= asciiBytes[i] && asciiBytes[i] <= 64))
                {
                    count++;
                }

            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errPassword.Visible = true;
            }
            if (txtPassword.Text.Length < 8 || count == 0)
            {
                errPassword8Char.Visible = true;
            }
            else
            {
                using (var conn = new NpgsqlConnection(cs))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand("UPDATE public.users SET password = @newPassword WHERE key = @key", conn))
                    {
                        // Assuming txtNewPassword.Text contains the new password
                        cmd.Parameters.AddWithValue("newPassword", txtPassword.Text);

                        // Assuming txtUsername.Text contains the target username
                        cmd.Parameters.AddWithValue("key", txtKey.Text);

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
                this.Hide();
                using (Login login = new())
                {
                    login.ShowDialog();
                }
                this.Close();
            }

        }
    }
}
