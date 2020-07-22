using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasCompleted = false;
            char genre = 'F';
            char character = '\u0041';
            float myFloat = 4.5f;
            double myDouble = 4.5;
            string name = "Maria Green";
            object myObject = "Alex Brown";
            object otherObject = 4.5;
            decimal max = decimal.MaxValue;

            Console.WriteLine($"bool: {hasCompleted}");
            Console.WriteLine($"char: {genre}");
            Console.WriteLine($"char: {character}");
            Console.WriteLine($"float: {myFloat}");
            Console.WriteLine($"double: {myDouble}");
            Console.WriteLine($"string: {name}");
            Console.WriteLine($"object: {myObject}");
            Console.WriteLine($"object: {otherObject}");
            Console.WriteLine($"decimal max: {max}");
        }
    }
}
