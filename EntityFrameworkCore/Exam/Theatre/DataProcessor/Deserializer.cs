namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.Data.Models;
    using Theatre.Data.Models.Enums;
    using Theatre.DataProcessor.ImportDto;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfulImportPlay
            = "Successfully imported {0} with genre {1} and a rating of {2}!";

        private const string SuccessfulImportActor
            = "Successfully imported actor {0} as a {1} character!";

        private const string SuccessfulImportTheatre
            = "Successfully imported theatre {0} with #{1} tickets!";

        public static string ImportPlays(TheatreContext context, string xmlString)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Plays");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportPlayDto[]), xmlRoot);

            using StringReader sr = new StringReader(xmlString);

            ImportPlayDto[] playDtos = (ImportPlayDto[])xmlSerializer.Deserialize(sr);

            HashSet<Play> plays = new HashSet<Play>();
            StringBuilder sb = new StringBuilder();

            foreach (var play in playDtos)
            {
                if (!IsValid(play))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                bool IsValidDiration = TimeSpan.TryParse(play.Duration, out TimeSpan duration);

                if (!IsValidDiration)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (duration.TotalMinutes < 60)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                bool isValidGenre = Enum.TryParse<Genre>(play.Genre, out Genre genre);

                if (!isValidGenre)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Play newPlay = new Play()
                {
                    Title = play.Title,
                    Duration = duration,
                    Rating = play.Rating,
                    Genre = genre,
                    Description = play.Description,
                    Screenwriter = play.Screenwriter
                };

                plays.Add(newPlay);
                sb.AppendLine(String.Format(SuccessfulImportPlay, newPlay.Title, newPlay.Genre, newPlay.Rating));
            }

            context.Plays.AddRange(plays);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportCasts(TheatreContext context, string xmlString)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Casts");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCastDto[]), xmlRoot);

            using StringReader sr = new StringReader(xmlString);

            ImportCastDto[] castDtos = (ImportCastDto[])xmlSerializer.Deserialize(sr);

            HashSet<Cast> casts = new HashSet<Cast>();
            StringBuilder sb = new StringBuilder();

            foreach (var cast in castDtos)
            {
                if (!IsValid(cast))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                bool isValidMainCharacter = (cast.IsMainCharacter == "false" || cast.IsMainCharacter == "true" ? true : false);

                if (!isValidMainCharacter)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                bool isMainCharacter = (cast.IsMainCharacter == "false" ? false : true);

                Cast newCast = new Cast()
                {
                    FullName = cast.FullName,
                    IsMainCharacter = isMainCharacter,
                    PhoneNumber = cast.PhoneNumber,
                    PlayId = cast.PlayId
                };

                casts.Add(newCast);
                sb.AppendLine(String.Format(SuccessfulImportActor, newCast.FullName, 
                    newCast.IsMainCharacter == true ? "main" : "lesser"));
            }

            context.Casts.AddRange(casts);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportTtheatersTickets(TheatreContext context, string jsonString)
        {
            ImportTheatreDto[] theatreDtos = JsonConvert.DeserializeObject<ImportTheatreDto[]>(jsonString);

            HashSet<Theatre> theaters = new HashSet<Theatre>();
            StringBuilder sb = new StringBuilder();

            foreach (var theatre in theatreDtos)
            {
                if (!IsValid(theatre))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Theatre newTheatre = new Theatre()
                {
                    Name = theatre.Name,
                    NumberOfHalls = theatre.NumberOfHalls,
                    Director = theatre.Director
                };

                HashSet<Ticket> tickets = new HashSet<Ticket>();

                foreach (var ticket in theatre.Tickets)
                {
                    if (!IsValid(ticket))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    //var play = context.Plays
                    //    .Find(ticket.PlayId);

                    //if (play == null)
                    //{
                    //    sb.AppendLine(ErrorMessage);
                    //    continue;
                    //}

                    Ticket newTicket = new Ticket()
                    {
                        Price = ticket.Price,
                        RowNumber = ticket.RowNumber,
                        PlayId = ticket.PlayId
                    };

                    tickets.Add(newTicket);
                }

                newTheatre.Tickets = tickets;
                theaters.Add(newTheatre);

                sb.AppendLine(String.Format(SuccessfulImportTheatre, newTheatre.Name, newTheatre.Tickets.Count));
            }

            context.Theatres.AddRange(theaters);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }


        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}
