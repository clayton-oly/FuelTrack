using FuelTrack.DTOs;
using FuelTrack.Interfaces;
using FuelTrack.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuelTrack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IEnumerable<UsuarioDTO> GetAll()
        {
            return _usuarioRepository.GetAll().Select(v => new UsuarioDTO
            {
                Id = v.Id,
            });
        }

        [HttpGet("id")]
        public UsuarioDTO GetById(Guid id)
        {
            var usuario = _usuarioRepository.GetById(id);

            return new UsuarioDTO
            {
                Id = usuario.Id,
            };
        }

        [HttpPost]
        public IActionResult Post(UsuarioDTO usuarioDTO)
        {
            var usuario = new Usuario
            {
                Id = Guid.NewGuid(),
            };

            _usuarioRepository.Post(usuario);

            return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
        }
    }
}
