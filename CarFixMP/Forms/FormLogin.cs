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
            LoginManager.Login(txtUsername.Text, txtPassword.Text);
            this.Hide();
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

        private void PictureQuit_Click(object sender, EventArgs e) => CustomButtons.Exit();

    }
}
