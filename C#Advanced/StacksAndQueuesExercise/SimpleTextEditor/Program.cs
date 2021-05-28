using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int command = int.Parse(input[0]);                

                switch (command)
                {
                    case 1:
                        stack.Push(text);
                        text += input[1];

                        break;
                    case 2:
                        stack.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(input[1]));

                        break;
                    case 3:
                        Console.WriteLine(text[int.Parse(input[1]) - 1]);
                        break;
                    case 4:
                        text = stack.Pop();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
