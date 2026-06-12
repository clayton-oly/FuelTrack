using FuelTrack.Models;

namespace FuelTrack.Interfaces
{
    public interface IVeiculoRepository
    {
        public IEnumerable<Veiculo> GetAll();

        public Veiculo GetById(Guid id);

        public void Post(Veiculo veiculo);
    }
}
