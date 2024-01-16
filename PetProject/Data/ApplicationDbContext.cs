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
            builder.Entity<TableEmployees>().Property(z => z.JobTitel).HasMaxLength(30);

            base.OnModelCreating(builder);
        }

        public DbSet<TableProjects> TableProjects { get; set; }

        public DbSet<TableTasks> TableTasks { get; set; }

        public DbSet<TableEmployees> TableEmployees { get; set; }
    }
}
