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
            RegisterManager.Register(txtUsername.Text, txtPassword.Text, txtConfirmPassword.Text);
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
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
