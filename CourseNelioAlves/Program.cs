
using Entities;
using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Enter rental data");
                Console.Write("Car Model:" );
                string model = Console.ReadLine();
                Console.Write("Pickup (dd/MM/yyyy hh:mm): " );
                DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
                Console.Write("Return (dd/MM/yyyy hh:mm): " );
                DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

                Vehicle vehicle = new Vehicle(model);
                CarRental carRental = new CarRental(start, finish, vehicle);
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
