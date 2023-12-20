using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Admin
{
    public partial class frmBorrowHistory : Form
    {

        bool sidebarExpand;
        public frmBorrowHistory()
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
                }
            }
            else 
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width) 
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
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

        public void fillDataHist() 
        {
            Functions.Functions.gen = "Select borrow_id as [Borrow ID], borrowedBooks.studentID as [Student ID], borrowedBooks.studentName as [Student Name], borrowedBooks.title as [Book Title], borrowedBooks.dateBorrowed as [Date Borrowed], borrowedBooks.dateReturned as [Date Returned] from borrowedBooks where studentID = "+ frmLogin.setUserID + "order by dateReturned desc";
            Functions.Functions.fill(Functions.Functions.gen, dataGridView1);
        }

        private void frmBorrowHistory_Load(object sender, EventArgs e)
        {
            fillDataHist();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentDashboard student = new frmStudentDashboard();
            student.Show();
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAvailBooks available = new frmAvailBooks();
            available.Show();
        }
    }
}
