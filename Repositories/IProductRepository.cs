using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepository
    {
        FlowerBouquet? GetFlowerBouquet(int id);
        ICollection<FlowerBouquet>GetFlowerBouquets(int id);
        ICollection<FlowerBouquet> SearchAndFilterFlowerBouquetByID(int id);
        bool AddNewFlowerBouquet(FlowerBouquet flowerBouquet);
        bool DeleteFlowerBouquet(int id);
        bool UpdateFlowerBouquet(FlowerBouquet flowerBouquet);
    }
}
