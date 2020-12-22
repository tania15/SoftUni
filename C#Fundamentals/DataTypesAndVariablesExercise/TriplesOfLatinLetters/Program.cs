using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char first = (char)(97 + i);
                        char second = (char)(97 + j);
                        char third = (char)(97 + k);

                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
