using System;
using System.Globalization;
namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto :" + produto);
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int add = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(add);
            Console.WriteLine("Dados atualizados :" + produto);
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine());
            produto.RemoverProduto(remover);
            Console.WriteLine("Dados atualizados :" + produto);



        }
    }
}
