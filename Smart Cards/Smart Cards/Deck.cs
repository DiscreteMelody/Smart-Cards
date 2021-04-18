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
        public const string DefaultTitle = "My Deck";
        public const string DefaultDescription = "An interesting description";

        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Card> Cards { get; set; }

        [JsonConstructor]
        public Deck(int id, string title, string description, List<Card> cards)
        {
            Id = id;
            Title = title;
            Description = description;
            Cards = cards;
        }
        public Deck(string title, string description, List<Card> cards,int overwrittenId)
        {
            Id = overwrittenId;
        }
        public Deck(int id)
        {
            Id = id;
            Title = "Enter a Title";
            Description = "Enter a Description";
            Cards = new List<Card>();
        }

        public override string ToString()
        {
            string deckInfo = "\n-----------------------------------------" +
                "\nDeck Title:\t\t\t" + Title +
                "\nDeck Description:\t" + Description +
                "\n\nNumber of cards:\t" + Cards.Count + "\n";
            foreach(Card c in Cards)
            {
                deckInfo += "\n" + c.ToString() + "\n";
            }
            return deckInfo;
        }

		public override bool Equals(object obj) {
			return base.Equals(obj);
		}

		public override int GetHashCode() {
			return base.GetHashCode();
		}
	}
}
