using System;

namespace FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumWin = 0;
            int sumLost = 0;
            int sumEqual = 0;

            for (int i = 0; i < 3; i++)
            {
                string result = Console.ReadLine();

                if (result[0] == result[2])
                {
                    sumEqual++;
                }
                else if (result[0] > result[2])
                {
                    sumWin++;
                }
                else
                {
                    sumLost++;
                }
            }

            Console.WriteLine($"Team won {sumWin} games.");
            Console.WriteLine($"Team lost {sumLost} games.");
            Console.WriteLine($"Drawn games: {sumEqual}");
        }
    }
}
