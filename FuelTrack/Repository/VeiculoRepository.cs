using FuelTrack.Data;
using FuelTrack.Interfaces;
using FuelTrack.Models;

namespace FuelTrack.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly AppDbContext _context;

        public VeiculoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Veiculo> GetAll()
        {
            return _context.Veiculos.ToList();
        }

        public Veiculo GetById(Guid id)
        {
            return _context.Veiculos.Find(id);
        }

        public void Post(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
        }
    }
}
