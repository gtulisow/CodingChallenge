using CodingChallenge.Data.Classes.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.GeometricShapes
{
    class Cuadrado : ICalculosGeometricos
    {
        private readonly decimal _lado;

        private readonly TipoFormasEnum _tipo = TipoFormasEnum.Cuadrado;

        TipoFormasEnum ICalculosGeometricos.Tipo
        {
            get
            {
                return _tipo;
            }
            
        }

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
