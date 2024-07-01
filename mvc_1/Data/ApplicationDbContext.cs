using Microsoft.EntityFrameworkCore;
using mvc_1.Models;
using mvc_1.Models.Entities;

namespace mvc_1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        
    }
}
