using Microsoft.EntityFrameworkCore;

namespace MiniApi.Model
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {

        }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; } //require dor our code to generete employee table on the database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettigs.json")
                .Build();
            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
