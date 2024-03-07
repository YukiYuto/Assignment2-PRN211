namespace SaleManagementWinApp
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you wanna close it?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
