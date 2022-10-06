using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Matematica
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine("A soma é: " + (a + b));
        }
        public void Subtrair(int a, int b)
        {
            Console.WriteLine("A subtracao é: " + (a - b));
        }
        public void Multiplicar(int a, int b)
        {
            Console.WriteLine("A multiplicacao é: " + (a * b));
        }
        public void Dividir(int a, int b)
        {
            Console.WriteLine("A divisao é: " + (a / b));
        }
    }
}
