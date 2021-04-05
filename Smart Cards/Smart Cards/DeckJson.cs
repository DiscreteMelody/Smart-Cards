using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cards
{
    public class DeckJson
    {
        [JsonProperty("decks")]
        public Dictionary<int, Deck> DeckList { get; set; }
    }
}
