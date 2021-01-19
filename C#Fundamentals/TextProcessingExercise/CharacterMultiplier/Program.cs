using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);            

            Console.WriteLine(Multiplier(str[0], str[1])); 
        }

        public static int Multiplier(string str1, string str2)
        {
            int result = 0;

            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                result += str1[i] * str2[i];
            }

            int index = Math.Min(str1.Length, str2.Length);

            if (str1.Length > str2.Length)
            {
                for (int i = index; i < str1.Length; i++)
                {
                    result += str1[i];
                }
            }
            else if (str2.Length > str1.Length)
            {
                for (int i = index; i < str2.Length; i++)
                {
                    result += str2[i];
                }
            }

            return result;
        }
    }
}
