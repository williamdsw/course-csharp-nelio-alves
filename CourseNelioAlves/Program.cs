
using CourseNelioAlves.LastChapter.Entities;
using LastChapter.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                List<OtherProduct> products = new List<OtherProduct>();

                Console.Write("Enter full file path: ");
                string path = Console.ReadLine();

                using (StreamReader reader = File.OpenText(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        string name = values[0];
                        double price = double.Parse(values[1], CultureInfo.InvariantCulture);

                        OtherProduct product = new OtherProduct(name, price);
                        products.Add(product);
                    }
                }

                Console.WriteLine("\nALL PRODUCTS");
                products.ForEach(p => Console.WriteLine(p));

                double average = products.Select(p => p.Price).DefaultIfEmpty(0.00).Average();
                Console.WriteLine($"\nAverage Price: {average.ToString("F2", CultureInfo.InvariantCulture)}");

                // List<string> names = products.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name).ToList();
                List<string> names = (from p in products
                                      where p.Price < average
                                      orderby p.Name descending
                                      select p.Name).ToList();
                names.ForEach(name => Console.WriteLine(name));
            }
			catch (IOException ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
