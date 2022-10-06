using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooPokedex
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }

        private List<PokemonAtaques> pokemons;

        public List<PokemonAtaques> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            // Instanciar a lista
            this.pokemons = new List<PokemonAtaques>();
            PokemonAtaques p = new PokemonAtaques(
                001,
                "Bulbasauro",
                "Planta",
                "Fogo",
                "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger.",
                5
            );
            this.pokemons.Add(p);
            p = new PokemonAtaques(
                002,
                "Ivysaur",
                "Planta",
                "Fogo",
                "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.",
                6
            );
            this.pokemons.Add(p);
            p = new PokemonAtaques(
                003,
                "Venusaur",
                "Planta",
                "Fogo",
                "Its plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.",
                20
            );
            this.pokemons.Add(p);
            p = new PokemonAtaques(
                004,
                "Charmander",
                "Fogo",
                "Agua",
                "It has a preference for hot things. When it rains, steam is said to spout from the tip of its tail.",
                5
            );
            this.pokemons.Add(p);
            p = new PokemonAtaques(
                005,
                "Charmeleon",
                "Fogo",
                "Agua",
                "It has a barbaric nature. In battle, it whips its fiery tail around and slashes away with sharp claws.",
                10
            );
            this.pokemons.Add(p);
            p = new PokemonAtaques(
                006,
                "Charizard",
                "Fogo",
                "Agua",
                "It spits fire that is hot enough to melt boulders. It may cause forest fires by blowing flames.",
                27
            );
            this.pokemons.Add(p);
            p = new PokemonAtaques(
                007,
                "Squirtle",
                "Agua",
                "Planta",
                "When it retracts its long neck into its shell, it squirts out water with vigorous force.",
                5
            );
            this.pokemons.Add(p);
            p = new PokemonAtaques(
                008,
                "Wartortle",
                "Agua",
                "Planta",
                "It is recognized as a symbol of longevity. If its shell has algae on it, that Wartortle is very old.",
                8
            );
            this.pokemons.Add(p);
            p = new PokemonAtaques(
                009,
                "Blastoise",
                "Agua",
                "Planta",
                "It crushes its foe under its heavy body to cause fainting. In a pinch, it will withdraw inside its shell.",
                22
            );
            this.pokemons.Add(p);
            p = new PokemonAtaques(
                010,
                "Caterpie",
                "Normal",
                "",
                "For protection, it releases a horrible stench from the antenna on its head to drive away enemies.",
                4
            );
            this.pokemons.Add(p);
        }

        public void ListarPokemons()
        {
            foreach (Pokemon p in this.pokemons)
            {
                Console.WriteLine("Numero: " + p.Numero);
                Console.WriteLine("Nome: " + p.Nome);
                Console.WriteLine("Tipo: " + p.Tipo);
                Console.WriteLine("Descricao: " + p.Descricao);
                Console.WriteLine("Fraqueza: " + p.Fraqueza);
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}
