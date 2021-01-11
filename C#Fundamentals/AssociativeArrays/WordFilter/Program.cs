using System;
using System.Linq;
using System.Collections.Generic;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            words = words.Where(w => w.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));

            //Console.ReadLine()
            //    .Split()
            //    .Where(x => x.Length % 2 == 0)
            //    .ToList()
            //    .ForEach(word => Console.WriteLine(word));
        }
    }
}
