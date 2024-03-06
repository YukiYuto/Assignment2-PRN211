using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public bool AddNewOrder(Order order) => OrderDAO.Instance.AddNewOrder(order);
       

        public bool DeleteOrder(int id) => OrderDAO.Instance.DeleteOrder(id);
       

        public Order? GetOrder(int id) => OrderDAO.Instance.GetOrder(id);
       

        public ICollection<Order> GetOrders() => OrderDAO.Instance.GetOrdersById(id);
        

        public ICollection<Order> SearchAndFilterOrderByID(int id) => OrderDAO.Instance.SearchAndFilterOrderByID(id);
       

        public bool UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
       
    }
}
