using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string text = await File.ReadAllTextAsync("Words.txt");
            string[] wordsArray = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (string w in wordsArray)
            {
                words.Add(w, 0);
            }

            string[] lines = await File.ReadAllLinesAsync("Input.txt");
            
            foreach (string l in lines)
            {
                string[] line = l.Split(new string[] {" ", ", ", "...", ". ", "-", "?! ", "? ", "?", "."}, StringSplitOptions.RemoveEmptyEntries);

                foreach (string p in line)
                {
                    if (words.ContainsKey(p.ToLower()))
                    {
                        words[p.ToLower()]++;
                    }                    
                }
            }

            string[] lineArray = new string[words.Count];
            int i = 0;

            foreach (var w in words.OrderByDescending(w => w.Value))
            {
                lineArray[i] = $"{w.Key} - {w.Value}";
                i++;
            }

            await File.WriteAllLinesAsync("Output.txt", lineArray);
        }
    }
}
