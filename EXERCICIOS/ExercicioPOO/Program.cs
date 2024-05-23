using System;
using System.Globalization;

namespace ExercicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            produto1.nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto1.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto1.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + produto1);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado:");
            int qte = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + produto1);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido:");
            int rmv = int.Parse(Console.ReadLine());
            produto1.RemoverProdutos(rmv);
            Console.WriteLine("Dados atualizados: " + produto1);
        }
    }
}
