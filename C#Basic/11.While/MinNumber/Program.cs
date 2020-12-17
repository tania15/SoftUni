using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;

            while (input != "Stop")
            {
                int n = int.Parse(input);

                if (n < min)
                {
                    min = n;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(min);
        }
    }
}
