namespace Mini_Proj
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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

    }
}