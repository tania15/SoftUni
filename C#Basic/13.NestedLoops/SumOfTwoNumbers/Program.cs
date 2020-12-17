using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            bool flag = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    count++;

                    if (i + j == number)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {i + j})");
                        flag = true;
                        break;
                    }

                    if (i == end && j == end)
                    {
                        Console.WriteLine($"{count} combinations - neither equals {number}");
                    }
                }

                if (flag == true)
                {
                    break;
                }
            }            
        }
    }
}
