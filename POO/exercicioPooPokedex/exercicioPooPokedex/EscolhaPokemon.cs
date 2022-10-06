using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooPokedex
{
    public class EscolhaPokemon
    {
        public void ListarPokemon(Pokedex pokedex)
        {
            Console.Write("Escolha um dos 10 pokemons iniciais: ");
            int opcaop = int.Parse(Console.ReadLine());
            if (opcaop > 0 && opcaop <= 10)
            {
                Pokemon p = pokedex.Pokemons[opcaop - 1];
                p.ExibirPokemon();
            }
            else
                Console.WriteLine("Opção inválida");
        }
    }
}
