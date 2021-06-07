using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Data.Models;

namespace TestApp.Data.Interfaces
{
    public interface IOrders
    {
        IEnumerable<Order> GetAllOrders { get; }
        Order GetOrderById(int orderId);
    }
}
