using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class CompanyDBContext:DbContext
    {
        public CompanyDBContext()
        {
        }

        public CompanyDBContext(DbContextOptions<CompanyDBContext> options) : base(options) { }
        public DbSet<Employee> employee { get; set; }
        public DbSet<Department> department { get; set; }
        public DbSet<Company> company { get; set; }

    }
}
