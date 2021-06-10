using System;
using System.IO;
using System.Threading.Tasks;

namespace OddLines
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader str = new StreamReader("Input.txt"))
            {
                int count = 0;
                string line = await str.ReadLineAsync();

                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }

                    count++;
                    line = await str.ReadLineAsync();
                }
            }
        }
    }
}
