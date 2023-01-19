using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraLMS
{
    public partial class frmUser_Books : Form
    {
        public frmUser_Books()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin returnLogin = new frmLogin();
            returnLogin.Show();
            this.Hide();
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-91PB1EBQ\\SQLEXPRESS;Initial Catalog=LibraDatabase;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INT O");
            pbAvatar.Image = new Bitmap(pbAvatar.Width, pbAvatar.Height);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

        }
    }
}
