using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EfExample
{
   public class OrderDetail
    {

        public double UnitPrice { get; set; }
        [Key]
        public int OrderID{ get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public Order Order { get; set; }
    }
}
