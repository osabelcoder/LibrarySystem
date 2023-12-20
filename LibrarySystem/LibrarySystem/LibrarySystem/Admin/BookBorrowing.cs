using LibrarySystem.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Admin
{
    public partial class frmBookBorrowing : Form
    {

        bool sidebarExpand;
        public frmBookBorrowing()
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
                    lblBorrow.Location = new Point(757, 9);
                }
            }
            else 
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width) 
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                    lblBorrow.Location = new Point(856, 9);
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

        private void frmBookBorrowing_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select studentID from student where studentID like '%" + txtSearchStudent.Text + "%'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();
                AutoCompleteStringCollection studentID = new AutoCompleteStringCollection();

                while (Functions.Functions.reader.Read())
                {
                    studentID.Add(Functions.Functions.reader.GetString(0));
                }

                txtSearchStudent.AutoCompleteCustomSource = studentID;
                Connection.Connection.conn.Close();

                Connection.Connection.DB();
                Functions.Functions.gen = "Select title from book where status = 'Available'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                while (Functions.Functions.reader.Read()) 
                {
                    for (int i = 0; i < Functions.Functions.reader.FieldCount; i++) 
                    {
                        cmbTitle.Items.Add(Functions.Functions.reader.GetString(i));
                    } 
                }

                Connection.Connection.conn.Close();

                fillDataBorrow();
                fillDataReturn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select firstname, lastname, department, course from student where studentID ='" + txtSearchStudent.Text + "'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                if (Functions.Functions.reader.HasRows) 
                {
                    Functions.Functions.reader.Read();
                    string fname = Functions.Functions.reader["firstname"].ToString();
                    string lname = Functions.Functions.reader["lastname"].ToString();
                    txtStudentName.Text = fname + " " + lname;

                    cmbDepartment.Text = Functions.Functions.reader["Department"].ToString();
                    cmbCourse.Text = Functions.Functions.reader["Course"].ToString();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            try 
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Insert into borrowedBooks(studentID, studentName, department, course, title, dateBorrowed) values('" + txtSearchStudent.Text + "','" + txtStudentName.Text + "','" + cmbDepartment.Text + "','" + cmbCourse.Text + "','" + cmbTitle.Text + "','" + dtrBorrow.Value + "')";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.command.ExecuteNonQuery();

                readTitleBorrow();

                MessageBox.Show("The issuance of book is saved in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connection.Connection.conn.Close();

                clear();
                fillDataBorrow();
                this.tabControl1.SelectedIndex = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateBookStatusBorrowed() 
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Update book set status = 'Borrowed' where title = '" + cmbTitle.Text + "'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.command.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void readTitleBorrow() 
        {
            string title;
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select title from book where title = '" + cmbTitle.Text + "'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                if (Functions.Functions.reader.HasRows)
                {
                    Functions.Functions.reader.Read();
                    title = Functions.Functions.reader["title"].ToString();

                    if (title == cmbTitle.Text) 
                    {
                        updateBookStatusBorrowed();
                    }
                }

                Connection.Connection.conn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillDataBorrow() 
        {
            Functions.Functions.gen = "Select borrow_id as [Borrow ID], borrowedBooks.studentID as [Student ID], borrowedBooks.studentName as [Student Name], borrowedBooks.department as [Department], borrowedBooks.course as [Course], borrowedBooks.title as [Book Title], borrowedBooks.dateBorrowed as [Date Borrowed] from borrowedBooks";
            Functions.Functions.fill(Functions.Functions.gen, dgvBorrow);
        }

        public void fillDataReturn() 
        {
            fillDataBorrow();
            Functions.Functions.gen = "Select borrow_id as [Borrow ID], borrowedBooks.studentID as [Student ID], borrowedBooks.studentName as [Student Name], borrowedBooks.department as [Department], borrowedBooks.course as [Course], borrowedBooks.title as [Book Title], borrowedBooks.dateBorrowed as [Date Borrowed], borrowedBooks.dateReturned as [Date Returned] from borrowedBooks order by dateReturned desc";
            Functions.Functions.fill(Functions.Functions.gen, dgvReturn);
        }

        public void clear() 
        {
            txtSearchStudent.Clear();
            txtStudentName.Clear();
            cmbCourse.Text = "";
            cmbDepartment.Text = "";
            cmbTitle.Text = "";
            txtStudentID.Clear();
            txtStudName.Clear();
            cmbCour.Text = "";
            cmbDept.Text = "";
            cmbBookTitle.Text = "";
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchStudent.Text == "")
            {
                clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvReturn_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtStudentID.Text = dgvReturn[1, e.RowIndex].Value.ToString();
                txtStudName.Text = dgvReturn[2, e.RowIndex].Value.ToString();
                cmbDept.Text = dgvReturn[3, e.RowIndex].Value.ToString();
                cmbCour.Text = dgvReturn[4, e.RowIndex].Value.ToString();
                cmbBookTitle.Text = dgvReturn[5, e.RowIndex].Value.ToString();

                this.tabControl1.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Connection.Connection.DB();
            Functions.Functions.gen = "Update borrowedBooks set studentID ='" + txtStudentID.Text + "', studentName ='" + txtStudName.Text + "', department ='" + cmbDept.Text + "', course ='" + cmbCour.Text + "', title ='" + cmbBookTitle.Text + "', dateReturned ='" + dtrReturn.Value + "' where studentId = '" + txtStudentID.Text + "'";
            Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
            Functions.Functions.command.ExecuteNonQuery();

            readTitleReturn();

            MessageBox.Show("The returning of book is saved in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.conn.Close();

            clear();
            fillDataReturn();
            this.tabControl1.SelectedIndex = 3;
        }

        public void updateBookStatusReturn()
        {
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Update book set status = 'Available' where title = '" + cmbBookTitle.Text + "'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void readTitleReturn()
        {
            string title;
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select title from book where title = '" + cmbBookTitle.Text + "'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                if (Functions.Functions.reader.HasRows)
                {
                    Functions.Functions.reader.Read();
                    title = Functions.Functions.reader["title"].ToString();

                    if (title == cmbBookTitle.Text)
                    {
                        updateBookStatusReturn();
                    }
                }

                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAuthorMgmt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAuthorManagement author = new frmAuthorManagement();
            author.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataReturn();
        }
    }
}
