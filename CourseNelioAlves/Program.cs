
using Entities;
using Services;
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
                Console.Write("Car Model: ");
                string model = Console.ReadLine();
                Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
                DateTime start = DateTime.Parse(Console.ReadLine()); // ParseExact(...)
                Console.Write("Return (dd/MM/yyyy hh:mm): ");
                DateTime finish = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter price per hour: ");
                double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter price per day: ");
                double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Vehicle vehicle = new Vehicle(model);
                CarRental carRental = new CarRental(start, finish, vehicle);
                RentalService rentalService = new RentalService(pricePerHour, pricePerDay);
                rentalService.ProcessInvoice(carRental);

                Console.WriteLine("INVOICE: ");
                Console.WriteLine(carRental.Invoice);
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
