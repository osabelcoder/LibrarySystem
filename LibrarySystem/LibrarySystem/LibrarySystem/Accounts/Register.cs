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

namespace LibrarySystem.Accounts
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = " ";
            try
            {
                if (rbtnMale.Checked == true)
                {
                    gender = rbtnMale.Text;
                    rbtnFemale.Checked = false;
                }
                else if (rbtnFemale.Checked == true)
                {
                    gender = rbtnFemale.Text;
                    rbtnMale.Checked = false;
                }

                string FName = txtFirstname.Text;
                string LName = txtLastname.Text;

                DialogResult result = MessageBox.Show("Please confirm if the information you entered is correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Connection.Connection.DB();
                    Functions.Functions.gen = "Insert into student(studentID, firstname, lastname, gender, year_level, department, course, username, password, dateregistered, roleID) values('" + txtStudentID.Text + "','" + char.ToUpper(FName[0]) + FName.Substring(1) + "','" + char.ToUpper(LName[0]) + LName.Substring(1) + "','" + gender + "','" + cmbYear_lvl.Text + "','" + cmbDepartment.Text + "','" + cmbCourse.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + DateTime.Now.ToString() + "', 2)";
                    Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                    Functions.Functions.command.ExecuteNonQuery();

                    MessageBox.Show("You can now login with you account", "Register Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connection.Connection.conn.Close();
                    this.Hide();
                    frmLogin login = new frmLogin();
                    login.Show();
                }
                else 
                {
                    this.Show();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            lblReg.Visible = false;
            dtpReg.Visible = false;
            txtStudentID.TabIndex = 1;
            txtFirstname.TabIndex = 2;
            txtLastname.TabIndex = 3;
            rbtnMale.TabIndex = 4;
            rbtnFemale.TabIndex = 5;
            cmbYear_lvl.TabIndex = 6;
            cmbDepartment.TabIndex = 7;
            cmbCourse.TabIndex = 8;
            txtUsername.TabIndex = 9;
            txtPassword.TabIndex = 10;
            btnSave.TabIndex = 11;
            btnBack.TabIndex = 12;
        }
    }
}
