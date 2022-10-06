using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculoIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo idade de uma pessoa");
            Console.Write("Digite o nome: ");
            String nome = Console.ReadLine();
            Console.Write("Digite o ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            Pessoa p = new Pessoa(nome, anoNascimento);
            p.ExibirDados();
            Console.ReadKey();
        }
    }
}
s