using Libra_ELMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DSA_Thesis
{
    public partial class FrmUser : Form
    {
        private readonly SQLQueryManager sqlQueryManager = new SQLQueryManager();
        private string userRegistryDBT = "UserRegistry";
        private string bookRegistryDBT = "BookRegistry";
        private string borrowRegistryDBT = "BorrowRegistry";
        private string nameUser;
        public FrmUser()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-91PB1EBQ\\SQLEXPRESS;Initial Catalog=LibraDatabase;Integrated Security=True");
            connection.Open();
            string query = $"SELECT BookRegistry.BookTitle, BorrowRegistry.BorrowDate, BorrowRegistry.ReturnDate FROM " +
                $"bookRegistry JOIN borrowRegistry ON BorrowRegistry.BookID = BookRegistry.BookID;";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvMyBooks.DataSource = dt;
        }
        public FrmUser(string nameUser)
        {
            InitializeComponent();
            this.nameUser = nameUser;
            lblUserID.Text = nameUser;
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-91PB1EBQ\\SQLEXPRESS;Initial Catalog=LibraDatabase;Integrated Security=True");
            connection.Open();
            string query = $"SELECT BookRegistry.BookTitle, BorrowRegistry.BorrowDate, BorrowRegistry.ReturnDate FROM " +
                $"bookRegistry JOIN borrowRegistry ON BorrowRegistry.BookID = BookRegistry.BookID;";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvMyBooks.DataSource = dt;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {

            Search(cbCategory.Text, tbSearchBar.Text);
        }

        private void Search(string category, string keyword)
        {

           /* if (category.Equals("All"))
            {
                sqlQueryManager.GetData(dgvBookRegistry, $"select BookTitle, BookAuthor, BookPublisher, BookStatus from" +
                           $" {bookRegistryDBT} where BookTitle='{keyword}' or " +
                          $"BookAuthor='{keyword}' or BookPublisher='{keyword}' or BookStatus='{keyword}'; ");
            }*/
                 switch (category)
            {
                case "All":
                    sqlQueryManager.GetData(dgvBookRegistry, $"select BookTitle, BookAuthor, BookPublisher, BookStatus from" +
                        $" {bookRegistryDBT} where BookTitle='{keyword}' or " +
                        $"BookAuthor='{keyword}' or BookPublisher='{keyword}' or BookStatus='{keyword}'; ");
                    
                    break;
                case "Title":
                    sqlQueryManager.GetData(dgvBookRegistry, $"select BookTitle, BookAuthor, BookPublisher, BookStatus from" +
                        $" {bookRegistryDBT} where BookTitle='{keyword}'; ");
                    break;
                case "Author":
                    sqlQueryManager.GetData(dgvBookRegistry, $"select BookTitle, BookAuthor, BookPublisher, BookStatus from" +
                        $" {bookRegistryDBT} where BookAuthor='{keyword}'; ");
                    break;
                case "Publisher":
                    sqlQueryManager.GetData(dgvBookRegistry, $"select select BookTitle, BookAuthor, BookPublisher, BookStatus from" +
                        $" {bookRegistryDBT} where BookPublisher='{keyword}'; ");
                    break;
                case "Status":
                    sqlQueryManager.GetData(dgvBookRegistry, $"select select BookTitle, BookAuthor, BookPublisher, BookStatus from" +
                        $" {bookRegistryDBT} where BookStatus='{keyword}'; ");
                    break;
                default:
                    RefreshDVGBookRegistry();
                    break;
            }

        }

        private void RefreshDVGBookRegistry()
        {
            sqlQueryManager.GetData(dgvBookRegistry, $"select BookTitle, BookAuthor, BookPublisher, BookStatus from" +
                $" {bookRegistryDBT};");
        }
        private void RefreshDVGUserBorrow() {
            //Does not work Multi-line error
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-91PB1EBQ\\SQLEXPRESS;Initial Catalog=LibraDatabase;Integrated Security=True");
            connection.Open();
            string query = $"SELECT BookRegistry.BookTitle, BorrowRegistry.BorrowDate, BorrowRegistry.ReturnDate FROM " +
                $"bookRegistry JOIN borrowRegistry ON BorrowRegistry.BookID = BookRegistry.BookID;";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvMyBooks.DataSource = dt;
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            RefreshDVGBookRegistry();
            RefreshDVGUserBorrow();
            cbCategory.Text = "All";
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;


            dgvBookRegistry.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvBookRegistry.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvBookRegistry.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMyBooks.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMyBooks.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMyBooks.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(cbCategory.Text, tbSearchBar.Text);
            tbUser.SelectTab(1);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (FrmLogin.frmLogin != null)
            {
                FrmLogin.frmLogin.Show();
                this.Dispose();
            }
        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
