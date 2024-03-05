using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        public static List<FlowerBouquet> GetProducts()
        {
            List<FlowerBouquet> list = new List<FlowerBouquet>();
            try
            {
                var context = new FUFlowerBouquetManagementV4Context();
                list = context.FlowerBouquets.Include(p => p.Category).ToList();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return list;
        }

        public static FlowerBouquet GetProduct(int id) => GetProducts().FirstOrDefault(p => p.FlowerBouquetId == id);
        public static void UpdateProduct(FlowerBouquet product)
        {
                var context = new FUFlowerBouquetManagementV4Context();
                context.Update(product);
                context.SaveChanges();
        }

        public static void SaveProduct(FlowerBouquet product)
        {
            if(product == null)
            {
                return;
            }

            var context = new FUFlowerBouquetManagementV4Context();
            // check if duplicate
            if (context.FlowerBouquets.FirstOrDefault(product) != null)
            {
                return;
            }

            context.Add(product);
            context.SaveChanges();
            
        }

        public static void DeleteProduct(FlowerBouquet product)
        {
            if (product == null)
            {
                return;
            }

            var context = new FUFlowerBouquetManagementV4Context();
            context.Remove(product);
            context.SaveChanges();

        }

        public static List<Category> GetCategories()
        {
            List<Category> list = new List<Category>();
            try
            {
                var context = new FUFlowerBouquetManagementV4Context();
                list = context.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return list;

        }








    }
}
