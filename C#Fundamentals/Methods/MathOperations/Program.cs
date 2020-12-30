using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(a, @operator, b));
        }

        private static double Calculate(int a, string @operator, int b)
        {
            switch (@operator)
            {
                case "+": return a + b; break;
                case "-": return a - b; break;
                case "*": return a * b; break;
                case "/": return a / b * 1.0; break;
                default: return 0;
            }
        }
    }
}
