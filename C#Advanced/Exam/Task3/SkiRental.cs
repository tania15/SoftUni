using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count;

        public SkiRental(string name, int capacity)
        {
            data = new List<Ski>();
            Name = name;
            Capacity = capacity;
        }

        public void Add(Ski ski)
        {
            if (Count < Capacity)
            {
                data.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (data.Where(s => s.Manufacturer == manufacturer && s.Model == model).Count() > 0)
            {
                Ski s = data.Where(s => s.Manufacturer == manufacturer && s.Model == model).First();
                data.Remove(s);
                return true;
            }

            return false;
        }

        public Ski GetNewestSki()
        {
            if (Count > 0)
            {
                return data.OrderByDescending(d => d.Year).First();
            }

            return null;
        }

        public Ski GetSki(string manufacturer, string model)
        {
            if (data.Where(s => s.Manufacturer == manufacturer && s.Model == model).Count() > 0)
            {
                return data.Where(s => s.Manufacturer == manufacturer && s.Model == model).First();
            }

            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");

            foreach (var d in data)
            {
                sb.AppendLine(d.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
