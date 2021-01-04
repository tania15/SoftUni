using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int index = int.Parse(Console.ReadLine());

            while (numbers.Count != 0)
            {
                if (index >= 0 && index < numbers.Count)
                {
                    int element = numbers[index];
                }
                else
                {

                }


            }
        }
    }
}
