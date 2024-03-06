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

        // Define a method to execute the stored procedure
        public IList<Student> GetStudents()
        {
            return this.Students.FromSqlRaw("EXECUTE GetStudents").ToList();
        }
        public DbSet<Department> Departments { get; set; }

    }
}
