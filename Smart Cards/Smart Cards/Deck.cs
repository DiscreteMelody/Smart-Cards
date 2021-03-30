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

        public Deck(string newTitle, string newDescription, List<Card> newCards)
        {
            Title = newTitle;
            Description = newDescription;
            Cards = newCards;
        }

        public override string ToString()
        {
            string deckInfo = "Deck Title: " + Title +
                "\nDeck Description: " + Description +
                "\nNumber of cards: " + Cards.Count;
            foreach(Card c in Cards)
            {
                deckInfo += "\n" + c.ToString();
            }
            return deckInfo;
        }
    }
}
