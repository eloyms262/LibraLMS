namespace LibraLMS
{
    partial class frmUser_Borrow
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
            this.components = new System.ComponentModel.Container();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMyBooks = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblLMS = new System.Windows.Forms.Label();
            this.lblLibra = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libraDatabaseDataSet2 = new LibraLMS.LibraDatabaseDataSet2();
            this.libraDatabaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraDatabaseDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1571, 162);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 58);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnName.FlatAppearance.BorderSize = 0;
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.ForeColor = System.Drawing.Color.Black;
            this.btnName.Location = new System.Drawing.Point(1393, 82);
            this.btnName.Margin = new System.Windows.Forms.Padding(4);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(169, 37);
            this.btnName.TabIndex = 25;
            this.btnName.Text = "--- name ---";
            this.btnName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnName.UseVisualStyleBackColor = false;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(1571, 31);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(136, 111);
            this.pbAvatar.TabIndex = 24;
            this.pbAvatar.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1452, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Welcome,";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMyBooks
            // 
            this.btnMyBooks.BackColor = System.Drawing.Color.DimGray;
            this.btnMyBooks.FlatAppearance.BorderSize = 0;
            this.btnMyBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyBooks.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyBooks.ForeColor = System.Drawing.Color.White;
            this.btnMyBooks.Location = new System.Drawing.Point(449, 162);
            this.btnMyBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyBooks.Name = "btnMyBooks";
            this.btnMyBooks.Size = new System.Drawing.Size(188, 58);
            this.btnMyBooks.TabIndex = 22;
            this.btnMyBooks.Text = "My Books";
            this.btnMyBooks.UseVisualStyleBackColor = false;
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.DimGray;
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Location = new System.Drawing.Point(176, 162);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(265, 58);
            this.btnBorrow.TabIndex = 21;
            this.btnBorrow.Text = "Borrow a Book";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DimGray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(17, 162);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(151, 58);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.DimGray;
            this.lblMenu.Location = new System.Drawing.Point(-3, 162);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(1745, 58);
            this.lblMenu.TabIndex = 19;
            // 
            // lblLMS
            // 
            this.lblLMS.AutoSize = true;
            this.lblLMS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblLMS.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMS.ForeColor = System.Drawing.Color.Black;
            this.lblLMS.Location = new System.Drawing.Point(289, 44);
            this.lblLMS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLMS.Name = "lblLMS";
            this.lblLMS.Size = new System.Drawing.Size(66, 31);
            this.lblLMS.TabIndex = 18;
            this.lblLMS.Text = "LMS";
            // 
            // lblLibra
            // 
            this.lblLibra.AutoSize = true;
            this.lblLibra.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblLibra.Font = new System.Drawing.Font("Rockwell", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibra.ForeColor = System.Drawing.Color.White;
            this.lblLibra.Location = new System.Drawing.Point(31, 31);
            this.lblLibra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibra.Name = "lblLibra";
            this.lblLibra.Size = new System.Drawing.Size(267, 101);
            this.lblLibra.TabIndex = 16;
            this.lblLibra.Text = "Libra";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.LightSkyBlue;
            this.header.Location = new System.Drawing.Point(-3, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1745, 162);
            this.header.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.libraDatabaseDataSet2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(136, 276);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1507, 513);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // libraDatabaseDataSet2
            // 
            this.libraDatabaseDataSet2.DataSetName = "LibraDatabaseDataSet2";
            this.libraDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraDatabaseDataSet2BindingSource
            // 
            this.libraDatabaseDataSet2BindingSource.DataSource = this.libraDatabaseDataSet2;
            this.libraDatabaseDataSet2BindingSource.Position = 0;
            // 
            // frmUser_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 853);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMyBooks);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblLMS);
            this.Controls.Add(this.lblLibra);
            this.Controls.Add(this.header);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUser_Borrow";
            this.Text = "frmUser_Borrow";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraDatabaseDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMyBooks;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblLMS;
        private System.Windows.Forms.Label lblLibra;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource libraDatabaseDataSet2BindingSource;
        private LibraDatabaseDataSet2 libraDatabaseDataSet2;
    }
}