using BusinessObjects.Models;
using DataAccessObjects;
using Repositories;
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
    public partial class frmProduct : Form
    {


        IProductRepository repository = new ProductRepository();

        public frmProduct()
        {
          
            InitializeComponent();
           

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }



        

        private void Create_Click(object sender, EventArgs e)
        {
            MessageBox.Show("create");
            LoadProduct();
        }



        public void LoadProduct()
        {

            try
            {
                var list = repository.GetFlowerBouquets().Select(c => new
                {
                    ProductID = c.FlowerBouquetId,
                    Category = ProductDAO.GetCateName(c.CategoryId),
                    Name = c.FlowerBouquetName,
                    Description = c.Description,
                    Price = c.UnitPrice,
                    Stock = c.UnitsInStock,
                    SupplierName = ProductDAO.GetSupplierName(c.SupplierId)

                }).ToList();

              
             
              





                BindingSource source = new BindingSource();
                source.DataSource = list;
                dataGridView1.DataSource = source.DataSource;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

     

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
