using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private readonly List<IRepair> repairs;
        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
        }

        public IReadOnlyCollection<IRepair> Repairs => repairs.AsReadOnly();

        public void AddRepair(IRepair repair)
        {
            repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString()).AppendLine("Repairs:");

            foreach (IRepair repair in repairs)
            {
                sb.AppendLine(" " + repair);
            }

            return sb.ToString().Trim();
        }
    }
}
