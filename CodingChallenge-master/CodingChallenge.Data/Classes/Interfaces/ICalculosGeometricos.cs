using System;
using System.Collections.Generic;


namespace CodingChallenge.Data.Classes.Interfaces
{
    public interface ICalculosGeometricos
    {
        TipoFormasEnum Tipo { get; }

        decimal CalcularArea();

        decimal CalcularPerimetro();
    }
}
