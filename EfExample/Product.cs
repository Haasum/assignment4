using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class Product
    {
        public OrderDetail orderDetail { get; set; }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public double UnitPrice { get; set; }
    }
}
