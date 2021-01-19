using System;
using System.Text;
using System.Linq;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] explosions = Console.ReadLine().Split('>');                //  abv>1>1>2>2asdasd
            int temp = 0;

            for (int j = 0; j < explosions.Length; j++)
            {
                if (char.IsDigit(explosions[j][0]))
                {
                    int first = explosions[j][0] - '0';
                    int digit = first + temp;
                    int length = explosions[j].Length;

                    for (int i = 0; i < Math.Min(length, digit); i++)
                    {
                        explosions[j] = explosions[j].Remove(0, 1);
                    }

                    if (length < digit)
                    {
                        temp = digit - length;
                    }
                    else
                    {
                        temp = 0;
                    }
                }                                
            }

            Console.WriteLine(string.Join('>', explosions));
        }
    }
}
