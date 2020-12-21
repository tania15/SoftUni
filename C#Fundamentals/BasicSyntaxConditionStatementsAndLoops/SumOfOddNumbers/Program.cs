using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            int count = 0;
            int sum = 0;

            while (count < n)
            {
                if (k % 2 == 1)
                {
                    Console.WriteLine(k);
                    count++;
                    sum += k;
                }
                k++;
            }

            Console.WriteLine($"Sum: {sum}");
        } 
    }
}
