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
    public partial class frmAvailBooks : Form
    {

        bool sidebarExpand;
        public frmAvailBooks()
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
            fillData();
        }

        public void fillData() 
        {
            Functions.Functions.gen = "Select book.title as [Title], book.author as [Author], book.volume as [Volume], book.genre as [Genre], book.date_published as [Date Published], book.publisher as [Publisher], book.status as [Status] from book order by status desc";
            Functions.Functions.fill(Functions.Functions.gen, dataGridView1);
        }
        private void btnAdminMgmt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBorrowHistory history = new frmBorrowHistory();
            history.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select * from book where accession_number like '%" + txtSearch.Text + "%' or title like '%" + txtSearch.Text + "%' or author like '%" + txtSearch.Text + "%' or publisher like '%" + txtSearch.Text + "%' or genre like '%" + txtSearch.Text + "%'";
                Functions.Functions.fill(Functions.Functions.gen, dataGridView1);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
