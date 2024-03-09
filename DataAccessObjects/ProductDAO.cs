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
                list = context.FlowerBouquets.ToList();
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

        public static void DeleteProduct(int id)
        {
            var context = new FUFlowerBouquetManagementV4Context();
            FlowerBouquet product = context.FlowerBouquets.SingleOrDefault(p => p.FlowerBouquetId.Equals(id));
            if (product != null)
            {
                context.Remove(product);
                context.SaveChanges();
                return;
            }
            else
            {
                throw new Exception("product null");
            }

            
         

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



        public static string GetCateName(int id)
        {
            var context = new FUFlowerBouquetManagementV4Context();

            return context.Categories.FirstOrDefault(c => c.CategoryId == id).CategoryName;
        }

        public static string GetSupplierName(int? id)
        {
            var context = new FUFlowerBouquetManagementV4Context();

            return context.Suppliers.FirstOrDefault(c => c.SupplierId == id).SupplierName.ToString();
        }








    }
}
