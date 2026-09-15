namespace Week4Assignment4._2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Teacher" && txtPassword.Text == "Admin")
            {
                MessageBox.Show("Login Successful");
                TeacherForm teacherForm = new TeacherForm();
                teacherForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }
    }
}
