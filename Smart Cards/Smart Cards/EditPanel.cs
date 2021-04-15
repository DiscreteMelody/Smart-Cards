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
    public partial class EditPanel : UserControl
    {
        private List<EditCardPanel> cards;
        private Deck DeckReference;
        private Button SearchButton;
        private Button clearBtn;
        private TextBox SearchBox;
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

        public void ResetCards() {
            termFlowLayoutPanel.Controls.Clear();
            termFlowLayoutPanel.Controls.AddRange(cards.ToArray());
            if (cards.Count>0) {
                tableLayoutPanel1.Visible = true;
            }
            /*if (DeckReference != null) {

                foreach (Card c in DeckReference.Cards) {
                    termFlowLayoutPanel.Controls.Add(new EditCardPanel(c, this));
                }

                if (DeckReference.Cards.Count > 0) {
                    
                }
            }*/
        }

        public void SearchCards(string str) {
            termFlowLayoutPanel.Controls.Clear();

            List<EditCardPanel> ecps = termFlowLayoutPanel.Controls.Cast<EditCardPanel>().ToList();
            List<Card> cardList = ecps.Select(ecp=>ecp.ConvertToCard()).ToList();

            foreach (Card c in cardList.Where(el=>el.Question.ToLower().Contains(str) || el.Answer.ToLower().Contains(str))) {
                termFlowLayoutPanel.Controls.Add(new EditCardPanel(c, this));
            }
        }

        public void ResetSearch() {
            SearchBox.Clear();
		}

        public void OnCardRemoved() {
            if (termFlowLayoutPanel.Controls.Count == 0) {
                tableLayoutPanel1.Visible = false;
			}
		}


        private void deleteDeckButton_Click(object sender, EventArgs e)
        {
            //create a yes/no dialog box
            var confirmResult = MessageBox.Show("Really delete the deck?", "Deck deletion", MessageBoxButtons.YesNo);

            //if the user answers yes
            if (confirmResult == DialogResult.Yes)
            {
                DeckManager.DeleteDeck(DeckReference);
                DeckManager.ExportDecksToJson();

                NavigationManager.SetActiveScreen(NavigationScreen.DeckList);
            }
        }

        private void addTermButton_Click(object sender, EventArgs e)
        {
            SearchBox.Enabled = false;
            EditCardPanel newPanel = new EditCardPanel(new Card(), this);
            termFlowLayoutPanel.Controls.Add(newPanel);
            cards.Add(newPanel);
            if (tableLayoutPanel1.Visible==false) {
                tableLayoutPanel1.Visible = true;
            } else {
                this.ResetSearch();
            }
            SearchBox.Enabled = true;
        }

        private void saveDeckButton_Click(object sender, EventArgs e)
        {
            List<Card> Cards = new List<Card>();
            foreach (EditCardPanel cardInDeck in this.termFlowLayoutPanel.Controls)
            {
                Cards.Add(cardInDeck.ConvertToCard());
            }
            DeckReference = new Deck(deckTitleTextbox.Text, "description", Cards,DeckReference.Id);

            DeckManager.OverwriteDeck(DeckReference);
            DeckManager.ExportDecksToJson();

            NavigationManager.SetActiveScreen(NavigationScreen.DeckList);
        }

		private void label1_Click(object sender, EventArgs e) {

		}

		private void searchButton_Click(object sender, EventArgs e) {
            tableLayoutPanel1.Controls.Remove(SearchButton);
            tableLayoutPanel1.Controls.Add(SearchBox, 1, 0);
		}

        private void clearBtn_Click(object sender, EventArgs e) {
            tableLayoutPanel1.Controls.Remove(SearchBox);
            tableLayoutPanel1.Controls.Add(SearchButton, 1, 0);
            this.ActiveControl = null;
            this.ResetSearch();
            this.ResetCards();
        }

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
