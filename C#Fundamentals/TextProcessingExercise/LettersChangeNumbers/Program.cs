using System;
using System.Text;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double result = 0.0;

            foreach (string i in input)
            {
                char firstLetter = i[0];
                char lastLetter = i[i.Length - 1];

                int positionFirstLetter = char.IsUpper(firstLetter) ? (firstLetter - 64) : (firstLetter - 96);            // A = 65
                int positionLastLetter = char.IsUpper(lastLetter) ? (lastLetter - 64) : (lastLetter - 96);                // a = 97

                //StringBuilder num = new StringBuilder();

                //for (int j = 1; j < i.Length - 1; j++)
                //{
                //    num.Append(i[j]);
                //}

                //int number = int.Parse(num.ToString());

                int number = int.Parse(i.Substring(1, i.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    result += (number * 1.0 / positionFirstLetter);
                }
                else
                {
                    result += (number * positionFirstLetter);
                }

                if (char.IsUpper(lastLetter))
                {
                    result -= positionLastLetter;
                }
                else
                {
                    result += positionLastLetter;
                }
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
