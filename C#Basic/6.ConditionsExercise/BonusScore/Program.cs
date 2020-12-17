using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double result;
            double bonus = 0; 

            if (count <= 100)
            {
                result = count + 5;
                bonus += 5;
            }
            else if (count > 100 && count <= 1000)
            {
                result = count + count * 20 / 100.0;
                bonus = count * 20 / 100.0;
            }
            else
            {
                result = count + count * 10 / 100.0;
                bonus = count * 10 / 100.0;
            }

            if (count % 2 == 0)
            {
                result += 1;
                bonus += 1;
            }

            if (count % 10 == 5)
            {
                result += 2;
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(result);

        }
    }
}
