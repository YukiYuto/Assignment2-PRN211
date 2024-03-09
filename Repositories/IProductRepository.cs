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
        List<FlowerBouquet>GetFlowerBouquets();

        void AddNewFlowerBouquet(FlowerBouquet flowerBouquet);
        void DeleteFlowerBouquet(int id);
        void UpdateFlowerBouquet(FlowerBouquet flowerBouquet);
    }
}
