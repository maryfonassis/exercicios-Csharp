using System;


namespace Teste7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel[] room = new Hotel[10];
            Console.WriteLine("Quantos quartos serão alugados:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++){
                Console.WriteLine("Aluguel #" +  i);
                Console.WriteLine("Qual o seu nome:");
                string name = Console.ReadLine();
                Console.WriteLine("Informe seu Email:");
                string email = Console.ReadLine();
                Console.WriteLine("Qual quarto deseja:");
                int num = int.Parse(Console.ReadLine());
                room[num] = new Hotel(name, email);
            }
            Console.WriteLine("Quartos Alugados:");
            for (int i = 1; i < 10; i++)
            {
                if (room[i] != null)
                {
                    Console.WriteLine("Quarto " + i + ": " + room[i].ToString());
                }

            }

            
        }
    }
}
