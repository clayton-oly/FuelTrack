using FuelTrack.Data;
using FuelTrack.Interfaces;
using FuelTrack.Models;

namespace FuelTrack.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetById(Guid id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Post(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }
    }
}
