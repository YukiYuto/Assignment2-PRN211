namespace SaleManagementWinApp
{
    partial class frmProduct
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
            txtFlowerBouquetID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCategory = new TextBox();
            txtFlowerBouquetName = new TextBox();
            txtPrice = new TextBox();
            txtSupplier = new TextBox();
            label6 = new Label();
            Create = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtFlowerBouquetID
            // 
            txtFlowerBouquetID.Location = new Point(119, 52);
            txtFlowerBouquetID.Name = "txtFlowerBouquetID";
            txtFlowerBouquetID.Size = new Size(265, 23);
            txtFlowerBouquetID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 52);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "FlowerBouquetID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 100);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 55);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 3;
            label3.Text = "FlowerBouquetName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 100);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 147);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 5;
            label5.Text = "Supplier";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(119, 97);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(265, 23);
            txtCategory.TabIndex = 6;
            // 
            // txtFlowerBouquetName
            // 
            txtFlowerBouquetName.Location = new Point(536, 52);
            txtFlowerBouquetName.Name = "txtFlowerBouquetName";
            txtFlowerBouquetName.Size = new Size(252, 23);
            txtFlowerBouquetName.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(536, 97);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(252, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(119, 144);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(265, 23);
            txtSupplier.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 24);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 10;
            label6.Text = "ProductManagement";
            label6.Click += label6_Click;
            // 
            // Create
            // 
            Create.Location = new Point(119, 415);
            Create.Name = "Create";
            Create.Size = new Size(75, 23);
            Create.TabIndex = 11;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(267, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(418, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(568, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 14;
            button4.Text = "Detail";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(774, 204);
            dataGridView1.TabIndex = 15;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Create);
            Controls.Add(label6);
            Controls.Add(txtSupplier);
            Controls.Add(txtPrice);
            Controls.Add(txtFlowerBouquetName);
            Controls.Add(txtCategory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFlowerBouquetID);
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFlowerBouquetID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCategory;
        private TextBox txtFlowerBouquetName;
        private TextBox txtPrice;
        private TextBox txtSupplier;
        private Label label6;
        private Button Create;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}