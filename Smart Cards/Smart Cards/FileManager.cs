﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Smart_Cards
{
    public class FileManager
    {
        private readonly string filePath;


        private readonly StreamReader deckFile;

        public FileManager(string path)
        {
            filePath = path;
            if (File.Exists(filePath))
                deckFile = new StreamReader(filePath);
            //else
            //path to deck data doesn't exist
        }

        public List<Deck> ImportDecks()
        {
            List<Deck> deckList = new List<Deck>();

            //string line;
            //while ((line = deckFile.ReadLine()) != null)
            //{
            //    deckList.Add(ParseDeck(line));
            //}

            string data = deckFile.ReadToEnd();

            Console.WriteLine(data);

            DeckJson DeckJson = JsonConvert.DeserializeObject<DeckJson>(data);

            foreach (Deck d in DeckJson.DeckList)
            {
                Console.WriteLine(d.ToString());
            }

            return deckList;
        }

        private Deck ParseDeck(string deckData)
        {
            //assumptions: deck must have at least one card, a title, and a description
            //deck parse goes as follows:
            //each entry is separated by a comma
            //first entry is title
            //second entry is description
            //after that each entry is a card with front and back separated with forward slash

            //string[] strArray = deckData.Split(',');

            //string deckTitle = strArray[0];
            //string deckDescription = strArray[1];
            //List<Card> cards = new List<Card>();

            //ignore the first 2 elements (those are title and desc)
            //for (int i = 2; i < strArray.Length; i += 2)
            //{
            //    cards.Add(new Card(strArray[i], strArray[i + 1]));
            //}

            //return new Deck(deckTitle, deckDescription, cards);

            return null;
        }

        private void SaveDecks(List<Deck> deckList)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePath);

                foreach (Deck d in deckList)
                {
                    sw.WriteLine(d.Title + "," + d.Description + "," + "cards go here");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}

