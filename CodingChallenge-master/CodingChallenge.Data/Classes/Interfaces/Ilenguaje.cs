using System;
using System.Collections.Generic;


namespace CodingChallenge.Data.Classes.Interfaces
{
    public interface Ilenguaje
    {
        IdiomasEnum idioma { get; }

        string ListaVacia();

        string ReporteFormas();

        string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFormasEnum tipo);

        string TraducirForma(TipoFormasEnum tipo, int cantidad);

        string Footer(int totalFormas, decimal totalPerimetro, decimal totalArea);
    }
}
