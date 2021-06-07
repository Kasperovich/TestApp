﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public List<Order> Orders { get; set; }
    }
}
