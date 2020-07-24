using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;
            double? y = 10;
            double z = x ?? 5; // checks if x is null or sets default value

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x is null");
            }
            
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y is null");
            }

            Console.WriteLine(z);
        }
    }
}
