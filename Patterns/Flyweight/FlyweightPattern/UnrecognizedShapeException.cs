using System;

namespace FlyweightPattern
{
    public class UnrecognizedShapeException : SystemException
    {
        public UnrecognizedShapeException()
            : base("Unrecognized shape exception.")
        {
        }
    }
}