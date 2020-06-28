using CodingChallenge.Data.Interfaces;
using System;
using static CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.Circulo;
        public decimal Lado { get; }
        public Circulo(decimal radio)
        {
            Lado = radio;
        }

        public decimal CalcularArea() => ((decimal)Math.PI * (Lado / 2) * (Lado / 2));
        public decimal CalcularPerimetro() => ((decimal)Math.PI * Lado);
    }
}
