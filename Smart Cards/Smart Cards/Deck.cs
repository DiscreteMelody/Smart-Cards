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
        private static int NextId = 0;
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Card> Cards { get; set; }

        [JsonConstructor]
        public Deck(string title, string description, List<Card> cards)
        {
            Id = NextId++;
            Title = title;
            Description = description;
            Cards = cards;
        }
        public Deck(string title, string description, List<Card> cards,int overwrittenId) : this(title, description, cards)
        {
            Id = overwrittenId;
        }
        public Deck()
        {
            Id = NextId++;
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
    }
}
