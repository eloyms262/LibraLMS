using Libra_ELMS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DSA_Thesis
{
    public partial class FrmAdmin : Form
    {
        private readonly SQLQueryManager sqlQueryManager = new SQLQueryManager();
        private BindingSource bindingSource1 = new BindingSource();
        private string userRegistryDBT = "UserRegistry";
        private string bookRegistryDBT = "BookRegistry";
        private string borrowRegistryDBT = "BorrowRegistry";
        private string nameUser;
        private string connectionString = "Data Source=LAPTOP-91PB1EBQ\\SQLEXPRESS;Initial Catalog=LibraDatabase;Integrated Security=True"; 
        public FrmAdmin()
        {
            InitializeComponent();
            tabBookRegistry.AutoScroll = true;           
            this.CenterToScreen();
           
        }
        public FrmAdmin(string nameUser)
        {
            
            InitializeComponent();
            this.nameUser = nameUser;
            lblAdminID.Text = nameUser;
            tabBookRegistry.AutoScroll = true;
            this.CenterToScreen();

        }

        //Home Tab Controls
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Idk
            Search(tbSearchBar.Text);
            tcAdmin.SelectTab(2);
        }

        private void Search(string keyword)
        {
            sqlQueryManager.executeQuery($"select BookTitle, BookAuthor, BookPublisher, BookStatus from" +
                $" {bookRegistryDBT} where BookTitle='{keyword}' or " +
                $"BookAuthor='{keyword}' or BookPublisher='{keyword}' or BookStatus='{keyword}'; ");
        }
        //User Tab Controls
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbUserPassword.Text) || string.IsNullOrEmpty(cbUserType.Text))
            {
                MessageBox.Show("Please provide all required inputs", "Error inserting User information",MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {

            InsertUser(tbUsername.Text, tbUserPassword.Text, cbUserType.Text);
            }
            /*            bookRegistryDGVM.InsertRecord(tbUsername.Text, tbUserPassword.Text, cbUserType.Text);*/
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            UpdateUser(Int32.Parse(tbUserID.Text), tbUsername.Text, tbUserPassword.Text);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser(Int32.Parse(tbUserID.Text));
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            SearchUser(Int32.Parse(tbUserID.Text), tbUsername.Text, tbUserPassword.Text);
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            ClearUser();
        }

        private void btnRefreshUser_Click(object sender, EventArgs e)
        {
            RefreshUser();
        }

        //Book Tab Controls
        private void btnNewBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBookTitle.Text) || string.IsNullOrEmpty(tbAuthor.Text) ||
                string.IsNullOrEmpty(tbPublisher.Text) || string.IsNullOrEmpty(cbStatus.Text) || string.IsNullOrEmpty(cbStatus.Text)) {
                MessageBox.Show("Please provide all required inputs", "Erro inserting Book information", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
            InsertBook(tbBookTitle.Text, tbAuthor.Text, tbPublisher.Text, cbStatus.Text);
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBook(Int32.Parse(tbBookID.Text), tbBookTitle.Text, tbAuthor.Text, tbPublisher.Text, cbStatus.Text);
            }
            catch {
                MessageBox.Show("Hi");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBook(Int32.Parse(tbBookID.Text));
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SearchBook(Int32.Parse(tbBookID.Text), tbBookTitle.Text, tbAuthor.Text, tbPublisher.Text, cbStatus.Text);
        }

        private void btnClearBook_Click(object sender, EventArgs e)
        {
            ClearBook();
        }

        private void btnRefreshBook_Click(object sender, EventArgs e)
        {
            RefreshBook();
        }

        //Borrow Tab Controls
        private void btnNewBorrow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(dateTimePicker2.Text) ||
                string.IsNullOrEmpty(tbBorrowBookID.Text) || string.IsNullOrEmpty(tbBorrowUserID.Text))
            {
                MessageBox.Show("Please provide all required inputs", "Error inserting User information",MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            }
            else
            {
            InsertBorrow(Int32.Parse(tbBorrowUserID.Text), Int32.Parse(tbBorrowBookID.Text), 
                dateTimePicker1.Value.Date.ToString("yyyyMMdd"), dateTimePicker2.Value.Date.ToString("yyyyMMdd"));
            }
        }

        private void btnUpdateBorrow_Click(object sender, EventArgs e)
        {
            UpdateBorrow(Int32.Parse(tbBorrowID.Text), Int32.Parse(tbBorrowUserID.Text), 
                Int32.Parse(tbBorrowBookID.Text), dateTimePicker1.Value.Date.ToString("yyyyMMdd"), dateTimePicker2.Value.Date.ToString("yyyyMMdd"));
        }

        private void btnDeleteBorrow_Click(object sender, EventArgs e)
        {
            DeleteBorrow(Int32.Parse(tbBorrowID.Text));
        }

        private void btnSearchBorrow_Click(object sender, EventArgs e)
        {
            SearchBorrow(Int32.Parse(tbBorrowID.Text),Int32.Parse(tbBorrowUserID.Text), 
                Int32.Parse(tbBorrowBookID.Text), dateTimePicker1.Value.Date.ToString("yyyyMMdd"), dateTimePicker2.Value.Date.ToString("yyyyMMdd"));
        }

        private void btnClearBorrow_Click(object sender, EventArgs e)
        {
            ClearBorrow();
        }

        private void btnRefreshBorrow_Click(object sender, EventArgs e)
        {
            RefreshBorrow();
        }

        //User Tab
        private void InsertUser(string username, string password, string type)
        {
            sqlQueryManager.executeQuery($"insert into {userRegistryDBT} values ('{username}', '{password}', '{type}'); ");
            RefreshUser();
        }

        private void UpdateUser(int userID, string userame, string userPassword)
        {
            if (userame != "")
            {
                sqlQueryManager.executeQuery($"update {userRegistryDBT} set Username='{userame}' where UserID={userID}");
            }
            if (userPassword != "")
            {
                sqlQueryManager.executeQuery($"update {userRegistryDBT} set UserPassword='{userPassword}' where UserID={userID}");
            }
            RefreshUser();
        }

        private void DeleteUser(int userID)
        {
            sqlQueryManager.executeQuery($"delete from {userRegistryDBT} where UserId={userID}; ");
            RefreshUser();
            ClearUser();
        }

        private void SearchUser(int userID, string username, string userPassword)
        {
            sqlQueryManager.GetData(dgvUserRegistry, $"select * from {userRegistryDBT} where UserID={userID} or " +
                $"Username='{username}' or UserPassword='{userPassword}';");
        }

        private void ClearUser()
        {
            tbUserID.Text = "";
            tbUsername.Text = "";
            tbUserPassword.Text = "";
            cbUserType.Text = "--Select Type--";
        }

        private void RefreshUser()
        {
            sqlQueryManager.GetData(dgvUserRegistry, $"select UserID, Username, UserPassword," +
                $" UserType from {userRegistryDBT};");
        }

        //Book Tab
        private void InsertBook(string title, string author, string publisher, string status)
        {
            sqlQueryManager.executeQuery($"insert into {bookRegistryDBT} values ('{title}', '{author}', '{publisher}', " +
                $"'{status}');");
            RefreshBook();
            
        }

        private void UpdateBook(int bookID, string title, string author, string publisher, string status)
        {
            if (title != "")
            {
                sqlQueryManager.executeQuery($"update {bookRegistryDBT} set BookTitle='{title}' where BookID={bookID}");
            }
            if (author != "")
            {
                sqlQueryManager.executeQuery($"update {bookRegistryDBT} set BookAuthor='{author}' where BookID={bookID}");
            }
            if (publisher != "")
            {
                sqlQueryManager.executeQuery($"update {bookRegistryDBT} set BookPublisher='{publisher}' where BookID={bookID}");
            }
            if (status != "")
            {
                sqlQueryManager.executeQuery($"update {bookRegistryDBT} set BookStatus='{status}' where BookID={bookID}");
            }
            RefreshBook();
        }

        private void DeleteBook(int bookID)
        {
            sqlQueryManager.executeQuery($"delete from {bookRegistryDBT} where BookID={bookID}; ");
            RefreshBook();
            ClearBook();
        }

        private void SearchBook(int bookID, string title, string author, string publisher, string status)
        {
            sqlQueryManager.GetData(dgvBookRegistry, $"select * from {bookRegistryDBT} where BookID={bookID} or " +
                $"BookTitle='{title}' or BookAuthor='{author}' or BookPublisher='{publisher}' or " +
                $"BookStatus='{status}';");
        }

        private void ClearBook()
        {
            tbBookID.Text = "";
            tbBookTitle.Text = "";
            tbAuthor.Text = "";
            tbPublisher.Text = "";
            cbStatus.Text = "--Select Status--";
        }

        private void RefreshBook()
        {
            sqlQueryManager.GetData(dgvBookRegistry, $"select * from {bookRegistryDBT};");
        }

        //Borrow Tab
        private void InsertBorrow(int userID, int bookID, string bDate, string rDate)
        {
            if(CheckIfExists(userID, bookID))
            {
            sqlQueryManager.executeQuery($"insert into {borrowRegistryDBT} values ({userID}, {bookID}, '{bDate}', " +
            $"'{rDate}'); ");
            }
            RefreshBorrow();
        }

        public bool CheckIfExists(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM BorrowRegistry WHERE UserID = @userID AND BookID = @bookID", connection))
                {
                    command.Parameters.Add("@userID", SqlDbType.VarChar).Value = userID;
                    command.Parameters.Add("@bookID", SqlDbType.VarChar).Value = bookID;
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("User ID and Book ID do not exist in the database.", "Error inserting transaction", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        private void UpdateBorrow(int borrowID, int userID, int bookID, string bDate, string rDate)
        {
            if (userID != 0)
            {
                sqlQueryManager.executeQuery($"update {borrowRegistryDBT} set UserID={userID} where BorrowID={borrowID}");
            }
            if (bookID != 0)
            {
                sqlQueryManager.executeQuery($"update {borrowRegistryDBT} set BookID={bookID} where BorrowID={borrowID}");
            }
            if (bDate != "")
            {
                sqlQueryManager.executeQuery($"update {borrowRegistryDBT} set BorrowDate= '{bDate}' where BorrowID={borrowID}");
            }
            if (rDate != "")
            {
                sqlQueryManager.executeQuery($"update {borrowRegistryDBT} set ReturnDate= '{rDate}' where BorrowID={borrowID}");
            }
            RefreshBorrow();
        }

        private void DeleteBorrow(int borrowID)
        {
            sqlQueryManager.executeQuery($"delete from {borrowRegistryDBT} where BorrowID={borrowID}; ");
            RefreshBorrow();
            ClearBorrow();
        }

        private void SearchBorrow(int borrowID, int userID, int bookID, string bDate, string rDate)
        {
            sqlQueryManager.GetData(dgvBorrowRegistry, $"select * from {borrowRegistryDBT} where BorrowID='{borrowID}' or " +
                $" UserID='{userID}' or BookID='{bookID}' or BorrowDate='{bDate}' or ReturnDate='{rDate}';");
        }

        private void ClearBorrow()
        {
            tbBorrowID.Text = "";
            tbBorrowUserID.Text = "";
            tbBorrowBookID.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void RefreshBorrow()
        {
            sqlQueryManager.GetData(dgvBorrowRegistry, $"select * from {borrowRegistryDBT};");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (FrmLogin.frmLogin != null)
            {
                FrmLogin.frmLogin.Show();
                this.Dispose();
            } 
        }

        private void dgvBookRegistry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookRegistry.Rows[e.RowIndex];
                tbBookID.Text = row.Cells["BookID"].Value.ToString();
                tbBookTitle.Text = row.Cells["BookTitle"].Value.ToString();
                tbAuthor.Text = row.Cells["BookAuthor"].Value.ToString();
                tbPublisher.Text = row.Cells["BookPublisher"].Value.ToString();
                cbStatus.Text = row.Cells["BookStatus"].Value.ToString();
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            RefreshBook();
            RefreshUser();
            RefreshBorrow();
            cbStatus.Text = "--Select Status--";
            cbUserType.Text = "--Select Status--";
            //lblAdminID.Text = FrmLogin.nameUser;
            dgvUserRegistry.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUserRegistry.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUserRegistry.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUserRegistry.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvBookRegistry.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvBookRegistry.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvBookRegistry.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvBookRegistry.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvBookRegistry.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvBorrowRegistry.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvBorrowRegistry.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvBorrowRegistry.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvBorrowRegistry.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvBorrowRegistry.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void dgvBorrowRegistry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminID_Click(object sender, EventArgs e)
        {

        }

        private void tbUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUserRegistry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUserRegistry.Rows[e.RowIndex];
                tbUserID.Text = row.Cells["UserID"].Value.ToString();
                tbUsername.Text = row.Cells["Username"].Value.ToString();
                tbUserPassword.Text = row.Cells["UserPassword"].Value.ToString();
                cbUserType.Text = row.Cells["UserType"].Value.ToString();
            }
        }
    }
}
