using System;
using System.Linq;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    if (occurrences.ContainsKey(word[i]))
                    {
                        occurrences[word[i]]++;
                    }
                    else
                    {
                        occurrences.Add(word[i], 1);
                    }
                }
            }

            foreach (var w in occurrences)
            {
                Console.WriteLine($"{w.Key} -> {w.Value}");
            }
        }
    }
}
