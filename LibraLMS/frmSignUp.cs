using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

//SQL 
using System.Data.SqlClient;
using System.IO;

namespace LibraLMS
{
    public partial class frmSignUp : Form
    {
        public string[] ListOfCourses = { "BS in Computer Science", "BS in Information Technology", "BS in Information Systems",
            "BS in Marine Engineering", "Marine Transportation (BSMT)", "BS in Business Administration"
                                    ,"BS in Accountancy", "BS in Hospitality Management", "Bachelor of Multimedia Arts"};
        public frmSignUp()
        {
            InitializeComponent();


        }

        public string GetRegRes(RadioButton rdoButton)
        {
            if (rdoButton.Checked)
            {
                return rdoButton.Text;
            }
            else
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string firstName = fNameBox.Text;
                string pattern = "^[A - Za - z]{ 1,8}$";
       
;
            bool isValid = Regex.IsMatch(firstName, pattern);
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string userRes;

       
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91PB1EBQ\\SQLEXPRESS;Initial Catalog=LibraDatabase;Integrated Security=True");
            
             SqlCommand cmd = new SqlCommand("Insert Into UserRegistry (UserPassword ,Username, UserImage, UserType)Values('"+ lNameBox.Text +"','"+ fNameBox.Text + "', @Pictures, @userRes)", conn);

            MemoryStream stream = new MemoryStream();

            pbAvatar.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();
            cmd.Parameters.AddWithValue("@Pictures", pic);
            if (userRad.Checked)
            {
                userRes = GetRegRes(userRad);
                cmd.Parameters.AddWithValue("@userRes", userRes);

            }
            else if (adminRad.Checked)
            {
                userRes = GetRegRes(userRad);
                cmd.Parameters.AddWithValue("@userRes", userRes);
            }
            else
            {
                MessageBox.Show("Please choose a member type", "Error sign up");
            }
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("User Detail Save...");
        }
        
        private void frmSignUp_Load(object sender, EventArgs e)
        {
            foreach (string s in ListOfCourses)
            {
                courseCB.Items.Add(s);
            }
    
        }

        private void btnMyBooks_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            string filename = System.IO.Path.GetFileName(opnfd.FileName);
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";


            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void adminRad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblLMS_Click(object sender, EventArgs e)
        {

        }
    } 
}

    

