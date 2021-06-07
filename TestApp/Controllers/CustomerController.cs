using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Data.Interfaces;

namespace TestApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomers allCustomers;
        private readonly ICustomers allOrders;

        public CustomerController(ICustomers iCustomers, IOrders iOrders)
        {
            allCustomers = iCustomers;
            allOrders = iOrders;
        }
    }
}
