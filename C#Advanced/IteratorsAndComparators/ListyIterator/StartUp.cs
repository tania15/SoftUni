using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            ListyIterator<string> list = null;

            while ((command = Console.ReadLine()).ToLower() != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Create")
                {
                    list = new ListyIterator<string>(tokens.Skip(1).ToArray());
                }
                else if (tokens[0] == "Move")
                {
                    Console.WriteLine(list.Move());
                }
                else if (tokens[0] == "Print")
                {
                    try
                    {
                        list.Print();
                    }
                    catch (ArgumentException a)
                    {
                        Console.WriteLine(a.Message);
                    }
                }
                else if (tokens[0] == "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                }
                else if (tokens[0] == "PrintAll")
                {
                    list.PrintAll();
                }
            }
        }
    }
}
