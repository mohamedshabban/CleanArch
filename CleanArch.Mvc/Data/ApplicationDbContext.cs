using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Mvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "UniversityDbConnection",
                    x => x.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                          .MigrationsHistoryTable("__EFMigrationsHistory", "dbo"));
            }
        }
    }
}
