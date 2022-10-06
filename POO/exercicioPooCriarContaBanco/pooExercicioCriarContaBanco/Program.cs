using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooExercicioCriarContaBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abrir conta corrente
            ContaBanco contaCorrente = new ContaBanco();
            contaCorrente.Tipo = "Conta Corrente";
            contaCorrente.abrirConta();
            contaCorrente.depositar(200.00);
            contaCorrente.pagarMensalidade();
            contaCorrente.sacar(15.00);
            Console.WriteLine("Seu saldo é de " + contaCorrente.Saldo + " Reais");

            Console.WriteLine("\n");

            //Abrir conta popança
            ContaBanco contaPoupanca = new ContaBanco();
            contaPoupanca.Tipo = "Conta Poupança";
            contaPoupanca.abrirConta();
            contaPoupanca.depositar(500.00);
            contaPoupanca.pagarMensalidade();
            contaPoupanca.sacar(55.00);
            Console.WriteLine("Seu saldo é de " + contaPoupanca.Saldo + " Reais");

            //Finalizar o processo
            Console.ReadKey();
        }
    }
}
