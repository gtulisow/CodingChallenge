
using System;
using System.Collections.Generic;


namespace CodingChallenge.Data.Classes.Utils
{
    /*
     * Clase que devuelve totales de las formas geometricas
     */
    public class SumaFormas
    {
        private List<FormaGeometrica> _list;
        private List<Formas> _listFormas;

        private int _totalFormas;
        private decimal _totalPerimetro;
        private decimal _totalArea;

        public SumaFormas(List<FormaGeometrica> List)
        {
            _list = List;
            CreateListaFormas();
            FillListaTotales();
        }

        #region Metodos privados
        /*
         * Creo _listFormas con el total de formas geometricas definidas en 'TipoFormasEnum'
         */
        private void CreateListaFormas()
        {
            _listFormas = new List<Formas>();

            foreach (var forma in Enum.GetValues(typeof(TipoFormasEnum)))
            {
                var _forma = new Formas();
                _forma.Forma = (TipoFormasEnum)forma;
                _listFormas.Add(_forma);
            }
        }

        /*
         * Lleno _listFormas de Fomas con los totales por forma geometrica
         */
        private void FillListaTotales()
        {
            foreach (FormaGeometrica item in _list)
            {
                var _forma = _listFormas[(int)item.forma.Tipo - 1];
                _forma.Cantidad++;
                _totalFormas++;

                _forma.TotalArea += item.forma.CalcularArea();
                _totalArea += item.forma.CalcularArea();

                _forma.TotalPerimetro += item.forma.CalcularPerimetro();
                _totalPerimetro += item.forma.CalcularPerimetro();
            }           
        }

        #endregion

        #region Getters
        public List<Formas> GetListaTotales
        {
            get { return _listFormas; }
        }

        public int TotalFormas
        {
            get { return _totalFormas; }
        }

        public decimal TotalPerimetro
        {
            get { return _totalPerimetro; }
        }

        public decimal TotalArea
        {
            get { return _totalArea; }
        }
        #endregion
    }

    /*
     * Creao Clase para guardar los totales de cada forma geometrica
     */
    public class Formas
    {
        public TipoFormasEnum Forma { get; set; }
        public int Cantidad { get; set; }
        public decimal TotalPerimetro { get; set; }
        public decimal TotalArea { get; set; }
    }
}
