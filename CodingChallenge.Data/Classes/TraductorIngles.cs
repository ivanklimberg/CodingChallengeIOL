using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using static CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Classes
{
    public class TraductorIngles : ITraductor
    {
        public Idioma Idioma => Idioma.Ingles;

        public Dictionary<Traduccion, string> Traducciones =>
            new Dictionary<Traduccion, string>
            {
                { Traduccion.ListaVacia, "Empty list of shapes!" },
                { Traduccion.TituloReporte, "Shapes report" },
                { Traduccion.Formas, "shapes" },
                { Traduccion.Perimetro, "Perimeter" },
                { Traduccion.Area, "Area" }
            };

        public string Traducir(Traduccion key)
        {
            var traduccion = Traducciones.FirstOrDefault(x => x.Key == key);
            if (traduccion.Value == null) throw new ArgumentOutOfRangeException("Translation not found");
            return traduccion.Value;
        }

        public string TraducirFormas(TipoFormaGeometrica tipoFormaGeometrica, int cantidad)
        {
            bool masDeUno = cantidad > 1;
            switch (tipoFormaGeometrica)
            {
                case TipoFormaGeometrica.Circulo:
                    return masDeUno ? 
                        "Circles" : 
                        "Circle";
                case TipoFormaGeometrica.Cuadrado:
                    return masDeUno ? 
                        "Squares" : 
                        "Square";
                case TipoFormaGeometrica.TrianguloEquilatero:
                    return masDeUno ? 
                        "Triangles" : 
                        "Triangle";
                case TipoFormaGeometrica.Trapecio:
                    return masDeUno ? 
                        "Trapezes" : 
                        "Trapeze";
                case TipoFormaGeometrica.Rectangulo:
                    return masDeUno ?
                        "Rectangles" :
                        "Rectangle";
                default:
                    throw new Exception($"No translation found for the shape {tipoFormaGeometrica}");

            }
        }
    }
}
