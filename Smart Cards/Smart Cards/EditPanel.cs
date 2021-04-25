using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Cards
{
    /*
     * Allows the user to edit or delete the selected deck from the DeckList screen
     */
    public partial class EditPanel : UserControl
    {
        private List<EditCardPanel> cards; //Used to keep track of all present EditCardPanels for card search functionality
        private Deck DeckReference;
        private Button SearchButton;
        private Button clearBtn;
        private TextBox SearchBox;

        /*
         * Author: LM
         * Establish some basic UI elements and initialize the List<EditCardPanel>
         */
        public EditPanel()
        {
            InitializeComponent();
            tableLayoutPanel1.Visible = false;
            SearchButton = (Button) tableLayoutPanel1.Controls.Find("searchButton", true)[0];
            SearchBox = new TextBox() { Font = new Font(this.Font.FontFamily, 14), Width = 400 };
            SearchBox.TextChanged += new EventHandler(SearchBox_textChanged);

            clearBtn = new Button() { Size = new Size(32, 32), Cursor = Cursors.Default, Image = Properties.Resources.clear_search_icon, Name = "clearBtn" };
            clearBtn.Location = new Point(SearchBox.ClientSize.Width - clearBtn.Width, -1);
            clearBtn.Click += new EventHandler(clearBtn_Click);
            SearchBox.Controls.Add(clearBtn);

            cards = new List<EditCardPanel>();
        }

        /*
         * Author: LS, LM
         * Notes: Levi wrote the majority of this, Lucas added the lines regarding adding to the cards list and controlling the visibility of the table layout
         * Get the details and cards from the selected deck and create all the needed EditCardPanels
         * If there are any cards to show, then make the containing TableLayout visible
         */
        public void SetDeckToEdit(int DeckId)
        {
            DeckReference = DeckManager.GetDeckFromId(DeckId);
            termFlowLayoutPanel.Controls.Clear();
            if (DeckReference != null)
            {
                deckTitleTextbox.Text = DeckReference.Title;
                foreach (Card c in DeckReference.Cards)
                {
                    EditCardPanel newPanel = new EditCardPanel(c, this);
                    termFlowLayoutPanel.Controls.Add(newPanel);
                    cards.Add(newPanel);
                }

                if (DeckReference.Cards.Count > 0) {
                    tableLayoutPanel1.Visible = true;
                }
            }
        }

        /*
         * Author: LM
         * Re-renders all the EditCardPanels after clearing the search
         */
        public void ResetCards() {
            termFlowLayoutPanel.Controls.Clear();
            termFlowLayoutPanel.Controls.AddRange(cards.ToArray());
            if (cards.Count>0) {
                tableLayoutPanel1.Visible = true;
            }
        }

        /*
         * Author: LM
         * Accepts the latest search string from the search textbox and re-renders EditCardPanels only for the cards that contain the given string in their question and/or answer
         */
        public void SearchCards(string str) {
            termFlowLayoutPanel.Controls.Clear();
            //Convert list of EditCardPanels in to list of Cards
            List<Card> cardList = cards.Select(ecp=>ecp.ConvertToCard()).ToList();
            //Filter the list of cards into a list only containing cards that contain the search string in their question and/or answer
            List<Card> filteredCards = cardList.Where(el => el.Question.ToLower().Contains(str) || el.Answer.ToLower().Contains(str)).ToList();

            //Loop the filtered cards and render the new EditCardPanels for those cards
            foreach (Card c in filteredCards) {
                termFlowLayoutPanel.Controls.Add(new EditCardPanel(c, this));
            }
        }

        /*
         * Author: LM
         * Clear any text out of the search textbox
         */
        public void ResetSearch() {
            SearchBox.Clear();
		}

        /*
         * Author: LM
         * Keep track of when an EditCardPanel is removed from the deck to determine if the TableLayout containing the cards should remain visible
         */
        public void OnCardRemoved() {
            if (termFlowLayoutPanel.Controls.Count == 0) {
                tableLayoutPanel1.Visible = false;
			}
		}

        public void SaveCurrentDeck() {
            List<Card> Cards = new List<Card>();
            foreach (EditCardPanel cardInDeck in this.termFlowLayoutPanel.Controls) {
                Cards.Add(cardInDeck.ConvertToCard());
            }
            DeckReference.Cards = Cards;
            DeckReference.Title = deckTitleTextbox.Text;
            DeckManager.OverwriteDeck(DeckReference);
            DeckManager.ExportDecksToJson();
        }


        //fires when the delete button is clicked - LS
        /*
         * Author: LS, LM
         * Notes: Levi wrote most of this method, Lucas updated it to use the new overloaded version of the NavigationManager.SetActiveScreen method to prevent any attempts to autosave a deck that no longer exists when navigating away
         * Asks the user to confirm deleting the current deck and navigates back to DeckList screen without trying to autosave after deleting
         */
        private void deleteDeckButton_Click(object sender, EventArgs e)
        {
            //create a yes/no dialog box - LS
            var confirmResult = MessageBox.Show("Really delete the deck?", "Deck deletion", MessageBoxButtons.YesNo);

            //if the user answers yes - LS
            if (confirmResult == DialogResult.Yes)
            {
                DeckManager.DeleteDeck(DeckReference);
                DeckManager.ExportDecksToJson();
                //Calls new overload of SetActiveScreen, avoids attempting to autosave deck that no longer exists
                NavigationManager.SetActiveScreen(NavigationScreen.DeckList, false);
            }
        }

        //fires whenever the Add Term button is clicked - LS
        /*
         * Author: LS, LM
         * Notes: Levi wrote the original version of this method, Lucas later updated it to work with the addition of the card search functionality
         * Creates a new EditCardPanel populated with an empty card and adds it to the list
         * Makes the card list visible if it was hidden and empty, resets the search textbox if the list was already visible in case the user was actively searching for a card when they decided to create a new one
         */
        private void addTermButton_Click(object sender, EventArgs e)
        {
            //Disabling and later reenabling the searchbox to get it to give up focus, otherwise it causes some odd conflicts with button click functionality
            SearchBox.Enabled = false;
            EditCardPanel newPanel = new EditCardPanel(new Card(), this);
            termFlowLayoutPanel.Controls.Add(newPanel);
            cards.Add(newPanel);
            //Show the TableLayout if it was hidden due to being empty, otherwise resets the search bar
            if (tableLayoutPanel1.Visible==false) {
                tableLayoutPanel1.Visible = true;
            } else {
                this.ResetSearch();
            }
            SearchBox.Enabled = true;
        }

        /*
         * Author: LM
         * Save the current deck to storage and navigate back to the DeckList without attempting to autosave becuase it is redundant
         */
        private void saveDeckButton_Click(object sender, EventArgs e)
        {
            SaveCurrentDeck();

            NavigationManager.SetActiveScreen(NavigationScreen.DeckList, false);
        }

        /*
         * Author: LM
         * Replace the search button with the search box when the button is clicked
         */
		private void searchButton_Click(object sender, EventArgs e) {
            tableLayoutPanel1.Controls.Remove(SearchButton);
            tableLayoutPanel1.Controls.Add(SearchBox, 1, 0);
		}

        /*
         * Author: LM
         * Clear any text from the search box and replace with the search button when the clear button is clicked
         * Re-render EditCardPanels for all the cards
         * Reset focus
         */
        private void clearBtn_Click(object sender, EventArgs e) {
            tableLayoutPanel1.Controls.Remove(SearchBox);
            tableLayoutPanel1.Controls.Add(SearchButton, 1, 0);
            this.ActiveControl = null;
            this.ResetSearch();
            this.ResetCards();
        }

        /*
         * Author: LM
         * The foundation of the card search functionality
         * Evaluate the length of the current string in the textbox every time it changes
         * If length > 0 then search for cards containing the string, otherwise just render all EditCardPanels
         */
        private void SearchBox_textChanged(object sender, EventArgs e) {
            if (SearchBox.Text.Length>0) {
                SearchCards(SearchBox.Text.ToLower());
			}
            else {
                ResetCards();
			}
		}
    }
}
