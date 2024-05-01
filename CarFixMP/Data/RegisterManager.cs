using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFix.Data
{
    public class RegisterManager
    {
        public static void Register(string username, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Username, Password, and Confirm Password fields cannot be empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var con = LoginManager.GetConnection())
            {
                string registerQuery = "INSERT INTO users_table (username, password) VALUES (@username, @password)";
                SqlCommand cmd = new SqlCommand(registerQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Your account has been successfully created", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
