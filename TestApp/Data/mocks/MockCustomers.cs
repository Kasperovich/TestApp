using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Data.Interfaces;
using TestApp.Data.Models;

namespace TestApp.Data.mocks
{
    public class MockCustomers : ICustomers
    {
        public IEnumerable<Customer> GetAllCustomer
        {
            get
            {
                return new List<Customer>
                {
                    new Customer { Name = "Гольдюк Вячеслав Викторович", Addres = "г.Минск ул. Красноормейская 11-23"},
                    new Customer { Name = "Малащенко Никита Сергеевич", Addres = "г.Жлобин ул. Вокзальная 23-32"}
                };
            }
        }
    }
}
