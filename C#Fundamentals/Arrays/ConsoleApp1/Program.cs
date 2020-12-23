using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] array = { 1, 2, 3, 4 };

            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }

            int[] ar = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)          // вторият премахва празните елементи
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(string.Join(' ', arr.Reverse()));         // reverse връща абстрактна колекция, а не масив;
            int[] newArr = arr.Reverse().ToArray();

            // Away from zero
            double[] testRounding = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < testRounding.Length; i++)
            {
                Console.WriteLine($"{testRounding[i]} => {Math.Round(testRounding[i], MidpointRounding.AwayFromZero)}");
            }

            Console.WriteLine(string.Join(' ', array));
            // четене и печатане на един ред
            Console.WriteLine(string.Join(' ', Console.ReadLine().Split().Reverse()));
        }
    }
}
