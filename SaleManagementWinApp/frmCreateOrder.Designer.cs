namespace SaleManagementWinApp
{
    partial class frmCreateOrder
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
            btnOrder = new Button();
            btncClose = new Button();
            txtOrderID = new TextBox();
            txtCustomerID = new TextBox();
            txtOrderDate = new TextBox();
            txtShippedDate = new TextBox();
            txtTotal = new TextBox();
            txtOrderStatus = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 80);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "OrderID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 137);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "CustomerID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 201);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "OrderDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 250);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "ShippedDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 299);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 356);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "OrderStatus";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(166, 402);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(75, 23);
            btnOrder.TabIndex = 6;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btncClose
            // 
            btncClose.Location = new Point(323, 402);
            btncClose.Name = "btncClose";
            btncClose.Size = new Size(75, 23);
            btncClose.TabIndex = 7;
            btncClose.Text = "Close";
            btncClose.UseVisualStyleBackColor = true;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(239, 80);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(100, 23);
            txtOrderID.TabIndex = 8;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(239, 137);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 9;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(239, 201);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(100, 23);
            txtOrderDate.TabIndex = 10;
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(239, 247);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(100, 23);
            txtShippedDate.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(239, 299);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 12;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Location = new Point(239, 353);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new Size(100, 23);
            txtOrderStatus.TabIndex = 13;
            // 
            // frmCreateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(txtOrderStatus);
            Controls.Add(txtTotal);
            Controls.Add(txtShippedDate);
            Controls.Add(txtOrderDate);
            Controls.Add(txtCustomerID);
            Controls.Add(txtOrderID);
            Controls.Add(btncClose);
            Controls.Add(btnOrder);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCreateOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCreateOrder";
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
        private Button btnOrder;
        private Button btncClose;
        private TextBox txtOrderID;
        private TextBox txtCustomerID;
        private TextBox txtOrderDate;
        private TextBox txtShippedDate;
        private TextBox txtTotal;
        private TextBox txtOrderStatus;
    }
}