using System.Diagnostics;
using CustomPokedex.Models;
using Microsoft.AspNetCore.Mvc;
using CustomPokedex.Service;

namespace CustomPokedex.Controllers
{
    // [Route("home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PokemonService _pokemonService;
        public HomeController(ILogger<HomeController> logger, PokemonService pokemonService)
        {
            _logger = logger;
            _pokemonService = pokemonService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Returns the list of Pokemon as JSON
            var pokemons = _pokemonService.Pokemons;
            var wrapper = new PokemonList
            {
                Pokemons = pokemons
            };
            return View(wrapper);
        }

        [HttpGet("/pokemon")]
        public IActionResult PokemonView(int pokedex_id)
        {
            if (pokedex_id == null)
            {
                return View(
                    new PokemonList { Pokemons = new List<Pokemon>() }
                );
            }

            var filtered = _pokemonService.Pokemons
                                          .Where(p => p.PokedexNumber == pokedex_id)
                                          .ToList();

            var wrapper = new PokemonList { Pokemons = filtered };

            if (!filtered.Any())
            {
                ViewData["Message"] = $"No Pokémon found with ID {pokedex_id}.";
            }

            return View(wrapper);
        }

        public IActionResult _InfoPartialTab(Pokemon pokemon)
        {
            return PartialView(pokemon);
        }

        public IActionResult _StatsPartialTab(Pokemon pokemon)
        {
            return PartialView(pokemon);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
