using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooPokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int opcao = 5;
            while (opcao != 0)
            {
                opcao = Menu();
                if (opcao == 1)
                {
                    //Escolher um pokemon
                    EscolhaPokemon escolhaPokemon = new EscolhaPokemon();
                    escolhaPokemon.ListarPokemon(pokedex);
                }
                else if (opcao == 2)
                {
                    pokedex.ListarPokemons(); //Listar todos os pokemons
                }
                else if (opcao == 3)
                {
                    pokedex.ListarPokemons();
                    Console.Write("Digite o codigo do pokemon: ");
                    int codigo = int.Parse(Console.ReadLine());
                    //Pokemon Usuario
                    PokemonAtaques pPlayer = pokedex.Pokemons[codigo - 1];
                    //Pokemon Inimigo
                    Random r = new Random();
                    codigo = r.Next(1, 10);
                    PokemonAtaques pInimigo = pokedex.Pokemons[codigo];
                    Console.WriteLine(
                        "Seu pokemon "
                            + pPlayer.Nome
                            + "encontrou o "
                            + pInimigo.Nome
                            + " do Inimigo"
                    );
                    Console.WriteLine("Comçando a luta: ");
                    if (pInimigo.Fraqueza == pPlayer.Tipo)
                    {
                        pInimigo.Poder = pInimigo.Poder * 2;
                        if (pInimigo.Poder > pPlayer.Poder)
                        {
                            Console.WriteLine("Você perdeu!");
                        }
                        else
                        {
                            Console.WriteLine("Você ganhou!");
                        }
                    }
                    else if (pInimigo.Tipo == pPlayer.Fraqueza)
                    {
                        pPlayer.Poder = pPlayer.Poder * 2;
                        if (pInimigo.Poder > pPlayer.Poder)
                        {
                            Console.WriteLine("Você perdeu!");
                        }
                        else
                        {
                            Console.WriteLine("Você ganhou!");
                        }
                    }
                }
                else if (opcao == 0)
                    Console.WriteLine("Fechando pokedex"); //Fechar o programa
                else
                    Console.WriteLine("Opção inválida");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int Menu()
        {
            Console.WriteLine("1 - Escolher um pokemon");
            Console.WriteLine("2 - Listar todos os pokemons da pokedex");
            Console.WriteLine("3 - Batalhar");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }
    }
}
