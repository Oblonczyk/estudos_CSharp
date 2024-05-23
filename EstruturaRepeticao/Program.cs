using System;
using System.Globalization;

namespace EstruturaRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite um novo numero:");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("O número é negativo.");
        }
    }
}
