using FuelTrack.DTOs;
using FuelTrack.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FuelTrack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculosController : ControllerBase
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculosController(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        [HttpGet]
        public IEnumerable<VeiculoDTO> GetAll()
        {
            return _veiculoRepository.GetAll().Select(v => new VeiculoDTO
            {
                Id = v.Id,
                Modelo = v.Modelo,
            });
        }

        [HttpGet("id")]
        public VeiculoDTO GetById(Guid id)
        {
            var veiculo =  _veiculoRepository.GetById(id);

            return new VeiculoDTO
            {
                Id = veiculo.Id,
                Modelo = veiculo.Modelo,
                TanqueCapacidade = veiculo.TanqueCapacidade,
            };
        }
    }
}
