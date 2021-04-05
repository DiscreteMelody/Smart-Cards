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
        private Deck DeckReference;
        public EditPanel()
        {
            InitializeComponent();
        }

        public void setDeckToEdit(int DeckId)
        {
            DeckReference = DeckManager.GetDeckFromId(DeckId);
            termFlowLayoutPanel.Controls.Clear();
            if (DeckReference != null)
            {
                deckTitleTextbox.Text = DeckReference.Title;
                foreach (KeyValuePair<int, Card> c in DeckReference.Cards)
                {
                    termFlowLayoutPanel.Controls.Add(new EditCardPanel(c.Value));
                }
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
                PrimaryForm mainForm = (PrimaryForm)ParentForm;
                mainForm.setDeckView();
            }
        }

        private void addTermButton_Click(object sender, EventArgs e)
        {
            termFlowLayoutPanel.Controls.Add(new EditCardPanel(new Card()));
        }

        private void saveDeckButton_Click(object sender, EventArgs e)
        {
            List<Card> Cards = new List<Card>();
            foreach (EditCardPanel cardInDeck in this.termFlowLayoutPanel.Controls)
            {
                Console.WriteLine(cardInDeck.CardReference.ToString());
                Cards.Add(cardInDeck.CardReference);
            }
            DeckReference = new Deck(DeckReference.Id, deckTitleTextbox.Text, "description", Cards);

            DeckManager.OverwriteDeck(DeckReference);
            DeckManager.ExportDecksToJson();

            PrimaryForm mainForm = (PrimaryForm)ParentForm;
            mainForm.setDeckView();
        }

        
    }
}
