using asp01_efc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace asp01_efc.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }//constructor
        
            public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    
    }
}
