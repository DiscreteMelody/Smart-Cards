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
     * Takes in the contents of a card and a reference to the parent EditDeck panel
     * Allow the user to edit the contents of a card before saving it back to the deck
     */
    public partial class EditCardPanel : UserControl
    {
        public static EditPanel edit;
        public Card CardReference { get; set; }

        /*
         * Constructor
         * Takes a Card object and reference to the parent panel
         */
        public EditCardPanel(Card c, EditPanel ep)
        {
            InitializeComponent();

            CardReference = c;
            edit = ep;

            QuestionTextbox.Text = CardReference.Question;
            AnswerTextbox.Text = CardReference.Answer;
        }

        /*
         * Returns this EditCardPanel's values as a Card
         * Used when saving the parent Deck
         */
        public Card ConvertToCard()
        {
            return new Card(QuestionTextbox.Text, AnswerTextbox.Text);
        }

        /*
         * Remove this EditCardPanel from the parent panel's list of controls
         * Fire the parent's OnCardRemoved method to update the parent's state to reflect the now missing card
         */
        private void deleteTermButton_Click_1(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            edit.OnCardRemoved();
        }

    }
}
