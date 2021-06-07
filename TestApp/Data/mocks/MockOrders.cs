using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Data.Interfaces;
using TestApp.Data.Models;

namespace TestApp.Data.mocks
{
    public class MockOrders : IOrders
    {
        private readonly ICustomers _customers = new MockCustomers();
        public IEnumerable<Order> GetAllOrders
        {
            get
            {
                return new List<Order>
                {
                    new Order {Count = 1, Desc = "Мышь компьюттерная", Summ = 14, Date = new DateTime(2021, 5, 4), Customer =  _customers.GetAllCustomer.First()},
                    new Order {Count = 1, Desc = "Стол компьютерный", Summ = 14, Date = new DateTime(2021, 5, 4), Customer =  _customers.GetAllCustomer.First() },
                    new Order {Count = 1, Desc = "Монитор ", Summ = 14, Date = new DateTime(2021, 5, 4) , Customer =  _customers.GetAllCustomer.First()},
                    new Order {Count = 1, Desc = "Системный блок", Summ = 14, Date = new DateTime(2021, 5, 4) , Customer =  _customers.GetAllCustomer.Last()},
                    new Order {Count = 1, Desc = "Лампа настольная", Summ = 14, Date = new DateTime(2021, 5, 4), Customer =  _customers.GetAllCustomer.Last()},
                    new Order {Count = 1, Desc = "Коврик для мыши", Summ = 14, Date = new DateTime(2021, 5, 4), Customer =  _customers.GetAllCustomer.Last() }
                };
            }
        }

        public Order GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
