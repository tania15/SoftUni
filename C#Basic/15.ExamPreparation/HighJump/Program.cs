using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int minRange = height - 30;
            int countJumps = 0;

            while (minRange <= height)
            {
                int jump = int.Parse(Console.ReadLine());
                countJumps++;
                int count = 1;

                while (jump <= minRange)
                {
                    jump = int.Parse(Console.ReadLine());
                    countJumps++;
                    if (jump > minRange)
                    {
                        break;
                    }
                    count++;

                    if (count == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {minRange}cm after {countJumps} jumps.");
                        break;
                    }
                }

                if (count >= 3)
                {
                    break;
                }

                minRange += 5;
            }

            if (minRange > height)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {minRange - 5}cm after {countJumps} jumps.");
            }

        }
    }
}
