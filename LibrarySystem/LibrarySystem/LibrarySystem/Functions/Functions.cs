using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Functions
{
    internal class Functions
    {
        public static string gen = "";
        public static SqlConnection conn;
        public static SqlCommand command;
        public static SqlDataReader reader;

        public static void fill(string q, DataGridView dgv)
        {
            try
            {
                Connection.Connection.DB();
                DataTable dt = new DataTable();
                SqlDataAdapter data = null;
                SqlCommand command = new SqlCommand(q, Connection.Connection.conn);
                data = new SqlDataAdapter(command);
                data.Fill(dt);
                dgv.DataSource = dt;
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
