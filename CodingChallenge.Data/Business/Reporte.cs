using CodingChallenge.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Business
{
    public class Reporte
    {
        private ITraductor Traductor;
        public Reporte(ITraductor traductor)
        {
            Traductor = traductor;
        }
        public string Imprimir(IEnumerable<IFormaGeometrica> formas)
        {
            var sb = new StringBuilder();
            if (!formas.Any())
            {
                //TEXTO DE LISTA VACIA
                sb.Append($"<h1>{Traductor.Traducir(Traduccion.ListaVacia)}</h1>");
                return sb.ToString();
            }
            //HEADER
            sb.Append($"<h1>{Traductor.Traducir(Traduccion.TituloReporte)}</h1>");
            var tipos = formas.Select(x => x.Tipo).Distinct();
            decimal perimetroTotal = 0;
            decimal areaTotal = 0;
            foreach(var tipo in tipos)
            {
                var formasByTipo = formas.Where(x => x.Tipo == tipo);
                decimal area = 0;
                decimal perimetro = 0;
                foreach(var forma in formasByTipo)
                {
                    area += forma.CalcularArea();
                    perimetro += forma.CalcularPerimetro();
                }
                //SUMO AL TOTAL GENERAL
                perimetroTotal += perimetro;
                areaTotal += area;
                //OBTENGO LINEA
                string linea = obtenerLinea(tipo, area, perimetro, formasByTipo.Count());
                sb.Append(linea);
            }

            //AGREGO TOTALES
            sb.Append("TOTAL:<br/>");
            sb.Append($"{formas.Count()} {Traductor.Traducir(Traduccion.Formas)} ");
            sb.Append($"{Traductor.Traducir(Traduccion.Perimetro)} {perimetroTotal:#.##} ");
            sb.Append($"{Traductor.Traducir(Traduccion.Area)} {areaTotal:#.##}");

            return sb.ToString();
        }

        private string obtenerLinea(TipoFormaGeometrica tipo, decimal area, decimal perimetro, int cantidad)
        {
            if (cantidad <= 0) return string.Empty;
            return 
                $"{cantidad} {Traductor.TraducirFormas(tipo, cantidad)} " +
                $"| {Traductor.Traducir(Traduccion.Area)} {area:#.##} " +
                $"| {Traductor.Traducir(Traduccion.Perimetro)} {perimetro:#.##} <br/>";
        }
    }
}
