using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("test");
            list.Add("test1");
            list.Add("test2");
            list.Add("test3");
            list.Add("test4");

            Console.WriteLine(list.RandomString());

        }
    }
}
