using System;

namespace EstruturaRepetitiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros você vai digitar?");

            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Valor: #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine($"O valor total é: {soma}");
        }
    }
}
