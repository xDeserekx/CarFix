using CarFixMP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFix.Tests
{
    [TestFixture]
    public class DbCarTests
    {
        [Test]
        public void TestConnection()
        {
            bool connectionSuccessful = false;

            try
            {
                using ( var connection = DbCar.GetConnection())
                {
                    connectionSuccessful = (connection.State == System.Data.ConnectionState.Open);
                }
            }
            catch(Exception )
            {

            }

            Assert.IsTrue(connectionSuccessful, "Connection to the database failed");
        }
    }
}
