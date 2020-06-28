using System.Collections.Generic;
using static CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Interfaces
{
    public interface ITraductor
    {
        Idioma Idioma { get; }
        Dictionary<Traduccion, string> Traducciones { get; }
        string TraducirFormas(TipoFormaGeometrica tipoFormaGeometrica, int cantidad);
        string Traducir(Traduccion key);
    }
}
