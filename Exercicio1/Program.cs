using System;
using System.Globalization;
namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R${preco1:F2}");
            Console.WriteLine("{0}, cujo preço é R${1:F2}", produto2, preco2);

            Console.WriteLine("");

            Console.WriteLine("Registro " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);

            Console.WriteLine("");

            Console.WriteLine($"Medida com 8 casas decimais: {medida}");
            Console.WriteLine("Arredondado (três casa decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
