using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (sum < 10000)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int endSteps = int.Parse(Console.ReadLine());
                    sum += endSteps;
                    break;
                }
                else
                {
                    int steps = int.Parse(input);
                    sum += steps;
                }
            }

            if (sum >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sum - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - sum} more steps to reach goal.");
            }
        }
    }
}
