using System;
using System.Text;
using System.Linq;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(Encrypt(text));
        }

        public static string Encrypt(string text)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                result = result.Append((char)(text[i] + 3));
            }

            return result.ToString();
        }
    }
}
