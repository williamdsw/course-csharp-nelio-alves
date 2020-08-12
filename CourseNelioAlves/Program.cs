
using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                string a = "Maria";
                string b = "Alex";
                string c = "Maria";

                Console.WriteLine($"a = {a}, b = {b}, c = {c}");
                Console.WriteLine($"a equals b ? {a.Equals(b)}");
                Console.WriteLine($"a equals c ? {a.Equals(c)}");
                Console.WriteLine($"a hash code ? {a.GetHashCode()}");
                Console.WriteLine($"b hash code ? {b.GetHashCode()}");
                Console.WriteLine($"c hash code ? {c.GetHashCode()}");

                Client maria = new Client("Maria", "maria@gmail.com");
                Client alex = new Client("Alex", "alex@gmail.com");

                Console.WriteLine(maria.Equals(alex));
                Console.WriteLine(maria == alex); // Compare reference pointers
                Console.WriteLine(maria.GetHashCode());
                Console.WriteLine(alex.GetHashCode());
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
