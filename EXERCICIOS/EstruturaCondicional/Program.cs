using System;
using System.Globalization;

namespace EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCICIO 1:");

            int nOrP = int.Parse(Console.ReadLine());

            if (nOrP < 0)
            {
                Console.WriteLine("NEGATIVO");
            } else
            {
                Console.WriteLine("POSITIVO");
            }

            Console.WriteLine("----------------------");

            Console.WriteLine("EXERCICIO 2:");

            int pOrI = int.Parse(Console.ReadLine());

            if (pOrI % 2 == 0)
            {
                Console.WriteLine("PAR");
            } else
            {
                Console.WriteLine("ÍMPAR");
            }

            Console.WriteLine("----------------------");

            Console.WriteLine("EXERCICIO 3:");

            string[] vetor1 = Console.ReadLine().Split(' ');

            int a, b;

            a = int.Parse(vetor1[0]);
            b = int.Parse(vetor1[1]);

            if( a % b == 0 || b % a == 0) 
            {
                Console.WriteLine("São Multiplos");
            } else
            {
                Console.WriteLine("Não são Multiplos");
            }

            Console.WriteLine("----------------------");

            Console.WriteLine("EXERCICIO 4:");

            string[] vetor2 = Console.ReadLine().Split(' ');

            int horaI, horaF, duracao;

            horaI = int.Parse(vetor2[0]);
            horaF = int.Parse(vetor2[1]);

            if ( horaI < horaF )
            {
                duracao = horaF - horaI;
            } else
            {
                duracao = 24 - horaI + horaF;
            }
            Console.WriteLine(duracao);

            Console.WriteLine("----------------------");

            Console.WriteLine("EXERCICIO 5:");

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
