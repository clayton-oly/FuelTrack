using FuelTrack.DTOs;
using FuelTrack.Interfaces;
using FuelTrack.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuelTrack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AbastecimentosController : ControllerBase
    {
        private readonly IAbastecimentoRepository _abastecimentoRepository;

        public AbastecimentosController(IAbastecimentoRepository abastecimentoRepository)
        {
            _abastecimentoRepository = abastecimentoRepository;
        }

        [HttpGet]
        public IEnumerable<AbastecimentoDTO> GetAll()
        {
            return _abastecimentoRepository.GetAll().Select(v => new AbastecimentoDTO
            {
                Id = v.Id,
            });
        }

        [HttpGet("id")]
        public AbastecimentoDTO GetById(Guid id)
        {
            var veiculo = _abastecimentoRepository.GetById(id);

            return new AbastecimentoDTO
            {
                Id = veiculo.Id,
            };
        }

        [HttpPost]
        public IActionResult Post(AbastecimentoDTO abastecimentoDTO)
        {
            var abastecimento = new Abastecimento
            {
                Id = Guid.NewGuid(),
                VeiculoId = abastecimentoDTO.VeiculoId,
                PrecoTotal = abastecimentoDTO.PrecoTotal,
                Anotacoes = abastecimentoDTO.Anotacoes,
                IsTanqueCompleto = abastecimentoDTO.IsTanqueCompleto,
                OdometroKm = abastecimentoDTO.OdometroKm,
                Litros = abastecimentoDTO.Litros,
                PrecoCombustivel = abastecimentoDTO.PrecoCombustivel,
                //CreatedAt = DateTime.UtcNow
            };

            _abastecimentoRepository.Post(abastecimento);

            return CreatedAtAction(nameof(GetById), new { id = abastecimento.Id }, abastecimento);
        }
    }
}
