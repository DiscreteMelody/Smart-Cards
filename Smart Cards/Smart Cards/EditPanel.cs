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
        //parrallel lists to store the added and deleted UI controls
        private List<CustomizedTextBox> termTextboxes;
        private List<CustomizedTextBox> termAnswerTextboxes;
        private List<Button> deleteTermButtons;

        private Deck DeckReference;

        public EditPanel(Deck DeckClicked)
        {
            InitializeComponent();

            DeckReference = DeckClicked;
        }

        //use this to run necessary code when the EditPanel is opened
        private void EditPanel_Load(object sender, EventArgs e)
        {
            //termTextboxes = new List<CustomizedTextBox>() { termTextbox };
            //termAnswerTextboxes = new List<CustomizedTextBox>() { termAnswerTextbox };
            //deleteTermButtons = new List<Button>() { deleteTermButton };
            //deleteTermButton.Click += new EventHandler(OnDeleteButtonClicked);
            //deleteTermButton.Enabled = false;

            foreach (Card c in DeckReference.Cards)
            {
                termFlowLayoutPanel.Controls.Add(new EditCardPanel(c));
            }

            this.EditPanel_Resize(sender, e);
        }

        private void EditPanel_Resize(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.Width = Parent.Width;
            this.Height = Parent.Height;

            termFlowLayoutPanel.Height = Convert.ToInt32(this.Height * 0.45);
            termFlowLayoutPanel.Width = Convert.ToInt32(this.Width * 0.9);

        }

        /// <summary>
        /// Executes whenever a delete button is pressed on the EditPanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            //remove the chosen delete button, answertextbox, and termtextbox from the EditPanel
            for (int i = 0; i < deleteTermButtons.Count; i++)
            {
                if (deleteTermButtons[i] == sender)
                {
                    deleteTermButtons[i].Dispose();
                    termTextboxes[i].Dispose();
                    termAnswerTextboxes[i].Dispose();

                    deleteTermButtons.RemoveAt(i);
                    termTextboxes.RemoveAt(i);
                    termAnswerTextboxes.RemoveAt(i);
                    break;
                }
            }

            //if there is only 1 term left in the list, disable its delete button
            if (deleteTermButtons.Count == 1)
            {
                deleteTermButtons[0].Enabled = false;
            }
        }

        private void deleteDeckButton_Click(object sender, EventArgs e)
        {
            //create a yes/no dialog box
            var confirmResult = MessageBox.Show("Really delete the deck?", "Deck deletion", MessageBoxButtons.YesNo);

            //if the user answers yes
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("TODO: delete the user's deck.");
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
                Cards.Add(cardInDeck.CardReference);
            }
            DeckReference = new Deck(deckTitleTextbox.Text, "description", Cards);

        }
    }
}
