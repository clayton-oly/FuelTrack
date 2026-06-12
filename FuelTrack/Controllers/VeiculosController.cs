using FuelTrack.DTOs;
using FuelTrack.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FuelTrack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculosController : ControllerBase
    {
        private readonly VeiculoRepository _veiculoRepository;

        public VeiculosController(VeiculoRepository veiculoRepository)
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
                Tanque = veiculo.Tanque,
                //TipoCombustivel = veiculo.TipoCombustivel
            };
        }
    }
}
