using CodingChallenge.Data.Classes.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Language
{
    public class Ingles : Ilenguaje
    {
        private readonly IdiomasEnum _idioma = IdiomasEnum.Ingles;

        public IdiomasEnum idioma
        {
            get
            {
                return _idioma;
            }
        }

        public Ingles()
        {

        }

        public string ListaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFormasEnum tipo)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(tipo, cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            }
            return string.Empty;
        }

        public string ReporteFormas()
        {
            return "<h1>Shapes report</h1>";
        }

        public string TraducirForma(TipoFormasEnum tipo, int cantidad)
        {
            switch (tipo)
            {
                case TipoFormasEnum.Cuadrado:
                    return cantidad == 1 ? "Square" : "Squares";
                case TipoFormasEnum.Circulo:
                    return cantidad == 1 ? "Circle" : "Circles";
                case TipoFormasEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangle" : "Triangles";  
                case TipoFormasEnum.TrapecioRectangulo:
                    return cantidad == 1 ? "Trapeze" : "Trapezoids";
                case TipoFormasEnum.Rectangulo:
                    return cantidad == 1 ? "Rectangle" : "Rectangles";
            }

            return string.Empty;
        }

        public string Footer(int totalFormas, decimal totalPerimetro, decimal totalArea)
        {
            var footer = "TOTAL:<br/>";
            footer += totalFormas.ToString() + " " + "shapes" + " ";
            footer += "Perimeter " + totalPerimetro.ToString("#.##") + " ";
            footer += "Area " + totalArea.ToString("#.##");

            return footer;
        }
    }
}
