using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ClasseAbstratas
            //Carro c = new Carro();
            //Bicicleta b = new Bicicleta();

            //c.Acelerar();
            //b.Acelerar();
            #endregion

            Console.WriteLine("\nHumano");
            Humano h = new Humano();
            h.Olhos();
            h.Cabelos();
            Console.WriteLine("\nPessoa");
            Pessoa p = new Pessoa();
            p.Olhos();
            p.Cabelos();
            Console.WriteLine("\nHomem");
            Homem m = new Homem();
            m.Olhos();
            m.Cabelos();
        }
    }
}
