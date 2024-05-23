using System;
using System.Globalization;

namespace SaidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.3596;
            string nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");

            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("{0} tem {1} anos e seu saldo atual é de {2:F2} reais", nome, idade, saldo); //Place-holders
            Console.WriteLine($"{nome} tem {idade} anos e seu saldo atual é de {saldo:F2} reais"); //Interpolação
            Console.WriteLine(nome+ " tem " +idade+ " anos e seu saldo atual é de " +saldo.ToString("F2")+ " reais"); //Concatenação
        }
    }
}
