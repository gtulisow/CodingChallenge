using CodingChallenge.Data.Classes.Interfaces;
using System;


namespace CodingChallenge.Data.Classes.GeometricShapes
{
    class TrianguloEquilatero : ICalculosGeometricos
    {
        private readonly decimal _lado;

        private readonly TipoFormasEnum _tipo = TipoFormasEnum.TrianguloEquilatero;

        TipoFormasEnum ICalculosGeometricos.Tipo
        {
            get
            {
                return _tipo;
            }
            
        }

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}
