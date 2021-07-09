using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int minStat = 0;
        private const int maxStat = 100;
        private readonly List<string> listOfStat = new List<string>(5) { "Endurance", "Sprint", "Dribble", "Passing", "Shooting" };

        private string name;
        private List<int> stat;
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public List<int> Statistics
        {
            get
            {
                return stat;
            }
            private set
            {
                if (value.Exists(v => v < minStat || v > maxStat))
                {
                    int element = value.Find(v => v < minStat || v > maxStat);

                    throw new ArgumentException($"{listOfStat[value.IndexOf(element)]} should be between {minStat} and {maxStat}.");
                } 

                stat = value;
            }
        }

        public Player(string name)
        {
            Name = name;
            Statistics = new List<int>(5);
        }

        public Player(string name, List<int> stat)
            : this(name)
        {            
            Statistics = new List<int>(stat);            
        }

        //public void AddStat(string name, List<int> values)            
        //{            
        //    foreach (var v in values)
        //    {
        //        Statistics.Add(v);
        //    }
        //}
    }
}
