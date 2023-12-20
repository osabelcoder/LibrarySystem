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

namespace LibrarySystem.Admin
{
    public partial class frmStudentManagement : Form
    {

        bool sidebarExpand;
        
        public frmStudentManagement()
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
                    tcStudents.Location = new Point(96, 161);
                    tcStudents.Size = new Size(1458, 721);
                    lblForm.Location = new Point(642, 9);
                    dataGridView1.Size = new Size(1439, 632);
                    lblUpdate.Location = new Point(607, 13);
                    lblLName.Location = new Point(809, 164);
                    txtLastname.Location = new Point(932, 161);
                    lblYear.Location = new Point(809, 242);
                    cmbYear.Location = new Point(932, 239);
                    lblCourse.Location = new Point(809, 324);
                    cmbCourse.Location = new Point(932, 321);
                    lblPassword.Location = new Point(809, 409);
                    txtPassword.Location = new Point(932, 406);
                    lblDate.Location = new Point(809, 492);
                    dateTimePicker1.Location = new Point(985, 486);
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
                    tcStudents.Location = new Point(333, 170);
                    tcStudents.Size = new Size(1219, 721);
                    lblForm.Location = new Point(839, 9);
                    dataGridView1.Size = new Size(1211, 632);
                    lblUpdate.Location = new Point(484, 13);
                    lblLName.Location = new Point(660, 164);
                    txtLastname.Location = new Point(783, 161);
                    lblYear.Location = new Point(660, 242);
                    cmbYear.Location = new Point(783, 239);
                    lblCourse.Location = new Point(660, 324);
                    cmbCourse.Location = new Point(783, 321);
                    lblPassword.Location = new Point(660, 409);
                    txtPassword.Location = new Point(783, 406);
                    lblDate.Location = new Point(660, 492);
                    dateTimePicker1.Location = new Point(836, 486);
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
            txtStudentID.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            cmbYear.Text = "";
            cmbDepartment.Text = "";
            cmbCourse.Text = "";
            txtUsername.Clear();
            txtPassword.Clear();
            dateTimePicker1.Text = "";
            rbtnAdmin.Checked = false;
            rbtnStudent.Checked = false;
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
            txtStudentID.TabIndex = 1;
            txtFirstname.TabIndex = 2;
            txtLastname.TabIndex = 3;
            groupBox1.TabIndex = 4;
            cmbYear.TabIndex = 5;
            cmbDepartment.TabIndex = 6;
            cmbCourse.TabIndex = 7;
            txtUsername.TabIndex = 8;
            txtPassword.TabIndex = 9;
        }

