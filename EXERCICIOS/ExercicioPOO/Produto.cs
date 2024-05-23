using System;
using System.Globalization;

namespace ExercicioPOO
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }

        public void AdicionarProdutos(int quantidadeAdd)
        {
            quantidade += quantidadeAdd;
        }

        public void RemoverProdutos(int quantidadeAdd)
        {
            quantidade -= quantidadeAdd;
        }

        public override string ToString()
        {
            return nome + ", $ " + preco.ToString("F2", CultureInfo.InvariantCulture) + " unidadades, Total : $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
