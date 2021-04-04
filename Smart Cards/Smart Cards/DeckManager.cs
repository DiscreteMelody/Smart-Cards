using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cards
{
    public static class DeckManager
    {
        private static List<Deck> DeckList = new List<Deck>();

        private static readonly string filePath = "deck_data/DeckList.json";


        private static readonly StreamReader deckFile = new StreamReader(filePath);


        //reads Json file located at 'filePath' and returns list of Decks
        public static void ImportDecksFromJson()
        {
            string data = deckFile.ReadToEnd();
            DeckJson DeckJson = JsonConvert.DeserializeObject<DeckJson>(data);

            foreach (Deck d in DeckJson.DeckList)
            {
                Console.WriteLine(d.ToString());
            }

            DeckList = DeckJson.DeckList;
        }

        public static List<DeckPanel> CreateDeckPanels()
        {
            List<DeckPanel> DeckPanels = new List<DeckPanel>();

            DeckPanel newDeckPanel;
            foreach (Deck d in DeckList)
            {
                newDeckPanel = new DeckPanel(d);
                DeckPanels.Add(newDeckPanel);
            }

            return DeckPanels;
        }


        public static void SaveDecks(List<Deck> deckList)
        {
            try
            {
                using (StreamWriter file = File.CreateText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, deckList);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

    }
}
