using System;
using System.Globalization;

namespace Construtores
{
    internal class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        private string NomeTitular { get; set; }
        public double Saldo { get; private set; } 

        public ContaBancaria(int numeroDaConta, string nomeTitular)
        {
            NumeroDaConta = numeroDaConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroDaConta, string nomeTitular, double depositoInicial) : this(numeroDaConta, nomeTitular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return $"Conta {NumeroDaConta}, Titular : {NomeTitular}, Saldo : R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
