using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            char[][] beach = new char[r][];

            for (int i = 0; i < r; i++)
            {
                char[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                beach[i] = arr;
            }

            int collectedTokens = 0;
            int opponentTokens = 0;

            string input = Console.ReadLine();

            while (input.ToLower() != "gong")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                if (row >= r || row < 0 || col < 0 || beach[row].Length <= col)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (command[0].ToLower() == "find")
                {
                    if (beach[row][col] == 'T')
                    {
                        collectedTokens++;
                        beach[row][col] = '-';
                    }
                }

                if (command[0].ToLower() == "opponent")
                {
                    if (beach[row][col] == 'T')
                    {
                        opponentTokens++;
                        beach[row][col] = '-';
                    }

                    switch (command[3].ToLower())
                    {
                        case "up":
                            if (row - 1 < r && beach[row - 1].Length > col && beach[row - 1][col] == 'T')
                            {
                                opponentTokens++;
                                beach[row - 1][col] = '-';
                            }
                            if (row - 2 < r && beach[row - 2].Length > col && beach[row - 2][col] == 'T')
                            {
                                opponentTokens++;
                                beach[row - 2][col] = '-';
                            }
                            if (row - 3 < r && beach[row - 3].Length > col && beach[row - 3][col] == 'T')
                            {
                                opponentTokens++;
                                beach[row - 3][col] = '-';
                            }
                            break;
                        case "down":
                            if (row + 1 < r && beach[row + 1].Length > col && beach[row + 1][col] == 'T')
                            {
                                opponentTokens++;
                                beach[row + 1][col] = '-';
                            }
                            if (row + 2 < r && beach[row + 2].Length > col && beach[row + 2][col] == 'T')
                            {
                                opponentTokens++;
                                beach[row + 2][col] = '-';
                            }
                            if (row + 3 < r && beach[row + 3].Length > col && beach[row + 3][col] == 'T')
                            {
                                opponentTokens++;
                                beach[row + 3][col] = '-';
                            }
                            break;
                        case "left":
                            if (col - 1 < beach[row].Length && col - 1 >= 0 && beach[row][col - 1] == 'T')
                            {
                                opponentTokens++;
                                beach[row][col - 1] = '-';
                            }
                            if (col - 2 < beach[row].Length && col - 2 >= 0 && beach[row][col - 2] == 'T')
                            {
                                opponentTokens++;
                                beach[row][col - 2] = '-';
                            }
                            if (col - 3 < beach[row].Length && col - 3 >= 0 && beach[row][col - 3] == 'T')
                            {
                                opponentTokens++;
                                beach[row][col - 3] = '-';
                            }
                            break;
                        case "right":
                            if (col + 1 < beach[row].Length && col + 1 >= 0 && beach[row][col + 1] == 'T')
                            {
                                opponentTokens++;
                                beach[row][col + 1] = '-';
                            }
                            if (col + 2 < beach[row].Length && col + 2 >= 0 && beach[row][col + 2] == 'T')
                            {
                                opponentTokens++;
                                beach[row][col + 2] = '-';
                            }
                            if (col + 3 < beach[row].Length && col + 3 >= 0 && beach[row][col + 3] == 'T')
                            {
                                opponentTokens++;
                                beach[row][col + 3] = '-';
                            }
                            break;
                        default:
                            break;
                    }

                }

                input = Console.ReadLine();
            }


            foreach (var b in beach)
            {
                Console.WriteLine(string.Join(" ", b));
            }

            Console.WriteLine($"Collected tokens: {collectedTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");
        }
    }
}
