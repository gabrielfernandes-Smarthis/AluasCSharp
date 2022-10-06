using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematica.taxa = 10;

            int v1 = Matematica.Adicinar(200);
            int v2 = Matematica.Subtrair(100);
            Console.WriteLine("Valor 1: {0} Valor 2: {1}", v1, v2);
        }
    }
}
