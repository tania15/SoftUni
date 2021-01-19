using System;
using System.Linq;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder(text);

            for (int i = 0; i < sb.Length - 1; i++)
            {
                while (i + 1 < sb.Length && sb[i] == sb[i + 1])
                {
                    sb = sb.Remove(i + 1, 1);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
