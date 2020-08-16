
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
                Category catTools = new Category(1, "Tools", 2);
                Category catComputers = new Category(2, "Computers", 1);
                Category catElectronics = new Category(3, "Electronics", 1);

                List<Product> products = new List<Product>();

                products.Add(new Product(1, "Computer", 1100.0, catComputers));
                products.Add(new Product(2, "Hammer", 90.0, catTools));
                products.Add(new Product(3, "TV", 1700.0, catElectronics));
                products.Add(new Product(4, "Notebook", 1300.0, catComputers));
                products.Add(new Product(5, "Saw", 80.0, catTools));
                products.Add(new Product(6, "Tablet", 700.0, catComputers));
                products.Add(new Product(7, "Camera", 700.0, catElectronics));
                products.Add(new Product(8, "Printer", 350.0, catElectronics));
                products.Add(new Product(9, "MacBook", 1800.0, catComputers));
                products.Add(new Product(10, "Sound Bar", 700.0, catElectronics));
                products.Add(new Product(11, "Level", 70.0, catTools));

                Print("ALL PRODUCTS:", products);
                
                List<Product> result1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0).ToList();
                Print("TIER 1 AND PRICE < 900:", result1);

                List<string> result2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name).ToList();
                Print("NAMES OF PRODUCTS FROM TOOLS:", result2);

                var result3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
                Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", result3);

                List<Product> result4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name).ToList();
                Print("TIER 1 ORDER BY PRICE THEN BY NAME:", result4);

                List<Product> result5 = result4.Skip(2).Take(4).ToList();
                Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4:", result5);

                Product result6 = products.First();
                Console.WriteLine($"First test: " + result6);

                Product result7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
                Console.WriteLine($"First or default test: " + result7);

                Product result8 = products.Where(p => p.Id == 3).SingleOrDefault();
                Console.WriteLine($"single or default test1: " + result8);

                Product result9 = products.Where(p => p.Id == 30).SingleOrDefault();
                Console.WriteLine($"single or default test2: " + result9);
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }

        private static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
