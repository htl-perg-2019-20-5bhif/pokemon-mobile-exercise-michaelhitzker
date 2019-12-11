using Newtonsoft.Json;

namespace PokemonExplorer.Model
{
    public class Ability
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
