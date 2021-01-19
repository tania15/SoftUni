using System;
using System.Linq;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var ban in bannedWords)
            {
                if (text.Contains(ban))
                {
                    text = text.Replace(ban, new string('*', ban.Length));
                }
            }

            //foreach (var ban in bannedWords)
            //{
            //    int length = ban.Length;
            //    string asterisks = string.Empty;

            //    for (int i = 0; i < length; i++)
            //    {
            //        asterisks += "*";
            //    }

            //    text = text.Replace(ban, asterisks);

            //    //while (text.IndexOf(ban) > -1)
            //    //{
            //    //    int index = text.IndexOf(ban);
            //    //    text = text.Remove(index, length);

            //    //    text = text.Insert(index, asterisks);
            //    //}
            //}

            Console.WriteLine(text);
        }
    }
}
