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

            DeckManager.ImportDecksFromJson();

            NavigationManager.InitializeControl(PrimaryDeckListPanel);
            NavigationManager.InitializeControl(PrimaryEditPanel);
            NavigationManager.InitializeControl(PrimaryStudyPanel);
            NavigationManager.InitializeControl(PrimaryHelpPanel);
            NavigationManager.InitializeControl(PrimaryAddNewDeckPanel);

            //Set deck list screen as active when the form loads
            NavigationManager.SetActiveScreen(NavigationScreen.DeckList);
        }

        private void PrimaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeckManager.ExportDecksToJson();
        }
    }
}
