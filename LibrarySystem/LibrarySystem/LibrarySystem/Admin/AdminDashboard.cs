using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Admin
{
    public partial class frmAdminDashboard : Form
    {

        bool sidebarExpand;
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                    lblGreetings.Location = new Point(123, 141);
                    lblDashboard.Location = new Point(757, 9);
                    pnlTotalBooks.Location = new Point(282, 251);
                    llblBookManagement.Location = new Point(310, 553);
                    pnlStudents.Location = new Point(678, 251);
                    llblStudentManagement.Location = new Point(692, 553);
                }
            }
            else 
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width) 
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                    lblGreetings.Location = new Point(342, 141);
                    lblDashboard.Location = new Point(856, 9);
                    pnlTotalBooks.Location = new Point(464, 251);
                    llblBookManagement.Location = new Point(492, 553);
                    pnlStudents.Location = new Point(786, 251);
                    llblStudentManagement.Location = new Point(800, 553);
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            
            DialogResult ans = MessageBox.Show("Are you sure you want to logout from this account?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ans == DialogResult.Yes)
            {
                login.Show();
            }
            else 
            {
                this.Show();
            }
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.frmAdminDashboard adminDashboard = new Admin.frmAdminDashboard();
            adminDashboard.Show();
        }

        private void btnStudentMgmt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.frmStudentManagement adminManagement = new Admin.frmStudentManagement();
            adminManagement.Show();
        }

        public void totalStudents() 
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select count(*) as total from student INNER JOIN role on role.roleID=student.roleID where role.roleID = 2";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                if (Functions.Functions.reader.HasRows)
                {
                    Functions.Functions.reader.Read();
                    lblStudents.Text = Functions.Functions.reader["total"].ToString();
                }
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void totalBooks() 
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select count(*) as total from book where status = 'Available'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                if (Functions.Functions.reader.HasRows)
                {
                    Functions.Functions.reader.Read();
                    lblBooks.Text = Functions.Functions.reader["total"].ToString();
                }
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void totalBorrowed() 
        {
            Connection.Connection.DB();
            Functions.Functions.gen = "select count(status) as total from book where status = 'Borrowed'";
            Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
            Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

            if (Functions.Functions.reader.HasRows) 
            {
                Functions.Functions.reader.Read();
                lblBorrowed.Text = Functions.Functions.reader["total"].ToString();
            }
        }
        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            totalStudents();
            totalBooks();
            totalBorrowed();
        }

        private void llblStudentManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmStudentManagement student = new frmStudentManagement();
            student.Show();
        }

        private void btnBookMgmt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.frmBookManagement book = new frmBookManagement();
            book.Show();
        }

        private void btnBorrowedBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.frmBookBorrowing book = new frmBookBorrowing();
            book.Show();
        }

        private void btnAuthorMgmt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.frmAuthorManagement author = new frmAuthorManagement();
            author.Show();
        }

        private void llblBookManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmBookManagement book = new frmBookManagement();
            book.Show();
        }

        private void llblBorrowed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmBookBorrowing frmBookBorrowing = new frmBookBorrowing();
            frmBookBorrowing.Show();
        }
    }
}
