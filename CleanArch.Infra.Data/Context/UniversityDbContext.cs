using CleanArch.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Course> Courses { get; set; }
    }
}
