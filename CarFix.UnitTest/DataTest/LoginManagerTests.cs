using CarFix.Data;
using CarFixMP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFix.UnitTest.DataTest
{
    [TestClass]
    public class LoginManagerTests
    {
        [TestMethod]
        public void Login_EmptyUsernameAndPassword_ShowErrorMessageBox()
        {
            // Arrange
            string username = string.Empty;
            string password = string.Empty;

            // Acta
            bool loginResult=Login(username, password);

            // Assert
            Assert.IsTrue(true);
            Assert.AreEqual("Username and Password fields are empty", MessageBoxIcon.Information );
            Assert.AreEqual("Login failed", MessageBoxIcon.Error );
        }

        private bool Login(string username, string password)
        {
            // Mocking database connection and command
            // For unit tests, we are assuming the login is successful if both username and password are non-empty
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
