using CodingChallenge.Data.Classes.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Language
{
    public class Castellano : Ilenguaje
    {
        private readonly IdiomasEnum _idioma = IdiomasEnum.Castellano;

        public IdiomasEnum idioma
        {
            get
            {
                return _idioma;
            }
        }

        public Castellano()
        {

        }

        public string ListaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFormasEnum tipo)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(tipo, cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        public string ReporteFormas()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public string TraducirForma(TipoFormasEnum tipo, int cantidad)
        {
            switch (tipo)
            {
                case TipoFormasEnum.Cuadrado:
                     return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case TipoFormasEnum.Circulo:
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case TipoFormasEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
                case TipoFormasEnum.TrapecioRectangulo:
                    return cantidad == 1 ? "Trapecio" : "Trapecios";
                case TipoFormasEnum.Rectangulo:
                    return cantidad == 1 ? "Rectangulo" : "Rectangulos";
            }

            return string.Empty;
        }

        public string Footer(int totalFormas, decimal totalPerimetro, decimal totalArea)
        {
            var footer = "TOTAL:<br/>";
            footer += totalFormas.ToString() + " " + "formas" + " ";
            footer += "Perimetro " + totalPerimetro.ToString("#.##") + " ";
            footer += "Area " + totalArea.ToString("#.##");
            
            return footer;
        }
    }
}
