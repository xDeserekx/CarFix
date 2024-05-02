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

        public static void Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password fields are empty", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
using (var con = DbCar.GetConnection())
            {
                con.Open();
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
            catch(SqlException ex) 
            {
                MessageBox.Show("An error occurred while trying to login.","Login Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
