using Microsoft.EntityFrameworkCore;

namespace ProjectManagement1.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
                : base(options)
        {
        }

        public DbSet<Project> Project { get; set; }
    }
}
