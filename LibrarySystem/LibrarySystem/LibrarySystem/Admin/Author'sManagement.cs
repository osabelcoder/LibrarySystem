using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using LibrarySystem.Functions;

namespace LibrarySystem.Admin
{
    public partial class frmAuthorManagement: Form
    {

        bool sidebarExpand;
        
        public frmAuthorManagement()
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
                    tcAuthor.Location = new Point(96, 161);
                    tcAuthor.Size = new Size(1458, 721);
                    lblForm.Location = new Point(642, 9);
                    dataGridView1.Size = new Size(1439, 632);
                    lblUpdate.Location = new Point(607, 13);
                    lblLName.Location = new Point(809, 164);
                    txtLastname.Location = new Point(932, 161);
                    btnUpdate.Location = new Point(594, 627);
                    btnDelete.Location = new Point(805, 627);
                }
            }
            else 
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width) 
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                    tcAuthor.Location = new Point(333, 170);
                    tcAuthor.Size = new Size(1219, 721);
                    lblForm.Location = new Point(839, 9);
                    dataGridView1.Size = new Size(1211, 632);
                    lblUpdate.Location = new Point(484, 13);
                    lblLName.Location = new Point(660, 164);
                    txtLastname.Location = new Point(783, 161);
                    btnUpdate.Location = new Point(488, 627);
                    btnDelete.Location = new Point(664, 627);
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

        public void Clear() 
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtEmail.Clear();
            txtPublisher.Clear();
            dateTimePicker1.Text = "";
            txtEmail.Clear();
            txtTitle.Clear();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.frmAdminDashboard adminDashboard = new Admin.frmAdminDashboard();
            adminDashboard.Show();
        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            fillData();
            txtFirstname.TabIndex = 1;
            txtLastname.TabIndex = 2;
            txtTitle.TabIndex = 3;
            dateTimePicker1.TabIndex = 4;
            txtPublisher.TabIndex = 5;
            txtEmail.TabIndex = 6;
        }

        public void fillData() 
        {
            Functions.Functions.gen = "Select author.authorID as [Author ID], author.firstName as [First Name], author.lastName as [Last Name],author.title as [Book Title], author.publisher as [Publisher], author.datePublished as [Date Published],author.emailAddress as [Email Address] from author";
            Functions.Functions.fill(Functions.Functions.gen, dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) 
                {
                    Functions.Functions.gen = "Delete from author where authorID = " + txtAuthorID.Text + "";
                    Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                    Functions.Functions.command.ExecuteNonQuery();
                    Connection.Connection.conn.Close();

                    fillData();
                    this.tcAuthor.SelectedIndex = 0;
                    Clear();
                }
            }
            catch (Exception ex) 
            {
            
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select * from author where firstName like '%" + txtSearch.Text + "%' or lastName like '%" + txtSearch.Text + "%'";
                Functions.Functions.fill(Functions.Functions.gen, dataGridView1);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnStudentMgmt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentManagement student = new frmStudentManagement();
            student.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtAuthorID.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                txtFirstname.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                txtLastname.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                txtTitle.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                txtPublisher.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                txtEmail.Text = dataGridView1[6, e.RowIndex].Value.ToString();

                this.tcAuthor.SelectedIndex = 1;

                btnSave.Visible = false;
                btnSave.Enabled = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                label8.Visible = true;
                txtAuthorID.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select firstName = '" + txtFirstname.Text + "', lastName = '" + txtLastname.Text + "', title = '" + txtTitle.Text + "' from author" ;
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                if (Functions.Functions.reader.HasRows)
                {
                    Functions.Functions.reader.Read();
                    string name = Functions.Functions.reader["firstName"].ToString() + " " + Functions.Functions.reader["lastName"].ToString();
                    string title = Functions.Functions.reader["title"].ToString();
                    string fullname = txtFirstname.Text + " " + txtLastname.Text;
                    if (name == fullname && title == txtTitle.Text)
                    {
                        MessageBox.Show("This author and book title already exist!", "Already existed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        Connection.Connection.conn.Close();
                    }
                }

                else 
                {
                    Connection.Connection.DB();
                    Functions.Functions.gen = "Insert into author(firstName, lastName, title, publisher, datePublished, emailAddress) values ('" + txtFirstname.Text + "', '" + txtLastname.Text + "', '" + txtTitle.Text + "', '" + txtPublisher.Text + "', '" + dateTimePicker1.Value + "','" + txtEmail.Text + "')";
                    Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                    Functions.Functions.command.ExecuteNonQuery();

                    MessageBox.Show("Author's information is saved in the data base", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connection.Connection.conn.Close();

                    fillData();
                    this.tcAuthor.SelectedIndex = 0;
                    Clear();
                }
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Update author set firstName = '" + txtFirstname.Text + "', lastName = '" + txtLastname.Text + "', title = '" + txtTitle.Text + 
                    "', publisher = '" + txtPublisher.Text + "', datePublished = '" + dateTimePicker1.Value + "', emailAddress = '" + txtEmail.Text + "'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.command.ExecuteNonQuery();
                Connection.Connection.conn.Close();

                fillData();
                this.tcAuthor.SelectedIndex = 0;
                Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
