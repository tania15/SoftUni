using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.StartsWith(char.ToUpper(w[0])))
                .ToArray();

            //Predicate<string> predicate = w => w.ToUpper()[0] == w[0];

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
