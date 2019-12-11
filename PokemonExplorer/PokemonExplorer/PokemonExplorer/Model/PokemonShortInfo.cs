using Newtonsoft.Json;

namespace PokemonExplorer.Model
{
    public class PokemonShortInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
