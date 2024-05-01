using CarFix.CustomControls;
using CarFix.Data;
using CarFixMP;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var con = DbRegister.GetConnection();
            string login = "SELECT * FROM users_table WHERE username= '" + txtUsername.Text + "' AND password= '" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(login, con);

            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd.ExecuteNonQuery();
                con.Close();
                new CarFixInfo().Show();
   this.Hide();
            }
         

        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }

        private void CheckBoxShowLoginPassowrd_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowLoginPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void PictureQuit_Click(object sender, EventArgs e) => CustomButtons.Exit() ;

    }
}
