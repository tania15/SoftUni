using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

class Demon
{
    public string Name { get; set; }
    public int Health { get; set; }
    public double Damage { get; set; }
    public override string ToString()
    {
        return $"{Name} - {Health} health, {Damage:F2} damage";
    }
}

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allDemons = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<Demon> demons = new List<Demon>();

            Regex numbersRegex = new Regex(@"[+-]?[0-9]+\.?[0-9]*");

            foreach (string demon in allDemons)
            {
                string filter = "0123456789+-/.*";

                int health = demon.Where(c => !filter.Contains(c)).Sum(c => c);

                double damage = CalculateDamage(numbersRegex, demon);

                demons.Add(new Demon { Name = demon, Health = health, Damage = damage });
            }

            foreach (var demon in demons.OrderBy(d => d.Name))
            {
                Console.WriteLine(demon);
            }
        }

        private static double CalculateDamage(Regex numbersRegex, string demon)
        {
            MatchCollection numberMatches = numbersRegex.Matches(demon);
            double damage = 0.0;

            foreach (Match match in numberMatches)
            {
                damage += double.Parse(match.Value);
            }

            foreach (var ch in demon)
            {
                if (ch == '*')
                {
                    damage *= 2.0;
                }
                else if (ch == '/')
                {
                    damage /= 2.0;
                }
            }

            return damage;
        }
    }
}
