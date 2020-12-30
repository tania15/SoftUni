using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine(MaxInt(x, y));
            }
            else if (type == "char")
            {
                char x = char.Parse(Console.ReadLine());
                char y = char.Parse(Console.ReadLine());

                Console.WriteLine(MaxChar(x, y));
            }

            else if (type == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();

                Console.WriteLine(MaxString(str1, str2));
            }
        }

        static int MaxInt(int x, int y)
        {
            return x >= y ? x : y;
        }

        static char MaxChar(char x, char y)
        {
            return (int)x >= (int)y ? x : y;
        }

        static string MaxString(string str1, string str2)
        {
            return str1.CompareTo(str2) == 0 ? str1 : str2;
        }
    }
}
