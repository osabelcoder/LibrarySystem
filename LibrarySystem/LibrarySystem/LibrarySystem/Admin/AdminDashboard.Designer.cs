namespace LibrarySystem.Admin
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStudentMgmt = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAuthorMgmt = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBookMgmt = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnBorrowedBook = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlTotalBooks = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.llblBookManagement = new System.Windows.Forms.LinkLabel();
            this.llblStudentManagement = new System.Windows.Forms.LinkLabel();
            this.llblBorrowed = new System.Windows.Forms.LinkLabel();
            this.pnlBorrowed = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlTotalBooks.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            this.pnlBorrowed.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel11);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(324, 902);
            this.sidebar.MinimumSize = new System.Drawing.Size(90, 902);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(324, 902);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 168);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(18, 45);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(58, 56);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(3, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 88);
            this.panel2.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-14, -27);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(421, 149);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "                 Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnStudentMgmt);
            this.panel3.Location = new System.Drawing.Point(3, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 88);
            this.panel3.TabIndex = 2;
            // 
            // btnStudentMgmt
            // 
            this.btnStudentMgmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.btnStudentMgmt.FlatAppearance.BorderSize = 0;
            this.btnStudentMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentMgmt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentMgmt.ForeColor = System.Drawing.Color.White;
            this.btnStudentMgmt.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentMgmt.Image")));
            this.btnStudentMgmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentMgmt.Location = new System.Drawing.Point(-15, -27);
            this.btnStudentMgmt.Name = "btnStudentMgmt";
            this.btnStudentMgmt.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnStudentMgmt.Size = new System.Drawing.Size(421, 149);
            this.btnStudentMgmt.TabIndex = 1;
            this.btnStudentMgmt.Text = "           Student Management";
            this.btnStudentMgmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentMgmt.UseVisualStyleBackColor = false;
            this.btnStudentMgmt.Click += new System.EventHandler(this.btnStudentMgmt_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAuthorMgmt);
            this.panel4.Location = new System.Drawing.Point(3, 365);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 88);
            this.panel4.TabIndex = 3;
            // 
            // btnAuthorMgmt
            // 
            this.btnAuthorMgmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.btnAuthorMgmt.FlatAppearance.BorderSize = 0;
            this.btnAuthorMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthorMgmt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorMgmt.ForeColor = System.Drawing.Color.White;
            this.btnAuthorMgmt.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthorMgmt.Image")));
            this.btnAuthorMgmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthorMgmt.Location = new System.Drawing.Point(-24, -26);
            this.btnAuthorMgmt.Name = "btnAuthorMgmt";
            this.btnAuthorMgmt.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAuthorMgmt.Size = new System.Drawing.Size(421, 149);
            this.btnAuthorMgmt.TabIndex = 1;
            this.btnAuthorMgmt.Text = "             Author Management";
            this.btnAuthorMgmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthorMgmt.UseVisualStyleBackColor = false;
            this.btnAuthorMgmt.Click += new System.EventHandler(this.btnAuthorMgmt_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnBookMgmt);
            this.panel5.Location = new System.Drawing.Point(3, 459);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 88);
            this.panel5.TabIndex = 4;
            // 
            // btnBookMgmt
            // 
            this.btnBookMgmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.btnBookMgmt.FlatAppearance.BorderSize = 0;
            this.btnBookMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookMgmt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookMgmt.ForeColor = System.Drawing.Color.White;
            this.btnBookMgmt.Image = ((System.Drawing.Image)(resources.GetObject("btnBookMgmt.Image")));
            this.btnBookMgmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookMgmt.Location = new System.Drawing.Point(-15, -27);
            this.btnBookMgmt.Name = "btnBookMgmt";
            this.btnBookMgmt.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBookMgmt.Size = new System.Drawing.Size(421, 149);
            this.btnBookMgmt.TabIndex = 1;
            this.btnBookMgmt.Text = "            Book Management";
            this.btnBookMgmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookMgmt.UseVisualStyleBackColor = false;
            this.btnBookMgmt.Click += new System.EventHandler(this.btnBookMgmt_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnBorrowedBook);
            this.panel11.Location = new System.Drawing.Point(3, 553);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(321, 88);
            this.panel11.TabIndex = 5;
            // 
            // btnBorrowedBook
            // 
            this.btnBorrowedBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.btnBorrowedBook.FlatAppearance.BorderSize = 0;
            this.btnBorrowedBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowedBook.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowedBook.ForeColor = System.Drawing.Color.White;
            this.btnBorrowedBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowedBook.Image")));
            this.btnBorrowedBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowedBook.Location = new System.Drawing.Point(-24, -27);
            this.btnBorrowedBook.Name = "btnBorrowedBook";
            this.btnBorrowedBook.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBorrowedBook.Size = new System.Drawing.Size(421, 149);
            this.btnBorrowedBook.TabIndex = 1;
            this.btnBorrowedBook.Text = "                Borrow Books";
            this.btnBorrowedBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowedBook.UseVisualStyleBackColor = false;
            this.btnBorrowedBook.Click += new System.EventHandler(this.btnBorrowedBook_Click);
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(3, 647);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(324, 142);
            this.panel8.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnLogout);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(3, 795);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 88);
            this.panel6.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-12, -28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(421, 149);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "                    Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(3, 663);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(321, 88);
            this.panel7.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-15, -27);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(421, 149);
            this.button1.TabIndex = 1;
            this.button1.Text = "                    Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 1;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.BackColor = System.Drawing.Color.Transparent;
            this.lblGreetings.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.ForeColor = System.Drawing.Color.White;
            this.lblGreetings.Location = new System.Drawing.Point(342, 141);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(236, 30);
            this.lblGreetings.TabIndex = 1;
            this.lblGreetings.Text = "Good Day, Admin!";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.LightCyan;
            this.lblDashboard.Location = new System.Drawing.Point(856, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(174, 36);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            // 
            // pnlTotalBooks
            // 
            this.pnlTotalBooks.BackColor = System.Drawing.Color.White;
            this.pnlTotalBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTotalBooks.Controls.Add(this.label4);
            this.pnlTotalBooks.Controls.Add(this.lblBooks);
            this.pnlTotalBooks.Location = new System.Drawing.Point(464, 251);
            this.pnlTotalBooks.Name = "pnlTotalBooks";
            this.pnlTotalBooks.Size = new System.Drawing.Size(265, 288);
            this.pnlTotalBooks.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Books";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.BackColor = System.Drawing.Color.Transparent;
            this.lblBooks.Font = new System.Drawing.Font("Century Gothic", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.ForeColor = System.Drawing.Color.Black;
            this.lblBooks.Location = new System.Drawing.Point(81, 79);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(113, 126);
            this.lblBooks.TabIndex = 0;
            this.lblBooks.Text = "0";
            // 
            // pnlStudents
            // 
            this.pnlStudents.BackColor = System.Drawing.Color.White;
            this.pnlStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStudents.Controls.Add(this.label5);
            this.pnlStudents.Controls.Add(this.lblStudents);
            this.pnlStudents.Location = new System.Drawing.Point(786, 251);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(265, 288);
            this.pnlStudents.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Students Registered";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Century Gothic", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.ForeColor = System.Drawing.Color.Black;
            this.lblStudents.Location = new System.Drawing.Point(82, 79);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(113, 126);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "0";
            // 
            // llblBookManagement
            // 
            this.llblBookManagement.AutoSize = true;
            this.llblBookManagement.BackColor = System.Drawing.Color.Transparent;
            this.llblBookManagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblBookManagement.Location = new System.Drawing.Point(492, 553);
            this.llblBookManagement.Name = "llblBookManagement";
            this.llblBookManagement.Size = new System.Drawing.Size(210, 24);
            this.llblBookManagement.TabIndex = 3;
            this.llblBookManagement.TabStop = true;
            this.llblBookManagement.Text = "Book Management";
            this.llblBookManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblBookManagement_LinkClicked);
            // 
            // llblStudentManagement
            // 
            this.llblStudentManagement.AutoSize = true;
            this.llblStudentManagement.BackColor = System.Drawing.Color.Transparent;
            this.llblStudentManagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblStudentManagement.Location = new System.Drawing.Point(800, 553);
            this.llblStudentManagement.Name = "llblStudentManagement";
            this.llblStudentManagement.Size = new System.Drawing.Size(237, 24);
            this.llblStudentManagement.TabIndex = 3;
            this.llblStudentManagement.TabStop = true;
            this.llblStudentManagement.Text = "Student Management";
            this.llblStudentManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblStudentManagement_LinkClicked);
            // 
            // llblBorrowed
            // 
            this.llblBorrowed.AutoSize = true;
            this.llblBorrowed.BackColor = System.Drawing.Color.Transparent;
            this.llblBorrowed.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblBorrowed.Location = new System.Drawing.Point(1150, 553);
            this.llblBorrowed.Name = "llblBorrowed";
            this.llblBorrowed.Size = new System.Drawing.Size(173, 24);
            this.llblBorrowed.TabIndex = 5;
            this.llblBorrowed.TabStop = true;
            this.llblBorrowed.Text = "Borrowed Books";
            this.llblBorrowed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblBorrowed_LinkClicked);
            // 
            // pnlBorrowed
            // 
            this.pnlBorrowed.BackColor = System.Drawing.Color.White;
            this.pnlBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBorrowed.Controls.Add(this.label2);
            this.pnlBorrowed.Controls.Add(this.lblBorrowed);
            this.pnlBorrowed.Location = new System.Drawing.Point(1104, 251);
            this.pnlBorrowed.Name = "pnlBorrowed";
            this.pnlBorrowed.Size = new System.Drawing.Size(265, 288);
            this.pnlBorrowed.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Borrowed Books";
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.BackColor = System.Drawing.Color.Transparent;
            this.lblBorrowed.Font = new System.Drawing.Font("Century Gothic", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lblBorrowed.Location = new System.Drawing.Point(82, 79);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(113, 126);
            this.lblBorrowed.TabIndex = 0;
            this.lblBorrowed.Text = "0";
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1555, 894);
            this.Controls.Add(this.llblBorrowed);
            this.Controls.Add(this.pnlBorrowed);
            this.Controls.Add(this.llblStudentManagement);
            this.Controls.Add(this.llblBookManagement);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlTotalBooks);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.sidebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlTotalBooks.ResumeLayout(false);
            this.pnlTotalBooks.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.pnlBorrowed.ResumeLayout(false);
            this.pnlBorrowed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStudentMgmt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAuthorMgmt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBookMgmt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlTotalBooks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.LinkLabel llblBookManagement;
        private System.Windows.Forms.LinkLabel llblStudentManagement;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnBorrowedBook;
        private System.Windows.Forms.LinkLabel llblBorrowed;
        private System.Windows.Forms.Panel pnlBorrowed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.Panel panel8;
    }
}