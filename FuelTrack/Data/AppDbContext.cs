using FuelTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace FuelTrack.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Abastecimento> Abastecimentos { get; set; }
    }
}
