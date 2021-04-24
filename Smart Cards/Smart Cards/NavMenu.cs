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
     * Author: LS
     * Responsible for triggering navigation and updating NavMenu visual studios to make navigation selections as obvious as possible
     */
    public partial class NavMenu : UserControl
    {
        public NavMenu()
        {
            InitializeComponent();
        }

        /*
         * Methods to trigger the correct navigation based on which button is clicked
         */
        private void decksButton_Click(object sender, EventArgs e)
        {
            NavigationManager.SetActiveScreen(NavigationScreen.DeckList);
        }

        private void addDeckButton_Click(object sender, EventArgs e)
        {
            NavigationManager.SetActiveScreen(NavigationScreen.AddDeck);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            NavigationManager.SetActiveScreen(NavigationScreen.Help); 
        }

        private void shareButton_Click(object sender, EventArgs e) {
            NavigationManager.SetActiveScreen(NavigationScreen.Share);
        }

        //style each button to its "selected" appearance when clicked
        public void HighlightDeckListButton()
        {
            decksButton.BackColor = StyleManager.primaryColor;
            addDeckButton.BackColor = StyleManager.secondaryColor;
            helpButton.BackColor = StyleManager.secondaryColor;

            HighlightPanel.Location = new Point(decksButton.Location.X + decksButton.Width - HighlightPanel.Width, decksButton.Location.Y);
        }

        public void HighlightAddDeckButton()
        {
            decksButton.BackColor = StyleManager.secondaryColor;
            addDeckButton.BackColor = StyleManager.primaryColor;
            helpButton.BackColor = StyleManager.secondaryColor;

            HighlightPanel.Location = new Point(addDeckButton.Location.X + addDeckButton.Width - HighlightPanel.Width, addDeckButton.Location.Y);
        }

        public void HighlightHelpButton()
        {
            decksButton.BackColor = StyleManager.secondaryColor;
            addDeckButton.BackColor = StyleManager.secondaryColor;
            helpButton.BackColor = StyleManager.primaryColor;

            HighlightPanel.Location = new Point(helpButton.Location.X + helpButton.Width - HighlightPanel.Width, helpButton.Location.Y);
        }

        public void HighlightShareButton() {
            decksButton.BackColor = StyleManager.secondaryColor;
            addDeckButton.BackColor = StyleManager.secondaryColor;
            helpButton.BackColor = StyleManager.secondaryColor;
            shareButton.BackColor = StyleManager.primaryColor;

            HighlightPanel.Location = new Point(shareButton.Location.X + shareButton.Width - HighlightPanel.Width, shareButton.Location.Y);
        }

        /*
         * Trigger the closing of the primary form
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

		
	}
}
