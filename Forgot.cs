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

            }
            else
            {
                errInvalid.Visible = true;
            }

        }
    }
}
