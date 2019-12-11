using Newtonsoft.Json;
using PokemonExplorer.Model;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokemonExplorer
{
    public class PokemonManager
    {
        private static readonly HttpClient httpClient
           = new HttpClient() { BaseAddress = new Uri("https://pokeapi.co/api/v2/") };

        async public Task<Pokemons> GetAllPokemons()
        {
            var pokemonResponse = await httpClient.GetAsync("pokemon");
            pokemonResponse.EnsureSuccessStatusCode();
            var responseBody = await pokemonResponse.Content.ReadAsStringAsync();
            var pokemons = JsonConvert.DeserializeObject<Pokemons>(responseBody);
            return pokemons;
        }

        async public Task<Pokemon> GetPokemonInfo(string pokemonId)
        {
            var pokemonResponse = await httpClient.GetAsync($"pokemon/{pokemonId}");
            pokemonResponse.EnsureSuccessStatusCode();
            var responseBody = await pokemonResponse.Content.ReadAsStringAsync();
            var pokemon = JsonConvert.DeserializeObject<Pokemon>(responseBody);
            return pokemon;
        }
    }
}
