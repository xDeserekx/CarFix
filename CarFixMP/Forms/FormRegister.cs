using CarFix.CustomControls;
using CarFix.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFix.Forms
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                var con = DbRegister.GetConnection();
                
                string register = "INSERT INTO users_table VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

                MessageBox.Show("Your account has been succesfully created", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not match. Please Re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();

            }
        }



        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void CheckBoxShowRegisterPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowRegisterPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void PictureQuitRegister_Click(object sender, EventArgs e) => CustomButtons.Exit();

    }
}
