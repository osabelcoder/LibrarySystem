namespace LibrarySystem.Admin
{
    partial class frmStudentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentManagement));
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.lblForm = new System.Windows.Forms.Label();
            this.tcStudents = new System.Windows.Forms.TabControl();
            this.tpRegistered = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpEdit = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbtnStudent = new System.Windows.Forms.RadioButton();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tcStudents.SuspendLayout();
            this.tpRegistered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpEdit.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.sidebar.Controls.Add(this.panel9);
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
            this.btnDashboard.Location = new System.Drawing.Point(-15, -27);
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
            this.panel11.TabIndex = 6;
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
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(3, 647);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(324, 142);
            this.panel9.TabIndex = 9;
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
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.BackColor = System.Drawing.Color.Transparent;
            this.lblForm.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.Color.LightCyan;
            this.lblForm.Location = new System.Drawing.Point(839, 9);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(333, 36);
            this.lblForm.TabIndex = 2;
            this.lblForm.Text = "Student Management";
            // 
            // tcStudents
            // 
            this.tcStudents.Controls.Add(this.tpRegistered);
            this.tcStudents.Controls.Add(this.tpEdit);
            this.tcStudents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcStudents.Location = new System.Drawing.Point(330, 177);
            this.tcStudents.MaximumSize = new System.Drawing.Size(1458, 721);
            this.tcStudents.MinimumSize = new System.Drawing.Size(1219, 721);
            this.tcStudents.Name = "tcStudents";
            this.tcStudents.SelectedIndex = 0;
            this.tcStudents.Size = new System.Drawing.Size(1219, 721);
            this.tcStudents.TabIndex = 3;
            // 
            // tpRegistered
            // 
            this.tpRegistered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.tpRegistered.Controls.Add(this.btnSearch);
            this.tpRegistered.Controls.Add(this.txtSearch);
            this.tpRegistered.Controls.Add(this.label5);
            this.tpRegistered.Controls.Add(this.dataGridView1);
            this.tpRegistered.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpRegistered.Location = new System.Drawing.Point(4, 30);
            this.tpRegistered.Name = "tpRegistered";
            this.tpRegistered.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistered.Size = new System.Drawing.Size(1211, 687);
            this.tpRegistered.TabIndex = 0;
            this.tpRegistered.Text = "Registered Students";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(404, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 41);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(102, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(292, 37);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1439, 632);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(1211, 632);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1211, 632);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // tpEdit
            // 
            this.tpEdit.Controls.Add(this.groupBox1);
            this.tpEdit.Controls.Add(this.dateTimePicker1);
            this.tpEdit.Controls.Add(this.lblDate);
            this.tpEdit.Controls.Add(this.txtStudentID);
            this.tpEdit.Controls.Add(this.label12);
            this.tpEdit.Controls.Add(this.btnUpdate);
            this.tpEdit.Controls.Add(this.btnDelete);
            this.tpEdit.Controls.Add(this.rbtnStudent);
            this.tpEdit.Controls.Add(this.rbtnAdmin);
            this.tpEdit.Controls.Add(this.label11);
            this.tpEdit.Controls.Add(this.txtPassword);
            this.tpEdit.Controls.Add(this.lblPassword);
            this.tpEdit.Controls.Add(this.txtUsername);
            this.tpEdit.Controls.Add(this.label9);
            this.tpEdit.Controls.Add(this.lblCourse);
            this.tpEdit.Controls.Add(this.label7);
            this.tpEdit.Controls.Add(this.lblYear);
            this.tpEdit.Controls.Add(this.cmbCourse);
            this.tpEdit.Controls.Add(this.cmbDepartment);
            this.tpEdit.Controls.Add(this.cmbYear);
            this.tpEdit.Controls.Add(this.lblUpdate);
            this.tpEdit.Controls.Add(this.txtLastname);
            this.tpEdit.Controls.Add(this.lblLName);
            this.tpEdit.Controls.Add(this.txtFirstname);
            this.tpEdit.Controls.Add(this.label2);
            this.tpEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpEdit.Location = new System.Drawing.Point(4, 30);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(1211, 687);
            this.tpEdit.TabIndex = 1;
            this.tpEdit.Text = "Edit Students";
            this.tpEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFemale);
            this.groupBox1.Controls.Add(this.rbtnMale);
            this.groupBox1.Location = new System.Drawing.Point(62, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 80);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(272, 33);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(94, 26);
            this.rbtnFemale.TabIndex = 7;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(51, 33);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(73, 26);
            this.rbtnMale.TabIndex = 6;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(836, 486);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(326, 31);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(660, 492);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(168, 22);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date Registered: ";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(192, 87);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(253, 31);
            this.txtStudentID.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 22);
            this.label12.TabIndex = 13;
            this.label12.Text = "Student ID:  ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(488, 627);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 41);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(664, 627);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 41);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbtnStudent
            // 
            this.rbtnStudent.AutoSize = true;
            this.rbtnStudent.Location = new System.Drawing.Point(328, 489);
            this.rbtnStudent.Name = "rbtnStudent";
            this.rbtnStudent.Size = new System.Drawing.Size(100, 26);
            this.rbtnStudent.TabIndex = 11;
            this.rbtnStudent.TabStop = true;
            this.rbtnStudent.Text = "Student";
            this.rbtnStudent.UseVisualStyleBackColor = true;
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(213, 489);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(88, 26);
            this.rbtnAdmin.TabIndex = 10;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 22);
            this.label11.TabIndex = 9;
            this.label11.Text = "Role:   ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(783, 406);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 31);
            this.txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(660, 409);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(105, 22);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(192, 406);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(253, 31);
            this.txtUsername.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = "Username: ";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(660, 324);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(79, 22);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Course:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Department:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(660, 242);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(122, 22);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year - Level:";
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(783, 321);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(352, 30);
            this.cmbCourse.TabIndex = 5;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "College of Teacher Education",
            "College of Computer Studies",
            "College of Engineering",
            "College of Business Administration",
            "College of Tourism and Hospitality Management",
            "College of Criminal Justice",
            "College of Customs Administration",
            "College of Maritime Education"});
            this.cmbDepartment.Location = new System.Drawing.Point(192, 321);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(356, 30);
            this.cmbDepartment.TabIndex = 5;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "Masteral",
            "Doctorate"});
            this.cmbYear.Location = new System.Drawing.Point(783, 239);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(186, 30);
            this.cmbYear.TabIndex = 5;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(484, 13);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(278, 22);
            this.lblUpdate.TabIndex = 2;
            this.lblUpdate.Text = "Update Student\'s Information";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(783, 161);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(253, 31);
            this.txtLastname.TabIndex = 1;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(660, 164);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(117, 22);
            this.lblLName.TabIndex = 0;
            this.lblLName.Text = "Last Name: ";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(192, 161);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(253, 31);
            this.txtFirstname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name: ";
            // 
            // frmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1555, 894);
            this.Controls.Add(this.tcStudents);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.sidebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.frmStudentManagement_Load);
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
            this.tcStudents.ResumeLayout(false);
            this.tpRegistered.ResumeLayout(false);
            this.tpRegistered.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpEdit.ResumeLayout(false);
            this.tpEdit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.TabControl tcStudents;
        private System.Windows.Forms.TabPage tpRegistered;
        private System.Windows.Forms.TabPage tpEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rbtnStudent;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnBorrowedBook;
        private System.Windows.Forms.Panel panel9;
    }
}