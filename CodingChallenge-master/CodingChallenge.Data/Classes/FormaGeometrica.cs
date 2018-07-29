/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingChallenge.Data.Classes.Interfaces;
using CodingChallenge.Data.Classes.Utils;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        #region Formas

        public const TipoFormasEnum Cuadrado = TipoFormasEnum.Cuadrado;
        public const TipoFormasEnum TrianguloEquilatero = TipoFormasEnum.TrianguloEquilatero;
        public const TipoFormasEnum Circulo = TipoFormasEnum.Circulo;
        public const TipoFormasEnum TrapecioRectangulo = TipoFormasEnum.TrapecioRectangulo;
        public const TipoFormasEnum Rectangulo = TipoFormasEnum.Rectangulo;
        public const TipoFormasEnum Rombo = TipoFormasEnum.Rombo;

        #endregion

        #region Idiomas

        public const IdiomasEnum Castellano = IdiomasEnum.Castellano;
        public const IdiomasEnum Ingles = IdiomasEnum.Ingles;
        public const IdiomasEnum Italiano = IdiomasEnum.Italiano;

        #endregion

        public ICalculosGeometricos forma;

        private static Ilenguaje _lenguaje;

        public FormaGeometrica(TipoFormasEnum tipo, decimal ancho, decimal baseMayor = 0, decimal altura = 0)
        {
            forma = new InstanciaGeomitrica().Instancia(tipo, ancho, baseMayor, altura);
        }

        public static string Imprimir(List<FormaGeometrica> formas, IdiomasEnum idioma)
        {
            var sumaforma = new SumaFormas(formas);
            List<Formas> ListForma = sumaforma.GetListaTotales;

            _lenguaje = new InstanciaLenguaje().Instancia((IdiomasEnum)idioma);
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(_lenguaje.ListaVacia());
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(_lenguaje.ReporteFormas());

                foreach(Formas forma in ListForma)
                {
                    sb.Append(_lenguaje.ObtenerLinea(forma.Cantidad, forma.TotalArea, forma.TotalPerimetro, forma.Forma));
                }
                // FOOTER
                sb.Append(_lenguaje.Footer(sumaforma.TotalFormas, sumaforma.TotalPerimetro, sumaforma.TotalArea));
            }

            return sb.ToString();
        }

    }
}
