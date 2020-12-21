using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNumber = int.Parse(Console.ReadLine());
            evenNumber = Math.Abs(evenNumber);

            while (evenNumber % 2 == 1)
            {
                Console.WriteLine("Please write an even number.");
                evenNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(evenNumber)}");
        }
    }
}
