using System;
using System.Globalization;
namespace Estoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double TotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome +", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) +", " + Quantidade + " unidades, Total = $" + TotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
