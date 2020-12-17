using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    sum += 1;
                }
                if (str[i] == 'e')
                {
                    sum += 2;
                }
                if (str[i] == 'i')
                {
                    sum += 3;
                }
                if (str[i] == 'o')
                {
                    sum += 4;
                }
                if (str[i] == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
