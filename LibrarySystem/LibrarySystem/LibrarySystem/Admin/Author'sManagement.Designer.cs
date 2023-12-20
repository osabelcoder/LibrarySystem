namespace LibrarySystem.Admin
{
    partial class frmAuthorManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuthorManagement));
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
            this.tcAuthor = new System.Windows.Forms.TabControl();
            this.tpRegistered = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpEdit = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.tcAuthor.SuspendLayout();
            this.tpRegistered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpEdit.SuspendLayout();
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
            this.lblForm.Size = new System.Drawing.Size(336, 36);
            this.lblForm.TabIndex = 2;
            this.lblForm.Text = "Author\'s Management";
            // 
            // tcAuthor
            // 
            this.tcAuthor.Controls.Add(this.tpRegistered);
            this.tcAuthor.Controls.Add(this.tpEdit);
            this.tcAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAuthor.Location = new System.Drawing.Point(330, 177);
            this.tcAuthor.MaximumSize = new System.Drawing.Size(1458, 721);
            this.tcAuthor.MinimumSize = new System.Drawing.Size(1219, 721);
            this.tcAuthor.Name = "tcAuthor";
            this.tcAuthor.SelectedIndex = 0;
            this.tcAuthor.Size = new System.Drawing.Size(1219, 721);
            this.tcAuthor.TabIndex = 3;
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
            this.tpRegistered.Text = "Authors";
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
            this.dataGridView1.Size = new System.Drawing.Size(1211, 632);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // tpEdit
            // 
            this.tpEdit.Controls.Add(this.dateTimePicker1);
            this.tpEdit.Controls.Add(this.btnSave);
            this.tpEdit.Controls.Add(this.btnUpdate);
            this.tpEdit.Controls.Add(this.btnDelete);
            this.tpEdit.Controls.Add(this.lblUpdate);
            this.tpEdit.Controls.Add(this.txtLastname);
            this.tpEdit.Controls.Add(this.label4);
            this.tpEdit.Controls.Add(this.lblLName);
            this.tpEdit.Controls.Add(this.txtEmail);
            this.tpEdit.Controls.Add(this.label7);
            this.tpEdit.Controls.Add(this.txtPublisher);
            this.tpEdit.Controls.Add(this.label6);
            this.tpEdit.Controls.Add(this.txtTitle);
            this.tpEdit.Controls.Add(this.label3);
            this.tpEdit.Controls.Add(this.txtAuthorID);
            this.tpEdit.Controls.Add(this.label8);
            this.tpEdit.Controls.Add(this.txtFirstname);
            this.tpEdit.Controls.Add(this.label2);
            this.tpEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpEdit.Location = new System.Drawing.Point(4, 30);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(1211, 687);
            this.tpEdit.TabIndex = 1;
            this.tpEdit.Text = "Add | Edit Author";
            this.tpEdit.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(825, 267);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(342, 31);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(612, 623);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 43);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(493, 625);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 41);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(696, 625);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 41);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(484, 13);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(285, 22);
            this.lblUpdate.TabIndex = 2;
            this.lblUpdate.Text = "Add | Update Author Record";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(785, 180);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(285, 31);
            this.txtLastname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date Published: ";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(662, 183);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(117, 22);
            this.lblLName.TabIndex = 0;
            this.lblLName.Text = "Last Name: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(785, 368);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 31);
            this.txtEmail.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(662, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email: ";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(194, 368);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(304, 31);
            this.txtPublisher.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Publisher: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(194, 269);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(304, 31);
            this.txtTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Title: ";
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Enabled = false;
            this.txtAuthorID.Location = new System.Drawing.Point(194, 98);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(95, 31);
            this.txtAuthorID.TabIndex = 1;
            this.txtAuthorID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "authorID: ";
            this.label8.Visible = false;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(194, 180);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(304, 31);
            this.txtFirstname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name: ";
            // 
            // frmAuthorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1555, 894);
            this.Controls.Add(this.tcAuthor);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.sidebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAuthorManagement";
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
            this.tcAuthor.ResumeLayout(false);
            this.tpRegistered.ResumeLayout(false);
            this.tpRegistered.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpEdit.ResumeLayout(false);
            this.tpEdit.PerformLayout();
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
        private System.Windows.Forms.TabControl tcAuthor;
        private System.Windows.Forms.TabPage tpRegistered;
        private System.Windows.Forms.TabPage tpEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnBorrowedBook;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Label label8;
    }
}