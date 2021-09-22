using EstacionaAki.Models;
using Microsoft.EntityFrameworkCore;

namespace EstacionaAki.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<ItemFaturamento> ItemFaturamentos { get; set; }
        public DbSet<ModeloVeiculo> ModeloVeiculos { get; set; }
    }
}