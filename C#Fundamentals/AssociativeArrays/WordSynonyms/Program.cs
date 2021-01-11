using System;
using System.Linq;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (!synonims.ContainsKey(word))
                {
                    synonims.Add(word, new List<string> { synonim});
                }
                else
                {
                    synonims[word].Add(synonim);
                }
            }

            foreach (var s in synonims)
            {
                Console.WriteLine($"{s.Key} - " + string.Join(", ", s.Value));
            }
        }
    }
}
