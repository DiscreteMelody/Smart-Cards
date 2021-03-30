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
        private readonly FileManager fm;
        private readonly List<Deck> DeckList;
        public PrimaryForm()
        {
            InitializeComponent();

            fm = new FileManager("deck_data/DeckList.json");
            DeckList = fm.ImportDecksFromJson();
        }

        private void addDeckButton_Click(object sender, EventArgs e)
        {
            
        }

        //use this to run neccessary code at the time the application runs
        private void PrimaryForm_Load(object sender, EventArgs e)
        {
            //this will be the default screen when the app loads
            decksButton.PerformClick();


            UpdateDeckScreen();
        }

        private void UpdateDeckScreen()
        {


            DeckPanel newDeckPanel;
            foreach (Deck d in DeckList)
            {
                newDeckPanel = new DeckPanel(d);
                DeckListFlowPanel.Controls.Add(newDeckPanel);
            }
        }
    }
}
