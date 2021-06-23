using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> filter = str => str.Length <= length;
            Action<string[]> printer = names => Console.WriteLine(string.Join(Environment.NewLine, names.Where(n => filter(n))));

            printer(names);
        }
    }
}
