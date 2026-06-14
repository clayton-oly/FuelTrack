using FuelTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace FuelTrack.Interfaces
{
    public interface IAbastecimentoRepository
    {
        public IEnumerable<Abastecimento> GetAll();
        public Abastecimento GetLast();

        public Abastecimento GetById(Guid id);

        public void Post(Abastecimento abastecimento);
    }
}
