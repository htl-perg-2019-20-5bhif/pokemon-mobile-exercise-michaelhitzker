using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokemonExplorer.Model
{
    public class Pokemons
    {
        [JsonProperty("results")]
        public List<Pokemon> Results { get; set; }
    }
}
