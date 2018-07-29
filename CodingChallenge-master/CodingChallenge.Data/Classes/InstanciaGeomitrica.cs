using CodingChallenge.Data.Classes.CustomException;
using CodingChallenge.Data.Classes.GeometricShapes;
using CodingChallenge.Data.Classes.Interfaces;


namespace CodingChallenge.Data.Classes
{
    public class InstanciaGeomitrica
    {
        public ICalculosGeometricos Instancia(TipoFormasEnum forma, decimal lado, decimal baseMayor = 0, decimal altura = 0)
        {
            switch (forma)
            {
                case TipoFormasEnum.Circulo:
                    return new Circulo(lado);
                case TipoFormasEnum.Cuadrado:
                    return new Cuadrado(lado);
                case TipoFormasEnum.TrianguloEquilatero:
                    return new TrianguloEquilatero(lado);
                case TipoFormasEnum.TrapecioRectangulo:
                    return new TrapecioRectangulo(lado, baseMayor, altura);
                case TipoFormasEnum.Rectangulo:
                    return new Rectangulo(lado, altura);
                default:
                    throw new GeometricShapeNotFoundException("Forma desconocida");
            }
        }
    }
}
