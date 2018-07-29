using CodingChallenge.Data.Classes.Interfaces;
using CodingChallenge.Data.Classes.Language;
using System;

namespace CodingChallenge.Data.Classes
{
    public class InstanciaLenguaje
    {
        public Ilenguaje Instancia(IdiomasEnum idioma)
        {
            switch (idioma)
            {
                case IdiomasEnum.Castellano:
                    return new Castellano();
                case IdiomasEnum.Ingles:
                    return new Ingles();
                case IdiomasEnum.Italiano:
                    return new Italiano();
                default:
                    throw new ArgumentOutOfRangeException(@"idioma desconocido");
            }
        }
    }
}
