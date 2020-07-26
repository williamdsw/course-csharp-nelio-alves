using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "   I see the bad moon on rising. I see trouble on the way.   ";
            string upper = phrase.ToUpper();
            string lower = phrase.ToLower();
            int length = phrase.Length;
            string trim = phrase.Trim();
            int firstIndexOf = phrase.IndexOf("see");
            int lastIndexOf = phrase.LastIndexOf("see");
            string substring = phrase.Substring(10);
            string otherSubstring = phrase.Substring(3, 10);
            string replace = phrase.Replace("see", "saw");
            bool nullOrEmpty = string.IsNullOrEmpty(phrase);
            bool nullOrWhiteSpace = string.IsNullOrWhiteSpace(phrase);

            Console.WriteLine(phrase);
            Console.WriteLine(upper);
            Console.WriteLine(lower);
            Console.WriteLine($"Length: {length}");
            Console.WriteLine(trim);
            Console.WriteLine($"IndexOf(see): {firstIndexOf}");
            Console.WriteLine($"LastIndexOf(see): {lastIndexOf}");
            Console.WriteLine($"Substring(3): {substring}");
            Console.WriteLine($"Substring(3, 10): {otherSubstring}");
            Console.WriteLine(replace);
            Console.WriteLine($"IsNullOrEmpty: {nullOrEmpty}");
            Console.WriteLine($"IsNullOrWhitespace: {nullOrWhiteSpace}");
            Console.WriteLine("------------------------------------------");

            foreach (char c in phrase.Trim(' '))
            {
                Console.Write($" {c} ");
            }
        }
    }
}
