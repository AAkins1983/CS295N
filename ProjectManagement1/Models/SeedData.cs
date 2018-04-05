using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ProjectManagement1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectContext(
                serviceProvider.GetRequiredService<DbContextOptions<ProjectContext>>()))
            {
                // Look for projects.
                if (context.Project.Any())
                {
                    return;   // DB has been seeded
                }

                context.Project.AddRange(
                    new Project
                    {
                        ProjectName = "OnBase Upgrade",
                        Description = "Upgrade OnBase system to version 2017.",
                        ProjectManager = "Bobby",
                        TechLead = "Kirby",
                        Status = "At Risk",
                        StartDate = DateTime.Parse("2017-01-01"),
                        DueDate = DateTime.Parse ("2018-01-01")
                    },

                    new Project
                    {
                        ProjectName = "WCM User Site",
                        Description = "Develop SharePoint site for Workflow and Content Management providing user training documents.",
                        ProjectManager = "Cicely",
                        TechLead = "Amanda",
                        Status = "On Track",
                        StartDate = DateTime.Parse("2017-05-05"),
                        DueDate = DateTime.Parse("2018-05-05")
                    },

                    new Project
                    {
                        ProjectName = "CRM Deployment",
                        Description = "Deploy and implement the use of CRM system for all lines of business.",
                        ProjectManager = "Bobby",
                        TechLead = "Luke",
                        Status = "Significant risk",
                        StartDate = DateTime.Parse("2017-07-07"),
                        DueDate = DateTime.Parse("2018-07-07") 
                    },

                    new Project
                    {
                        ProjectName = "Marketing and Communications Workfront",
                        Description = "Deploy and implement the use of Workfront software for Markting and Communications.",
                        ProjectManager = "Bobby",
                        TechLead = "Kris",
                        Status = "On Track",
                        StartDate = DateTime.Parse("2017-09-09"),
                        DueDate = DateTime.Parse("2018-09-09")
                    },

                    new Project
                    {
                        ProjectName = "New Project",
                        Description = "New project description.",
                        ProjectManager = "Elmo",
                        TechLead = "Big Bird",
                        Status = "On Hold",
                        StartDate = DateTime.Parse("2017-09-09"),
                        DueDate = DateTime.Parse("2018-09-09")
                    },

                    new Project
                    {
                        ProjectName = "Another New Project",
                        Description = "Another new project description.",
                        ProjectManager = "Flavor Flav",
                        TechLead = "Reverand Run",
                        Status = "Cancelled",
                        StartDate = DateTime.Parse("2017-09-09"),
                        DueDate = DateTime.Parse("2018-09-09")
                    },

                    new Project
                    {
                        ProjectName = "Test",
                        Description = "Test.",
                        ProjectManager = "Test",
                        TechLead = "Test",
                        Status = "Complete",
                        StartDate = DateTime.Parse("2017-09-09"),
                        DueDate = DateTime.Parse("2018-09-09")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
