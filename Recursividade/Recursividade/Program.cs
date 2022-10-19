using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RECURSIVIDADEf
            //Recursiva m = new Recursiva();
            //m.ExecutarRecursivo("Olá", 5);

            //Exercicio Recursividade com fatorial
            Fatorial f = new Fatorial();
            Console.Write("Escolha um numero para calcular o fatorial: ");
            int num = int.Parse(Console.ReadLine());
            int fatorial = f.CalculoFatorial(num);
            Console.WriteLine("Resultado do calculo do fatorial de {0}: {1}", num, fatorial);

            Console.ReadKey();
        }
    }
}
