using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace ProjectManagement1.Pages.Projects
{
    public class SearchModel : PageModel
    {
        private readonly ProjectManagement1.Models.ProjectContext _context;

        public SearchModel(ProjectManagement1.Models.ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Project Proj { get; set; }
        public IList<Project> Project { get; set; }
        public SelectList PStatus;
        public string ProjectStatus { get; set; }

        public async Task OnGetAsync(string projectStatus, string nameSearchString, string managerSearchString, string techSearchString)
        {         
            IQueryable<string> statusQuery = from p in _context.Project
                                             orderby p.Status
                                             select p.Status;

            var projects = from p in _context.Project
                           select p;

            if (!String.IsNullOrEmpty(nameSearchString))
            {
                projects = projects.Where(s => s.ProjectName.Contains(nameSearchString));
            }

            if (!String.IsNullOrEmpty(managerSearchString))
            {
                projects = projects.Where(s => s.ProjectManager.Contains(managerSearchString));
            }

            if (!String.IsNullOrEmpty(techSearchString))
            {
                projects = projects.Where(s => s.TechLead.Contains(techSearchString));
            }

            if (!String.IsNullOrEmpty(projectStatus))
            {
                projects = projects.Where(x => x.Status == projectStatus);
            }

            PStatus = new SelectList(await statusQuery.Distinct().ToListAsync());

            Project = await projects.ToListAsync();
            //Project = await _context.Project.ToListAsync();
        }
    }
}
