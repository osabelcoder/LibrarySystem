namespace LibrarySystem.Admin
{
    partial class frmBookManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookManagement));
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
            this.lblBook = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBook = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccession = new System.Windows.Forms.TextBox();
            this.lblAccession = new System.Windows.Forms.Label();
            this.lblTab = new System.Windows.Forms.Label();
            this.tpViewBook = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.tabControl1.SuspendLayout();
            this.tpBook.SuspendLayout();
            this.tpViewBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(3, 647);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(324, 152);
            this.panel9.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnLogout);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(3, 805);
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
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.BackColor = System.Drawing.Color.Transparent;
            this.lblBook.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.ForeColor = System.Drawing.Color.LightCyan;
            this.lblBook.Location = new System.Drawing.Point(856, 9);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(294, 36);
            this.lblBook.TabIndex = 1;
            this.lblBook.Text = "Book Management";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBook);
            this.tabControl1.Controls.Add(this.tpViewBook);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(330, 173);
            this.tabControl1.MaximumSize = new System.Drawing.Size(1450, 720);
            this.tabControl1.MinimumSize = new System.Drawing.Size(1225, 720);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1225, 720);
            this.tabControl1.TabIndex = 2;
            // 
            // tpBook
            // 
            this.tpBook.Controls.Add(this.btnDelete);
            this.tpBook.Controls.Add(this.BtnUpdate);
            this.tpBook.Controls.Add(this.btnSave);
            this.tpBook.Controls.Add(this.txtPublisher);
            this.tpBook.Controls.Add(this.lblPublisher);
            this.tpBook.Controls.Add(this.txtGenre);
            this.tpBook.Controls.Add(this.lblGenre);
            this.tpBook.Controls.Add(this.dateTimePicker1);
            this.tpBook.Controls.Add(this.label5);
            this.tpBook.Controls.Add(this.txtAuthor);
            this.tpBook.Controls.Add(this.lblAuthor);
            this.tpBook.Controls.Add(this.txtTitle);
            this.tpBook.Controls.Add(this.label3);
            this.tpBook.Controls.Add(this.txtVolume);
            this.tpBook.Controls.Add(this.label7);
            this.tpBook.Controls.Add(this.label6);
            this.tpBook.Controls.Add(this.txtAccession);
            this.tpBook.Controls.Add(this.lblAccession);
            this.tpBook.Controls.Add(this.lblTab);
            this.tpBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBook.Location = new System.Drawing.Point(4, 31);
            this.tpBook.Name = "tpBook";
            this.tpBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpBook.Size = new System.Drawing.Size(1217, 685);
            this.tpBook.TabIndex = 0;
            this.tpBook.Text = "Add | Edit Book";
            this.tpBook.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(740, 615);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 43);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(600, 615);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(105, 43);
            this.BtnUpdate.TabIndex = 12;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(466, 615);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 43);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(851, 395);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(290, 31);
            this.txtPublisher.TabIndex = 8;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(690, 401);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(155, 22);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Publisher Name:";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(780, 294);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(273, 31);
            this.txtGenre.TabIndex = 6;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(690, 293);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(79, 22);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "Genre: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 395);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(336, 31);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date Published:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(780, 184);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(371, 31);
            this.txtAuthor.TabIndex = 2;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(690, 187);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(84, 22);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(125, 184);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(371, 31);
            this.txtTitle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Title: ";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(163, 294);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(162, 31);
            this.txtVolume.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Volume: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 1;
            // 
            // txtAccession
            // 
            this.txtAccession.Location = new System.Drawing.Point(253, 83);
            this.txtAccession.Name = "txtAccession";
            this.txtAccession.Size = new System.Drawing.Size(162, 31);
            this.txtAccession.TabIndex = 2;
            this.txtAccession.Visible = false;
            // 
            // lblAccession
            // 
            this.lblAccession.AutoSize = true;
            this.lblAccession.Location = new System.Drawing.Point(66, 89);
            this.lblAccession.Name = "lblAccession";
            this.lblAccession.Size = new System.Drawing.Size(191, 22);
            this.lblAccession.TabIndex = 1;
            this.lblAccession.Text = "Accession Number: ";
            this.lblAccession.Visible = false;
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Location = new System.Drawing.Point(478, 10);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(311, 22);
            this.lblTab.TabIndex = 0;
            this.lblTab.Text = "Add | Update Books Information";
            // 
            // tpViewBook
            // 
            this.tpViewBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.tpViewBook.Controls.Add(this.btnSearch);
            this.tpViewBook.Controls.Add(this.txtSearch);
            this.tpViewBook.Controls.Add(this.label2);
            this.tpViewBook.Controls.Add(this.dataGridView1);
            this.tpViewBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpViewBook.Location = new System.Drawing.Point(4, 31);
            this.tpViewBook.Name = "tpViewBook";
            this.tpViewBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpViewBook.Size = new System.Drawing.Size(1217, 685);
            this.tpViewBook.TabIndex = 1;
            this.tpViewBook.Text = "View Books";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(391, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 41);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(92, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(292, 31);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 53);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1447, 632);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(1213, 632);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 632);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // frmBookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1555, 894);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.frmBookManagement_Load);
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
            this.tabControl1.ResumeLayout(false);
            this.tpBook.ResumeLayout(false);
            this.tpBook.PerformLayout();
            this.tpViewBook.ResumeLayout(false);
            this.tpViewBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnBorrowedBook;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBook;
        private System.Windows.Forms.TabPage tpViewBook;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.TextBox txtAccession;
        private System.Windows.Forms.Label lblAccession;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
    }
}