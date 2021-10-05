using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            var date = DateTime.Today.ToShortDateString();
            var userName = Console.ReadLine();
            var message = $"Welcome back {userName} today is the {date}";
            Console.WriteLine(message);

            string path = @"C:\Users\will2\source\repos\Scores\Scores\studentscores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double totalScore = 0.0;

            Console.WriteLine("\nStudent Score: \n");
            foreach (string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                totalScore += score;
            }

            double avgScore = totalScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " students score. \tAverage Score: " + avgScore);

            Console.WriteLine("\n\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}


