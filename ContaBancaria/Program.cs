using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Remoting;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco cliente;
            Console.WriteLine("Informe o nome do titular:");
            string nomeTitular = Console.ReadLine();
            Console.WriteLine("Informe o número da conta:");
            int numeroDaConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja realizar o primeiro deposito:");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int realizarDeposito = int.Parse(Console.ReadLine());
            if (realizarDeposito == 1)
            {
                Console.WriteLine("Quanto deseja depositar:");
                double primeiroDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente = new Banco(numeroDaConta, nomeTitular, primeiroDeposito);
            }
            else
            {
                cliente = new Banco(numeroDaConta, nomeTitular);
            }
            Console.WriteLine(cliente);
            Console.WriteLine("Realizar deposito:");
            Console.WriteLine("Quanto deseja depositar:");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.Depositar(deposito);
            Console.WriteLine(cliente);
            Console.WriteLine("Quanto deseja sacar:");
            double sacar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.Sacar(sacar);
            Console.WriteLine(cliente);


        }
    }
}
