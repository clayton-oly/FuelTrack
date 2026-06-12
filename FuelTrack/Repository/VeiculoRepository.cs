using FuelTrack.Data;
using FuelTrack.Models;

namespace FuelTrack.Repository
{
    public class VeiculoRepository
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
    }
}
