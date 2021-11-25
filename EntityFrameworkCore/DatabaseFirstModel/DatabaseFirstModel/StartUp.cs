using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Scaffold-DbContext 'Server=.;Database=SoftUni;Integrated Security=True;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data/Models

            SoftUniContext result = new SoftUniContext();

            //Console.WriteLine(GetEmployeesFullInformation(result));

            //Console.WriteLine(GetEmployeesWithSalaryOver50000(result));

            //Console.WriteLine(GetEmployeesFromResearchAndDevelopment(result));

            //Console.WriteLine(AddNewAddressToEmployee(result));

            //Console.WriteLine(GetEmployeesInPeriod(result));

            //Console.WriteLine(GetAddressesByTown(result));

            //Console.WriteLine(GetEmployee147(result));

            //Console.WriteLine(GetDepartmentsWithMoreThan5Employees(result));

            //Console.WriteLine(GetLatestProjects(result));

            //Console.WriteLine(IncreaseSalaries(result));

            //Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(result));

            //Console.WriteLine(RemoveTown(result));

            Console.WriteLine(DeleteProjectById(result));
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            Employee[] employees = context.Employees
                .OrderBy(e => e.EmployeeId)
                .ToArray();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            Employee[] employees = context.Employees
                .Where(e => e.Salary > 50000)
                .OrderBy(e => e.FirstName)
                .ToArray();

            //var employees = context.Employees
            //    .Where(e => e.Salary > 50000)
            //    .Select(e => new
            //    {
            //        e.FirstName,
            //        e.Salary
            //    })
            //    .ToArray();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} - {e.Salary:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            //List<Employee> employees = context.Employees
            //    .Where(e => e.Department.Name == "Research and Development")
            //    .OrderBy(e => e.Salary).ThenByDescending(e => e.FirstName)
            //    .ToList();

            var employees = context.Employees
                .Where(e => e.Department.Name == "Research and Development")   // IQueryable
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)                            // IQueryable   
                .Select(e => new                                               // IQueryable
                { 
                    e.FirstName,
                    e.LastName,
                    DepartmentName = e.Department.Name,
                    e.Salary
                })
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - {e.Salary:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Address newAddress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.Addresses.Add(newAddress);

            Employee nakov = context.Employees
                .Where(e => e.LastName == "Nakov")
                .First();

            nakov.Address = newAddress;
            context.SaveChanges();

            var employeesAddresses = context.Employees
                .OrderByDescending(e => e.AddressId)
                .Select(e => e.Address.AddressText)
                .Take(10)
                .ToArray();

            return string.Join(Environment.NewLine, employeesAddresses);
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.EmployeesProjects
                    .Any(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003))
                .Take(10)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstName = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    Projects = e.EmployeesProjects
                        .Select(ep => new
                        {
                            ProjectName = ep.Project.Name,
                            StartDate = ep.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                            EndDate = ep.Project.EndDate.HasValue
                           ? ep.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                           : "not finished"
                        })
                        .ToArray()
                })
                .ToList();
            

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                string managerFullName = $"{employee.ManagerFirstName} {employee.ManagerLastName}";

                sb.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {managerFullName}");

                foreach (var projects in employee.Projects)
                {
                    sb.AppendLine($"--{projects.ProjectName} - {projects.StartDate} - {projects.EndDate}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                //.Select(a => new
                //{
                //    a.Town.Name,
                //    a.AddressText,
                //    a.Employees.Count
                //})
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(a => a.Town.Name)
                .ThenBy(a => a.AddressText)
                .Select(a => new
                {
                    a.Town.Name,
                    a.AddressText,
                    a.Employees.Count
                })
                .Take(10)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var a in addresses)
            {
                sb.AppendLine($"{a.AddressText}, {a.Name} - {a.Count} employees");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            Employee employee = context.Employees
                .FirstOrDefault(e => e.EmployeeId == 147);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            foreach (var p in employee.EmployeesProjects.OrderBy(p => p.Project.Name))
            {
                sb.AppendLine($"{p.Project.Name}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    DepartmentName = d.Name,
                    ManagerFirstName = d.Manager.FirstName,
                    ManagerLastName = d.Manager.LastName,
                    SelectedEmployee = d.Employees
                        .Select(e => new
                        {
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            JobTitle = e.JobTitle
                        })
                        .OrderBy(e => e.FirstName)
                        .ThenBy(e => e.LastName)
                        .ToArray()
                })
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var d in departments)
            {
                sb.AppendLine($"{d.DepartmentName} - {d.ManagerFirstName} {d.ManagerLastName}");

                foreach (var e in d.SelectedEmployee)
                {
                    sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var projects = context.Projects
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    StartDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                })
                .OrderBy(p => p.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var p in projects)
            {
                sb.AppendLine(p.Name);
                sb.AppendLine(p.Description);
                sb.AppendLine(p.StartDate);
            }

            return sb.ToString().TrimEnd();
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            IQueryable<Employee> employees = context.Employees
                .Where(e => e.Department.Name == "Engineering" || e.Department.Name == "Tool Design" ||
                    e.Department.Name == "Marketing" || e.Department.Name == "Information Services");

            foreach (var e in employees)
            {
                e.Salary += e.Salary * 0.12m;
            }

            context.SaveChanges();

            var employeesToDisplay = employees
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var e in employeesToDisplay)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary:F2})");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.FirstName.ToLower().StartsWith("sa"))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:F2})");
            }

            return sb.ToString().TrimEnd();
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            Project projectWithId2 = context.Projects
                .First(p => p.ProjectId == 2);

            var employeesProjects = context.EmployeesProjects
                .Where(p => p.ProjectId == 2)
                .ToArray();

            context.EmployeesProjects.RemoveRange(employeesProjects);
            context.Projects.Remove(projectWithId2);
            context.SaveChanges();

            var projectsToDisplay = context.Projects
                .Take(10)
                .Select(p => p.Name)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var p in projectsToDisplay)
            {
                sb.AppendLine(p);
            }

            return sb.ToString().TrimEnd();
        }

        public static string RemoveTown(SoftUniContext context)
        {
            Address[] seattleAddresses = context.Addresses
                .Where(a => a.Town.Name == "Seattle")
                .ToArray();

            Employee[] employees = context.Employees
                .ToArray()
                .Where(e => seattleAddresses.Any(a => a.AddressId == e.AddressId))
                .ToArray();

            foreach (var e in employees)
            {
                e.AddressId = null;
            }

            context.Addresses.RemoveRange(seattleAddresses);

            Town seattleTown = context
                .Towns
                .First(t => t.Name == "Seattle");
            context.Towns.Remove(seattleTown);

            context.SaveChanges();

            return $"{seattleAddresses.Length} addresses in Seattle were deleted";
        }
    }
}
