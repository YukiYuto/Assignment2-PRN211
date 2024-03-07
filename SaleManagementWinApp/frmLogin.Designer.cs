namespace SaleManagementWinApp
{
    partial class frmLogin
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
            button1 = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(235, 46);
            label1.Name = "label1";
            label1.Size = new Size(113, 50);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 133);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 180);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(202, 214);
            button1.Name = "button1";
            button1.Size = new Size(80, 26);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(202, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(202, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(186, 23);
            txtPassword.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(308, 214);
            button2.Name = "button2";
            button2.Size = new Size(80, 26);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 302);
            Controls.Add(button2);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button button2;
    }
}