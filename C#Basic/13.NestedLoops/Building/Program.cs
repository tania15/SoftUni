using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floors; i > 0; i--)
            {
                for (int j = 1; j <= rooms; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (i == floors)
                        {
                            Console.Write($"L{i * 10 + j - 1} ");
                        }
                        else
                        {
                            Console.Write($"O{i * 10 + j - 1} ");
                        }
                    }
                    else
                    {
                        if (i == floors)
                        {
                            Console.Write($"L{i * 10 + j - 1} ");
                        }
                        else
                        {
                            Console.Write($"A{i * 10 + j - 1} ");
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
