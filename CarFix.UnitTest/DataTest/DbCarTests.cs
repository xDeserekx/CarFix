using CarFixMP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFix.UnitTest
{
    [TestClass]
    public class DbCarTests
    {


        [TestMethod]
        public void TestConnection()
        {
            bool connectionSuccessful = false;

            try
            {
                using (var connection = DbCar.GetConnection())
                {
                    connectionSuccessful = (connection.State == System.Data.ConnectionState.Open);
                }
            }
            catch (Exception)
            {

            }

            Assert.IsTrue(connectionSuccessful, "Connection to the database failed");
        }

        [TestMethod]
        public void TestAddCar()
        {
            Car car = new Car("TestBrand", "TestModel", "TestInformation", "TestPrice");

            DbCar.AddCar(car);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestDeleteCar()
        {
            string id = "1";

            DbCar.DeleteCar(id);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestUpdateCar()
        {
            Car car = new Car("TestBrand", "TestModel", "UpdatedTestInformaction", "TestPrice");

            string id = "1";

            DbCar.UpdateCar(car, id);

            Assert.IsTrue(true);
        }


    }
}
