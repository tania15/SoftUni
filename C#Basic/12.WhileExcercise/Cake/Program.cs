using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int sizeOfCake = width * length;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int pieces = int.Parse(input);
                sizeOfCake -= pieces;

                if (sizeOfCake < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(sizeOfCake)} pieces more.");
                    break;
                }

                input = Console.ReadLine();
            }

            if (sizeOfCake >= 0)
            {
                Console.WriteLine($"{sizeOfCake} pieces are left.");
            }
        }
    }
}
