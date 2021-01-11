using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> nums = new Dictionary<double, int>();

            foreach (double n in numbers)
            {
                if (nums.ContainsKey(n))
                {
                    nums[n]++;
                }
                else
                {
                    nums.Add(n, 1);
                }
            }

            nums = nums.OrderBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);

            foreach (var n in nums)
            {
                Console.WriteLine($"{n.Key} -> {n.Value}");
            }
        }
    }
}
