using CarFix;
using CarFix.CustomControls;
using CarFix.Interfaces;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Tls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;



namespace CarFixMP
{
    public partial class CarFixInfo : Form
    {
        public DataGridView dataGridView;
        FormCar form;
        private Car car;
        private string filename;
        readonly string id;
        CarExporter CarExporter;
        public Point mouseLocation;
        bool mouseDown;
        private Point offset;




        public CarFixInfo()
        {
            InitializeComponent();
            form = new FormCar(car);
            CarExporter = new CarExporter(dataGridView,filename);
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            Display();
            CustomButtons.SetDefault(this);
        }

        public void Display() =>
        DbCar.DisplayAndSearch("SELECT ID, Brand, Model, Information, Price, CreatedAt, UpdatedAt FROM car_table", dataGridView);
    
        private void txtSearch_TextChanged(object sender, EventArgs e) =>
        DbCar.DisplayAndSearch("SELECT ID, Brand, Model, Information, Price, CreatedAt, UpdatedAt FROM car_table WHERE Brand LIKE'%" + txtSearch.Text + "%'", dataGridView);
        

        private void DisplayAndSearch(object sql, DataGridView dataGridView)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DbCar.DeleteCar(id);
                DisplayAndSearch(sql, dataGridView);

            }
        }

        // Method to show full description window
        private void ShowFullDescription(string brand, string model, string information, string price)
        {
            FullDescriptionForm fullDescriptionForm = new FullDescriptionForm(brand, model, information, price);

            fullDescriptionForm.ShowDialog();
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                if (e.ColumnIndex == 0)
                {
                    // Edit button clicked
                    // Update FormCar with selected car information and show the dialog
                    form.Clear();
                    form.id = dataGridView.Rows[e.RowIndex].Cells["column1"].Value.ToString();
                    form.brand = dataGridView.Rows[e.RowIndex].Cells["column2"].Value.ToString();
                    form.model = dataGridView.Rows[e.RowIndex].Cells["column3"].Value.ToString();
                    form.information = dataGridView.Rows[e.RowIndex].Cells["column5"].Value.ToString();
                    form.price = dataGridView.Rows[e.RowIndex].Cells["column6"].Value.ToString();
                    form.UpdateInfo();
                    form.ShowDialog();
                    Display();
                    return;
                }
                if (e.ColumnIndex == 1)
                {
                    // Delete button clicked
                    // Prompt user to confirm deletion and delete the selected car information
                    if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        DbCar.DeleteCar(dataGridView.Rows[e.RowIndex].Cells["column1"].Value.ToString());
                        Display();
                    }
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
            Display();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => Display();

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            CarExporter.ExportToPdf(dataGridView,filename);
        }

        // Event handler method for cell double click in the DataGridView
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if double click occurred on a valid row
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                // Get information from the selected row
                string brand = dataGridView.Rows[e.RowIndex].Cells["column2"].Value.ToString();
                string model = dataGridView.Rows[e.RowIndex].Cells["column3"].Value.ToString();
                string information = dataGridView.Rows[e.RowIndex].Cells["column5"].Value.ToString();
                string price = dataGridView.Rows[e.RowIndex].Cells["column6"].Value.ToString();
                string createdat = dataGridView.Rows[e.RowIndex].Cells["column4"].Value.ToString();
                string updatedat = dataGridView.Rows[e.RowIndex].Cells["column9"].Value.ToString();

                // Open a new window (Form) with full description
                ShowFullDescription(brand, model, information, price);
            }
        }





        private void btnClose_Click(object sender, EventArgs e)
        {
           CustomButtons.Exit();
        }

        private void btnMaximalize_Click(object sender, EventArgs e)
        {
            CustomButtons.Maximize(this);
        }

        private void btnMinimalize_Click(object sender, EventArgs e)
        {
            CustomButtons.Minimize(this);
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;


        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouse_Up(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}


