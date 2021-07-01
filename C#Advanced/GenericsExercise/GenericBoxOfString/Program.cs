using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            // task 1
            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();

            //    Box<string> box = new Box<string>(input);

            //    Console.WriteLine(box);
            //}



            // task 2
            //for (int i = 0; i < n; i++)
            //{
            //    int input = int.Parse(Console.ReadLine());

            //    Box<int> box = new Box<int>(input);

            //    Console.WriteLine(box);
            //}



            // task 3 and 4
            //List<string> list = new List<string>(n);

            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();

            //    list.Add(input);
            //}

            //int[] indexes = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            //Box<string> box = new Box<string>(list);
            //box.Swap(list, indexes[0], indexes[1]);

            //Console.WriteLine(box);


            // task 5 and 6
            //List<double> list = new List<double>(n);

            //for (int i = 0; i < n; i++)
            //{
            //    double input = double.Parse(Console.ReadLine());

            //    list.Add(input);
            //}

            //Box<double> box = new Box<double>(list);
            //double element = double.Parse(Console.ReadLine());

            //int count = box.CountIfGreaterElements(list, element);
            //Console.WriteLine(count);


            // task 7
            string[] personInfo = Console.ReadLine().Split();
            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string city = personInfo[2];

            string[] nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int numberOfLiters = int.Parse(nameAndBeer[1]);

            string[] numbersInput = Console.ReadLine().Split();
            int intNum = int.Parse(numbersInput[0]);
            double doubleNum = double.Parse(numbersInput[1]);

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, city);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, numberOfLiters);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(intNum, doubleNum);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
