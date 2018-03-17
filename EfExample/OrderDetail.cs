using System;
using System.Collections.Generic;
using System.Text;

namespace EfExample
{
   public class OrderDetail
    {

        public double UnitPrice { get; set; }
        public int OrderId{ get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
    }
}
