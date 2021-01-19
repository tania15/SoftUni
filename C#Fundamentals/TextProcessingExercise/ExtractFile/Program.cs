using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string[] path = text[text.Length - 1].Split('.');

            Console.WriteLine($"File name: {path[0]}");
            Console.WriteLine($"File extension: {path[1]}");
        }
    }
}
