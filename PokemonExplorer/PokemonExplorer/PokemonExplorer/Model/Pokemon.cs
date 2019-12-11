using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokemonExplorer.Model
{
    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("abilities")]
        public List<Ability> Abilities { get; set; }

        [JsonProperty("sprites.front_default")]
        public string FrontDefaultImageLink { get; set; }

        [JsonProperty("sprites.back_default")]
        public string BackDefaultImageLink { get; set; }


    }
}
