using FuelTrack.DTOs;
using FuelTrack.Interfaces;
using FuelTrack.Models;
using FuelTrack.Repository;
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
                UsuarioId = v.UsuarioId,
                Nome = v.Nome,
                Marca = v.Marca,
                Modelo = v.Modelo,
                Ano = v.Ano,
                TanqueCapacidade = v.TanqueCapacidade,
                TipoCombustivel = v.TipoCombustivel,
                CreatedAt = v.CreatedAt
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

        [HttpPost]
        public IActionResult Post(VeiculoDTO veiculoDTO)
        {
            var veiculo = new Veiculo
            {
                Id = Guid.NewGuid(),
                UsuarioId = veiculoDTO.UsuarioId,
                Nome = veiculoDTO.Nome,
                Marca = veiculoDTO.Marca,
                Modelo = veiculoDTO.Modelo,
                Ano = veiculoDTO.Ano,
                TanqueCapacidade = veiculoDTO.TanqueCapacidade,
                TipoCombustivel = veiculoDTO.TipoCombustivel,
                CreatedAt = veiculoDTO.CreatedAt
            };

            _veiculoRepository.Post(veiculo);

            return CreatedAtAction(nameof(GetById), new { id = veiculo.Id }, veiculo);
        }
    }
}
