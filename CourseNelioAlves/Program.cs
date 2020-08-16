
using LastChapter.Entities;
using System;
using System.Collections.Generic;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                List<Product> products = new List<Product>();

                products.Add(new Product("TV", 900.00));
                products.Add(new Product("Mouse", 50.00));
                products.Add(new Product("Tablet", 350.50));
                products.Add(new Product("HD Case", 80.90));

                //products.RemoveAll((p) => p.Price >= 100.0);
                products.RemoveAll(ProductTest);

                foreach (Product product in products)
                {
                    Console.WriteLine(product);
                }
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }

        // Needs to return boolean and have a generic parameter
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
