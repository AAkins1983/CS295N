using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectManagement1.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectManagement1.Pages.Projects
{
    public class CreateModel : PageModel
    {
        private readonly ProjectManagement1.Models.ProjectContext _context;

        public CreateModel(ProjectManagement1.Models.ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Project Project { get; set; }
        //public SelectList PStatus;
        //public string ProjectStatus { get; set; }

        //public async Task OnGetAsync(string projectStatus)
        //{
        //    IQueryable<string> projectQuery = from p in _context.Project
        //                                      orderby p.Status
        //                                      select p.Status;

        //    var projects = from p in _context.Project
        //                   select p;

        //    PStatus = new SelectList(await projectQuery.Distinct().ToListAsync());
        //}

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Project.Add(Project);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}