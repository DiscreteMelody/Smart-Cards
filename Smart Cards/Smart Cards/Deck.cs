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
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Card> Cards { get; set; }

        public Deck(string title, string description, List<Card> cards)
        {
            Title = title;
            Description = description;
            Cards = cards;
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
