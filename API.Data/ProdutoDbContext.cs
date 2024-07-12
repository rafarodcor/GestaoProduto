using API.Data.Mappings;
using API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ProdutoDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=yourServer;Database=yourDatabase;User ID=yourUser;Password=yourPassword");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfiguration(new ProdutoMap());
    }
}