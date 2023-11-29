using BlogApiDemo.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=NIRVANA\\SQLEXPRESS05;database=CoreBlogApiDB;integrated security=true;TrustServerCertificate=True; "); //sql e bagladık
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
