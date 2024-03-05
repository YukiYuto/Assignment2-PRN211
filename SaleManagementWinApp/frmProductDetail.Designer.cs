namespace SaleManagementWinApp
{
    partial class frmProductDetail
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
            txtDescription = new TextBox();
            txtUnitslnStock = new TextBox();
            txtFlowerBouquetStatus = new TextBox();
            txtMorphology = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 86);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 152);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "UnitslnStock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 215);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 2;
            label3.Text = "FlowerBouquetStatus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 268);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Morphology";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(187, 19);
            label5.Name = "label5";
            label5.Size = new Size(158, 32);
            label5.TabIndex = 4;
            label5.Text = "ProductDetail";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(276, 83);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 5;
            // 
            // txtUnitslnStock
            // 
            txtUnitslnStock.Location = new Point(276, 144);
            txtUnitslnStock.Name = "txtUnitslnStock";
            txtUnitslnStock.Size = new Size(100, 23);
            txtUnitslnStock.TabIndex = 6;
            // 
            // txtFlowerBouquetStatus
            // 
            txtFlowerBouquetStatus.Location = new Point(276, 212);
            txtFlowerBouquetStatus.Name = "txtFlowerBouquetStatus";
            txtFlowerBouquetStatus.Size = new Size(100, 23);
            txtFlowerBouquetStatus.TabIndex = 7;
            // 
            // txtMorphology
            // 
            txtMorphology.Location = new Point(276, 268);
            txtMorphology.Name = "txtMorphology";
            txtMorphology.Size = new Size(100, 23);
            txtMorphology.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(223, 318);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 9;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 401);
            Controls.Add(button1);
            Controls.Add(txtMorphology);
            Controls.Add(txtFlowerBouquetStatus);
            Controls.Add(txtUnitslnStock);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductDetail";
            Text = "frmProductDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDescription;
        private TextBox txtUnitslnStock;
        private TextBox txtFlowerBouquetStatus;
        private TextBox txtMorphology;
        private Button button1;
    }
}