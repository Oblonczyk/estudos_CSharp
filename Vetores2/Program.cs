using System;
using System.Globalization;

namespace Vetores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Escreva o nome do produto: ");
                string name = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Escreva o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();   

                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine($"Preço medio = {avg}");
        }
    }
}
