using System;

namespace GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();

            string command = Console.ReadLine();
            int pointsOfFirstPlayer = 0;
            int pointsOfSecondPlayer = 0;

            while (command != "End of game")
            {
                int firstCard = int.Parse(command);
                int secondCard = int.Parse(Console.ReadLine());

                if (firstCard > secondCard)
                {
                    pointsOfFirstPlayer += (firstCard - secondCard);
                }
                else if (secondCard > firstCard)
                {
                    pointsOfSecondPlayer += (secondCard - firstCard);
                }
                else
                {
                    Console.WriteLine("Number wars!");
                    firstCard = int.Parse(Console.ReadLine());
                    secondCard = int.Parse(Console.ReadLine());

                    if (firstCard > secondCard)
                    {
                        Console.WriteLine($"{firstPlayer} is winner with {pointsOfFirstPlayer} points");
                    }
                    else
                    {
                        Console.WriteLine($"{secondPlayer} is winner with {pointsOfSecondPlayer} points");
                    }

                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "End of game")
            {
                Console.WriteLine($"{firstPlayer} has {pointsOfFirstPlayer} points");
                Console.WriteLine($"{secondPlayer} has {pointsOfSecondPlayer} points");
            }
        }
    }
}
