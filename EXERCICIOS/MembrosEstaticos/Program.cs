using System;
using System.Globalization;

namespace MembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double reais = ConversorDeMoeda.Conversor(cotacao, dolares);

            Console.WriteLine($"Valor a ser pago em reais = {reais.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
