using System;
using System.Text;
using System.Linq;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //StringBuilder text = new StringBuilder(Console.ReadLine());
            string text = Console.ReadLine();

            while (text.ToLower().IndexOf(str.ToLower()) > -1)
            {
                int index = text.ToLower().IndexOf(str.ToLower());
                text = text.Remove(index, str.Length);
            }

            Console.WriteLine(text);
        }
    }
}
