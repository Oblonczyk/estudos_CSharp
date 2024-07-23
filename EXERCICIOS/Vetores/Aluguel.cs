using System;
using System.Globalization;

namespace Vetores
{
    internal class Aluguel
    {
        public string Student { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return Student + ", " + Email;
        }
    }
}
