using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        Order? GetOrder(int id);
        ICollection<Order> GetOrders(int id);
        ICollection<Order> SearchAndFilterOrderByID(int id);
        bool AddNewOrder(Order order);
        bool DeleteOrder(int id);
        bool UpdateOrder(Order order);

    }
}