        public void fillData() 
        {
            Functions.Functions.gen = "Select student.studentID as [Student ID], student.firstname as [First Name], student.lastname as [Last Name], student.gender as [Gender], student.year_level as [Year Level], student.department as [Department], student.course as [Course], student.username as [Username], student.password as [Password], student.dateregistered as [Date Registered], role.roleID as [Role] from student inner join role on role.roleID = student.roleID";
            Functions.Functions.fill(Functions.Functions.gen, dataGridView1);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
            {
                txtStudentID.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                txtFirstname.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                txtLastname.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[3].FormattedValue.Equals("Male"))
                {
                    rbtnMale.Checked = true;
                    rbtnFemale.Checked = false;
                }
                else
                {
                    rbtnFemale.Checked = true;
                    rbtnMale.Checked = false;
                }
                cmbYear.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                cmbDepartment.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                cmbCourse.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                txtUsername.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                txtPassword.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
                if (dataGridView1.CurrentRow.Cells[10].FormattedValue.Equals("2"))
                {
                    rbtnStudent.Checked = true;
                    rbtnAdmin.Checked = false;
                }

                this.tcStudents.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.Text == "College of Teacher Education")
            {
                cmbCourse.Items.Clear();
                cmbCourse.Items.Add("Bachelor of Library and Information System");
                cmbCourse.Items.Add("Bachelor of Elementary Education");
                cmbCourse.Items.Add("Bachelor of Secondary Education");
            }
            else if (cmbDepartment.Text == "College of Computer Studies")
            {
                cmbCourse.Items.Clear();
                cmbCourse.Items.Add("Associate in Computer Technology");
                cmbCourse.Items.Add("Bachelor of Science in Computer Science");
                cmbCourse.Items.Add("Bachelor of Science in Cybersecurity");
                cmbCourse.Items.Add("Bachelor of Science in Information System");
                cmbCourse.Items.Add("Bachelor of Science in Information Technology");
                cmbCourse.Items.Add("Bachelor of Science in Media and Interactive Arts");
            }
            else if (cmbDepartment.Text == "College of Engineering")
            {
                cmbCourse.Items.Clear();
                cmbCourse.Items.Add("Bachelor of Science in Chemical Engineering");
                cmbCourse.Items.Add("Bachelor of Science in Civil Engineering");
                cmbCourse.Items.Add("Bachelor of Science in Computer Engineering");
                cmbCourse.Items.Add("Bachelor of Science in Electronics Engineering");
                cmbCourse.Items.Add("Bachelor of Science in Electrical Engineering");
                cmbCourse.Items.Add("Bachelor of Science in Geodetic Engineering");
                cmbCourse.Items.Add("Bachelor of Science in Industrial Engineering");
                cmbCourse.Items.Add("Bachelor of Science in Mechanical Engineering");
                cmbCourse.Items.Add("Bachelor of Science in Materials Engineering");
                cmbCourse.Items.Add("Bachelor of Science in Metallurgical Engineering");
                cmbCourse.Items.Add("Bachelor of Science in Mining Engineering");
            }
            else if (cmbDepartment.Text == "College of Business Administration")
            {
                cmbCourse.Items.Clear();
                cmbCourse.Items.Add("Bachelor of Science in Business Administration");
            }
            else if (cmbDepartment.Text == "College of Tourism and Hospitality Management")
            {
                cmbCourse.Items.Clear();
                cmbCourse.Items.Add("Bachelor of Science in Tourism Management");
                cmbCourse.Items.Add("Bachelor of Science in Hospitality Management");
            }
            else if (cmbDepartment.Text == "College of Criminal Justice")
            {
                cmbCourse.Items.Clear();
                cmbCourse.Items.Add("Bachelor of Science in Criminology");
            }
            else if (cmbDepartment.Text == "College of Customs Administration")
            {
                cmbCourse.Items.Clear();
                cmbCourse.Items.Add("Bachelor of Science in Customs Administrarion");
            }
            else if (cmbDepartment.Text == "College of Maritime Education")
            {
                cmbCourse.Items.Clear();
                cmbCourse.Items.Add("Bachelor of Science in Marine Transportation");
                cmbCourse.Items.Add("Bachelor of Science in Marine Engineering");

            }
            else if (cmbDepartment.Text == "College of Nursing")
            {
                cmbCourse.Items.Clear();
                cmbCourse.Items.Add("Bachelor of Science in Nursing");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = "";
            string FName = txtFirstname.Text;
            string LName = txtLastname.Text;
            int role = 0;

            if (rbtnMale.Checked == true)
            {
                gender = rbtnMale.Text;
                rbtnFemale.Checked = false;
            }
            else 
            {
                gender = rbtnFemale.Text;
                rbtnMale.Checked = false;
            }

            if (rbtnStudent.Checked == true)
            {
                role = 2;
                rbtnAdmin.Checked = false;
            }
            else 
            {
                role = 1;
                rbtnStudent.Checked = false;
            }

            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Update students set studentID = " + txtStudentID.Text + ", firstname = '" + FName + "',lastname = '" + LName + "', gender = '" + gender + "', year_level = '" 
                    + cmbYear.Text + "', department = '" + cmbDepartment.Text + "', course = '" + cmbCourse.Text + "', username = '" + txtUsername.Text + "', password = '" 
                    + txtPassword.Text + "', dateregistered = '" + dateTimePicker1.Value.ToString() + "', roleID = " + role + "";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.command.ExecuteNonQuery();
                Connection.Connection.conn.Close();

                fillData();
                this.tcStudents.SelectedIndex = 0;
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
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) 
                {
                    Functions.Functions.gen = "Delete from student where studentID = " + txtStudentID.Text + "";
                    Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                    Functions.Functions.command.ExecuteNonQuery();
                    Connection.Connection.conn.Close();

                    fillData();
                    this.tcStudents.SelectedIndex = 0;
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
                Functions.Functions.gen = "Select * from student where studentID like '%" + txtSearch.Text + "%' or firstname like '%" + txtSearch.Text + "%' or lastname like '%" + txtSearch.Text + "%'";
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

        private void btnAuthorMgmt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAuthorManagement author = new frmAuthorManagement();
            author.Show();
        }
    }
}
