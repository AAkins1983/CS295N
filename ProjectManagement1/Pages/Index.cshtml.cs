using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectManagement1.Models;

namespace ProjectManagement1.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly ProjectManagement1.Models.ProjectContext _context;

        public IndexModel(ProjectManagement1.Models.ProjectContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; }

        public async Task OnGetAsync()
        {
            Project = await _context.Project.ToListAsync();
        }
    }
}
