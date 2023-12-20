using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Admin
{
    public partial class frmBookManagement : Form
    {

        bool sidebarExpand;
        public frmBookManagement()
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
                    lblBook.Location = new Point(665, 9);
                    tabControl1.Location = new Point(96, 173);
                    tabControl1.Size = new Size(1459, 720);
                    dataGridView1.Size = new Size(1439, 632);
                    lblTab.Location = new Point(579, 10);
                    lblAuthor.Location = new Point(793, 187);
                    txtAuthor.Location = new Point(883, 184);
                    lblGenre.Location = new Point(793, 293);
                    txtGenre.Location = new Point(883, 293);
                    lblPublisher.Location = new Point(793, 401);
                    txtPublisher.Location = new Point(954, 395);
                    btnSave.Location = new Point(583, 615);
                    BtnUpdate.Location = new Point(717, 615);
                    btnDelete.Location = new Point(857, 615);
                }
            }
            else 
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width) 
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                    lblBook.Location = new Point(856, 9);
                    tabControl1.Location = new Point(330, 173);
                    tabControl1.Size = new Size(1225, 720);
                    dataGridView1.Size = new Size(1213, 632);
                    lblTab.Location = new Point(478, 10);
                    lblAuthor.Location = new Point(690, 187);
                    txtAuthor.Location = new Point(780, 184);
                    lblGenre.Location = new Point(690, 293);
                    txtGenre.Location = new Point(780, 294);
                    lblPublisher.Location = new Point(690, 401);
                    txtPublisher.Location = new Point(9851, 395);
                    btnSave.Location = new Point(466, 615);
                    BtnUpdate.Location = new Point(600, 615);
                    btnDelete.Location = new Point(740, 615);
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
            Admin.frmStudentManagement student = new frmStudentManagement();
            student.Show();
        }

        public void Clear() 
        {
            txtAccession.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtVolume.Clear();
            txtGenre.Clear();
            dateTimePicker1.Text = "";
            txtPublisher.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select title, author from book where title = '" + txtTitle.Text + "' and author = '" + txtAuthor.Text + "'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                if (Functions.Functions.reader.HasRows)
                {
                    Functions.Functions.reader.Read();
                    string bookTitle = Functions.Functions.reader["title"].ToString();
                    string author = Functions.Functions.reader["author"].ToString();

                    if (bookTitle == txtTitle.Text && author == txtAuthor.Text)
                    {
                        MessageBox.Show("This book already exist in the database! Please enter another book", "The book exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                        Connection.Connection.conn.Close();
                    }
                }
                else 
                {
                    string title = txtTitle.Text;

                    Connection.Connection.DB();
                    Functions.Functions.gen = "Insert into book(title, author, volume, genre, date_published, publisher, status) values('" + char.ToUpper(title[0]) + title.Substring(1) + "','" + txtAuthor.Text + "','" + txtVolume.Text + "','" + txtGenre.Text + "','" + dateTimePicker1.Value + "','" + txtPublisher.Text + "','" + "Available')";
                    Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                    Functions.Functions.command.ExecuteNonQuery();

                    MessageBox.Show("The book is saved in the database", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connection.Connection.conn.Close();

                    Clear();
                    fillData();
                    this.tabControl1.SelectedIndex = 1;
                }
                
                }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillData() 
        {
            Functions.Functions.gen = "Select accession_number as [Accession Number], book.title as [Title], book.author as [Author], book.volume as [Volume], book.genre as [Genre], book.date_published as [Date Published], book.publisher as [Publisher], book.status as [Status] from book order by book.status ASC";
            Functions.Functions.fill(Functions.Functions.gen, dataGridView1);
        }

        private void frmBookManagement_Load(object sender, EventArgs e)
        {
            
            fillData();
            txtTitle.TabIndex = 1;
            txtAuthor.TabIndex = 2;
            txtVolume.TabIndex = 3;
            txtGenre.TabIndex = 4;
            dateTimePicker1.TabIndex = 5;
            txtPublisher.TabIndex = 6;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtAccession.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                txtTitle.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                txtAuthor.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                txtVolume.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                txtGenre.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                txtPublisher.Text = dataGridView1[6, e.RowIndex].Value.ToString();

                this.tabControl1.SelectedIndex = 0;

                btnSave.Enabled = false;
                BtnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                txtAccession.Visible = true;
                lblAccession.Visible = true;
                txtAccession.Enabled = false;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Update book set title = '" + txtTitle.Text + ", author = '" + txtAuthor.Text +"', volume ='" + txtVolume.Text + "', genre = '"
                    + txtGenre.Text + "', date_published = '" + dateTimePicker1.Value + "', publisher = '" + txtPublisher.Text + "'" + "";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.command.ExecuteNonQuery(); 
                Connection.Connection.conn.Close();

                MessageBox.Show("The record has been updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fillData();
                this.tabControl1.SelectedIndex = 1;
                Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);          
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Functions.Functions.gen = "Delete from book where accession_number = " + txtAccession.Text + "";
                    Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                    Functions.Functions.command.ExecuteNonQuery();
                    Connection.Connection.conn.Close();

                    frmBookManagement_Load(sender, e);
                    this.tabControl1.SelectedIndex = 1;
                    Clear();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnBorrowedBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.frmBookBorrowing book = new Admin.frmBookBorrowing();
            book.Show();
        }

        private void btnAuthorMgmt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAuthorManagement author = new frmAuthorManagement();
            author.Show();
        }
    }
}
