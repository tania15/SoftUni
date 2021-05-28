using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] parenthesis = Console.ReadLine().ToCharArray();

            Stack<char> stack = new Stack<char>();
            char[] brackets = { '(', '{', '[' };
            bool isValid = true;

            foreach (var p in parenthesis)
            {
                if (brackets.Contains(p))
                {
                    stack.Push(p);                    
                }
                else if (stack.Count > 0 && stack.Peek() == '(' && p == ')')
                {
                    stack.Pop();
                }
                else if (stack.Count > 0 && stack.Peek() == '[' && p == ']')
                {
                    stack.Pop();
                }
                else if (stack.Count > 0 && stack.Peek() == '{' && p == '}')
                {
                    stack.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (stack.Count == 0 && isValid == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
