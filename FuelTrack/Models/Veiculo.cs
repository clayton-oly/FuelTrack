namespace FuelTrack.Models
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public double Tanque { get; set; }
        public TipoCombustivel TipoCombustivel { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Diesel,
        Eletrico
    }
}
