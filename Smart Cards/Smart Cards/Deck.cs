using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cards
{
    public class Deck
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<Card> cards { get; set; }

        public Deck(string newTitle, string newDescription, List<Card> newCards)
        {
            title = newTitle;
            description = newDescription;
            cards = newCards;
        }

        public override string ToString()
        {
            string deckInfo = "Deck Title: " + title +
                "\nDeck Description: " + description +
                "\nNumber of cards: " + cards.Count;
            return deckInfo;
        }
    }
}
