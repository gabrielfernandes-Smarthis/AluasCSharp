using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            String[] nomes = new String[3];
            int[] idades = new int[3];
            //Entrada de dados
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Digite o nome da pessoa: ");
                nomes[i - 1] = Console.ReadLine();
                Console.Write("Digite a idade da pessoa: ");
                idades[i - 1] = int.Parse(Console.ReadLine());
            }
            //Instanciando objetos
            Pessoa p1 = new Pessoa(nomes[0], idades[0]);
            Pessoa p2 = new Pessoa(nomes[1], idades[1]);
            Pessoa p3 = new Pessoa(nomes[2], idades[2]);

            //Saida de dados
            if (p1.Idade > p2.Idade && p1.Idade > p3.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
            else if (p2.Idade > p1.Idade && p2.Idade > p3.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p2.ExibirDados();
            }
            else if (p3.Idade > p1.Idade && p3.Idade > p2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p3.ExibirDados();
            }
            else
            {
                Console.WriteLine("As pessoas tem a mesma idade");
            }
            Console.ReadKey();
        }
    }
}
