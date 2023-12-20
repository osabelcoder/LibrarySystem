using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Connection
{
    internal class Connection
    {
        public static SqlConnection conn;
        private static string dbconnect = "Data Source=MARK\\SQLEXPRESS03;Initial Catalog=LibSys;Integrated Security=True";

        public static void DB()
        {
            try
            {
                conn = new SqlConnection(dbconnect);
                conn.Open();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }
    }
}
