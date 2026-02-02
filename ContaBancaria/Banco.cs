using System.Globalization;

namespace ContaBancaria
{
    internal class Banco
    {
        public double Saldo { get; private set; }
        public int NumeroDaConta { get; private set; }
        public string NomeDoTitular { get; set; }

        public Banco(int numeroDaConta, string nomeDoTitular)
        {
            NumeroDaConta = numeroDaConta;
            NomeDoTitular = nomeDoTitular;
        }

        public Banco(int numeroDaConta, string nomeDoTitular, double saldo) : this(numeroDaConta, nomeDoTitular)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            Saldo = Saldo - valor - 5.00;   
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return $"Número da conta: {NumeroDaConta}, Nome do Titular: {NomeDoTitular}, Saldo: R$" +
                $" {Saldo.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
