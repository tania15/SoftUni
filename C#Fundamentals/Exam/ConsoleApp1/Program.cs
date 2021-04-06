using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a++;
            int c = ++a;
            Console.WriteLine(c);

            Console.WriteLine();

            bool i = 100f == 100d;
            Console.WriteLine(i);

            Console.WriteLine();

            for (int j = 10; j > 3; j-=2)
            {
                Console.WriteLine(j);
            }

            string ff = "fsgghdfhh";
            ff.Substring()
        }
    }
}
