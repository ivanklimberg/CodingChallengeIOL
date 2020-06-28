using static CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Interfaces
{
    public interface IFormaGeometrica
    {
        TipoFormaGeometrica Tipo { get; }
        decimal Lado { get; }
        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}
