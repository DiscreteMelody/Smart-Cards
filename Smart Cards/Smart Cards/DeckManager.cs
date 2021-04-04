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


        private static readonly StreamReader deckFile = new StreamReader(filePath);


        //reads Json file located at 'filePath' and returns list of Decks
        public static void ImportDecksFromJson()
        {
            string data = deckFile.ReadToEnd();
            DeckJson DeckJson = JsonConvert.DeserializeObject<DeckJson>(data);

            foreach (Deck d in DeckJson.DeckList)
            {
                DeckList[d.Id] = d;
                Console.WriteLine(d.ToString());
            }
        }

        public static Deck GetDeckFromId(int id)
        {
            return DeckList[id];
        }

        public static void OverwriteDeck(Deck newDeck)
        {
            DeckList[newDeck.Id] = newDeck;
        }

        public static void DeleteDeck(Deck deckToDelete)
        {
            DeckList.Remove(deckToDelete.Id);
        }

        //Takes a List<Deck> parameter and sets the DeckList equal to it
        //public static void UpdateDeckList(List<Deck> UpdatedDeckList)
        //{
        //    DeckList = UpdatedDeckList;
        //
        //    ExportDecksToJson();
        //}

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

    }
}
