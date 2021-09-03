using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0].ToLower() != "end")
            {                

                if (tokens[0].ToLower() == "push")
                {
                    stack.Push(tokens.Skip(1).Select(t => t.Split(",").First()).ToArray());
                }
                else if (tokens[0].ToLower() == "pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException a)
                    {
                        Console.WriteLine(a.Message);
                    }
                }

                tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (string e in stack)
            {
                Console.WriteLine(e);
            }

            foreach (string e in stack)
            {
                Console.WriteLine(e);
            }
        }
    }
}
