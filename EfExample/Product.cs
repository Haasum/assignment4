﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EfExample
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public double UnitPrice { get; set; }
    }
}
