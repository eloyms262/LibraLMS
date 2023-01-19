namespace DSA_Thesis
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabBookRegistry = new System.Windows.Forms.TabPage();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnClearBook = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnRefreshBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.dgvBookRegistry = new System.Windows.Forms.DataGridView();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUserList = new System.Windows.Forms.TabPage();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.btnClearUser = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnRefreshUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.dgvUserRegistry = new System.Windows.Forms.DataGridView();
            this.tabBorrowRegistry = new System.Windows.Forms.TabPage();
            this.tbBorrowID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.tbBorrowBookID = new System.Windows.Forms.TextBox();
            this.lblBorrowBookID = new System.Windows.Forms.Label();
            this.tbBorrowUserID = new System.Windows.Forms.TextBox();
            this.lblBorrowUserID = new System.Windows.Forms.Label();
            this.btnClearBorrow = new System.Windows.Forms.Button();
            this.btnSearchBorrow = new System.Windows.Forms.Button();
            this.btnRefreshBorrow = new System.Windows.Forms.Button();
            this.btnDeleteBorrow = new System.Windows.Forms.Button();
            this.btnUpdateBorrow = new System.Windows.Forms.Button();
            this.btnNewBorrow = new System.Windows.Forms.Button();
            this.dgvBorrowRegistry = new System.Windows.Forms.DataGridView();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabBookRegistry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookRegistry)).BeginInit();
            this.tcAdmin.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRegistry)).BeginInit();
            this.tabBorrowRegistry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowRegistry)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBookRegistry
            // 
            this.tabBookRegistry.Controls.Add(this.cbStatus);
            this.tabBookRegistry.Controls.Add(this.lblStatus);
            this.tabBookRegistry.Controls.Add(this.tbPublisher);
            this.tabBookRegistry.Controls.Add(this.lblPublisher);
            this.tabBookRegistry.Controls.Add(this.tbAuthor);
            this.tabBookRegistry.Controls.Add(this.lblAuthor);
            this.tabBookRegistry.Controls.Add(this.tbBookTitle);
            this.tabBookRegistry.Controls.Add(this.lblBookTitle);
            this.tabBookRegistry.Controls.Add(this.tbBookID);
            this.tabBookRegistry.Controls.Add(this.lblBookID);
            this.tabBookRegistry.Controls.Add(this.btnClearBook);
            this.tabBookRegistry.Controls.Add(this.btnSearchBook);
            this.tabBookRegistry.Controls.Add(this.btnRefreshBook);
            this.tabBookRegistry.Controls.Add(this.btnDeleteBook);
            this.tabBookRegistry.Controls.Add(this.btnUpdateBook);
            this.tabBookRegistry.Controls.Add(this.btnNewBook);
            this.tabBookRegistry.Controls.Add(this.dgvBookRegistry);
            this.tabBookRegistry.Location = new System.Drawing.Point(4, 44);
            this.tabBookRegistry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBookRegistry.Name = "tabBookRegistry";
            this.tabBookRegistry.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBookRegistry.Size = new System.Drawing.Size(1013, 836);
            this.tabBookRegistry.TabIndex = 2;
            this.tabBookRegistry.Text = "Book Registry";
            this.tabBookRegistry.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "In Library",
            "Borrowed",
            "Missing"});
            this.cbStatus.Location = new System.Drawing.Point(7, 269);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(213, 38);
            this.cbStatus.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 225);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(93, 31);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(344, 163);
            this.tbPublisher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(330, 38);
            this.tbPublisher.TabIndex = 15;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(344, 119);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(138, 31);
            this.lblPublisher.TabIndex = 14;
            this.lblPublisher.Text = "Publisher:";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(7, 163);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(330, 38);
            this.tbAuthor.TabIndex = 13;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(7, 119);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(105, 31);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "Author:";
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Location = new System.Drawing.Point(205, 52);
            this.tbBookTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(469, 38);
            this.tbBookTitle.TabIndex = 11;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(205, 8);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(144, 31);
            this.lblBookTitle.TabIndex = 10;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(7, 52);
            this.tbBookID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(190, 38);
            this.tbBookID.TabIndex = 9;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(7, 8);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(118, 31);
            this.lblBookID.TabIndex = 8;
            this.lblBookID.Text = "Book ID:";
            // 
            // btnClearBook
            // 
            this.btnClearBook.Location = new System.Drawing.Point(710, 208);
            this.btnClearBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearBook.Name = "btnClearBook";
            this.btnClearBook.Size = new System.Drawing.Size(125, 65);
            this.btnClearBook.TabIndex = 7;
            this.btnClearBook.Text = "Clear";
            this.btnClearBook.UseVisualStyleBackColor = true;
            this.btnClearBook.Click += new System.EventHandler(this.btnClearBook_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(864, 119);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(125, 65);
            this.btnSearchBook.TabIndex = 6;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnRefreshBook
            // 
            this.btnRefreshBook.Location = new System.Drawing.Point(864, 208);
            this.btnRefreshBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshBook.Name = "btnRefreshBook";
            this.btnRefreshBook.Size = new System.Drawing.Size(125, 65);
            this.btnRefreshBook.TabIndex = 5;
            this.btnRefreshBook.Text = "Refresh";
            this.btnRefreshBook.UseVisualStyleBackColor = true;
            this.btnRefreshBook.Click += new System.EventHandler(this.btnRefreshBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(710, 119);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(125, 65);
            this.btnDeleteBook.TabIndex = 4;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(864, 29);
            this.btnUpdateBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(125, 65);
            this.btnUpdateBook.TabIndex = 3;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnNewBook
            // 
            this.btnNewBook.Location = new System.Drawing.Point(710, 29);
            this.btnNewBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(125, 65);
            this.btnNewBook.TabIndex = 2;
            this.btnNewBook.Text = "New";
            this.btnNewBook.UseVisualStyleBackColor = true;
            this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // dgvBookRegistry
            // 
            this.dgvBookRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookRegistry.Location = new System.Drawing.Point(-1, 323);
            this.dgvBookRegistry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBookRegistry.Name = "dgvBookRegistry";
            this.dgvBookRegistry.RowHeadersWidth = 51;
            this.dgvBookRegistry.RowTemplate.Height = 25;
            this.dgvBookRegistry.Size = new System.Drawing.Size(990, 364);
            this.dgvBookRegistry.TabIndex = 1;
            this.dgvBookRegistry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookRegistry_CellContentClick);
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tabHome);
            this.tcAdmin.Controls.Add(this.tabUserList);
            this.tcAdmin.Controls.Add(this.tabBookRegistry);
            this.tcAdmin.Controls.Add(this.tabBorrowRegistry);
            this.tcAdmin.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tcAdmin.ItemSize = new System.Drawing.Size(100, 40);
            this.tcAdmin.Location = new System.Drawing.Point(10, 200);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1021, 884);
            this.tcAdmin.TabIndex = 6;
            // 
            // tabHome
            // 
            this.tabHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHome.Controls.Add(this.btnSearch);
            this.tabHome.Controls.Add(this.tbSearchBar);
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabHome.Location = new System.Drawing.Point(4, 44);
            this.tabHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabHome.Size = new System.Drawing.Size(1013, 836);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(535, 233);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 47);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(227, 233);
            this.tbSearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(300, 38);
            this.tbSearchBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Book";
            // 
            // tabUserList
            // 
            this.tabUserList.Controls.Add(this.cbUserType);
            this.tabUserList.Controls.Add(this.lblAccountType);
            this.tabUserList.Controls.Add(this.tbUserPassword);
            this.tabUserList.Controls.Add(this.lblPassword);
            this.tabUserList.Controls.Add(this.tbUsername);
            this.tabUserList.Controls.Add(this.lblUsername);
            this.tabUserList.Controls.Add(this.tbUserID);
            this.tabUserList.Controls.Add(this.lblAccountID);
            this.tabUserList.Controls.Add(this.btnClearUser);
            this.tabUserList.Controls.Add(this.btnSearchUser);
            this.tabUserList.Controls.Add(this.btnRefreshUser);
            this.tabUserList.Controls.Add(this.btnDeleteUser);
            this.tabUserList.Controls.Add(this.btnUpdateUser);
            this.tabUserList.Controls.Add(this.btnNewUser);
            this.tabUserList.Controls.Add(this.dgvUserRegistry);
            this.tabUserList.Location = new System.Drawing.Point(4, 44);
            this.tabUserList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUserList.Name = "tabUserList";
            this.tabUserList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUserList.Size = new System.Drawing.Size(1013, 836);
            this.tabUserList.TabIndex = 1;
            this.tabUserList.Text = "User Registry";
            this.tabUserList.UseVisualStyleBackColor = true;
            // 
            // cbUserType
            // 
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Items.AddRange(new object[] {
            "Admin",
            "Member"});
            this.cbUserType.Location = new System.Drawing.Point(394, 164);
            this.cbUserType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(213, 38);
            this.cbUserType.TabIndex = 35;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(394, 119);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(147, 31);
            this.lblAccountType.TabIndex = 34;
            this.lblAccountType.Text = "User Type:";
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Location = new System.Drawing.Point(17, 163);
            this.tbUserPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(330, 38);
            this.tbUserPassword.TabIndex = 31;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 119);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(139, 31);
            this.lblPassword.TabIndex = 30;
            this.lblPassword.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(245, 52);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(363, 38);
            this.tbUsername.TabIndex = 29;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(245, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(145, 31);
            this.lblUsername.TabIndex = 28;
            this.lblUsername.Text = "Username:";
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(17, 52);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(190, 38);
            this.tbUserID.TabIndex = 27;
            this.tbUserID.TextChanged += new System.EventHandler(this.tbUserID_TextChanged);
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(17, 17);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(113, 31);
            this.lblAccountID.TabIndex = 26;
            this.lblAccountID.Text = "User ID:";
            // 
            // btnClearUser
            // 
            this.btnClearUser.Location = new System.Drawing.Point(656, 180);
            this.btnClearUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearUser.Name = "btnClearUser";
            this.btnClearUser.Size = new System.Drawing.Size(125, 65);
            this.btnClearUser.TabIndex = 25;
            this.btnClearUser.Text = "Clear";
            this.btnClearUser.UseVisualStyleBackColor = true;
            this.btnClearUser.Click += new System.EventHandler(this.btnClearUser_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(830, 101);
            this.btnSearchUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(125, 65);
            this.btnSearchUser.TabIndex = 24;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnRefreshUser
            // 
            this.btnRefreshUser.Location = new System.Drawing.Point(830, 180);
            this.btnRefreshUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshUser.Name = "btnRefreshUser";
            this.btnRefreshUser.Size = new System.Drawing.Size(125, 65);
            this.btnRefreshUser.TabIndex = 23;
            this.btnRefreshUser.Text = "Refresh";
            this.btnRefreshUser.UseVisualStyleBackColor = true;
            this.btnRefreshUser.Click += new System.EventHandler(this.btnRefreshUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(656, 101);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(125, 65);
            this.btnDeleteUser.TabIndex = 22;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(830, 17);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(125, 65);
            this.btnUpdateUser.TabIndex = 21;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(656, 17);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(125, 65);
            this.btnNewUser.TabIndex = 20;
            this.btnNewUser.Text = "New";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // dgvUserRegistry
            // 
            this.dgvUserRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRegistry.Location = new System.Drawing.Point(17, 263);
            this.dgvUserRegistry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUserRegistry.Name = "dgvUserRegistry";
            this.dgvUserRegistry.RowHeadersWidth = 51;
            this.dgvUserRegistry.RowTemplate.Height = 25;
            this.dgvUserRegistry.Size = new System.Drawing.Size(710, 423);
            this.dgvUserRegistry.TabIndex = 19;
            this.dgvUserRegistry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserRegistry_CellContentClick);
            // 
            // tabBorrowRegistry
            // 
            this.tabBorrowRegistry.BackColor = System.Drawing.Color.White;
            this.tabBorrowRegistry.Controls.Add(this.tbBorrowID);
            this.tabBorrowRegistry.Controls.Add(this.label2);
            this.tabBorrowRegistry.Controls.Add(this.dateTimePicker2);
            this.tabBorrowRegistry.Controls.Add(this.dateTimePicker1);
            this.tabBorrowRegistry.Controls.Add(this.lblReturnDate);
            this.tabBorrowRegistry.Controls.Add(this.lblBorrowDate);
            this.tabBorrowRegistry.Controls.Add(this.tbBorrowBookID);
            this.tabBorrowRegistry.Controls.Add(this.lblBorrowBookID);
            this.tabBorrowRegistry.Controls.Add(this.tbBorrowUserID);
            this.tabBorrowRegistry.Controls.Add(this.lblBorrowUserID);
            this.tabBorrowRegistry.Controls.Add(this.btnClearBorrow);
            this.tabBorrowRegistry.Controls.Add(this.btnSearchBorrow);
            this.tabBorrowRegistry.Controls.Add(this.btnRefreshBorrow);
            this.tabBorrowRegistry.Controls.Add(this.btnDeleteBorrow);
            this.tabBorrowRegistry.Controls.Add(this.btnUpdateBorrow);
            this.tabBorrowRegistry.Controls.Add(this.btnNewBorrow);
            this.tabBorrowRegistry.Controls.Add(this.dgvBorrowRegistry);
            this.tabBorrowRegistry.Location = new System.Drawing.Point(4, 44);
            this.tabBorrowRegistry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBorrowRegistry.Name = "tabBorrowRegistry";
            this.tabBorrowRegistry.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBorrowRegistry.Size = new System.Drawing.Size(1013, 836);
            this.tabBorrowRegistry.TabIndex = 3;
            this.tabBorrowRegistry.Text = "Borrow Registry";
            // 
            // tbBorrowID
            // 
            this.tbBorrowID.Location = new System.Drawing.Point(7, 68);
            this.tbBorrowID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBorrowID.Name = "tbBorrowID";
            this.tbBorrowID.Size = new System.Drawing.Size(190, 38);
            this.tbBorrowID.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 36;
            this.label2.Text = "Borrow ID:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(344, 161);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(330, 39);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 161);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(330, 39);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(344, 119);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(166, 31);
            this.lblReturnDate.TabIndex = 32;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(7, 119);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(175, 31);
            this.lblBorrowDate.TabIndex = 30;
            this.lblBorrowDate.Text = "Borrow Date:";
            // 
            // tbBorrowBookID
            // 
            this.tbBorrowBookID.Location = new System.Drawing.Point(402, 68);
            this.tbBorrowBookID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBorrowBookID.Name = "tbBorrowBookID";
            this.tbBorrowBookID.Size = new System.Drawing.Size(190, 38);
            this.tbBorrowBookID.TabIndex = 29;
            // 
            // lblBorrowBookID
            // 
            this.lblBorrowBookID.AutoSize = true;
            this.lblBorrowBookID.Location = new System.Drawing.Point(402, 24);
            this.lblBorrowBookID.Name = "lblBorrowBookID";
            this.lblBorrowBookID.Size = new System.Drawing.Size(118, 31);
            this.lblBorrowBookID.TabIndex = 28;
            this.lblBorrowBookID.Text = "Book ID:";
            // 
            // tbBorrowUserID
            // 
            this.tbBorrowUserID.Location = new System.Drawing.Point(205, 68);
            this.tbBorrowUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBorrowUserID.Name = "tbBorrowUserID";
            this.tbBorrowUserID.Size = new System.Drawing.Size(190, 38);
            this.tbBorrowUserID.TabIndex = 27;
            // 
            // lblBorrowUserID
            // 
            this.lblBorrowUserID.AutoSize = true;
            this.lblBorrowUserID.Location = new System.Drawing.Point(205, 24);
            this.lblBorrowUserID.Name = "lblBorrowUserID";
            this.lblBorrowUserID.Size = new System.Drawing.Size(113, 31);
            this.lblBorrowUserID.TabIndex = 26;
            this.lblBorrowUserID.Text = "User ID:";
            // 
            // btnClearBorrow
            // 
            this.btnClearBorrow.Location = new System.Drawing.Point(687, 175);
            this.btnClearBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearBorrow.Name = "btnClearBorrow";
            this.btnClearBorrow.Size = new System.Drawing.Size(125, 65);
            this.btnClearBorrow.TabIndex = 25;
            this.btnClearBorrow.Text = "Clear";
            this.btnClearBorrow.UseVisualStyleBackColor = true;
            this.btnClearBorrow.Click += new System.EventHandler(this.btnClearBorrow_Click);
            // 
            // btnSearchBorrow
            // 
            this.btnSearchBorrow.Location = new System.Drawing.Point(857, 101);
            this.btnSearchBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchBorrow.Name = "btnSearchBorrow";
            this.btnSearchBorrow.Size = new System.Drawing.Size(125, 65);
            this.btnSearchBorrow.TabIndex = 24;
            this.btnSearchBorrow.Text = "Search";
            this.btnSearchBorrow.UseVisualStyleBackColor = true;
            this.btnSearchBorrow.Click += new System.EventHandler(this.btnSearchBorrow_Click);
            // 
            // btnRefreshBorrow
            // 
            this.btnRefreshBorrow.Location = new System.Drawing.Point(857, 175);
            this.btnRefreshBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshBorrow.Name = "btnRefreshBorrow";
            this.btnRefreshBorrow.Size = new System.Drawing.Size(125, 65);
            this.btnRefreshBorrow.TabIndex = 23;
            this.btnRefreshBorrow.Text = "Refresh";
            this.btnRefreshBorrow.UseVisualStyleBackColor = true;
            this.btnRefreshBorrow.Click += new System.EventHandler(this.btnRefreshBorrow_Click);
            // 
            // btnDeleteBorrow
            // 
            this.btnDeleteBorrow.Location = new System.Drawing.Point(687, 101);
            this.btnDeleteBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteBorrow.Name = "btnDeleteBorrow";
            this.btnDeleteBorrow.Size = new System.Drawing.Size(125, 65);
            this.btnDeleteBorrow.TabIndex = 22;
            this.btnDeleteBorrow.Text = "Delete";
            this.btnDeleteBorrow.UseVisualStyleBackColor = true;
            this.btnDeleteBorrow.Click += new System.EventHandler(this.btnDeleteBorrow_Click);
            // 
            // btnUpdateBorrow
            // 
            this.btnUpdateBorrow.Location = new System.Drawing.Point(857, 24);
            this.btnUpdateBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateBorrow.Name = "btnUpdateBorrow";
            this.btnUpdateBorrow.Size = new System.Drawing.Size(125, 65);
            this.btnUpdateBorrow.TabIndex = 21;
            this.btnUpdateBorrow.Text = "Update";
            this.btnUpdateBorrow.UseVisualStyleBackColor = true;
            this.btnUpdateBorrow.Click += new System.EventHandler(this.btnUpdateBorrow_Click);
            // 
            // btnNewBorrow
            // 
            this.btnNewBorrow.Location = new System.Drawing.Point(687, 24);
            this.btnNewBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewBorrow.Name = "btnNewBorrow";
            this.btnNewBorrow.Size = new System.Drawing.Size(125, 65);
            this.btnNewBorrow.TabIndex = 20;
            this.btnNewBorrow.Text = "New";
            this.btnNewBorrow.UseVisualStyleBackColor = true;
            this.btnNewBorrow.Click += new System.EventHandler(this.btnNewBorrow_Click);
            // 
            // dgvBorrowRegistry
            // 
            this.dgvBorrowRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowRegistry.Location = new System.Drawing.Point(0, 269);
            this.dgvBorrowRegistry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBorrowRegistry.Name = "dgvBorrowRegistry";
            this.dgvBorrowRegistry.RowHeadersWidth = 51;
            this.dgvBorrowRegistry.RowTemplate.Height = 25;
            this.dgvBorrowRegistry.Size = new System.Drawing.Size(982, 367);
            this.dgvBorrowRegistry.TabIndex = 19;
            this.dgvBorrowRegistry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowRegistry_CellContentClick);
            // 
            // lblAdminID
            // 
            this.lblAdminID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblAdminID.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminID.Location = new System.Drawing.Point(702, 45);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(177, 52);
            this.lblAdminID.TabIndex = 10;
            this.lblAdminID.Text = "Admin Name";
            this.lblAdminID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAdminID.Click += new System.EventHandler(this.lblAdminID_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(741, 141);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 51);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(237, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "LMS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(-3, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1062, 139);
            this.label5.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Rockwell", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 101);
            this.label3.TabIndex = 28;
            this.label3.Text = "Libra";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(-112, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1931, 77);
            this.label6.TabIndex = 29;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 967);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblAdminID);
            this.Controls.Add(this.tcAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.tabBookRegistry.ResumeLayout(false);
            this.tabBookRegistry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookRegistry)).EndInit();
            this.tcAdmin.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabUserList.ResumeLayout(false);
            this.tabUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRegistry)).EndInit();
            this.tabBorrowRegistry.ResumeLayout(false);
            this.tabBorrowRegistry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowRegistry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TabPage tabBookRegistry;
        private TabControl tcAdmin;
        private TabPage tabHome;
        private TabPage tabUserList;
        private Label lblAdminID;
        private DataGridView dgvBookRegistry;
        private Button btnRefreshBook;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnNewBook;
        private Button btnLogout;
        private Button btnSearchBook;
        private Button btnClearBook;
        private Label lblStatus;
        private TextBox tbPublisher;
        private Label lblPublisher;
        private TextBox tbAuthor;
        private Label lblAuthor;
        private TextBox tbBookTitle;
        private Label lblBookTitle;
        private TextBox tbBookID;
        private Label lblBookID;
        private ComboBox cbStatus;
        private TextBox tbUserPassword;
        private Label lblPassword;
        private TextBox tbUsername;
        private Label lblUsername;
        private TextBox tbUserID;
        private Label lblAccountID;
        private Button btnClearUser;
        private Button btnSearchUser;
        private Button btnRefreshUser;
        private Button btnDeleteUser;
        private Button btnUpdateUser;
        private Button btnNewUser;
        private DataGridView dgvUserRegistry;
        private ComboBox cbUserType;
        private Label lblAccountType;
        private Button btnSearch;
        private TextBox tbSearchBar;
        private Label label1;
        private TabPage tabBorrowRegistry;
        private Label lblReturnDate;
        private Label lblBorrowDate;
        private TextBox tbBorrowBookID;
        private Label lblBorrowBookID;
        private TextBox tbBorrowUserID;
        private Label lblBorrowUserID;
        private Button btnClearBorrow;
        private Button btnSearchBorrow;
        private Button btnRefreshBorrow;
        private Button btnDeleteBorrow;
        private Button btnUpdateBorrow;
        private Button btnNewBorrow;
        private DataGridView dgvBorrowRegistry;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox tbBorrowID;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label6;
    }
}