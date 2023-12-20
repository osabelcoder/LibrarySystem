namespace LibrarySystem.Admin
{
    partial class frmStudentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentDashboard));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAdminMgmt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlTotalBooks = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReturned = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlTotalBooks.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
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
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAdminMgmt);
            this.panel8.Location = new System.Drawing.Point(3, 271);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(321, 88);
            this.panel8.TabIndex = 3;
            // 
            // btnAdminMgmt
            // 
            this.btnAdminMgmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.btnAdminMgmt.FlatAppearance.BorderSize = 0;
            this.btnAdminMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMgmt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMgmt.ForeColor = System.Drawing.Color.White;
            this.btnAdminMgmt.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminMgmt.Image")));
            this.btnAdminMgmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminMgmt.Location = new System.Drawing.Point(-15, -27);
            this.btnAdminMgmt.Name = "btnAdminMgmt";
            this.btnAdminMgmt.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAdminMgmt.Size = new System.Drawing.Size(421, 149);
            this.btnAdminMgmt.TabIndex = 1;
            this.btnAdminMgmt.Text = "               Borrow History";
            this.btnAdminMgmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminMgmt.UseVisualStyleBackColor = false;
            this.btnAdminMgmt.Click += new System.EventHandler(this.btnAdminMgmt_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAvailable);
            this.panel3.Location = new System.Drawing.Point(3, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 88);
            this.panel3.TabIndex = 7;
            // 
            // btnAvailable
            // 
            this.btnAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(140)))));
            this.btnAvailable.FlatAppearance.BorderSize = 0;
            this.btnAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailable.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailable.ForeColor = System.Drawing.Color.White;
            this.btnAvailable.Image = ((System.Drawing.Image)(resources.GetObject("btnAvailable.Image")));
            this.btnAvailable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailable.Location = new System.Drawing.Point(0, -43);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(364, 177);
            this.btnAvailable.TabIndex = 8;
            this.btnAvailable.Text = "                   Books Status";
            this.btnAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailable.UseVisualStyleBackColor = false;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 459);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 334);
            this.panel4.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnLogout);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(3, 799);
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
            this.btnLogout.Location = new System.Drawing.Point(-15, -27);
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
            // pnlTotalBooks
            // 
            this.pnlTotalBooks.BackColor = System.Drawing.Color.White;
            this.pnlTotalBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTotalBooks.Controls.Add(this.label4);
            this.pnlTotalBooks.Controls.Add(this.lblBorrowed);
            this.pnlTotalBooks.Location = new System.Drawing.Point(585, 241);
            this.pnlTotalBooks.Name = "pnlTotalBooks";
            this.pnlTotalBooks.Size = new System.Drawing.Size(265, 288);
            this.pnlTotalBooks.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book/s Borrowed";
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.Font = new System.Drawing.Font("Century Gothic", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lblBorrowed.Location = new System.Drawing.Point(81, 79);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(113, 126);
            this.lblBorrowed.TabIndex = 0;
            this.lblBorrowed.Text = "0";
            // 
            // pnlStudents
            // 
            this.pnlStudents.BackColor = System.Drawing.Color.White;
            this.pnlStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStudents.Controls.Add(this.label5);
            this.pnlStudents.Controls.Add(this.lblReturned);
            this.pnlStudents.Location = new System.Drawing.Point(1023, 241);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(265, 288);
            this.pnlStudents.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Book/s Returned";
            // 
            // lblReturned
            // 
            this.lblReturned.AutoSize = true;
            this.lblReturned.Font = new System.Drawing.Font("Century Gothic", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturned.ForeColor = System.Drawing.Color.Black;
            this.lblReturned.Location = new System.Drawing.Point(82, 79);
            this.lblReturned.Name = "lblReturned";
            this.lblReturned.Size = new System.Drawing.Size(113, 126);
            this.lblReturned.TabIndex = 0;
            this.lblReturned.Text = "0";
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
            this.lblDashboard.TabIndex = 5;
            this.lblDashboard.Text = "Dashboard";
            // 
            // frmStudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1555, 894);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlTotalBooks);
            this.Controls.Add(this.sidebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.frmStudentDashboard_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlTotalBooks.ResumeLayout(false);
            this.pnlTotalBooks.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAdminMgmt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlTotalBooks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReturned;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAvailable;
    }
}