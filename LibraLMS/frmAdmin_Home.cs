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
    public partial class frmAdmin_Home : Form
    {
        public frmAdmin_Home()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin returnLogin = new frmLogin();
            returnLogin.Show();
            this.Hide();
        }
    }
}
