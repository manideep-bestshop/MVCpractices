using CodeFirstApproach.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }

    }
}
