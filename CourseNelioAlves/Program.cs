
using LastChapter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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

                products.ForEach(product => Console.WriteLine(product));

                Console.WriteLine();
                List<string> upper = products.Select(NameToUpper).ToList();
                upper.ForEach(item => Console.WriteLine(item));

                Console.WriteLine();
                List<string> lower = products.Select(product => product.Name.ToLower()).ToList();
                lower.ForEach(item => Console.WriteLine(item));
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }

        private static string NameToUpper(Product product)
        {
            return product.Name.ToUpper();
        }

    }
}
