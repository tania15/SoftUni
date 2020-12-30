using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            Console.WriteLine(CountVowels(word));
        }

        static int CountVowels(string word)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'y' || word[i] == 'u')
                {
                    count++;
                }                
            }

            return count;
        }
    }
}
