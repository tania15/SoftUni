using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                string reversedText = string.Empty;

                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversedText += text[i];
                }

                Console.WriteLine($"{text} = {reversedText}");

                text = Console.ReadLine();
            }
        }
    }
}
