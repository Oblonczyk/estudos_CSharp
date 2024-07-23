using System;
using System.Globalization;

namespace Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cliente1;

            int numeroC;
            string nomeT;
            char dpI;

            Console.Write("Entre com o número da conta: ");
            numeroC = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Entre com o titular da conta: ");
            nomeT = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Haverá depósito inicial? (s/n) ");
            dpI = char.Parse(Console.ReadLine());
            Console.WriteLine();
            if (dpI == 's' || dpI == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente1 = new ContaBancaria(numeroC, nomeT, depositoInicial);
            }
            else
            {
                cliente1 = new ContaBancaria(numeroC, nomeT);
            }

            Console.WriteLine($"Dados da conta {cliente1}");

            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente1.Deposito(deposito);
            Console.WriteLine();
            Console.WriteLine($"Dados da conta atualizados: {cliente1}");

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente1.Saque(saque);
            Console.WriteLine();
            Console.WriteLine($"Dados da conta atualizados: {cliente1}");
        }
    }
}
