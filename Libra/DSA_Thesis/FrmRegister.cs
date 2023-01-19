using DSA_Thesis;
using Libra_ELMS;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Libra_ELMS
{
    public partial class FrmRegister : Form
    {
      //  private readonly SQLQueryManager sqlQueryManager = new SQLQueryManager();
        private string userRegistryDBT = "UserRegistry";
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register(tbUsername.Text, tbPassword.Text, tbConfirmPassword.Text, cbAccountType.Text);
        }

        private void Register(string username, string pass, string confirmPass, string type)
        {               
            bool IsNotTaken = CheckUsername(username);
            bool IsMatch = CheckPass(pass, confirmPass);
            FrmLogin frmLogin = new FrmLogin();

            try
            {
                if (IsNotTaken && IsMatch)
                {
                    if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(confirmPass) || string.IsNullOrEmpty(type)){
                        throw new Exception("Please input all the required information!");
                    }
                    SqlConnection connection = new SqlConnection("Data Source=LAPTOP-91PB1EBQ\\SQLEXPRESS;Initial Catalog=LibraDatabase;Integrated Security=True");
                    connection.Open();
                    SqlCommand cmd = new SqlCommand($"INSERT INTO UserRegistry(Username, UserPassword, UserType) VALUES (@username, @pass,@type)", connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.ExecuteNonQuery();
                   var choice = MessageBox.Show("Account Created Successfully!","Congratulations!", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                    if(choice == DialogResult.OK)
                    {
                        frmLogin.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username is Taken! or Password does not match!");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on creating account", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation); ;
            }

        }

        private bool CheckUsername(string username)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-91PB1EBQ\\SQLEXPRESS;Initial Catalog=LibraDatabase;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserRegistry WHERE Username = @username", connection);
            command.Parameters.AddWithValue("@username", username);
            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
                return false;
                // username already exists
            }
            else
            {
            return true;
                // username is available
            }
        }


        private bool CheckPass(string pass, string confirmPass)
        {
            return pass.Equals(confirmPass);    
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }
    }
}
