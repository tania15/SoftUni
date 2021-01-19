using System;
using System.Text;
using System.Linq;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits = digits.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    letters = letters.Append(text[i]);
                }
                else
                {
                    others = others.Append(text[i]);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
