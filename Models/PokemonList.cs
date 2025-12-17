using System.Text.Json.Serialization;

namespace CustomPokedex.Models
{
    public class PokemonList
    {
        [JsonPropertyName("pokemons")]
        public List<Pokemon> Pokemons { get; set; }
    }
}
