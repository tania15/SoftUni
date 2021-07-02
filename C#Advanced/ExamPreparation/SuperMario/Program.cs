using System;
using System.Linq;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            char[][] maze = new char[row][];
            int col = 0;

            for (int i = 0; i < row; i++)
            {
                string str = Console.ReadLine();
                char[] charArray = new char[str.Length];

                for (int j = 0; j < str.Length; j++)
                {
                    charArray[j] = str[j];
                }

                maze[i] = charArray;
            }

            col = maze[0].Length;

            // position of Mario
            int rowMario = 0;
            int colMario = 0;

            for (int i = 0; i < maze.Length; i++)
            {
                if (maze[i].Contains('M'))
                {
                    rowMario = i;

                    for (int j = 0; j < maze[i].Length; j++)
                    {
                        if (maze[i][j] == 'M')
                        {
                            colMario = j;
                        }
                    }
                }
            }

            bool isDied = false;
            bool isReached = false;
            int newRow = 0;
            int newCol = 0;

            while (isDied == false && isReached == false)
            {
                char[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                int r = int.Parse(command[1].ToString());
                int c = int.Parse(command[2].ToString());
                maze[r][c] = 'B';

                switch (command[0])
                {
                    case 'W':                  // up
                        newRow = rowMario - 1;
                        newCol = colMario;
                        break;
                    case 'S':                  // down
                        newRow = rowMario + 1;
                        newCol = colMario;
                        break;
                    case 'A':                  // left
                        newRow = rowMario;
                        newCol = colMario - 1;
                        break;
                    case 'D':                  // right
                        newRow = rowMario;
                        newCol = colMario + 1;
                        break;
                    default:
                        break;
                }

                // checks
                if (newRow < 0 || newCol < 0 || newRow >= row || newCol >= col)
                {
                    e--;
                    newRow = rowMario;
                    newCol = colMario;
                }
                else
                {
                    if (maze[newRow][newCol] == 'B')                         
                    {
                        e -= 3;
                        maze[rowMario][colMario] = '-';
                    }

                    if (maze[newRow][newCol] == 'P')
                    {
                        maze[newRow][newCol] = '-';
                        maze[rowMario][colMario] = '-';
                        //e--;
                        isReached = true;
                    }

                    if (maze[newRow][newCol] == '-')
                    {
                        maze[rowMario][colMario] = '-';
                        e--;
                        maze[newRow][newCol] = '-';
                    }                    
                }                

                if (e <= 0)
                {
                    maze[newRow][newCol] = 'X';
                    isDied = true;
                }

                rowMario = newRow;
                colMario = newCol;
            }

            if (isDied)
            {
                Console.WriteLine($"Mario died at {newRow};{newCol}.");
            }

            if (isReached)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {e}");
            }

            foreach (var m in maze)
            {
                Console.WriteLine(string.Join("", m));
            }
        }
    }
}
