using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetProject.Areas.Identity;

namespace PetProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TableEmployees>().Property(z => z.Id).UseIdentityColumn();
            builder.Entity<TableEmployees>().Property(z => z.LastName).HasMaxLength(30);
            builder.Entity<TableEmployees>().Property(z => z.FirstName).HasMaxLength(30);
            builder.Entity<TableEmployees>().Property(z => z.jobTitel).HasMaxLength(30);

            base.OnModelCreating(builder);
        }

        public DbSet<TableProjects?> tableProjects { get; set; }

        public DbSet<TableTasks?> tableTasks { get; set; }

        public DbSet<TableEmployees?> tableEmployees { get; set; }
    }
}
