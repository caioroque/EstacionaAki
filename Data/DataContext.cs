using Microsoft.EntityFrameworkCore;
using EstacionaAki.Models;

namespace EstacionaAki.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<ItemFaturamento> ItemFaturamentos { get; set; }
        public DbSet<VagaEstacionamento> Vagas { get; set; }
        public DbSet<MarcaVeiculo> Marcas { get; set; }
        public DbSet<ModeloVeiculo> Modelos { get; set; }
    }
}