
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

                // Aggregations

                double result10 = products.Max(products => products.Price);
                Console.WriteLine($"Max Price: " + result10);

                double result11 = products.Min(products => products.Price);
                Console.WriteLine($"Min Price: " + result11);

                double result12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
                Console.WriteLine($"Category 1 Sum Prices: " + result12);

                double result13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
                Console.WriteLine($"Category 1 Average Price: " + result13);

                double result14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine($"Category 5 Average Price: " + result14);

                double result15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
                Console.WriteLine($"Category 1 Aggregate Sum: " + result15);

                double result16 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
                Console.WriteLine($"Category 5 Aggregate Sum: " + result16);

                Console.WriteLine();
                var result17 = products.GroupBy(p => p.Category);

                // Key - Pair
                foreach(IGrouping<Category, Product> group in result17)
                {
                    Console.WriteLine($"Category {group.Key.Name} :");
                    foreach(Product p in group)
                    {
                        Console.WriteLine(p);
                    }
                    Console.WriteLine('\n');
                }
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
