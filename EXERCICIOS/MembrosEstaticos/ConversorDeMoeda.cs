using System;
using System.Globalization;

namespace MembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double Conversor(double cotacao, double dolares)
        {
            double total = cotacao * dolares;
            return total + total * Iof / 100;
        }
    }
}
