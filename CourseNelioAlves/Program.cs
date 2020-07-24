using System;
using System.Collections.Generic;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> teams = new List<string>();

            teams.Add("Real Madrid");
            teams.AddRange(new string[] { "Barcelona", "Manchester City", "Atalanta", "Manchester United" });
            teams.Insert(1, "Chelsea");

            foreach (string team in teams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine($"List count: {teams.Count}");

            string firstWithM = teams.Find(team => team.StartsWith("M"));
            int firstIndex = teams.FindIndex(team => team.StartsWith("M"));
            Console.WriteLine($"Find first with M: {firstWithM}");
            Console.WriteLine($"Find index first with M: {firstIndex}");

            string lastWithM = teams.FindLast(team => team.StartsWith("M"));
            int lastIndex = teams.FindLastIndex(team => team.StartsWith("M"));
            Console.WriteLine($"Find last with M: {lastWithM}");
            Console.WriteLine($"Find last index first with M: {lastIndex}");

            Console.WriteLine("---------------------------");
            List<string> endsWithAList = teams.FindAll(team => team.EndsWith("a"));
            foreach (var team in endsWithAList)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("---------------------------");
            endsWithAList.Remove("Chelsea");
            foreach (var team in endsWithAList)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("---------------------------");
            teams.RemoveAll(team => team.Contains(" "));
            foreach (string team in teams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("---------------------------");
            endsWithAList.RemoveAt(0);
            foreach (string team in endsWithAList)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("---------------------------");
            teams.RemoveRange(1, 2);
            foreach (string team in teams)
            {
                Console.WriteLine(team);
            }
        }
    }
}
