using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Web.Models.Entities
{
    [Keyless]
    public class Department
    {
        // primary key
        
        public Guid DeptId { get; set; }  
        public string? DeptName { get; set; } 
    }
}
