namespace CarFix.Forms
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBoxShowRegisterPassword = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBackToLogin = new System.Windows.Forms.Label();
            this.PictureQuitRegister = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureQuitRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign up";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUsername.Location = new System.Drawing.Point(32, 148);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPassword.Location = new System.Drawing.Point(32, 230);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(232, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(32, 309);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(232, 26);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // CheckBoxShowRegisterPassword
            // 
            this.CheckBoxShowRegisterPassword.AutoSize = true;
            this.CheckBoxShowRegisterPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxShowRegisterPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxShowRegisterPassword.ForeColor = System.Drawing.Color.White;
            this.CheckBoxShowRegisterPassword.Location = new System.Drawing.Point(148, 351);
            this.CheckBoxShowRegisterPassword.Name = "CheckBoxShowRegisterPassword";
            this.CheckBoxShowRegisterPassword.Size = new System.Drawing.Size(116, 20);
            this.CheckBoxShowRegisterPassword.TabIndex = 8;
            this.CheckBoxShowRegisterPassword.Text = "Show Password";
            this.CheckBoxShowRegisterPassword.UseVisualStyleBackColor = true;
            this.CheckBoxShowRegisterPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowRegisterPassword_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegister.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(32, 415);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(232, 39);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Already Have an Account";
            // 
            // lblBackToLogin
            // 
            this.lblBackToLogin.AutoSize = true;
            this.lblBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackToLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBackToLogin.ForeColor = System.Drawing.Color.White;
            this.lblBackToLogin.Location = new System.Drawing.Point(105, 548);
            this.lblBackToLogin.Name = "lblBackToLogin";
            this.lblBackToLogin.Size = new System.Drawing.Size(99, 16);
            this.lblBackToLogin.TabIndex = 11;
            this.lblBackToLogin.Text = "Back to LOGIN";
            this.lblBackToLogin.Click += new System.EventHandler(this.lblBackToLogin_Click);
            // 
            // PictureQuitRegister
            // 
            this.PictureQuitRegister.BackColor = System.Drawing.Color.Transparent;
            this.PictureQuitRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureQuitRegister.BackgroundImage")));
            this.PictureQuitRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureQuitRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureQuitRegister.Location = new System.Drawing.Point(12, 12);
            this.PictureQuitRegister.Name = "PictureQuitRegister";
            this.PictureQuitRegister.Size = new System.Drawing.Size(35, 35);
            this.PictureQuitRegister.TabIndex = 24;
            this.PictureQuitRegister.TabStop = false;
            this.PictureQuitRegister.Click += new System.EventHandler(this.PictureQuitRegister_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(300, 600);
            this.Controls.Add(this.PictureQuitRegister);
            this.Controls.Add(this.lblBackToLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.CheckBoxShowRegisterPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)(this.PictureQuitRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBackToLogin;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtConfirmPassword;
        public System.Windows.Forms.CheckBox CheckBoxShowRegisterPassword;
        private System.Windows.Forms.PictureBox PictureQuitRegister;
    }
}