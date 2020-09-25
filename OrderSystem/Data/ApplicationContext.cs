using Microsoft.EntityFrameworkCore;

namespace OrderSystem.Data
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\msqllocaldb;Initial Catalog=CursoEFCore;Integrated Security=true");
        }
    }
}