using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;
        //public List<Player> Roster { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => roster.Count;
        public Guild(string name, int capacity)
        {
            roster = new List<Player>();
            Name = name;
            Capacity = capacity;
        }

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity && !roster.Any(x => x.Name == player.Name))
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            int count = roster.Where(r => r.Name == name).Count();

            if (count > 0)
            {
                roster.Remove(roster.Where(r => r.Name == name).First());
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            roster.Find(r => r.Name == name).Rank = "Member";
        }

        public void DemotePlayer(string name)
        {
            roster.Find(r => r.Name == name).Rank = "Trial";
        }

        public Player[] KickPlayersByClass(string @class)
        {
            Player[] result = roster.Where(r => r.Class == @class).ToArray();
            roster = roster.Where(r => r.Class != @class).ToList();
            return result;
        }

        public string Report()
        {
            StringBuilder myString = new StringBuilder();
            myString.AppendLine($"Players in the guild: {this.Name}");

            foreach (var player in this.roster)
            {
                myString.AppendLine(player.ToString());
                //myString.AppendLine($"Rank: {player.Rank}");
                //myString.AppendLine($"Description: {player.Description}");
            }

            return myString.ToString().TrimEnd();
        }
    }
}
