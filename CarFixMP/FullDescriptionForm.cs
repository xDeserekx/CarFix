using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarFix
{
    public partial class FullDescriptionForm : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblInformacje;
        internal System.Windows.Forms.TextBox textModel;
        internal System.Windows.Forms.TextBox textPrice;
        internal System.Windows.Forms.TextBox textInformation;
        internal System.Windows.Forms.Button btnSavePdf;
        internal System.Windows.Forms.TextBox textBrand;

        public FullDescriptionForm(string brand, string model, string information, string price)
        {
            InitializeComponent();

            textBrand.Text = brand;
            textModel.Text = model;
            textInformation.Text = information;
            textPrice.Text = price;

        }

        private void btnSavePdf_Click(object sender, System.EventArgs e)
        {
            Document doc = new Document();
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save to PDF";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {

                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    Paragraph header = new Paragraph("Report Repair");
                    header.Alignment = Element.ALIGN_CENTER;
                    doc.Add(header);

                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("Brand: " + textBrand.Text));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("Model: " + textModel.Text));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("Price: " + textPrice.Text));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("Information: " + textInformation.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInformacje = new System.Windows.Forms.Label();
            this.textBrand = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textInformation = new System.Windows.Forms.TextBox();
            this.btnSavePdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // lblInformacje
            // 
            this.lblInformacje.AutoSize = true;
            this.lblInformacje.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInformacje.ForeColor = System.Drawing.Color.White;
            this.lblInformacje.Location = new System.Drawing.Point(342, 21);
            this.lblInformacje.Name = "lblInformacje";
            this.lblInformacje.Size = new System.Drawing.Size(116, 22);
            this.lblInformacje.TabIndex = 3;
            this.lblInformacje.Text = "Information";
            // 
            // textBrand
            // 
            this.textBrand.Font = new System.Drawing.Font("Arial", 14.25F);
            this.textBrand.Location = new System.Drawing.Point(12, 46);
            this.textBrand.Multiline = true;
            this.textBrand.Name = "textBrand";
            this.textBrand.ReadOnly = true;
            this.textBrand.Size = new System.Drawing.Size(220, 55);
            this.textBrand.TabIndex = 4;
            // 
            // textModel
            // 
            this.textModel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.textModel.Location = new System.Drawing.Point(12, 155);
            this.textModel.Multiline = true;
            this.textModel.Name = "textModel";
            this.textModel.ReadOnly = true;
            this.textModel.Size = new System.Drawing.Size(220, 55);
            this.textModel.TabIndex = 5;
            // 
            // textPrice
            // 
            this.textPrice.Font = new System.Drawing.Font("Arial", 14.25F);
            this.textPrice.Location = new System.Drawing.Point(12, 263);
            this.textPrice.Multiline = true;
            this.textPrice.Name = "textPrice";
            this.textPrice.ReadOnly = true;
            this.textPrice.Size = new System.Drawing.Size(220, 55);
            this.textPrice.TabIndex = 6;
            // 
            // textInformation
            // 
            this.textInformation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInformation.Location = new System.Drawing.Point(256, 46);
            this.textInformation.Multiline = true;
            this.textInformation.Name = "textInformation";
            this.textInformation.ReadOnly = true;
            this.textInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textInformation.Size = new System.Drawing.Size(271, 403);
            this.textInformation.TabIndex = 7;
            // 
            // btnSavePdf
            // 
            this.btnSavePdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSavePdf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSavePdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePdf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePdf.Location = new System.Drawing.Point(12, 417);
            this.btnSavePdf.Name = "btnSavePdf";
            this.btnSavePdf.Size = new System.Drawing.Size(123, 32);
            this.btnSavePdf.TabIndex = 8;
            this.btnSavePdf.Text = "Save .pdf";
            this.btnSavePdf.UseVisualStyleBackColor = false;
            this.btnSavePdf.Click += new System.EventHandler(this.btnSavePdf_Click);
            // 
            // FullDescriptionForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(535, 461);
            this.Controls.Add(this.btnSavePdf);
            this.Controls.Add(this.textInformation);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.textBrand);
            this.Controls.Add(this.lblInformacje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FullDescriptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
