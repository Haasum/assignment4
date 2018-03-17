﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EfExample
{
    public class Order
    {
        public int OrderId { get; set; }
        public char CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public double Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAdress { get; set; }
        public string ShipCity { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
    }
}
