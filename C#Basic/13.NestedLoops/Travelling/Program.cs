using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                int budget = int.Parse(Console.ReadLine());
                int sum = 0;

                while (sum < budget)
                {
                    int number = int.Parse(Console.ReadLine());
                    sum += number;
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();                
            }
        }
    }
}
