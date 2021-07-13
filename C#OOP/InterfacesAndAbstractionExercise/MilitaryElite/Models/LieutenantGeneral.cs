using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly List<IPrivate> privates;
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            privates = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Privates => privates.AsReadOnly();

        public void AddPrivate(IPrivate prPrivate)
        {
            privates.Add(prPrivate);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach(IPrivate @private in privates)
            {
                sb.AppendLine(" " + @private);
            }

            return sb.ToString().Trim();
        }
    }
}
