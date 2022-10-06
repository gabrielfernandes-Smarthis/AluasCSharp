using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooPokedex
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Numero = 0;
            this.Nome = "";
            this.Tipo = "";
            this.Fraqueza = "";
            this.Descricao = "";
        }

        public Pokemon(int numero, String nome, String tipo, String fraqueza, String Descricao)
        {
            this.Numero = numero;
            this.Nome = nome;
            this.Tipo = tipo;
            this.Fraqueza = fraqueza;
            this.Descricao = Descricao;
        }

        private int numero;

        public int Numero
        {
            get { return numero; }
            set
            {
                if (value >= 0)
                    numero = value;
                else
                    numero = 000;
            }
        }
        public String Nome { get; set; }

        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set
            {
                if (value == "Planta" || value == "Fogo" || value == "Agua" || value == "Normal")
                    tipo = value;
                else
                    tipo = "Normal";
            }
        }

        private String fraqueza;

        public String Fraqueza
        {
            get { return fraqueza; }
            set
            {
                if (value == "Planta" || value == "Fogo" || value == "Agua" || value == "Normal")
                    fraqueza = value;
                else
                    fraqueza = "Nao Possui fraqueza";
            }
        }

        public String Descricao { get; set; }

        public void ExibirPokemon()
        {
            Console.WriteLine("Numero: " + this.Numero);
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Tipo: " + this.Tipo);
            Console.WriteLine("Descrição: " + this.Descricao);
        }

        public void ExibirPokemon(Boolean nome)
        {
            if (nome)
                Console.WriteLine("Nome: " + this.Nome);
            else
            {
                Console.WriteLine("Numero: " + this.Numero);
                Console.WriteLine("Nome: " + this.Nome);
                Console.WriteLine("Tipo: " + this.Tipo);
                Console.WriteLine("Descrição: " + this.Descricao);
            }
        }
    }
}
