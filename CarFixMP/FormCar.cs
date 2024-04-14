using System;
using System.Windows.Forms;

namespace CarFixMP
{
    public partial class FormCar : Form
    {
        private readonly Car _car;
        public string id, brand, model, information, price;

        public FormCar(Car car)
        {
            InitializeComponent();
            _car = car;
        }

        public void UpdateInfo()
        {
            btnSave.Text = "EDIT";
            txtBrand.Text = brand;
            txtModel.Text = model;
            txtInformation.Text = information;
            txtPrice.Text = price;          
        }

        public void SaveInfo() => btnSave.Text = "SAVE";

        public void Clear() => 
        txtBrand.Text = txtModel.Text = txtInformation.Text = txtPrice.Text = string.Empty;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text.Length > 50)
            {
                MessageBox.Show("(Brand) You have exceeded the character limit (50).");
                return;
            }
            if (txtModel.Text.Length > 50)
            {
                MessageBox.Show("(Model) You have exceeded the character limit (50).");
                return;
            }
            if (txtInformation.Text.Length > 1000)
            {
                MessageBox.Show("(Information) You have exceeded the character limit (1000).");
                return;
            }
            if (txtPrice.Text.Length > 50)
            {
                MessageBox.Show("(Price) You have exceeded the character limit (50).");
                return;
            }

           
            if (btnSave.Text == "SAVE")
            {
                Car carr = new Car(txtBrand.Text.Trim(), txtModel.Text.Trim(), txtInformation.Text.Trim(), txtPrice.Text.Trim());
                DbCar.AddCar(carr);
                Clear();
            }
            if (btnSave.Text == "EDIT")
            {
                Car carr = new Car(txtBrand.Text.Trim(), txtModel.Text.Trim(), txtInformation.Text.Trim(), txtPrice.Text.Trim());
                DbCar.UpdateCar(carr, id);
            }
        }
    }
}
