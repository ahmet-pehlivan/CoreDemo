using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    //server=AHMET;database=CoreBlogApiDb; integrated security = true;
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-O1CC06C;Initial Catalog=CoreBlogApiDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

