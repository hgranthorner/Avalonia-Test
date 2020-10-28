using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Models
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {
        }

        public AppDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            if (!optionbuilder.IsConfigured)
            {   
                optionbuilder.UseSqlite(@"Data Source=C:\Users\Grant\Dev\MyApp\Data.db");
            }
        }

        public DbSet<Todo> Todos { get; set; }
    }
}