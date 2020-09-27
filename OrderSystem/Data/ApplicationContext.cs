using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderSystem.Data.Configuration;
using OrderSystem.Domain;

namespace OrderSystem.Data
{
    public class ApplicationContext : DbContext
    {
        private static readonly ILoggerFactory _logger = LoggerFactory.Create(p => p.AddConsole());
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(_logger)
                .EnableSensitiveDataLogging()
                .UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CursoEFCore;Integrated Security=true"); //Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}