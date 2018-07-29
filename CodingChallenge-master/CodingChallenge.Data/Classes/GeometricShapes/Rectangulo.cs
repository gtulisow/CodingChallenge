using CodingChallenge.Data.Classes.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.GeometricShapes
{
    class Rectangulo : ICalculosGeometricos
    {
        private readonly decimal _base;

        private readonly decimal _altura;

        private readonly TipoFormasEnum _tipo = TipoFormasEnum.Rectangulo;

        public TipoFormasEnum Tipo
        {
            get
            {
                return _tipo;
            }
        }

        public Rectangulo(decimal ancho, decimal altura)
        {
            _base = ancho;
            _altura = altura;
        }

        public decimal CalcularArea()
        {
            return _base * _altura;
        }

        public decimal CalcularPerimetro()
        {
            return (_base + _altura) * 2;
        }
    }
}
