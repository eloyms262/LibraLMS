namespace LibraLMS
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.lblLMS = new System.Windows.Forms.Label();
            this.lblLibra = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.btnMyBooks = new System.Windows.Forms.Button();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.courseCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.adminRad = new System.Windows.Forms.RadioButton();
            this.userRad = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLMS
            // 
            this.lblLMS.AutoSize = true;
            this.lblLMS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblLMS.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMS.ForeColor = System.Drawing.Color.Black;
            this.lblLMS.Location = new System.Drawing.Point(289, 42);
            this.lblLMS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLMS.Name = "lblLMS";
            this.lblLMS.Size = new System.Drawing.Size(66, 31);
            this.lblLMS.TabIndex = 8;
            this.lblLMS.Text = "LMS";
            this.lblLMS.Click += new System.EventHandler(this.lblLMS_Click);
            // 
            // lblLibra
            // 
            this.lblLibra.AutoSize = true;
            this.lblLibra.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblLibra.Font = new System.Drawing.Font("Rockwell", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibra.ForeColor = System.Drawing.Color.White;
            this.lblLibra.Location = new System.Drawing.Point(31, 28);
            this.lblLibra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibra.Name = "lblLibra";
            this.lblLibra.Size = new System.Drawing.Size(267, 101);
            this.lblLibra.TabIndex = 6;
            this.lblLibra.Text = "Libra";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.LightSkyBlue;
            this.header.Location = new System.Drawing.Point(-3, -2);
            this.header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(631, 162);
            this.header.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(-3, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(631, 14);
            this.label3.TabIndex = 22;
            // 
            // pbAvatar
            // 
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbAvatar.InitialImage")));
            this.pbAvatar.Location = new System.Drawing.Point(35, 203);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(192, 135);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 23;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // btnMyBooks
            // 
            this.btnMyBooks.BackColor = System.Drawing.Color.DarkGray;
            this.btnMyBooks.FlatAppearance.BorderSize = 0;
            this.btnMyBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyBooks.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyBooks.ForeColor = System.Drawing.Color.White;
            this.btnMyBooks.Location = new System.Drawing.Point(35, 373);
            this.btnMyBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyBooks.Name = "btnMyBooks";
            this.btnMyBooks.Size = new System.Drawing.Size(188, 46);
            this.btnMyBooks.TabIndex = 24;
            this.btnMyBooks.Text = "+   Add Picture";
            this.btnMyBooks.UseVisualStyleBackColor = false;
            this.btnMyBooks.Click += new System.EventHandler(this.btnMyBooks_Click);
            // 
            // fNameBox
            // 
            this.fNameBox.BackColor = System.Drawing.Color.White;
            this.fNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameBox.Location = new System.Drawing.Point(272, 235);
            this.fNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(318, 30);
            this.fNameBox.TabIndex = 26;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(267, 203);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(122, 25);
            this.lblUser.TabIndex = 25;
            this.lblUser.Text = "First Name";
            // 
            // lNameBox
            // 
            this.lNameBox.BackColor = System.Drawing.Color.White;
            this.lNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lNameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameBox.Location = new System.Drawing.Point(272, 330);
            this.lNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(318, 30);
            this.lNameBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(267, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Last Name";
            // 
            // uNameBox
            // 
            this.uNameBox.BackColor = System.Drawing.Color.White;
            this.uNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uNameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNameBox.Location = new System.Drawing.Point(272, 423);
            this.uNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.uNameBox.Name = "uNameBox";
            this.uNameBox.Size = new System.Drawing.Size(318, 30);
            this.uNameBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(267, 391);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Desired Username";
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.White;
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(272, 521);
            this.passBox.Margin = new System.Windows.Forms.Padding(4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(318, 30);
            this.passBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(267, 489);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(267, 588);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Course/Program";
            // 
            // courseCB
            // 
            this.courseCB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCB.FormattingEnabled = true;
            this.courseCB.Location = new System.Drawing.Point(272, 622);
            this.courseCB.Margin = new System.Windows.Forms.Padding(4);
            this.courseCB.Name = "courseCB";
            this.courseCB.Size = new System.Drawing.Size(317, 31);
            this.courseCB.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(432, 689);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 46);
            this.button1.TabIndex = 38;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminLogin.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.ForeColor = System.Drawing.Color.Black;
            this.btnAdminLogin.Location = new System.Drawing.Point(272, 689);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(139, 46);
            this.btnAdminLogin.TabIndex = 39;
            this.btnAdminLogin.Text = "Cancel";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // adminRad
            // 
            this.adminRad.AutoSize = true;
            this.adminRad.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRad.Location = new System.Drawing.Point(98, 30);
            this.adminRad.Margin = new System.Windows.Forms.Padding(4);
            this.adminRad.Name = "adminRad";
            this.adminRad.Size = new System.Drawing.Size(89, 25);
            this.adminRad.TabIndex = 35;
            this.adminRad.TabStop = true;
            this.adminRad.Text = "Admin";
            this.adminRad.UseVisualStyleBackColor = true;
            this.adminRad.CheckedChanged += new System.EventHandler(this.adminRad_CheckedChanged);
            // 
            // userRad
            // 
            this.userRad.AutoSize = true;
            this.userRad.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRad.Location = new System.Drawing.Point(1, 30);
            this.userRad.Margin = new System.Windows.Forms.Padding(4);
            this.userRad.Name = "userRad";
            this.userRad.Size = new System.Drawing.Size(72, 25);
            this.userRad.TabIndex = 34;
            this.userRad.TabStop = true;
            this.userRad.Text = "User";
            this.userRad.UseVisualStyleBackColor = true;
            this.userRad.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userRad);
            this.groupBox1.Controls.Add(this.adminRad);
            this.groupBox1.Location = new System.Drawing.Point(34, 472);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 65);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign up as";
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 764);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.courseCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnMyBooks);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLMS);
            this.Controls.Add(this.lblLibra);
            this.Controls.Add(this.header);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSignUp";
            this.Text = "Sign Up – Libra LMS";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLMS;
        private System.Windows.Forms.Label lblLibra;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button btnMyBooks;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox courseCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton adminRad;
        private System.Windows.Forms.RadioButton userRad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}