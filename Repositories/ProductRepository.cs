using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void AddNewFlowerBouquet(FlowerBouquet flowerBouquet) => ProductDAO.SaveProduct(flowerBouquet);


        public void DeleteFlowerBouquet(int id) => ProductDAO.DeleteProduct(id);
      

        public FlowerBouquet? GetFlowerBouquet(int id) => ProductDAO.GetProduct(id);


        public List<FlowerBouquet> GetFlowerBouquets() => ProductDAO.GetProducts();
       

        public void UpdateFlowerBouquet(FlowerBouquet flowerBouquet) => ProductDAO.UpdateProduct(flowerBouquet);

       
    }
}
