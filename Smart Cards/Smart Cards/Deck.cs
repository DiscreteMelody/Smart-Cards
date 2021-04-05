using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cards
{
    public class Deck
    {
        public int Id { get; }
        
        public string Title { get; set; }
        public string Description { get; set; }
        public Dictionary<int, Card> Cards { get; set; }

        [JsonConstructor]
        public Deck(int id, string title, string description, Dictionary<int,Card> cards)
        {
            Id = id;
            Title = title;
            Description = description;
            Cards = cards;
        }

        public Deck(int id, string title, string description, List<Card> cards) {
            Id = id;
            Title = title;
            Description = description;
            Cards = convertListToDict(cards);
        }
        public Deck(int id, string title, string description, List<Card> cards,int overwrittenId) : this(id, title, description, cards)
        {
            Id = overwrittenId;
        }

        private Dictionary<int, Card> convertListToDict(List<Card> cards) {
            Console.WriteLine(Title);
            foreach(Card c in cards) {
               Console.WriteLine(c.ToString());
			}
            Dictionary<int, Card> dict = new Dictionary<int, Card>();
            dict = cards.Distinct().ToDictionary(c => c.Id, c => c);
            return dict;
		}

        public override string ToString()
        {
            string deckInfo = "\n-----------------------------------------" +
                "\nDeck id:\t\t\t" + Id +
                "\nDeck Title:\t\t\t" + Title +
                "\nDeck Description:\t" + Description +
                "\n\nNumber of cards:\t" + Cards.Count + "\n";
            foreach (KeyValuePair<int, Card> c in Cards) {
                deckInfo += "\n" + c.Value.ToString() + "\n";
            }
            return deckInfo;
        }
    }
}
