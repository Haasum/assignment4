using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfExample
{
    public class NorthwindContext : DbContext
    {   
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(
                "server=localhost;database=northwind;uid=root;pwd=puggle;SslMode=none");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            //modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnName("categoryid");
            modelBuilder.Entity<Category>().Property(x => x.Name).HasColumnName("categoryname");

            modelBuilder.Entity<Product>().Property(x => x.ProductID).HasColumnName("productid");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("productname");
            modelBuilder.Entity<Product>().Property(x => x.UnitPrice).HasColumnName("unitprice");

            modelBuilder.Entity<OrderDetail>().Property(x => x.OrderID).HasColumnName("orderid");
            modelBuilder.Entity<OrderDetail>().Property(x => x.UnitPrice).HasColumnName("unitprice");
            modelBuilder.Entity<OrderDetail>().Property(x => x.Quantity).HasColumnName("quantity");
            modelBuilder.Entity<OrderDetail>().Property(x => x.Discount).HasColumnName("discount");

            modelBuilder.Entity<Order>().Property(x => x.CustomerId).HasColumnName("customerid");
            modelBuilder.Entity<Order>().Property(x => x.EmployeeId).HasColumnName("employeeid");
            modelBuilder.Entity<Order>().Property(x => x.OrderDate).HasColumnName("orderdate");
            modelBuilder.Entity<Order>().Property(x => x.RequiredDate).HasColumnName("requireddate");
            //      modelBuilder.Entity<Order>().Property(x => x.ShippedDate).HasColumnName("shippeddate");
            modelBuilder.Entity<Order>().Property(x => x.Freight).HasColumnName("freight");
            modelBuilder.Entity<Order>().Property(x => x.ShipName).HasColumnName("shipname");
            modelBuilder.Entity<Order>().Property(x => x.ShipAdress).HasColumnName("shipaddress");
            modelBuilder.Entity<Order>().Property(x => x.ShipCity).HasColumnName("shipcity");
            modelBuilder.Entity<Order>().Property(x => x.ShipPostalCode).HasColumnName("shippostalcode");
            modelBuilder.Entity<Order>().Property(x => x.ShipCountry).HasColumnName("shipcountry");

            modelBuilder.Entity<Order>().HasMany(x => x.OrderDetail).WithOne(x => x.Order).IsRequired();







        }
    }
}
