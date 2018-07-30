using CodingChallenge.Data.Classes.Interfaces;
using System;


namespace CodingChallenge.Data.Classes.GeometricShapes
{
    class TrapecioRectangulo : ICalculosGeometricos
    {
        private readonly decimal _baseMenor;
        private readonly decimal _baseMayor;
        private readonly decimal _altura;

        private readonly TipoFormasEnum _tipo = TipoFormasEnum.TrapecioRectangulo;

        public TipoFormasEnum Tipo
        {
            get
            {
                return _tipo;
            }
        }

        public TrapecioRectangulo(decimal baseMenor, decimal baseMayor, decimal altura)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
        }

        public decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) / 2) * _altura;
        }

        public decimal CalcularPerimetro()
        {
            decimal basemenor2 = (_baseMayor - _baseMenor) * (_baseMayor - _baseMenor);
            decimal baseAltura = ((_altura * _altura) + (basemenor2));
            decimal ladoOblicuo = (decimal) Math.Sqrt((double)baseAltura);

            return _baseMenor + _altura + _baseMayor + ladoOblicuo;
        }
    }
}
