using System;
using System.Globalization;

namespace IntroPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1;
            Pessoa pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine($"Pessoa mais velha : {pessoa1.nome}");
            } else
            {
                Console.WriteLine($"Pessoa mais velha : {pessoa2.nome}");
            }

            Funcionario funcionario1;
            Funcionario funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Insira os dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira os dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (funcionario1.salario + funcionario2.salario) / 2;

            Console.WriteLine($"Salário médio = {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
