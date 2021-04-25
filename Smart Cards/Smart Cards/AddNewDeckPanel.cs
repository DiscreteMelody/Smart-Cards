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
    //Class for panel when adding new deck
    //Author: BH
    public partial class AddNewDeckPanel : UserControl
    {
        public AddNewDeckPanel()
        {
            InitializeComponent();
        }

        //Creates new empty deck and sets view to edit it
        private void CreateDeckButton_Click(object sender, EventArgs e)
        {
            Deck NewDeck = DeckManager.CreateNewDeck(DeckTitle.Text,DeckDescription.Text);
            NavigationManager.SetActiveScreen(NavigationScreen.EditDeck, NewDeck.Id);
            DeckTitle.clearText();
            DeckDescription.clearText();
        }

        //Clears the contents of the textboxes and sends the user back to the DeckList screen
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DeckTitle.clearText();
            DeckDescription.clearText();

            NavigationManager.SetActiveScreen(NavigationScreen.DeckList);
        }
	}
}
