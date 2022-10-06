using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooExercicioCriarContaBanco
{
    internal class ContaBanco
    {
        public ContaBanco()
        {
            this.Status = false;
            this.Saldo = 0;
        }

        public ContaBanco(String numConta, String tipo, String dono)
        {
            this.NumConta = numConta;
            this.Tipo = tipo;
            this.Dono = dono;
        }

        public String NumConta { get; set; }
        private int tipo;

        public String Tipo
        {
            get 
            {
                if (tipo == 1)
                    return "Conta Corrente";
                else if (tipo == 2)
                    return "Conta Poupança";
                else
                    return "Tipo invalido";
            }
            set
            {
                if(value == "Conta Corrente")
                {
                    tipo = 1;
                }else if(value == "Conta Poupança")
                {
                    tipo = 2;
                }
                else
                    Console.WriteLine("Tipo invalido");
            }
        }

        public String Dono { get; set; }
        public double Saldo { get; set; }
        public bool Status { get; set; }

        public void abrirConta()
        {
            if (!Status)
            {
                this.Status = true;
                if (this.tipo == 1)
                {
                    this.Saldo += 50.00;
                    Console.WriteLine("Conta corrente aberta com sucesso");
                    Console.WriteLine("O seu saldo é de: " + this.Saldo);
                }
                else if (this.tipo == 2)
                {
                    this.Saldo += 150.00;
                    Console.WriteLine("Conta poupaça aberta com sucesso");
                    Console.WriteLine("O seu saldo é de: " + this.Saldo);
                }
            }
            else
                Console.WriteLine("Voce já possui uma conta aberta");
        }

        public void fecharConta()
        {
            if (Status == true && Saldo == 0)
            {
                Console.WriteLine("Fechando sua conta");
                this.Status = false;
            }
            else if (Saldo != 0)
                Console.WriteLine("Voce não pode fechar uma conta que possuisaldo");
            else if (!Status)
            {
                Console.WriteLine("Voce já não possui nenhuma conta criada");
            }
        }

        public void depositar(double valor)
        {
            if (Status && valor > 0)
            {
                Saldo += valor;
                Console.WriteLine("Depositado valor de " + valor + " em sua conta");
            }
            else
                Console.WriteLine("Valor inserido é invalido");
        }

        public void sacar(double valor)
        {
            if(Status == true && valor <= Saldo && valor > 0)
            {
                Saldo -= valor;
                Console.WriteLine("Sacado " + valor + " da sua conta");
            }
            else
                Console.WriteLine("Valor inserido é invalido");
        }

        public void pagarMensalidade()
        {
            if (tipo == 1)
                Saldo -= 12.00;
            else
                Saldo -= 20.00;
        }
    }
}
