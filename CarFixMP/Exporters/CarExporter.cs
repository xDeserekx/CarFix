using CarFix.Interfaces;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFix
{
    public class CarExporter : ICarExporter
    {
        private string filename;
        private DataGridView dataGridView;

        private bool IsImageColumn(DataGridViewColumn column) { return column is DataGridViewImageColumn; }

        private bool IsImageCell(DataGridViewCell cell) { return cell is DataGridViewImageCell; }

        public CarExporter(DataGridView dataGridView, string filename)
        {
            this.dataGridView = dataGridView;
            this.filename = filename;
        }

        public void ExportToPdf(DataGridView dgv, string fileName)
        {

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(GetVisibleColumnCount(dgv));
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            // Add header
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible && !IsImageColumn(column))
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdftable.AddCell(cell);
                }
            }

            // Add datarow
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Visible && !IsImageCell(cell))
                    {
                        if (cell.Value != null)
                        {
                            if (cell.OwningColumn.Name == "column4" || cell.OwningColumn.Name == "column9")
                            {
                                if (DateTime.TryParse(cell.Value.ToString(), out DateTime dateValue))
                                {
                                    string formattedDate = dateValue.Date.ToString("yyyy-MM-dd");
                                    pdftable.AddCell(new Phrase(formattedDate, text));
                                }
                                else
                                {
                                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                                }
                            }
                            else
                            {
                                pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                            }
                        }
                    }
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = fileName;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        // Helper function to get the count of visible columns excluding image columns
        private int GetVisibleColumnCount(DataGridView dgv)
        {
            int count = 0;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible && !IsImageColumn(column))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
