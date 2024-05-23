using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFixMP
{
    public class DbCar
    {
        public static SqlConnection GetConnection()
        {
            //string sql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CarFixDb.mdf;Integrated Security=True";
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
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return con;
        }

        public static void AddCar(Car carr)
        {
            string sql = "INSERT INTO car_table VALUES (@Brand,@Model,@Information,@Price,@CreatedAt,@UpdatedAt)";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Brand", SqlDbType.VarChar).Value = carr.Brand;
            cmd.Parameters.Add("@Model", SqlDbType.VarChar).Value = carr.Model;
            cmd.Parameters.Add("@Information", SqlDbType.VarChar).Value = carr.Information;
            cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = carr.Price;
            cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = carr.CreatedAt;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = carr.UpdatedAt;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Not added. Try again. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        public static void UpdateCar(Car carr, string id)
        {
            string sql = "UPDATE car_table SET Brand=@Brand, Model=@Model, Information=@Information, Price=@Price, UpdatedAt=@UpdatedAt WHERE ID=@ID";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Brand", SqlDbType.VarChar).Value = carr.Brand;
            cmd.Parameters.Add("@Model", SqlDbType.VarChar).Value = carr.Model;
            cmd.Parameters.Add("@Information", SqlDbType.VarChar).Value = carr.Information;
            cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = carr.Price;
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = carr.UpdatedAt;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Not updated. Try again. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteCar(string id)
        {
            string sql = "DELETE FROM car_table WHERE ID = @ID";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Not deleted. Try again. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}

