using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.IO;

namespace CarFix.UnitTest.CarExporterTest
{
    [TestClass]
    public class CarExpoterTests
    {
        [TestMethod]
        public void ExportToPdf_WidthValidData_ExportSuccessful()
        {
            var dgv = new DataGridView();
            dgv.Columns.Add("column1", "Column 1");
            dgv.Columns.Add("column2", "Column 2");
            dgv.Columns.Add("column3", "Column 3");
            dgv.Rows.Add("Value 1", "Value 2", "Value 3");
            dgv.Rows.Add("Value 4", "Value 5", "Value 6");

            var filename = "test_export.pdf";
            var exporter = new CarExporter(dgv, filename);

            exporter.ExportToPdf(dgv,filename);

            Assert.IsTrue(File.Exists(filename));
        }

        [TestMethod]
        public void ExportToPdf_WithEmptyData_NoException()
        {
            DataGridView dgv = new DataGridView();
            string filename = "test_export_empty.pdf";
            CarExporter exporter = new CarExporter(dgv, filename);

            Assert.ThrowsException<ArgumentException>(() => exporter.ExportToPdf(dgv, filename));
        }
    }
}
