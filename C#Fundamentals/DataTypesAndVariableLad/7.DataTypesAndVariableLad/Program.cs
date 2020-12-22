using System;

namespace _7.DataTypesAndVariableLad
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            //float kilometers = meters / 1000F;
            //float kilometers = meters / 1000.0f;
            //decimal kilometers = meters / 1000,0M;
            decimal kilometers = meters / 1000M;
            Console.WriteLine($"{kilometers:F2}");

            //char a = '\u0061';
            //Console.WriteLine(a);
        }
    }
}
