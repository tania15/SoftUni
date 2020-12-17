using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int thirdSymbol = (int)'a';

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = thirdSymbol; k < thirdSymbol + l; k++)
                    {
                        for (int p = thirdSymbol; p < thirdSymbol + l; p++)
                        {
                            int fifthSymbol = i > j ? i : j;
                            if (fifthSymbol < n)
                            {
                                fifthSymbol++;
                            }
                            else
                            {
                                break;
                            }

                            for (int h = fifthSymbol; h <= n; h++)
                            {
                                Console.Write($"{i}{j}{(char)k}{(char)p}{h} ");
                            }                            
                        }
                    }
                }
            }
        }
    }
}
