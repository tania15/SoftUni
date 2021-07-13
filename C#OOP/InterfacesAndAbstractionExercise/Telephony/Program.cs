using System;
using System.Linq;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            ICallable phone;

            foreach (string number in numbers)
            {
                if (!number.All(c => char.IsDigit(c)) || !(number.Length == 7 || number.Length == 10))                              // All(char.IsDigit)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                                
                if (number.Length == 10)
                {
                    phone = new Smartphone();
                }
                else
                {
                    phone = new StationaryPhone();
                }

                phone.Call(number);
            }

            string[] urls = Console.ReadLine().Split();

            foreach (string u in urls)
            {
                if (u.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }

                IBrowsable url = new Smartphone();
                url.Browse(u);
            }
        }
    }
}
