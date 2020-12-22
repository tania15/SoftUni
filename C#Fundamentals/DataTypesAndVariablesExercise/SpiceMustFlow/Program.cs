using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int tYield = startingYield;
            int count = 0;
            int sum = 0;

            while (startingYield >= 100)
            {
                startingYield -= 10;
                tYield -= 26;
                sum += tYield;

                tYield = startingYield;
                count++;
            }

            Console.WriteLine(count);
            Console.WriteLine(sum - 26);
        }
    }
}
