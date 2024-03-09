using BusinessObjects.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmLogin : Form
    {
        private readonly IConfiguration _configuration;
        public frmLogin()
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string adminUsername = _configuration["Authentication:Username"];
                string adminPassword = _configuration["Authentication:Password"];

                string name = txtEmail.Text;
                string pass = txtPassword.Text;


              
             

                // Kiểm tra thông tin đăng nhập với admin từ appsettings.json
                if (string.Equals(adminUsername, name) && string.Equals(pass, adminPassword))
                {
                    // Nếu thông tin đăng nhập đúng với admin, mở form Order và ẩn form hiện tại
                    frmProduct product = new frmProduct();
                    product.ShowDialog();
                    this.Hide();
                }
                else
                {
                  /* var context = new FUFlowerBouquetManagementV4Context();
                    Customer customer = context.Customers.FirstOrDefault(p => p.Email.Equals(name) && p.Password.Equals(pass));
                    if (customer != null)
                    {

                    }
                    */
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi khi thao tác với cơ sở dữ liệu hoặc đọc cấu hình
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
