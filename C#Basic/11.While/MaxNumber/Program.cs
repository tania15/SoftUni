using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;

            while (input != "Stop")
            {
                int n = int.Parse(input);

                if (n > max)
                {
                    max = n;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
