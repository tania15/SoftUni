using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string command = Console.ReadLine();

            //try
            //{
                while (command.ToLower() != "end")
                {
                    string[] tokens = command
                        .Split(";", StringSplitOptions.RemoveEmptyEntries);
                    string teamName = tokens[1];                    

                    switch (tokens[0].ToLower())
                    {
                        case "team":
                            try
                            {
                                if (teams.Where(t => t.Name == teamName).Count() == 0)
                                {
                                    Team team = new Team(teamName);
                                    teams.Add(team);
                                }
                            }
                            catch (ArgumentException a)
                            {
                                Console.WriteLine(a.Message);
                            }

                            break;

                        case "add":
                            if (teams.Where(t => t.Name == teamName).Count() == 0)
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            else
                            {
                                try
                                {
                                    teams.Where(t => t.Name == teamName)
                                        .First()
                                        .Players
                                        .Add(new Player(tokens[2], 
                                             new List<int> { int.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7]) }));
                                    //teams.Where(t => t.Name == teamName).First().Players.Where(p => p.Name == tokens[2]).First()
                                        //.AddStat(new List<int> { int.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7]) });
                                }
                                catch (ArgumentException a)
                                {
                                    Console.WriteLine(a.Message);
                                }
                            }

                            break;

                        case "remove":
                            if (teams.First(t => t.Name == teamName).Players.Where(p => p.Name == tokens[2]).Count() > 0)
                            {
                                teams.First(t => t.Name == teamName).Players.RemoveAll(p => p.Name == tokens[2]);
                            }
                            else
                            {
                                Console.WriteLine($"Player {tokens[2]} is not in {teamName} team.");
                            }

                            break;
                        case "rating":
                            if (teams.Where(t => t.Name == teamName).Count() == 0)
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            else
                            {   
                                double result = 0.0;

                                if (teams.First(t => t.Name == teamName).Players.Count() > 0)
                                {
                                    result = Math.Ceiling(teams.First(t => t.Name == teamName).Players.Average(p => p.Statistics.Average()));
                                }
                                
                                Console.WriteLine($"{teamName} - {result:F0}");
                            }
                            break;

                        default:
                            break;
                    }

                    command = Console.ReadLine();
                }
            //}
            //catch (ArgumentException a)
            //{
            //    Console.WriteLine(a.Message);
            //}
        }
    }
}
