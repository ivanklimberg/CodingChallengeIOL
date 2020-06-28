using CodingChallenge.Data.Interfaces;
using static CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : IFormaGeometrica
    {
        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.Rectangulo;
        public decimal Lado { get; }
        public decimal Piso { get; }

        public Rectangulo(decimal lado, decimal piso)
        {
            Lado = lado;
            Piso = piso;
        }
        public decimal CalcularArea() => (Piso * Lado);
        public decimal CalcularPerimetro() => (Piso * 2 + Lado * 2);
    }
}
