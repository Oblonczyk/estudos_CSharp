using System;
using System.Globalization;

namespace ReferenciaValor
{
    internal struct Point()
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
