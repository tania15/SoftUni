using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Numerics;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patternName = @"(::|\*\*)([A-Z][a-z]{2,})\1";
            //string patternName = @"(::|\*\*)(?<emoji>[A-Z][a-z]{2}[a-z]*)\1";
            string patternDigit = @"\d";
            Regex regexName = new Regex(patternName);
            Regex regexDigit = new Regex(patternDigit);

            MatchCollection matchesDigits = regexDigit.Matches(input);
            BigInteger coolThreshold = CalculateCoolThreshold(matchesDigits);
            Console.WriteLine($"Cool threshold: {coolThreshold}");

            Dictionary<string, int> emojis = new Dictionary<string, int>();
            MatchCollection matchesEmojis = regexName.Matches(input);
            int count = 0;

            foreach (Match m in matchesEmojis)
            {
                count++;
                int valueOfLetters = SumLetters(m.Value);

                if (valueOfLetters >= coolThreshold)
                {
                    emojis.Add(m.Value, valueOfLetters);
                }
            }

            Console.WriteLine($"{count} emojis found in the text. The cool ones are:");

            //foreach (var e in emojis)
            //{
            //    Console.WriteLine(emojis.Keys);
            //}
            Console.WriteLine(string.Join(Environment.NewLine, emojis.Keys));
        }

        static int SumLetters(string word)
        {
            int sum = 0;

            for(int i = 2; i < word.Length - 2; i++)
            {
                sum += (int) word[i];
            }

            return sum;
        }

        public static BigInteger CalculateCoolThreshold(MatchCollection matches)
        {
            BigInteger prod = 1;

            foreach (Match m in matches)
            {
                prod *= int.Parse(m.Value);
            }

            return prod;
        }
    }
}
