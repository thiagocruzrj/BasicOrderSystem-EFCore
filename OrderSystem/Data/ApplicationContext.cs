using Microsoft.EntityFrameworkCore;
using OrderSystem.Data.Configuration;
using OrderSystem.Domain;

namespace OrderSystem.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CursoEFCore;Integrated Security=true"); //Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}