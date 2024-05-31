using Microsoft.EntityFrameworkCore;
using DeMariaSoftware.Entities;
using System.Configuration;

namespace DeMariaSoftware.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ItensVenda> ItensVenda { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Venda> Venda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseNpgsql(ConfigurationManager.AppSettings["ConnectionString"]);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ItensVenda>()
                .HasOne(iv => iv.Venda)
                .WithMany(v => v.ItensVenda)
                .HasForeignKey(iv => iv.VendaId);

            modelBuilder.Entity<ItensVenda>()
                .HasOne(iv => iv.Produto)
                .WithMany(p => p.ItensVenda)
                .HasForeignKey(iv => iv.ProdutoId);

            modelBuilder.Entity<Venda>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.Vendas)
                .HasForeignKey(v => v.ClienteId);
        }
    }
}