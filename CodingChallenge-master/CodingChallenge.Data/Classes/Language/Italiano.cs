using CodingChallenge.Data.Classes.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Language
{
    class Italiano : Ilenguaje
    {
        private readonly IdiomasEnum _idioma = IdiomasEnum.Italiano;

        public IdiomasEnum idioma
        {
            get
            {
                return _idioma;
            }
        }

        public Italiano()
        {

        }
      
        public string ListaVacia()
        {
            return "<h1>Lista vuota di moduli!</h1>";
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFormasEnum tipo)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(tipo, cantidad)} | Zona {area:#.##} | Perimetro {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        public string ReporteFormas()
        {
            return "<h1>Rapporto del modulo</h1>";
        }

        public string TraducirForma(TipoFormasEnum tipo, int cantidad)
        {
            switch (tipo)
            {
                case TipoFormasEnum.Cuadrado:
                    return cantidad == 1 ? "Cuadrado" : "Piazze";
                case TipoFormasEnum.Circulo:
                    return cantidad == 1 ? "Cerchio" : "cerchi";
                case TipoFormasEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangolo" : "Triangoli";
                case TipoFormasEnum.TrapecioRectangulo:
                    return cantidad == 1 ? "Trapezio" : "Trapezi";
                case TipoFormasEnum.Rectangulo:
                    return cantidad == 1 ? "Rettangolo" : "Rettangoli";
            }

            return string.Empty;
        }

        public string Footer(int totalFormas, decimal totalPerimetro, decimal totalArea)
        {
            var footer = "TOTALE:<br/>";
            footer += totalFormas.ToString() + " " + "forme" + " ";
            footer += "Perimetro " + totalPerimetro.ToString("#.##") + " ";
            footer += "Zona " + totalArea.ToString("#.##");

            return footer;
        }

    }
}
