using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarFixMP;

namespace CarFix.Data
{
    public class LoginManager
    {
        public static SqlConnection GetConnection()
        {
            //string sql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CarFixAccountsDb.mdf;Integrated Security=True";
            string sql = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CarFixDb;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL database not loaded! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password fields are empty", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var con = LoginManager.GetConnection())
            {
                string loginQuery = "SELECT * FROM users_table WHERE username= @username AND password= @password";
                SqlCommand cmd = new SqlCommand(loginQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    new CarFixInfo().Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
