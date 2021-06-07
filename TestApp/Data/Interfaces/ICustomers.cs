using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Data.Models;

namespace TestApp.Data.Interfaces
{
    public interface ICustomers
    {
         IEnumerable<Customer> GetAllCustomer { get; }
    }
}
