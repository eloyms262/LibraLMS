using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraLMS
{
    public partial class frmUser_Home : Form
    {
        public frmUser_Home()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin returnLogin = new frmLogin();
            returnLogin.Show();
            this.Hide();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frmUser_Borrow borrowForm = new frmUser_Borrow();
            borrowForm.Show();
            this.Hide();
        }

        private void btnMyBooks_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
