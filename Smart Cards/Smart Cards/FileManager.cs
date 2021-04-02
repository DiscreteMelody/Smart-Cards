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

        //reads Json file located at 'filePath' and returns list of Decks
        public List<Deck> ImportDecksFromJson()
        {
            string data = deckFile.ReadToEnd();
            DeckJson DeckJson = JsonConvert.DeserializeObject<DeckJson>(data);

            foreach (Deck d in DeckJson.DeckList)
            {
                Console.WriteLine(d.ToString());
            }

            return DeckJson.DeckList;
        }


        public void SaveDecks(List<Deck> deckList)
        {
            try
            {
                using (StreamWriter file = File.CreateText(filePath)) {
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

