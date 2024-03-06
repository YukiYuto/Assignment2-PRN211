using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MemberDAO
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> list = new List<Customer>();
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    list = context.Customers.ToList();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public static bool Login(Customer customer)
        {   
            var context = new FUFlowerBouquetManagementV4Context();
            if (context.Customers.FirstOrDefault(customer) != null)
            {
                return true;
            }
            
            return false;
        }



    }
}
