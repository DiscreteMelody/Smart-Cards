using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cards
{
    //Class representing a Deck with a title, optional descriptions, and list of cards with a length>=0
    //Author: BH
    public class Deck
    {
        //default values for title and description of the deck to be used if a deck is created without those values provided
        public const string DefaultTitle = "My Deck";
        public const string DefaultDescription = "An interesting description";

        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Card> Cards { get; set; }

        //Constructor used to create new decks from user actions or by initializing from JSON - BH
        [JsonConstructor]
        public Deck(int id, string title, string description, List<Card> cards)
        {
            Id = id;
            Title = title;
            Description = description;
            Cards = cards;
        }

        //Overridden ToString method used during the debugging process - BH
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
