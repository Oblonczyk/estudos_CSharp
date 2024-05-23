using System;
using System.Globalization;

namespace EntradaDeDados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            char ch = char.Parse(Console.ReadLine());
            
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(ch);

            Console.WriteLine("--------------------------------------------");

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome}, {sexo}, {idade}, {altura.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Entre com seu nome completo:");
            string nome2 = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int nQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double pProduto = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            Console.WriteLine(nome2);
            Console.WriteLine(nQuartos);
            Console.WriteLine(pProduto);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha):");
            string[] vet2 = Console.ReadLine().Split(' ');

            string uNome = vet2[0];
            int idade2 = int.Parse(vet2[1]);
            double altura2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            Console.WriteLine(uNome);
            Console.WriteLine(idade2);
            Console.WriteLine(altura2);

        }
    }
}
