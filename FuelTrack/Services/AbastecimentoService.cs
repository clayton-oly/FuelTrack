using FuelTrack.DTOs;
using FuelTrack.Interfaces;
using FuelTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace FuelTrack.Services
{
    public class AbastecimentoService
    {
        private readonly IAbastecimentoRepository _abastecimentoRepository;

        public AbastecimentoService(IAbastecimentoRepository abastecimentoRepository)
        {
            _abastecimentoRepository = abastecimentoRepository;
        }

        public AbastecimentoDTO GetLast()
        {
            var abastecimento = _abastecimentoRepository.GetLast();
            
            return new AbastecimentoDTO
            {
                Id = abastecimento.Id,
                VeiculoId = abastecimento.VeiculoId,
                PrecoTotal = abastecimento.PrecoTotal,
                Anotacoes = abastecimento.Anotacoes,
                IsTanqueCompleto = abastecimento.IsTanqueCompleto,
                OdometroKm = abastecimento.OdometroKm,
                Litros = abastecimento.Litros,
                PrecoCombustivel = abastecimento.PrecoCombustivel,
                Consumo = abastecimento.OdometroKm / abastecimento.Litros,
                CreatedAt = abastecimento.CreatedAt
            };
        }

        public IEnumerable<AbastecimentoDTO> GetAll()
        {
            return _abastecimentoRepository.GetAll().Select(v => new AbastecimentoDTO
            {
                Id = v.Id,
                VeiculoId = v.VeiculoId,
                PrecoTotal = v.PrecoTotal,
                Anotacoes = v.Anotacoes,
                IsTanqueCompleto = v.IsTanqueCompleto,
                OdometroKm = v.OdometroKm,
                Litros = v.Litros,
                PrecoCombustivel = v.PrecoCombustivel,
                Consumo = v.OdometroKm / v.Litros,
                CreatedAt = v.CreatedAt
            });
        }
    }
}
