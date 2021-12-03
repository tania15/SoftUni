namespace TeisterMask.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using TeisterMask.DataProcessor.ExportDto;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportProjectWithTheirTasks(TeisterMaskContext context)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Projects");
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportProjectDto[]), xmlRoot);

            StringBuilder sb = new StringBuilder();
            using StringWriter sw = new StringWriter(sb);

            ExportProjectDto[] projects = context.Projects
                .ToArray()
                .Where(p => p.Tasks.Any())
                .Select(p => new ExportProjectDto()
                {
                    Name = p.Name,
                    TasksCount = p.Tasks.Count,
                    HasEndDate = p.DueDate.HasValue ? "Yes" : "No",
                    Tasks = p.Tasks
                        .Select(t => new ExportProjectTaskDto()
                        {
                            TaskName = t.Name,
                            Label = t.LabelType.ToString()
                        })
                        .OrderBy(t => t.TaskName)
                        .ToArray()
                })
                .OrderByDescending(p => p.TasksCount)
                .ThenBy(p => p.Name)
                .ToArray();

            xmlSerializer.Serialize(sw, projects, namespaces);

            return sw.ToString().TrimEnd();
        }

        public static string ExportMostBusiestEmployees(TeisterMaskContext context, DateTime date)
        {
            var mostBussiestEmployees = context.Employees
                .ToArray()
                .Where(e => e.EmployeesTasks.Any(et => et.Task.OpenDate >= date))
                .Select(e => new
                {
                    e.Username,
                    Tasks = e.EmployeesTasks
                        .Where(et => et.Task.OpenDate >= date)
                        .OrderByDescending(t => t.Task.DueDate)
                        .ThenBy(t => t.Task.Name)
                        .Select(et => new
                        {
                            TaskName = et.Task.Name,
                            OpenDate = et.Task.OpenDate.ToString("d", CultureInfo.InvariantCulture),
                            Duedate = et.Task.DueDate.ToString("d", CultureInfo.InvariantCulture),
                            LabelType = et.Task.LabelType.ToString(),
                            ExecutionType = et.Task.ExecutionType.ToString()
                        })
                        .ToArray()
                })
                .OrderByDescending(e => e.Tasks.Length)
                .ThenBy(e => e.Username)
                .Take(10)
                .ToArray();

            string json = JsonConvert.SerializeObject(mostBussiestEmployees, Formatting.Indented);

            return json;
        }
    }
}