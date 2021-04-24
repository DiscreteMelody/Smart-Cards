using Smart_Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Smart_Cards
{
    public partial class PrimaryForm : Form
    {
        public PrimaryForm()
        {
            InitializeComponent();

            //Import deck file
            DeckManager.ImportDecksFromJson();

            //Initialize references to form controls
            NavigationManager.GetParent(this);
            NavigationManager.InitializeControl(PrimaryNavMenu);
            
            NavigationManager.InitializeControl(PrimaryDeckListPanel);
            NavigationManager.InitializeControl(PrimaryEditPanel);
            NavigationManager.InitializeControl(PrimaryStudyPanel);
            NavigationManager.InitializeControl(PrimaryHelpPanel);
            NavigationManager.InitializeControl(PrimaryAddNewDeckPanel);
            NavigationManager.InitializeControl(PrimarySharePanel);

            //Set deck list screen as active when the form loads
            NavigationManager.SetActiveScreen(NavigationScreen.DeckList);
        }

        /*
         * Author: LM
         * Determines whether a given child panel of the PrimaryForm is currently placed at the fron of the visual order
         */
        public bool IsFrontPanel (Control panel) {
            int index = this.ContentPanel.Controls.GetChildIndex(panel);
            if (index==0) {
                return true;
			} else {
                return false;
			}
		}

        /*
         * Author: BH
         * Detects when the PrimaryForm is closing, signaling that the application is closing
         * Writes the master DeckList to storage one more time before closing so that the next time the application starts it has access to the most recent, up-to-date data
         */
        private void PrimaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeckManager.ExportDecksToJson();
        }
    }
}
