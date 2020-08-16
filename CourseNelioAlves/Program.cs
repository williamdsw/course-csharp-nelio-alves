
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

                var result1 = from p in products
                              where p.Category.Tier == 1 && p.Price < 900.0
                              select p;
                Print("TIER 1 AND PRICE < 900.0:", result1);

                List<string> result2 = (from p in products
                               where p.Category.Name == "Tools"
                               select p.Name).ToList();
                Print("NAMES OF PRODUCTS FROM TOOLS:", result2);

                var result3 = from p in products
                              where p.Name[0] == 'C'
                              select new { p.Name, p.Price, CategoryName = p.Category.Name };
                Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", result3);

                List<Product> result4 = (from p in products
                                         where p.Category.Tier == 1
                                         orderby p.Price, p.Name
                                         select p).ToList();
                Print("TIER 1 ORDER BY PRICE THEN BY NAME", result4);

                List<Product> result5 = (from p in result4 select p).Skip(2).Take(4).ToList();
                Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", result5);

                var result6 = (from p in products group p by p.Category);
                foreach (IGrouping<Category, Product> group in result6)
                {
                    Console.WriteLine($"\nCategory {group.Key.Name}");
                    foreach (Product p in group)
                    {
                        Console.WriteLine(p);
                    }
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
