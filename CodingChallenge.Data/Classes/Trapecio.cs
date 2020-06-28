using CodingChallenge.Data.Interfaces;
using System;
using static CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : IFormaGeometrica
    {
        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.Trapecio;

        //LATERAL IZQUIERDO
        public decimal Lado { get; }
        public decimal LateralDerecho { get; }
        public decimal Piso { get; }
        public decimal Techo { get; }

        public Trapecio(decimal techo, decimal piso, decimal lateralIzquierdo, decimal lateralDerecho)
        {
            Techo = techo;
            Piso = piso;
            Lado = lateralIzquierdo;
            LateralDerecho = lateralDerecho;
        }

        public decimal CalcularArea()
        {
            //Convierto a double todos para evitar castear mas adelante
            double lateralIzq = (double)Lado;
            double lateralDer = (double)LateralDerecho;
            double piso = (double)Piso;
            double techo = (double)Techo;

            double firstTerm = ((piso + piso) / 2);
            double secondTerm = Math.Pow(lateralIzq, 2);
            double thirdTerm =
                Math.Pow(
                    (Math.Pow(lateralIzq, 2) -
                    Math.Pow(lateralDer, 2) +
                    Math.Pow((piso - techo), 2)) /
                    (2 * (piso - techo)),
                2);

            double area =
                firstTerm +
                Math.Sqrt(
                    secondTerm -
                    thirdTerm
                );

            return Convert.ToDecimal(area);
        }

        public decimal CalcularPerimetro() => (Lado + LateralDerecho + Piso + Techo);
    }
}
