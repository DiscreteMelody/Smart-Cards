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
        private static Dictionary<int,Deck> DeckList = new Dictionary<int, Deck>();

        //private static readonly string filePath = "deck_data/DeckList.json";

        private static readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Smart_Cards\\DeckList.json");

        //reads Json file located at 'filePath' and initializes DeckList Dictionary
        public static void ImportDecksFromJson()
        {
            Console.WriteLine(filePath);
            try
            {
                string data = File.ReadAllText(filePath);
                DeckList = JsonConvert.DeserializeObject<Dictionary<int, Deck>>(data);
                Console.WriteLine(DeckList.Count);
            }
            catch(Exception e)
            {
                
                Console.WriteLine("Could not read file: " + e.Message);
            }
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
                Console.WriteLine("Could not write file: " + e.Message);
                try {
                    if (!Directory.Exists(filePath)) {
                        Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Smart_Cards"));
                        using (StreamWriter file = File.CreateText(filePath)) {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.Serialize(file, DeckList);
                        }
                    } else {
                        Console.WriteLine(e);
                    }
                } catch (Exception e2) {
                    Console.WriteLine(e2.Message);
				}
            }
        }

        public static Deck GetDeckFromId(int id)
        {
            try
            {
                return DeckList[id];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        //Pass in a deck and it's original will be replaced in DeckList storage with the new one
        //This is used when editing a deck
        public static void OverwriteDeck(Deck newDeck)
        {
            DeckList[newDeck.Id] = newDeck;
        }

        //Creates an empty deck, adds it to the DeckList and returns it
        public static Deck CreateNewDeck(string DeckTitle = Deck.DefaultTitle,string DeckDescription = Deck.DefaultDescription)
        {
            Deck newDeck = new Deck(DeckTitle, DeckDescription, new List<Card>());
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
            if (DeckList.Count == 0) return DeckPanels;

            DeckPanel newDeckPanel;
            foreach (KeyValuePair<int,Deck> d in DeckList)
            {
                newDeckPanel = new DeckPanel(d.Value);
                DeckPanels.Add(newDeckPanel);
            }

            return DeckPanels;
        }

        public static List<DeckPanel> CreateDeckPanels(string str) {
            List<DeckPanel> DeckPanels = new List<DeckPanel>();
            if (DeckList.Count == 0) return DeckPanels;

            DeckPanel newDeckPanel;
            foreach (KeyValuePair<int, Deck> d in DeckList) {
                if (d.Value.Title.ToLower().Contains(str)) {
                    newDeckPanel = new DeckPanel(d.Value);
                    DeckPanels.Add(newDeckPanel);
                }
            }

            return DeckPanels;
        }

        public static Dictionary<int,Deck> getDeckList()
            {
            return DeckList;
		}
    }
}
