using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Subrtact(Add(firstNum, secondNum), thirdNum));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subrtact(int x, int y)
        {
            return x - y;
        }
    }
}
