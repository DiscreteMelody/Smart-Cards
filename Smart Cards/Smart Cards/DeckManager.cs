using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cards
{
    public static class DeckManager
    {
        private static Dictionary<int,Deck> DeckList = new Dictionary<int, Deck>();

        public static int nextId = 0;

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
                nextId = DeckList.Count;
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
            Deck newDeck = new Deck(nextId, DeckTitle, DeckDescription, new List<Card>());
            DeckList.Add(newDeck.Id, newDeck);
            nextId++;
            return newDeck;
        }

        public static void DeleteDeck(Deck deckToDelete)
        {
            DeckList.Remove(deckToDelete.Id);
            nextId--;
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

        public static Dictionary<int, string> getDeckNames() {
            Dictionary<int, string> deckNames = new Dictionary<int, string>();
            foreach(KeyValuePair<int, Deck> kvp in DeckList) {
				deckNames.Add(kvp.Key, kvp.Value.Title);
			}

            return deckNames;
		}

        public static void ShareDecks(List<int> ids) {
            List<Deck> exportList = new List<Deck>();
            
            foreach(int id in ids) {
                Deck deck = GetDeckFromId(id);
                
                exportList.Add(deck);
			}

            using(SaveFileDialog sfd = new SaveFileDialog()) {
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.FileName = "SmartCards_Export";
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.Title = "Save Your Exported Decks";
                sfd.ShowDialog();

                if (sfd.FileName != "") {
                    using (StreamWriter export = File.CreateText(sfd.FileName)) {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(export, exportList);
                    }
                }
            }
		}

        public static void ImportDecks() {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.Title = "Import Shared Decks";

                if (ofd.ShowDialog() == DialogResult.OK) {
                    try {
                        List<Deck> importedDecks = new List<Deck>();
                        List<string> titles = DeckList.Values.ToList().Select(el => el.Title).ToList();

                        using (StreamReader file = File.OpenText(ofd.FileName)) {
                            string json = file.ReadToEnd();
                            importedDecks = JsonConvert.DeserializeObject<List<Deck>>(json);
                        }

                        foreach(Deck d in importedDecks) {
                            if (titles.Contains(d.Title)) {
                                d.Title = d.Title + " (From import)";
							}
                            DeckList.Add(nextId, d);
                            nextId++;
						}
					} catch(Exception e) {
                        Console.WriteLine(e);
					}
				}
            }
		}
    }
}
