using System;

namespace AlgorithmsIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Demo(5);
            Console.WriteLine(result);
        }

        public static int Demo(int n)
        {
            if (n >= 10)
            {
                return n;
            }

            return Demo(n + 1);
        }

        public static int Power(int number, int power)
        {
            if (power == 1)
            {
                return number;
            }

            return number * Power(number, power - 1);
        }

        public static int SumArray(int[] array, int index)
        {            
            if (index == 0)
            {
                return array[0];
            }

            return array[index] + SumArray(array, --index);
        }

        public static int NFactorial(int n)
        {
            if (n == 2)
            {
                return 2;
            }

            return n * NFactorial(n - 1);
        }
    }
}
