using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                string adminUsername = _configuration["Authentication:AdminCredentials:Username"];
                string adminPassword = _configuration["Authentication:AdminCredentials:Password"];

                // Kiểm tra thông tin đăng nhập với admin từ appsettings.json
                if (string.Equals(txtEmail.Text, adminUsername) && string.Equals(txtPassword.Text, adminPassword))
                {
                    // Nếu thông tin đăng nhập đúng với admin, mở form Order và ẩn form hiện tại
                    frmOrder order = new frmOrder();
                    order.Show();
                    this.Hide();
                }
                else
                {
                    // Nếu không phải là admin, kiểm tra trong cơ sở dữ liệu
                    string connectionString = _configuration.GetConnectionString("DBDefault");
                    string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", txtEmail.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string role = reader["Role"].ToString();

                            if (role == "Admin")
                            {
                                // Nếu là admin, mở form Order và ẩn form hiện tại
                                frmOrder order = new frmOrder();
                                order.Show();
                                this.Hide();
                            }
                            else if (role == "Customer")
                            {
                                // Nếu là khách hàng, thực hiện các thao tác khác tùy thuộc vào vai trò của khách hàng
                                // Ví dụ: mở form khác hoặc thực hiện các chức năng khác cho khách hàng
                            }
                        }
                        else
                        {
                            // Nếu không tìm thấy người dùng trong cơ sở dữ liệu, hiển thị thông báo lỗi
                            MessageBox.Show("User not found or incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
