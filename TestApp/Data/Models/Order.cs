using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }
        public int Summ { get; set; }
        public string Desc { get; set; }
        public Customer Customer { get; set; }
    }
}
