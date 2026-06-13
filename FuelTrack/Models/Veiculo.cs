namespace FuelTrack.Models
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int Ano { get; set; }
        public decimal TanqueCapacidade { get; set; }
        public string TipoCombustivel { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}

