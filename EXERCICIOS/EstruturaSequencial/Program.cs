using System;
using System.Globalization;

namespace EstruturaSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCÍCIO 1:");

            int n1, n2, soma;
            Console.WriteLine("Insira o primeiro número a ser somado:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número a ser somado:");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;

            Console.WriteLine($"SOMA : {soma}");

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("EXERCÍCIO 2:");

            Console.WriteLine("Insira o raio do círculo:");
            double raio = double.Parse(Console.ReadLine());
            float pi = 3.14159f;
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine(area.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("EXERCÍCIO 3:");

            int a, b, c, d;

            Console.WriteLine("Digite o valor do produto A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto B:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto C:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto D:");
            d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);
            Console.WriteLine($"DIFERENÇA = {diferenca}");

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("EXERCÍCIO 4:");

            Console.WriteLine("Digite o Id, Horas Trabalhadas e quanto é pago ao funcionário por hora trabalhada, respectivamente:");
            string[] vetor = Console.ReadLine().Split(' ');

            int idFuncionario, horasTrabalhadas;
            idFuncionario = int.Parse(vetor[0]);
            horasTrabalhadas = int.Parse(vetor[1]);
            double valorHora, salario;
            valorHora = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"NUMBER = {idFuncionario}");
            Console.WriteLine($"SALARY = U${salario.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("EXERCÍCIO 5:");

            int codigo1, codigo2, numeroDePecas1, numeroDePecas2;
            double valorUnitario1, valorUnitario2, valorTotal;

            Console.WriteLine("Digite o código, quantidade e valor unitário do produto 1:");
            codigo1 = int.Parse(Console.ReadLine());
            numeroDePecas1 = int.Parse(Console.ReadLine());
            valorUnitario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código, quantidade e valor unitário do produto 2:");
            codigo2 = int.Parse(Console.ReadLine());
            numeroDePecas2 = int.Parse(Console.ReadLine());
            valorUnitario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorTotal = (valorUnitario1 * numeroDePecas1) + (valorUnitario2 * numeroDePecas2);

            Console.WriteLine($"CÓDIGO DO PRODUTO 1: {codigo1}   QUANTIDADE : {numeroDePecas1}   X VALOR UNITÁRIO : {valorUnitario1}");
            Console.WriteLine($"CÓDIGO DO PRODUTO 2: {codigo2}   QUANTIDADE : {numeroDePecas2}   X VALOR UNITÁRIO : {valorUnitario2}");
            Console.WriteLine($"                                                      VALOR A PAGAR : {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Digite os valores de A, B e C, respectivamente:");

            string[] vetor2 = Console.ReadLine().Split(' ');
            double A, B, C;
            A = double.Parse(vetor2[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor2[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor2[2], CultureInfo.InvariantCulture);

            double triangulo = A * C / 2.0;
            double circulo = pi * C * C;
            double trapezio = (A + B) / 2.0 * C;
            double quadrado = B * B;
            double retangulo = A * B;

            
            Console.WriteLine($"TRIANGULO : {triangulo}");
            Console.WriteLine($"CIRCULO : {circulo}");
            Console.WriteLine($"TRAPEZIO : {trapezio}");
            Console.WriteLine($"QUADRADO : {quadrado}");
            Console.WriteLine($"RETANGULO : {retangulo}");
        }
    }
}
