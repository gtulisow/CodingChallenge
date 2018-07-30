using System;

namespace CodingChallenge.Data.Classes.CustomException
{
    public class GeometricShapeNotFoundException : Exception
    {
        public GeometricShapeNotFoundException()
        {
        }

        public GeometricShapeNotFoundException(string message)
        : base(message)
        {
        }

        public GeometricShapeNotFoundException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
