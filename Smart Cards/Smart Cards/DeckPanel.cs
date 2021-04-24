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
     * Author: BH
     * Class representing a panel for each individual deck on the DeckList screen
     */
    public partial class DeckPanel : UserControl
    {
        public Deck DeckReference { get; set; }
        
        public CircularButton StudyButton
        {
            get { return studyButton; }
        }

        public CircularButton EditButton
        {
            get { return editButton; }
        }

        public DeckPanel(Deck d)
        {
            InitializeComponent();

            DeckReference = d;

            deckTitleLabel.Text = DeckReference.Title;
        }

        /*
         *Send the user to the Edit Deck screen to edit the selected deck - BH
         */
        private void editButton_Click(object sender, EventArgs e)
        {
            NavigationManager.SetActiveScreen(NavigationScreen.EditDeck, DeckReference.Id);
        }

        /*
         *Send the user to the Study screen to study the cards in the selected deck - BH
         */
        private void studyButton_Click(object sender, EventArgs e)
        {
            NavigationManager.SetActiveScreen(NavigationScreen.StudyDeck, DeckReference.Id);
        }
    }
}
