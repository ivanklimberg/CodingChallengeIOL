using CodingChallenge.Data.Interfaces;
using System;
using static CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.TrianguloEquilatero;
        public decimal Lado { get; }
        public TrianguloEquilatero(decimal lado)
        {
            Lado = lado;
        }
        public decimal CalcularArea() => (((decimal)Math.Sqrt(3) / 4) * Lado * Lado);
        public decimal CalcularPerimetro() => (Lado * 3);
    }
}
