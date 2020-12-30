using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(str, n));
        }

        static string RepeatString(string str, int n)
        {
            //string result = string.Empty;

            //for (int i = 0; i < n; i++)
            //{
            //    result += str;
            //}

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                result.Append(str);
            }

            return result.ToString();
        }
    }
}
