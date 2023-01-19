namespace DSA_Thesis
{
    partial class FrmUser
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbUser = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBorrow = new System.Windows.Forms.TabPage();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnRefreshBook = new System.Windows.Forms.Button();
            this.dgvBookRegistry = new System.Windows.Forms.DataGridView();
            this.tabMyBooks = new System.Windows.Forms.TabPage();
            this.dgvMyBooks = new System.Windows.Forms.DataGridView();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tbUser.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookRegistry)).BeginInit();
            this.tabMyBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 77);
            this.label3.TabIndex = 5;
            this.label3.Text = "Libra";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 334);
            this.panel1.TabIndex = 7;
            // 
            // tbUser
            // 
            this.tbUser.Controls.Add(this.tabHome);
            this.tbUser.Controls.Add(this.tabBorrow);
            this.tbUser.Controls.Add(this.tabMyBooks);
            this.tbUser.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUser.ItemSize = new System.Drawing.Size(100, 40);
            this.tbUser.Location = new System.Drawing.Point(12, 104);
            this.tbUser.Name = "tbUser";
            this.tbUser.SelectedIndex = 0;
            this.tbUser.Size = new System.Drawing.Size(862, 334);
            this.tbUser.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHome.Controls.Add(this.btnSearch);
            this.tabHome.Controls.Add(this.tb);
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Location = new System.Drawing.Point(4, 44);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(854, 286);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(460, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(191, 115);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(263, 32);
            this.tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Book";
            // 
            // tabBorrow
            // 
            this.tabBorrow.Controls.Add(this.cbCategory);
            this.tabBorrow.Controls.Add(this.tbSearchBar);
            this.tabBorrow.Controls.Add(this.btnSearchBook);
            this.tabBorrow.Controls.Add(this.btnRefreshBook);
            this.tabBorrow.Controls.Add(this.dgvBookRegistry);
            this.tabBorrow.Location = new System.Drawing.Point(4, 44);
            this.tabBorrow.Name = "tabBorrow";
            this.tabBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tabBorrow.Size = new System.Drawing.Size(854, 286);
            this.tabBorrow.TabIndex = 1;
            this.tabBorrow.Text = "Borrow Book/s";
            this.tabBorrow.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "All",
            "Title",
            "Author",
            "Publisher",
            "Status"});
            this.cbCategory.Location = new System.Drawing.Point(17, 28);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 31);
            this.cbCategory.TabIndex = 11;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(184, 28);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(263, 32);
            this.tbSearchBar.TabIndex = 10;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(470, 18);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(109, 49);
            this.btnSearchBook.TabIndex = 9;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnRefreshBook
            // 
            this.btnRefreshBook.Location = new System.Drawing.Point(660, 18);
            this.btnRefreshBook.Name = "btnRefreshBook";
            this.btnRefreshBook.Size = new System.Drawing.Size(109, 49);
            this.btnRefreshBook.TabIndex = 8;
            this.btnRefreshBook.Text = "Refresh";
            this.btnRefreshBook.UseVisualStyleBackColor = true;
            // 
            // dgvBookRegistry
            // 
            this.dgvBookRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookRegistry.Location = new System.Drawing.Point(3, 78);
            this.dgvBookRegistry.Name = "dgvBookRegistry";
            this.dgvBookRegistry.RowTemplate.Height = 25;
            this.dgvBookRegistry.Size = new System.Drawing.Size(835, 202);
            this.dgvBookRegistry.TabIndex = 7;
            // 
            // tabMyBooks
            // 
            this.tabMyBooks.Controls.Add(this.dgvMyBooks);
            this.tabMyBooks.Location = new System.Drawing.Point(4, 44);
            this.tabMyBooks.Name = "tabMyBooks";
            this.tabMyBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyBooks.Size = new System.Drawing.Size(854, 286);
            this.tabMyBooks.TabIndex = 2;
            this.tabMyBooks.Text = "My Books";
            this.tabMyBooks.UseVisualStyleBackColor = true;
            // 
            // dgvMyBooks
            // 
            this.dgvMyBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyBooks.Location = new System.Drawing.Point(3, 3);
            this.dgvMyBooks.Name = "dgvMyBooks";
            this.dgvMyBooks.RowTemplate.Height = 25;
            this.dgvMyBooks.Size = new System.Drawing.Size(759, 417);
            this.dgvMyBooks.TabIndex = 1;
            // 
            // lblUserID
            // 
            this.lblUserID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblUserID.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserID.Location = new System.Drawing.Point(698, 27);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(165, 32);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "User Name";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserID.Click += new System.EventHandler(this.lblUserID_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(-13, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(914, 104);
            this.label5.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(188, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "LMS";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(743, 62);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(111, 36);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Name = "FrmUser";
            this.Text = "User";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.tbUser.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabBorrow.ResumeLayout(false);
            this.tabBorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookRegistry)).EndInit();
            this.tabMyBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Panel panel1;
        private TabControl tbUser;
        private TabPage tabHome;
        private TabPage tabBorrow;
        private TabPage tabMyBooks;
        private Label lblUserID;
        private Label label1;
        private TextBox tb;
        private Button btnSearch;
        private DataGridView dgvMyBooks;
        private Button btnSearchBook;
        private Button btnRefreshBook;
        private DataGridView dgvBookRegistry;
        private ComboBox cbCategory;
        private TextBox tbSearchBar;
        private Label label5;
        private Label label4;
        private Button btnLogout;
    }
}