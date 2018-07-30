using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;
using CodingChallenge.Data.Classes.CustomException;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), FormaGeometrica.Castellano)); // se modifico el valor '1' por la property de la clase
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), FormaGeometrica.Ingles)); // se modifico el valor '2' por la property de la clase
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Cuadrado, 5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 1),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        /*
        * Nuevos Tests
        */

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecioRectangulo = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.TrapecioRectangulo, 5, 7, 4) };

            var resumen = FormaGeometrica.Imprimir(trapecioRectangulo, FormaGeometrica.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 24 | Perimetro 20,47 <br/>TOTAL:<br/>1 formas Perimetro 20,47 Area 24", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioIngles()
        {
            var trapecioRectangulo = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.TrapecioRectangulo, 5, 7, 4) };

            var resumen = FormaGeometrica.Imprimir(trapecioRectangulo, FormaGeometrica.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Trapeze | Area 24 | Perimeter 20,47 <br/>TOTAL:<br/>1 shapes Perimeter 20,47 Area 24", resumen);
        }

        [TestCase]
        public void TestResumenListaConNuevosTiposTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m),
                new FormaGeometrica(FormaGeometrica.TrapecioRectangulo, 5, 7, 4)

            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>1 Trapecio | Area 24 | Perimetro 20,47 <br/>TOTAL:<br/>8 formas Perimetro 118,14 Area 115,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var forma = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Rectangulo, 4, 0, 2) };

            var resumen = FormaGeometrica.Imprimir(forma, FormaGeometrica.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectangulo | Area 8 | Perimetro 12 <br/>TOTAL:<br/>1 formas Perimetro 12 Area 8", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectanguloIngles()
        {
            var forma = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Rectangulo, 4, 0, 2) };

            var resumen = FormaGeometrica.Imprimir(forma, FormaGeometrica.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Rectangle | Area 8 | Perimeter 12 <br/>TOTAL:<br/>1 shapes Perimeter 12 Area 8", resumen);
        }

        [TestCase]
        public void TestResumenFormaInexistente()
        {
            Assert.Throws<GeometricShapeNotFoundException>(() => new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Rombo, 4, 0, 2) }, "Forma desconocida");
        }

        [TestCase]
        public void TestResumenListaVaciaItaliano()
        {
            Assert.AreEqual("<h1>Lista vuota di moduli!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), FormaGeometrica.Italiano));
        }

        [TestCase]
        public void TestResumenListaConUnRectanguloItaliano()
        {
            var forma = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Rectangulo, 4, 0, 3) };

            var resumen = FormaGeometrica.Imprimir(forma, FormaGeometrica.Italiano);

            Assert.AreEqual("<h1>Rapporto del modulo</h1>1 Rettangolo | Zona 12 | Perimetro 14 <br/>TOTALE:<br/>1 forme Perimetro 14 Zona 12", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulos()
        {
            var total = 3;
            var lista = new List<FormaGeometrica>();

            for (int i = 0; i < total; i++)
            {
                lista.Add(new FormaGeometrica(FormaGeometrica.Rectangulo, 5, 0, 2));
                lista.Add(new FormaGeometrica(FormaGeometrica.TrapecioRectangulo, 4, 5, 3));
                lista.Add(new FormaGeometrica(FormaGeometrica.Circulo, 3));
            }

            var resumen = FormaGeometrica.Imprimir(lista, FormaGeometrica.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Circles | Area 21,21 | Perimeter 28,27 <br/>3 Trapezoids | Area 40,5 | Perimeter 45,49 <br/>3 Rectangles | Area 30 | Perimeter 42 <br/>TOTAL:<br/>9 shapes Perimeter 115,76 Area 91,71", resumen);
        }

    }
}
