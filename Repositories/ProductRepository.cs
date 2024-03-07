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
        public bool AddNewFlowerBouquet(FlowerBouquet flowerBouquet) => ProductDAO.Instance.AddNewFlowerBouquet(flowerBouquet);
        

        public bool DeleteFlowerBouquet(int id) => ProductDAO.Instance.DeleteFlowerBouquet(id);
      

        public FlowerBouquet? GetFlowerBouquet(int id) => ProductDAO.Instance.GetFlowerBouquet(id);
        

        public ICollection<FlowerBouquet> GetFlowerBouquets(int id) => ProductDAO.Instance.GetAllFlowerBouquets(id);
       

        public ICollection<FlowerBouquet> SearchAndFilterFlowerBouquetByID(int id) => ProductDAO.Instance.SearchAndFilterFlowerBouquetByID(id);
        

        public bool UpdateFlowerBouquet(FlowerBouquet flowerBouquet) => ProductDAO.Instance.UpdateFlowerBouquet()
        
    }
}
