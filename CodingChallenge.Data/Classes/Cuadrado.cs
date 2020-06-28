using CodingChallenge.Data.Interfaces;
using static CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : IFormaGeometrica
    {
        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.Cuadrado;
        public decimal Lado { get; }
        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }

        public decimal CalcularArea() => (Lado * Lado);
        public decimal CalcularPerimetro() => (Lado * 4);
    }
}
