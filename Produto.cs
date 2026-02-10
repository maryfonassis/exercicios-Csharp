using System;
using System.Globalization;

namespace SistemaDeCadastro_
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;


        }

        public double ValorTotal()
        {
            return Preco * Quantidade;
        }
        public static int LerInt(string mensagem)
        {
            int valor;
            Console.WriteLine(mensagem);
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Valor inválido, tente novamente:");
            }
            return valor;
        }
        public static double LerDouble(string mensagem)
        {
            double valor;
            Console.WriteLine(mensagem);
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
            {
                Console.WriteLine("Valor inválido, tente novamente:");
            }
            return valor;
        }

        public static int LerPosicao(Produto[] vetor)
        {
            int posicao;
            while (true)
            {
                posicao = LerInt("Digite a posição");
                if (posicao < 0 || posicao >= vetor.Length)
                {
                    Console.WriteLine("Posição inválida, tente novamente");
                }
                else if (vetor[posicao] != null)
                {
                    Console.WriteLine("Posição ocupada, tente novamente");
                }
                else
                {
                    return posicao;
                }

            }
        }

        public override string ToString()
        {
            return $"Nome = {Nome}, Preço = {Preco.ToString("F2", CultureInfo.InvariantCulture)}, Quantidade = {Quantidade}";
        }
    }
}
