using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < count; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");

                Team team = new Team(newTeam[1], newTeam[0]);

                bool isTeamExist = teams.Select(t => t.Name).Contains(newTeam[1]);
                bool isCreatorExist = teams.Select(c => c.Creator).Contains(newTeam[0]);

                if (isTeamExist)
                {
                    Console.WriteLine($"Team {newTeam[1]} was already created!");
                    break;
                }

                if (isCreatorExist)
                {
                    Console.WriteLine($"{newTeam[0]} cannot create another team!");
                    break;
                }

                teams.Add(team);
                Console.WriteLine($"Team {newTeam[1]} has been created by {newTeam[0]}!");
            }

            string member = Console.ReadLine();

            while (member != "end of assignment")
            {
                string[] memberArray = member.Split("->");

                bool isTeamExist = teams.Select(t => t.Name).Contains(memberArray[1]);
                bool isJoined = teams.Select(c => c.Creator).Contains(memberArray[0]) || teams.Select(t => t.Members).Any(x => x.Contains(memberArray[0]));

                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {memberArray[1]} does not exist!");
                }
                else if (isJoined)
                {
                    Console.WriteLine($"Member {memberArray[0]} cannot join team {memberArray[1]}!");
                }
                else
                {
                    int index = teams.FindIndex(t => t.Name == memberArray[1]);
                    teams[index].Members.Add(memberArray[0]);
                }

                member = Console.ReadLine();
            }

            Team[] teamsToDisband = teams.OrderBy(x => x.Name).Where(x => x.Members.Count == 0).ToArray();
            Team[] fullTeam = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).Where(x => x.Members.Count > 0).ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Team team in fullTeam)
            {
                sb.AppendLine($"{team.Name}");
                sb.AppendLine($"- {team.Creator}");

                foreach (var m in team.Members.OrderBy(x=>x))
                {
                    sb.AppendLine($"-- {m}");
                }
            }

            sb.AppendLine("Teams to disband:");

            foreach (Team team in teamsToDisband)
            {
                sb.AppendLine(team.Name);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
