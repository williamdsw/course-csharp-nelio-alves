
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

                //products.ForEach(UpdatePrice);

                /*products.ForEach((product) =>
                {
                    product.Price += (product.Price * 0.1);
                });*/

                /*Action<Product> action = UpdatePrice;
                products.ForEach(action);*/

                products.ForEach(product => product.Price += product.Price * 0.1);

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

        // To match an Action needs to be void and have one up to 16 parameters
        private static void UpdatePrice(Product product)
        {
            product.Price += (product.Price * 0.1);
        }
    }
}
