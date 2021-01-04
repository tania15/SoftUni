using System;
using System.Linq;
using System.Collections.Generic;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>(firstList.Count + secondList.Count);

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            for (int i = Math.Min(firstList.Count, secondList.Count); i < Math.Max(firstList.Count, secondList.Count); i++)
            {
                if (firstList.Count > secondList.Count)
                {
                    result.Add(firstList[i]);
                }
                else
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
