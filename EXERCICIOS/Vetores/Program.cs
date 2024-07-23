using System;
using System.Globalization;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] aluguel = new Aluguel[10];


            Console.Write("Quantos estudantes irão locar? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Escreva o nome do Estudante: ");
                string nome = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Escreva o email do estudante: ");
                string email = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Escreva o número do quarto escolhido pelo estudante 0 à 9: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                aluguel[quarto] = new Aluguel { Student = nome, Email = email };
            }

            for (int i = 0; i < 10; i++)
            {
                if (aluguel[i] != null)
                {
                    Console.WriteLine($"{i} : {aluguel[i]}");
                }
            }
        }
    }
}
