using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            int winningPoints = 0;
            int winningPlay = 0;

            for (int i = 1; i <= n; i++)
            {
                string position = Console.ReadLine();

                if (position == "W")
                {
                    points += 2000;
                    winningPoints += 2000;
                    winningPlay++;
                }
                else if (position == "F")
                {
                    points += 1200;
                    winningPoints += 1200;
                }
                else
                {
                    points += 720;
                    winningPoints += 720;
                }
            }

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {winningPoints / n}");
            Console.WriteLine($"{100.0 / n * winningPlay:F2}%");
        }
    }
}
