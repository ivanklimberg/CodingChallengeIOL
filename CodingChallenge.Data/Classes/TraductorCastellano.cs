using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using static CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Classes
{
    public class TraductorCastellano : ITraductor
    {
        public Idioma Idioma => Idioma.Castellano;

        public Dictionary<Traduccion, string> Traducciones => 
            new Dictionary<Traduccion, string>
            {
                { Traduccion.ListaVacia, "Lista vacía de formas!" },
                { Traduccion.TituloReporte, "Reporte de Formas" },
                { Traduccion.Formas, "formas" },
                { Traduccion.Perimetro, "Perimetro" },
                { Traduccion.Area, "Area" }
            };

        public string Traducir(Traduccion key)
        {
            var traduccion = Traducciones.FirstOrDefault(x => x.Key == key);
            if (traduccion.Value == null) throw new ArgumentOutOfRangeException("Traducción no encontrada");
            return traduccion.Value;
        }

        public string TraducirFormas(TipoFormaGeometrica tipoFormaGeometrica, int cantidad)
        {
            bool masDeUno = cantidad > 1;
            switch (tipoFormaGeometrica)
            {
                case TipoFormaGeometrica.Circulo:
                    return masDeUno ? 
                        "Círculos" : 
                        "Círculo";
                case TipoFormaGeometrica.Cuadrado:
                    return masDeUno ? 
                        "Cuadrados" : 
                        "Cuadrado";
                case TipoFormaGeometrica.TrianguloEquilatero:
                    return masDeUno ? 
                        "Triángulos" : 
                        "Triángulo";
                case TipoFormaGeometrica.Trapecio:
                    return masDeUno ?
                        "Trapecios" :
                        "Trapecio";
                case TipoFormaGeometrica.Rectangulo:
                    return masDeUno ?
                        "Rectangulos" :
                        "Rectangulo";
                default:
                    throw new Exception($"Traducción no encontrada para la forma {tipoFormaGeometrica}");

            }   
        }
    }
}
