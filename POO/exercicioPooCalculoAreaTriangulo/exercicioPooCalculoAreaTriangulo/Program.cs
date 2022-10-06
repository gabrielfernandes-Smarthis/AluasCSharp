using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooCalculoAreaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da largura do retângulo: ");
            int largura = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do retângulo: ");
            int altura = int.Parse(Console.ReadLine());
            Retangulo retangulo = new Retangulo(largura, altura);
            retangulo.ExibirDados();
            Console.ReadKey();

        }
    }
}
