using CodingChallenge.Data.Classes.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.GeometricShapes
{
    class Circulo : ICalculosGeometricos
    {
        private readonly decimal _lado;

        private readonly TipoFormasEnum _tipo = TipoFormasEnum.Circulo;

        TipoFormasEnum ICalculosGeometricos.Tipo
        {
            get
            {
                return _tipo;
            }
        }

        public Circulo(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
    }
}
