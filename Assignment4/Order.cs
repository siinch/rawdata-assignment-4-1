using System;
using System.Collections.Generic;

namespace Assignment4
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Required { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }
    }
}