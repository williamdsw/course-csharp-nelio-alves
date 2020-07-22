using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            char genre = 'F';
            int age = 32;
            double balance = 10.35784;
            string name = "Maria";
            String phrase = $"{name} has {age} years with {genre} genre and have $ {balance:F2}.";

            Console.WriteLine("Good Morning!");
            Console.Write("Good Afternoon!");
            Console.WriteLine("Good Night!");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(genre);
            Console.WriteLine(balance);
            Console.WriteLine(balance.ToString ("F2"));
            Console.WriteLine(balance.ToString ("F4"));
            Console.WriteLine(balance.ToString ("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(name + " has " + age + " years with " + genre + " genre and have $ " + balance.ToString("F2"));
            Console.WriteLine("{0} has {1} years with {2} genre and have $ {3:F2}.", name, age, genre, balance);
            Console.WriteLine(phrase);
        }
    }
}
