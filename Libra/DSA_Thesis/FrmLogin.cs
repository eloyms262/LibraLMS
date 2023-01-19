using Libra_ELMS;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DSA_Thesis
{
    public partial class FrmLogin : Form
    {
        public static FrmLogin? frmLogin { get; private set; }
        public FrmUser? frmUser;
        public FrmAdmin? frmAdmin;
        private string nameUser;

        public FrmLogin()
        {
            InitializeComponent();
            frmLogin = this;
            frmLogin.CenterToScreen();
            tbPassword.PasswordChar = '\u2B24';

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Check if account type is admin or member 
            //Select UserType from UserRegistry and add condition

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-91PB1EBQ\\SQLEXPRESS;Initial Catalog=LibraDatabase;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserType FROM UserRegistry WHERE Username = @username AND UserPassword = @password", connection);
            cmd.Parameters.AddWithValue("@username", tbUsername.Text);
            cmd.Parameters.AddWithValue("@password", tbPassword.Text);
            string role = (string)cmd.ExecuteScalar();
            if (string.IsNullOrEmpty(role))
            {
                // user does not exist in the database with the provided credentials
                // show error message or redirect to login form
                MessageBox.Show("Error User does not exist", "No Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else
            {
                if (role == "Admin")
                {
                    nameUser = tbUsername.Text;
                    frmAdmin = new FrmAdmin(nameUser);
                    frmAdmin.Show();
                    this.Hide();
                    tbPassword.Clear();
                    tbUsername.Clear();
                    //nameUser = tbUsername.Text;
                    // user is an admin
                    // redirect to admin page
                }
                else if (role == "Member")
                {
                    nameUser = tbUsername.Text;
                    frmUser = new FrmUser(nameUser);
                    frmUser.Show();
                    this.Hide();
                    tbPassword.Clear();
                    tbUsername.Clear();
                    //nameUser = tbUsername.Text;
                    // user is a member
                    // redirect to member page
                }
            }





            
        }

      /*  private bool isAdmin(string )
        {

        }*/
        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}