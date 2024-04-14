namespace CarFixMP
{
    partial class FormCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelCena = new System.Windows.Forms.Label();
            this.labelInformacje = new System.Windows.Forms.Label();
            this.labelMarka = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BackgroundImage = global::CarFix.Properties.Resources.audi_rs6_on_the_road;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.labelCena);
            this.panel1.Controls.Add(this.labelInformacje);
            this.panel1.Controls.Add(this.labelMarka);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtInformation);
            this.panel1.Controls.Add(this.txtBrand);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.labelModel);
            this.panel1.Location = new System.Drawing.Point(-9, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 563);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(118, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 24);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.BackColor = System.Drawing.Color.Transparent;
            this.labelCena.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelCena.Location = new System.Drawing.Point(66, 139);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(58, 22);
            this.labelCena.TabIndex = 0;
            this.labelCena.Text = "Price";
            // 
            // labelInformacje
            // 
            this.labelInformacje.AutoSize = true;
            this.labelInformacje.BackColor = System.Drawing.Color.Transparent;
            this.labelInformacje.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInformacje.Location = new System.Drawing.Point(358, 4);
            this.labelInformacje.Name = "labelInformacje";
            this.labelInformacje.Size = new System.Drawing.Size(116, 22);
            this.labelInformacje.TabIndex = 0;
            this.labelInformacje.Text = "Information";
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.BackColor = System.Drawing.Color.Transparent;
            this.labelMarka.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelMarka.Location = new System.Drawing.Point(66, 21);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(67, 22);
            this.labelMarka.TabIndex = 0;
            this.labelMarka.Text = "Brand";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrice.Location = new System.Drawing.Point(34, 164);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(133, 26);
            this.txtPrice.TabIndex = 6;
            // 
            // txtInformation
            // 
            this.txtInformation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInformation.Location = new System.Drawing.Point(193, 29);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInformation.Size = new System.Drawing.Size(471, 161);
            this.txtInformation.TabIndex = 0;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBrand.Location = new System.Drawing.Point(34, 46);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(133, 26);
            this.txtBrand.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtModel.Location = new System.Drawing.Point(34, 105);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(133, 26);
            this.txtModel.TabIndex = 2;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.Color.Transparent;
            this.labelModel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelModel.Location = new System.Drawing.Point(66, 80);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(67, 22);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Model";
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 524);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.Label labelInformacje;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label labelModel;
    }
}