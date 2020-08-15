
using Entities;
using Structs;
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
                HashSet<string> set = new HashSet<string>();
                set.Add("Maria");
                set.Add("Alex");

                Console.WriteLine(set.Contains("Maria"));

                HashSet<Product> products = new HashSet<Product>();
                products.Add(new Product("TV", 900.0));
                products.Add(new Product("Notebook", 1200.0));

                HashSet<Point> points = new HashSet<Point>();
                points.Add(new Point(3, 4));
                points.Add(new Point(5, 10));

                Product product = new Product("Notebook", 1200.0);

                // Primary compare by reference
                // Product class need to override GetHashCode() and Equals() to compare by values
                Console.WriteLine(products.Contains(product));

                // Compares by value
                Point point = new Point(5, 10);
                Console.WriteLine(points.Contains(point));
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }

    }
}
