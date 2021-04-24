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
    /*
     * Contains all the methods and functionality needed to work with file storage
     * Allows for file management to abstracted through public methods so that external classes cannot directly modify the storage file
     * File is always populated with JSON
     * Serialization and deserialization performed using Newtonsoft
     */
    public static class DeckManager
    {
        private static Dictionary<int,Deck> DeckList = new Dictionary<int, Deck>();
        public static int nextId = 0;
        //Data file will always be located in the currently signed-in user's AppData/Roaming directory. This makes it easy to deal with a standardized location that is not relative to the location of the project files
        private static readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Smart_Cards\\DeckList.json");
        private static readonly string backup_filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Smart_Cards\\DeckList_Backup.json");

        /*
         * Author: BH, LM
         * Notes: Ben wrote almost all of this method, Lucas  added the line assigning nextId as part of an update to the system of tracking deck ids while working on the deck import/export feature as well as the backup data file functionality
         * Reads all text from the data file as JSON and deserializes into dictionary
         */
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
                try {
                    string backup_data = File.ReadAllText(backup_filePath);
                    DeckList = JsonConvert.DeserializeObject<Dictionary<int, Deck>>(backup_data);
                    nextId = DeckList.Count;
                    Console.WriteLine(DeckList.Count);
                } catch (Exception e2) {
                    Console.WriteLine("Could not read backup file:" + e2.Message);
				}
                Console.WriteLine("Could not read file: " + e.Message);
            }
        }

        /*
         * Author: BH, LM
         * Notes: Ben wrote the basic export functionality during the initial development phase, Lucas wrote the section in the nested try/catch block afterwards to solve the app crashing when trying to save if the file didn't already exist
         * Attempts to serialize the dictionary of Decks and write it to the data file
         * If that fails, check to see if the path to the file exists. If the filepath does not exist, create the path and then try again to create the file with serialized dictionary
         */
		public static void ExportDecksToJson()
        {
            try
            {
                using (StreamWriter file = File.CreateText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, DeckList);
                }
                using (StreamWriter backup_file = File.CreateText(backup_filePath)) {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(backup_file, DeckList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not write file: " + e.Message);
                try {
                    //Check to see if path to the primary data file exists
                    if (!Directory.Exists(filePath)) {
                        //If not, then create the path and then try writing the file again
                        Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Smart_Cards"));
                        using (StreamWriter file = File.CreateText(filePath)) {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.Serialize(file, DeckList);
                        }
                    } else {
                        Console.WriteLine(e);
                    }
                    //Check to see if path to backup data file exists
                    if (!Directory.Exists(backup_filePath)) {
                        //If not, then create the path and then try writing the file again
                        Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Smart_Cards"));
                        using (StreamWriter backup_file = File.CreateText(backup_filePath)) {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.Serialize(backup_file, DeckList);
                        }
                    }
                    else {
                        Console.WriteLine(e);
                    }
                } catch (Exception e2) {
                    Console.WriteLine(e2.Message);
				}
            }
        }

        /*
         * Author: BH
         * Allows us to get a specific deck from the dictionary by its id
         */
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

        /*
         * Author: BH
         * Pass in a deck and it's original will be replaced in DeckList storage with the new one
         * This is used when editing a deck
         */
        public static void OverwriteDeck(Deck newDeck)
        {
            DeckList[newDeck.Id] = newDeck;
        }

        /*
         * Author: BH, LM
         * Notes: Ben wrote most of this method, Lucas modified it to use the new method of tracking deck ids from within the DeckManager class rather than withing the Deck class
         * Creates an empty deck, adds it to the DeckList and returns it
         * Updates the nextId value so that the next deck that gets added or created won't have conflicts in the dictionary for trying to use an existing key value
         */
        public static Deck CreateNewDeck(string DeckTitle = Deck.DefaultTitle,string DeckDescription = Deck.DefaultDescription)
        {
            Deck newDeck = new Deck(nextId, DeckTitle, DeckDescription, new List<Card>());
            DeckList.Add(newDeck.Id, newDeck);
            nextId++;
            return newDeck;
        }

        /*
         * Author: BH, LM
         * Notes: Ben wrote most of this method, Lucas modified it to use the new method of tracking deck ids from within the DeckManager class rather than withing the Deck class
         * Removes the selected deck from the DeckList 
         * Updates the nextId value so that the next deck that gets added or created won't have conflicts in the dictionary for trying to use an existing key value
         */
        public static void DeleteDeck(Deck deckToDelete)
        {
            DeckList.Remove(deckToDelete.Id);
            nextId--;
        }

        /*
         * Author: BH
         * Creates and returns deck panels to the DeckList screen for all of the Decks contained in data
         */
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

        /*
         * Author: LM
         * Overload for Ben's version of the CreateDeckPanels() method
         * Takes in a search string from the DeckList screen search box
         * Returns a DeckPanel for all decks with a title that contains the current search string
         */
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
        /*
         * Author: LM
         * Returns the entire DeckList dictionary
         * Used for unit testing
         */
        public static Dictionary<int,Deck> getDeckList()
        {
            return DeckList;
		}

        /*
         * Author: LM
         * Returns a dictionary consisting of the id of each deck and its title
         * Used to populate the CheckListBox on the share screen for exporting existing decks
         */
        public static Dictionary<int, string> getDeckNames() {
            Dictionary<int, string> deckNames = new Dictionary<int, string>();
            foreach(KeyValuePair<int, Deck> kvp in DeckList) {
				deckNames.Add(kvp.Key, kvp.Value.Title);
			}

            return deckNames;
		}

        /*
         * Author: LM
         * Takes in a List<int> representing the ids of the decks selected for export
         * Loops to get each desired deck and store in a List<Deck>
         * Opens a SaveFileDialog to allow the user to select where they want the new export file written and what they want it named
         * If the user clicks save and the new file name is any windows-valid, non-empty string then serialize the relevant data and write the file
         */
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

        /*
         * Author: LM
         * Opens a file dialog to allow the user to select a file
         * If the user clicks then try to read the file
         * For each deck in the file, see if a deck with that name already exists (if yes, then update the deck name to make it clear it was imported) and add it to the DeckList
         */
        public static void ImportDecks() {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.Title = "Import Shared Decks";

                if (ofd.ShowDialog() == DialogResult.OK) {
                    try {
                        //set up new Lists
                        //One to deserialize the file contents into
                        //The other to hold the titles of all existing decks to check against
                        List<Deck> importedDecks = new List<Deck>();
                        List<string> titles = DeckList.Values.ToList().Select(el => el.Title).ToList();


                        using (StreamReader file = File.OpenText(ofd.FileName)) {
                            string json = file.ReadToEnd();
                            importedDecks = JsonConvert.DeserializeObject<List<Deck>>(json);
                        }

                        //Loop all the import decks
                        //if the title already exists in another deck, update it to make clear that the new deck is imported
                        //Give each new deck a new id to ensure that there are no conflicts in the DeckList dictionary for trying to reuse an existing key
                        //Then add the new imported deck to the DeckList
                        foreach(Deck d in importedDecks) {
                            if (titles.Contains(d.Title)) {
                                d.Title = d.Title + " (From import)";
							}
                            DeckList.Add(nextId, new Deck(nextId, d.Title, d.Description, d.Cards));
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
