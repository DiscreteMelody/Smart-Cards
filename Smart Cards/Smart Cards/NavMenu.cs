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
    public partial class NavMenu : UserControl
    {
        public NavMenu()
        {
            InitializeComponent();
        }

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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}
