using System;
using System.Collections.Generic;
using System.Linq;
using TestApp.Data.Interfaces;
using TestApp.Data.Models;

namespace TestApp.Data.Repository
{
    public class OrderRepository : IOrders
    {
        private readonly AppDBContent appDBContent;

        public OrderRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Order> GetAllOrders => appDBContent.Order.ToList();
        public Order GetOrderById(int orderId)
        {
            return appDBContent.Order.FirstOrDefault(o => o.ID == orderId);
        }
    }
}
