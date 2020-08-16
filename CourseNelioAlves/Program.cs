
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
                products.Add(new Product("Notebook", 1200.00));
                products.Add(new Product("Tablet", 450.00));

                // Only works if class model implements IComparable
                //products.Sort();
                //products.Sort(CompareProducts);

                //Comparison<Product> comparison = CompareProducts;
                //products.Sort(comparison);

                //Comparison<Product> comparison = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
                //products.Sort(comparison);

                products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

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

        private static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
