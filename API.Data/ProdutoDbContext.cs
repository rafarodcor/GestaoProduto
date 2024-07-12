using API.Data.Mappings;
using API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ProdutoDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //.AddJsonFile("appsettings.json")
            //.Build();
            //options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));            

            options.UseSqlServer("Server=localhost,1433;Database=Autoglass;User ID=sa;Password=sqlRRC00!");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }
    }
}
