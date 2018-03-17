using System;
using System.Collections.Generic;
using System.Text;

namespace EfExample
{
    class OrderDetails
    {

        public double UnitPrice { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
    }
}
