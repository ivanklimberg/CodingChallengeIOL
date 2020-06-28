using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using static CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Classes
{
    public class TraductorFrances : ITraductor
    {
        public Idioma Idioma => Idioma.Frances;

        public Dictionary<Traduccion, string> Traducciones => new Dictionary<Traduccion, string>
        {
            { Traduccion.ListaVacia, "Liste vide de formes!" },
            { Traduccion.TituloReporte, "Rapport de formulaire" },
            { Traduccion.Formas, "formes" },
            { Traduccion.Perimetro, "Périmètre" },
            { Traduccion.Area, "Zone" }
        };

        public string Traducir(Traduccion key)
        {
            var traduccion = Traducciones.FirstOrDefault(x => x.Key == key);
            if (traduccion.Value == null) throw new ArgumentOutOfRangeException("Traduction introuvable");
            return traduccion.Value;
        }

        public string TraducirFormas(TipoFormaGeometrica tipoFormaGeometrica, int cantidad)
        {
            bool masDeUno = cantidad > 1;
            switch (tipoFormaGeometrica)
            {
                case TipoFormaGeometrica.Circulo:
                    return masDeUno ?
                        "Cercles" :
                        "Cercle";
                case TipoFormaGeometrica.Cuadrado:
                    return masDeUno ?
                        "Carrés" :
                        "Carré";
                case TipoFormaGeometrica.TrianguloEquilatero:
                    return masDeUno ?
                        "Triangles" :
                        "Triangle";
                case TipoFormaGeometrica.Trapecio:
                    return masDeUno ?
                        "Trapézoïdes" :
                        "Trapèze";
                case TipoFormaGeometrica.Rectangulo:
                    return masDeUno ?
                        "Rectangles" :
                        "Rectangle";
                default:
                    throw new Exception($"Traduction introuvable pour le formulaire {tipoFormaGeometrica}");

            }
        }
    }
}
