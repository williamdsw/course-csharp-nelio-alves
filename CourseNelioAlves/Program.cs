using System;
using System.Dynamic;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ');

            Console.WriteLine("\nInput: ");
            Console.WriteLine(phrase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            
            foreach (string word in words)
            {
                Console.WriteLine($"word: {word}");
            }
        }
    }
}
