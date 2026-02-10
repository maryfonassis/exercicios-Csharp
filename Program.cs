using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();

            int qntd = InputValidator.ValidarInt("Quantos funcionarios serão registrados");
            for (int i = 1; i <= qntd; i++)
            {
                Console.WriteLine("Funcionario #" + i);
                int id = InputValidator.ValidarInt("Id:");
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                double salario = InputValidator.ValidarDouble("Salario:");
                lista.Add(new Funcionario(id, nome, salario));
            }
            int procurarId = InputValidator.ValidarInt("Id do funcionario que tera um aumento de salario:");
            Funcionario fun = lista.Find(x => x.Id == procurarId);
            if (fun != null)
            {
            double porcentagem = InputValidator.ValidarDouble("Adicione a porcentagem:");
            fun.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse funcionario não existe");
            }
            Console.WriteLine("Update da lista de funcionarios");
            foreach (Funcionario i in lista) {
                Console.WriteLine(i);
            }
        }

    }
}
