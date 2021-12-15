namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.DataProcessor.ExportDto;

    public class Serializer
    {
        public static string ExportTheatres(TheatreContext context, int numbersOfHalls)
        {
            var theaters = context.Theatres
                 .Where(t => t.NumberOfHalls >= numbersOfHalls && t.Tickets.Count >= 20)
                 .Select(t => new
                 {
                     t.Name,
                     t.NumberOfHalls,
                     TotalIncome = t.Tickets.Where(t => t.RowNumber >= 1 && t.RowNumber <= 5).Sum(t => t.Price),
                     Tickets = t.Tickets.Where(t => t.RowNumber >= 1 && t.RowNumber <= 5)
                        .Select(t => new
                        {
                            t.Price,
                            t.RowNumber
                        })
                        .OrderByDescending(t => t.Price)
                        .ToArray()
                 })
                 .OrderByDescending(t => t.NumberOfHalls)
                 .ThenBy( t => t.Name)
                 .ToArray();

            string json = JsonConvert.SerializeObject(theaters, Formatting.Indented);

            return json;
        }

        public static string ExportPlays(TheatreContext context, double rating)
        {
            var plays = context.Plays
                .Where(p => p.Rating <= rating)
                .ToArray()
                .Select(p => new
                {
                    p.Title,
                    Duration = p.Duration.ToString("c", CultureInfo.InvariantCulture),
                    Rating = p.Rating == 0 ? "Premier" : p.Rating.ToString(),
                    Genre = p.Genre.ToString(),
                    Actors = p.Casts
                        .Where(c => c.IsMainCharacter == true)
                        .ToArray()
                        .Select(c => new
                        {
                            c.FullName,
                            IsMainCharacter = $"Plays main character in '{p.Title}'."
                        })
                        .OrderByDescending(a => a.FullName)
                        .ToArray()
                })
                .OrderBy(p => p.Title)
                .ThenByDescending(p => p.Genre)
                .ToArray();

            //string json = JsonConvert.SerializeObject(plays, Formatting.Indented);

            //return json;


            XmlRootAttribute root = new XmlRootAttribute("Plays");
            XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
            xmlns.Add(string.Empty, string.Empty);
            XmlSerializer serializer = new XmlSerializer(typeof(ExportPlayDto[]), root);
            StringBuilder sb = new StringBuilder();

            using (StringWriter sw = new StringWriter(sb))
            {
                serializer.Serialize(sw, plays.ToArray(), xmlns);
            }

            return sb.ToString();
        }
    }
}
