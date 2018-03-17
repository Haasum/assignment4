using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EfExample
{
    class Program
    {
        private static int TakeInput()
        {
            Console.WriteLine("Enter the ID value of the product you want");
            int UserInput = Convert.ToInt32(Console.ReadLine());
            return UserInput;


        }
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {

                // PrintCategory(1);
                // DeleteCatagory(15);
                GetProductId(3);
                foreach (var product in db.Products.Include(x => x.Category))
                {
                    // Different ways to do the same - syntatic sugar
                    //Console.WriteLine(product.Name + " " + product.Category.Name);
                    //Console.WriteLine("{0} {1}", product.Name, product.Category.Name);
                    // Console.WriteLine($"{product.Name} {product.Category.Name}");

                }
            }
            //UpdateCategoryName(5, "Updated");
            //CreateCategory(new Category { Name = "Test", Description = "Test" });
            // SelectCategories();
        }


        static void UpdateCategoryName(int id, string name)
        {
            using (var db = new NorthwindContext())
            {
                var category = db.Categories.FirstOrDefault(x => x.Id == id);
                if (category == null) return;
                category.Name = name;
                db.SaveChanges();
            }
        }

        static void CreateCategory(Category category)
        {
            using (var db = new NorthwindContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }

        private static void SelectCategories()
        {
            using (var db = new NorthwindContext())
            {
                foreach (var category in db.Categories)
                {
                    Console.WriteLine(category.Id + " " + category.Name + " " + category.Description);
                }
            }
        }


        private static void PrintCategory(int a)
        {

            using (var db = new NorthwindContext())
                foreach (var category in db.Categories)
                {
                    if (a == category.Id)
                    {
                        Console.WriteLine(category.Id);
                    }
                    else
                    {
                        return;
                    }


                }

        }
        private static bool DeleteCatagory(int id)
        {

            using (var db = new NorthwindContext())
            {
                var category = db.Categories.FirstOrDefault(x => x.Id == id);
                if (category == null) return false;
                else
                {
                    db.Remove(category);
                    db.SaveChanges();
                    return true;
                }
            }
        }
        private static void GetProductId(int id)
        {
            using (var db = new NorthwindContext())
            {

                var product = db.Products.FirstOrDefault(x => x.Id == id);
                Console.WriteLine(product.Name + ", " + product.UnitPrice + ", " + product.Category.Name);


            }
        }

    }

}
