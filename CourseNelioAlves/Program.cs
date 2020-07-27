using CourseNelioAlves.Entities;
using CourseNelioAlves.Enums;
using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1, Moment = DateTime.Now, Status = Enums.OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string currentStatus = OrderStatus.Processing.ToString();
            OrderStatus otherStatus = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine($"Current Status: {currentStatus}");
            Console.WriteLine($"Other Status: {otherStatus}");
        }
    }
}
