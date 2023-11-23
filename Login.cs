using Npgsql;

namespace Mini_Proj
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string cs = "Host=ragged-mummy-11407.8nj.cockroachlabs.cloud;Port=26257;Database=HomeWorkBud;Username=aq232596_aquinas_ac_;Password=72eg0Wd7zpeV1TLCwAqr2A;SSL Mode=Prefer;Trust Server Certificate=true";

        public static void UserValidation()
        {
            Login User = new Login();
            (bool firstValue, bool secondValue) pair = (false, false);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------");
            Console.WriteLine("ADMIN LOGIN");


            //-----------------------
            if (UserUsernameFetch(cs, User.txtUsernameEmail.Text))
            {
                pair.firstValue = true;
            }
            else
            {
                User.errLogin.Visible = true;
            }
            //-----------------------

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;

            if (UserPasswordFetch(cs, User.txtPassword.Text))
            {
                pair.secondValue = true;
            }
            else
            {
                User.errLogin.Visible = true;
            }
            //-----------------------
            if (pair.firstValue == true && pair.secondValue == true)
            {
                //Show menu mainscreen for user and hide this one
            }
            else
            {
                //Unreachable
            }
        }

        public static bool UserUsernameFetch(string cs, string username)
        {
            using (var conn = new NpgsqlConnection(cs))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    // Use ExecuteScalar to get the count of records.
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Check if the count is greater than 0 to determine if the username exists.
                    return count > 0;
                }
            }
        }

        public static bool UserPasswordFetch(string cs, string password)
        {
            using (var conn = new NpgsqlConnection(cs))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM Users WHERE Password = @password", conn))
                {
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Register register = new())
            {
                register.ShowDialog();
            }
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserValidation();
        }
    }
}