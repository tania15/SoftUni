using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] command = input.Split();

                if (command[0].ToLower() == "delete")
                {                    
                    numbers.RemoveAll(n => n == int.Parse(command[1]));
                }
                if (command[0].ToLower() == "insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
