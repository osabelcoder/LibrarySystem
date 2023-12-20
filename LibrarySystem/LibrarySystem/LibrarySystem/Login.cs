using LibrarySystem.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmLogin : Form
    {

        public static string setFName = "";
        public static string setLname = "";
        public static string setUserID = "";
        public static string setDepartment = "";
        public static string setcourse = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int roleID;
            try
            {
                Connection.Connection.DB();
                Functions.Functions.gen = "Select * from student where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                if (Functions.Functions.reader.HasRows)
                {
                    Functions.Functions.reader.Read();
                    roleID = Convert.ToInt32(Functions.Functions.reader["roleID"]);

                    if (roleID == 2)
                    {
                        txtUsername.Text = Functions.Functions.reader["username"].ToString();
                        txtPassword.Text = Functions.Functions.reader["password"].ToString();
                        setFName = Functions.Functions.reader["firstname"].ToString();
                        setLname = Functions.Functions.reader["lastname"].ToString();
                        setUserID = Functions.Functions.reader["studentID"].ToString();
                        setDepartment = Functions.Functions.reader["department"].ToString();
                        setcourse = Functions.Functions.reader["course"].ToString();

                        this.Visible = false;
                        frmStudentDashboard student = new frmStudentDashboard();
                        student.Show();
                    }

                    else if (roleID == 1)
                    {
                        txtUsername.Text = Functions.Functions.reader["username"].ToString();
                        txtPassword.Text = Functions.Functions.reader["password"].ToString();
                        setFName = Functions.Functions.reader["firstname"].ToString();
                        setLname = Functions.Functions.reader["lastname"].ToString();
                        setUserID = Functions.Functions.reader["userID"].ToString();

                        this.Visible = false;
                        frmAdminDashboard admin = new frmAdminDashboard();
                        admin.Show();
                    }
                }
                Connection.Connection.DB();
                Functions.Functions.gen = "Select * from admin where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
                Functions.Functions.command = new SqlCommand(Functions.Functions.gen, Connection.Connection.conn);
                Functions.Functions.reader = Functions.Functions.command.ExecuteReader();

                if (Functions.Functions.reader.HasRows)
                {
                    Functions.Functions.reader.Read();
                    roleID = Convert.ToInt32(Functions.Functions.reader["roleID"]);

                    if (roleID == 1)
                    {
                        txtUsername.Text = Functions.Functions.reader["username"].ToString();
                        txtPassword.Text = Functions.Functions.reader["password"].ToString();
                        setFName = Functions.Functions.reader["firstname"].ToString();
                        setLname = Functions.Functions.reader["lastname"].ToString();
                        setUserID = Functions.Functions.reader["userID"].ToString();

                        this.Visible = false;
                        Admin.frmAdminDashboard admin = new Admin.frmAdminDashboard();
                        admin.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Accounts.Register register = new Accounts.Register();
            register.Show();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username") 
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '•';

                if (txtPassword.Text == "") 
                {
                    txtPassword.PasswordChar = '•';
                }
            }
        }

        private void pctboxFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/uclmLibrary");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.TabIndex = 1;
            txtUsername.TabStop = true;
            txtPassword.TabIndex = 2;
            txtPassword.TabStop = true;
            llblRegister.TabStop = true;
            btnLogin.TabIndex = 3;
            llblRegister.TabIndex = 4;
        }
    }
}
