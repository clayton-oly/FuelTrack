using FuelTrack.Data;
using FuelTrack.Interfaces;
using FuelTrack.Models;

namespace FuelTrack.Repository
{
    public class AbastecimentoRepository : IAbastecimentoRepository
    {
        private readonly AppDbContext _context;

        public AbastecimentoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Abastecimento> GetAll()
        {
            return _context.Abastecimentos.ToList();
        }

        public Abastecimento GetLast()
        {
            return _context.Abastecimentos.OrderByDescending(a => a.CreatedAt).FirstOrDefault();
        }

        public Abastecimento GetById(Guid id)
        {
            return _context.Abastecimentos.Find(id);
        }

        public void Post(Abastecimento abastecimento)
        {
            _context.Abastecimentos.Add(abastecimento);
            _context.SaveChanges();
        }
    }
}
