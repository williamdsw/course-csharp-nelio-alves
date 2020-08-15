
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
                SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

                PrintCollection(a);
                PrintCollection(b);

                // Union
                SortedSet<int> c = new SortedSet<int>(a);
                c.UnionWith(b);
                PrintCollection(c);

                // Intersection
                SortedSet<int> d = new SortedSet<int>(a);
                d.IntersectWith(b);
                PrintCollection(d);

                // Difference
                SortedSet<int> e = new SortedSet<int>(a);
                e.ExceptWith(b);
                PrintCollection(e);
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }

        private static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T item in collection)
            {
                Console.Write($" {item} ");
            }

            Console.WriteLine();
        }
    }
}
