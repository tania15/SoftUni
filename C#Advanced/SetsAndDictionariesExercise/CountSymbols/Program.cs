using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> characters = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (characters.ContainsKey(text[i]))
                {
                    characters[text[i]]++;
                }
                else
                {
                    characters.Add(text[i], 1);
                }
            }

            foreach (var c in characters)
            {
                Console.WriteLine($"{c.Key}: {c.Value} time/s");
            }
        }
    }
}
