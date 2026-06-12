using FuelTrack.Models;

namespace FuelTrack.Interfaces
{
    public interface IAbastecimentoRepository
    {
        public IEnumerable<Abastecimento> GetAll();

        public Abastecimento GetById(Guid id);

        public void Post(Abastecimento abastecimento);
    }
}
