using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastro_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto[] vet = new Produto[10];
            bool executando = true;
            double valorTotal = 0;
            while (executando)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Cadastrar novo produto");
                Console.WriteLine("2 - Listar produtos cadastrados");
                Console.WriteLine("3 - Mostrar valor Total de todos os produtos em estoque");
                Console.WriteLine("4 - Sair");
                int n = Produto.LerInt("Escolha uma opção:");
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do produto:");
                        string nome = Console.ReadLine();
                        double preco = Produto.LerDouble("Digite o preço do produto:");
                        int quantidade = Produto.LerInt("Digite a quantidade do produto:");
                        Console.WriteLine("Em qual posição do vetor deseja guardar as informações");
                        int posicao = Produto.LerPosicao(vet);
                        vet[posicao] = new Produto(nome, preco, quantidade);
                        break;
                    case 2:
                        Console.WriteLine("Produtos Cadastrados:");
                        for (int i = 0; i < vet.Length; i++)
                        {
                            if (vet[i] != null)
                            {
                                Console.WriteLine("Posição #" + i + ": " + vet[i]);
                            }
                        }
                        break;
                    case 3:
                        valorTotal = 0;
                        Console.WriteLine("Valor total:");
                        for (int i = 0; i < vet.Length; i++)
                        {
                            if (vet[i] != null)
                            {
                                valorTotal += vet[i].ValorTotal();
                                Console.WriteLine(vet[i].Nome + " =  R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                            }
                        }
                        Console.WriteLine(" Valor Total =  R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        executando = false;
                        break;

                    default:
                        Console.WriteLine("Essa opção está invalida");
                        break;
                }
            }

        }
    }
}
