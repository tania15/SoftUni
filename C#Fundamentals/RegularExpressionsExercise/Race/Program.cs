using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = Console.ReadLine().Split(", ");
            //Dictionary<string, int> participants = new Dictionary<string, int>();

            //foreach (string name in names)
            //{
            //    participants.Add(name, 0);
            //}

            //string namePattern = @"[\W\d]";
            //string numberPattern = @"[\D]";

            Dictionary<string, int> participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(p => p, x => 0);

            string namePattern = @"[A-Za-z]+";
            string numberPattern = @"\d";
            Regex nameRegex = new Regex(namePattern);
            Regex numberRegex = new Regex(numberPattern);

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                //string name = Regex.Replace(input, namePattern, "");
                //string distance = Regex.Replace(input, numberPattern, "");

                //if (participants.ContainsKey(name))
                //{
                //    int num = 0;

                //    for (int i = 0; i < distance.Length; i++)
                //    {
                //        num += (distance[i] + '\0');
                //    }

                //    participants[name] += num;
                //}

                MatchCollection lettersMatches = nameRegex.Matches(input);
                StringBuilder sb = new StringBuilder();

                foreach (Match match in lettersMatches)
                {
                    sb.Append(match.Value);
                }

                string name = sb.ToString();

                MatchCollection digitsMatches = numberRegex.Matches(input);
                int sum = 0;

                foreach (Match m in digitsMatches)
                {
                    sum += int.Parse(m.Value);
                }

                if (participants.ContainsKey(name))
                {
                    participants[name] += sum;
                }

                input = Console.ReadLine();
            }

            participants = participants.OrderByDescending(v => v.Value).ToDictionary(k => k.Key, v => v.Value);

            int count = 1;

            foreach (var p in participants)
            {
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {p.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {p.Key}");
                }
                else if (count == 3)
                {
                    Console.WriteLine($"3rd place: {p.Key}");
                }
                else
                {
                    break;
                }

                count++;
            }

            //string[] winners = participants
            //    .OrderByDescending(p => p.Value)
            //    .Take(3)
            //    .Select(p => p.Key)
            //    .ToArray();
        }
    }
}
