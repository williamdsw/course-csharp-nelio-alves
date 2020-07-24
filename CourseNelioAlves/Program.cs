using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table");
            Console.Write("Input quantity of numbers: ");
            int quantity = int.Parse(Console.ReadLine()); 
            Console.Write("Input the number of ocorrences: ");
            int ocorrences = int.Parse(Console.ReadLine());

            int[,] values = new int[quantity, ocorrences];
            for (int row = 0; row < quantity; row++)
            {
                for (int col = 0; col < ocorrences; col++)
                {
                    values[row, col] = row * col;
                }
            }

            // Header
            Console.Write("\t");
            for (int i = 0; i < ocorrences; i++)
            {
                Console.Write($" { i } ");
            }

            Console.WriteLine('\n');
            for (int row = 0; row < values.GetLength(0); row++)
            {
                // Column count
                Console.Write($" {row}: \t");

                // Data
                for (int col = 0; col < values.GetLength(1); col++)
                {
                    Console.Write($" {values[row, col]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nRank: {values.Rank}");
            Console.WriteLine($"Length: {values.Length}");
            Console.WriteLine($"Length of 0: {values.GetLength(0)}");
            Console.WriteLine($"Length of 1: {values.GetLength(1)}");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < quantity; i++)
            {
                Console.Write($" {values[i, i]} ");
            }

        }
    }
}
