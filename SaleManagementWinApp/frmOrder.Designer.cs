namespace SaleManagementWinApp
{
    partial class frmOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCreate = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dgbListOrder = new DataGridView();
            button1 = new Button();
            txtSearch = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgbListOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 55);
            label1.Name = "label1";
            label1.Size = new Size(335, 50);
            label1.TabIndex = 0;
            label1.Text = "OrderManagement";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(138, 457);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 32);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoad.Location = new Point(552, 457);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 32);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(408, 457);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 32);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(273, 457);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 32);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgbListOrder
            // 
            dgbListOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbListOrder.Location = new Point(138, 186);
            dgbListOrder.Name = "dgbListOrder";
            dgbListOrder.RowTemplate.Height = 25;
            dgbListOrder.Size = new Size(628, 257);
            dgbListOrder.TabIndex = 16;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(138, 147);
            button1.Name = "button1";
            button1.Size = new Size(109, 28);
            button1.TabIndex = 17;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(273, 147);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(493, 23);
            txtSearch.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(684, 457);
            button2.Name = "button2";
            button2.Size = new Size(82, 32);
            button2.TabIndex = 19;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 548);
            Controls.Add(button2);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(dgbListOrder);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrder";
            ((System.ComponentModel.ISupportInitialize)dgbListOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCreate;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dgbListOrder;
        private Button button1;
        private TextBox txtSearch;
        private Button button2;
    }
}
