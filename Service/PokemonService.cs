using System.Text.Json;
using CustomPokedex.Models;

namespace CustomPokedex.Service
{
    
    public class PokemonService
    {
        public List<Pokemon> Pokemons { get; set; }
        public PokemonService()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "pokedex-details.json");
            var json = File.ReadAllText(path);

            var wrapper = JsonSerializer.Deserialize<PokemonList>(json);

            Pokemons = wrapper?.Pokemons ?? new List<Pokemon>();
        }

        public string testFunc()
        {
            return "Hello";
        }
    }
}
