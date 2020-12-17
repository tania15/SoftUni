using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine()) * 1000;
            string grams = Console.ReadLine();
            int sum = 0;

            while (grams != "Adopted")
            {
                int gram = int.Parse(grams);
                sum += gram;                

                grams = Console.ReadLine();
            }

            if (sum <= food)
            {
                Console.WriteLine($"Food is enough! Leftovers: {food - sum} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {sum - food} grams more.");
            }
        }
    }
}
