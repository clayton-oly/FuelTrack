using FuelTrack.Models;

namespace FuelTrack.Interfaces
{
    public interface IUsuarioRepository
    {
        public IEnumerable<Usuario> GetAll();

        public Usuario GetById(Guid id);

        public void Post(Usuario usuario);
    }
}
