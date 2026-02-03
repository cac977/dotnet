namespace Lab2_B2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usrName.Clear();
            passwd.Clear();
            usrName.Focus();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (usrName.Text == "Admin" && passwd.Text == "Admin")
            {
                EmployeeDetails frm = new EmployeeDetails();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

    }
}

