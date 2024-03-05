namespace SaleManagementWinApp
{
    partial class frmDetailInfo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtCustomerID = new TextBox();
            txtEmail = new TextBox();
            txtCustomerName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            txtBirthday = new TextBox();
            txtCustomerStatus = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 60);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "CustomerID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 105);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 142);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "CustomerName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 185);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 259);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 221);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 302);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 6;
            label7.Text = "Birthday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(105, 351);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 7;
            label8.Text = "CustomerStatus";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(238, 57);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(238, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(238, 142);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(100, 23);
            txtCustomerName.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(238, 185);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(238, 221);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(100, 23);
            txtCountry.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(238, 259);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 13;
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new Point(238, 302);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(100, 23);
            txtBirthday.TabIndex = 14;
            // 
            // txtCustomerStatus
            // 
            txtCustomerStatus.Location = new Point(238, 348);
            txtCustomerStatus.Name = "txtCustomerStatus";
            txtCustomerStatus.Size = new Size(100, 23);
            txtCustomerStatus.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(263, 396);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(105, 396);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmDetailInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCustomerStatus);
            Controls.Add(txtBirthday);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCustomerName);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDetailInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetailInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtCustomerID;
        private TextBox txtEmail;
        private TextBox txtCustomerName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private TextBox txtBirthday;
        private TextBox txtCustomerStatus;
        private Button button1;
        private Button button2;
    }
}