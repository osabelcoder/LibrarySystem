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
    public partial class frmStudentDashboard : Form
    {

        bool sidebarExpand;
        public frmStudentDashboard()
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

        private void frmStudentDashboard_Load(object sender, EventArgs e)
        {
            totalBorrowed();
            totalReturned();
        }

        public void totalBorrowed() 
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select (count(dateBorrowed) - count(dateReturned)) as total from borrowedBooks where studentID = " + frmLogin.setUserID + "";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                if (Functions.Functions.reader.HasRows) 
                {
                    Functions.Functions.reader.Read();
                    lblBorrowed.Text = Functions.Functions.reader["total"].ToString();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void totalReturned() 
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select count(dateReturned) as total from borrowedBooks where studentID = " + frmLogin.setUserID + "";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                if (Functions.Functions.reader.HasRows)
                {
                    Functions.Functions.reader.Read();
                    lblReturned.Text = Functions.Functions.reader["total"].ToString();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdminMgmt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBorrowHistory history = new frmBorrowHistory();
            history.Show();
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAvailBooks available = new frmAvailBooks();
            available.Show();
        }
    }
}
