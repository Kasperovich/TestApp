using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Data.Interfaces;
using TestApp.Data.Models;

namespace TestApp.Data.Repository
{
    public class CustomerRepository : ICustomers
    {
        private readonly AppDBContent appDBContent;

        public CustomerRepository (AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Customer> GetAllCustomer => appDBContent.Customer.ToList();
    }
}
