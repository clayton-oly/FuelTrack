using FuelTrack.Models;

namespace FuelTrack.DTOs
{
    public class AbastecimentoDTO
    {
        public Guid Id { get; set; }
        public Guid VeiculoId { get; set; }
        public decimal OdometroKm { get; set; }
        public decimal Litros { get; set; }
        public decimal PrecoTotal { get; set; }
        public decimal PrecoCombustivel { get; set; }
        public bool IsTanqueCompleto { get; set; }
        public string Anotacoes { get; set; }
        public decimal Consumo { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
