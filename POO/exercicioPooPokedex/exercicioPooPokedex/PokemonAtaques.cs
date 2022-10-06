using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooPokedex
{
    public class PokemonAtaques : Pokemon
    {
        public PokemonAtaques() : base()
        {
            this.Poder = 0;
        }

        public PokemonAtaques(
            int numero,
            String nome,
            String tipo,
            String fraqueza,
            String Descricao,
            int poder
        ) : base(numero, nome, tipo, fraqueza, Descricao)
        {
            this.Poder = poder;
        }

        public int Poder { get; set; }

        public void ExibirPokemonAtaque()
        {
            Console.WriteLine("Numero: " + this.Numero);
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Tipo: " + this.Tipo);
            Console.WriteLine("Descrição: " + this.Descricao);
            Console.WriteLine("Ataque: " + this.Poder);
        }
    }
}
