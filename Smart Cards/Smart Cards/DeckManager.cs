using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cards
{
    public static class DeckManager
    {
        private static Dictionary<int,Deck> DeckList = new Dictionary<int,Deck>();

        private static readonly string filePath = "deck_data/DeckList.json";

        //reads Json file located at 'filePath' and initializes DeckList Dictionary
        public static void ImportDecksFromJson()
        {
            string data = File.ReadAllText(filePath);

            DeckList = JsonConvert.DeserializeObject<Dictionary<int,Deck>>(data);
        }

        public static void ExportDecksToJson()
        {
            try
            {
                using (StreamWriter file = File.CreateText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, DeckList);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static Deck GetDeckFromId(int id)
        {
            return DeckList[id];
        }

        //Pass in a deck and it's original will be replaced in DeckList storage with the new one
        //This is used when editing a deck
        public static void OverwriteDeck(Deck newDeck)
        {
            DeckList[newDeck.Id] = newDeck;
        }

        //Creates an empty deck, adds it to the DeckList and returns it
        public static Deck GetNewDeck()
        {
            Deck newDeck = new Deck();
            DeckList.Add(newDeck.Id, newDeck);
            return newDeck;
        }

        public static void DeleteDeck(Deck deckToDelete)
        {
            DeckList.Remove(deckToDelete.Id);
        }

        public static List<DeckPanel> CreateDeckPanels()
        {
            List<DeckPanel> DeckPanels = new List<DeckPanel>();

            DeckPanel newDeckPanel;
            foreach (KeyValuePair<int,Deck> d in DeckList)
            {
                newDeckPanel = new DeckPanel(d.Value);
                DeckPanels.Add(newDeckPanel);
            }

            return DeckPanels;
        }


        

    }
}
