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
        FileManager fm;
        public PrimaryForm()
        {
            InitializeComponent();

            fm = new FileManager("deck_data/DeckList.json");
        }

        private void studyPanel1_Load(object sender, EventArgs e)
        {

        }

        private void addDeckButton_Click(object sender, EventArgs e)
        {
            fm.ImportDecks();
        }

        //use this to run neccessary code at the time the application runs
        private void PrimaryForm_Load(object sender, EventArgs e)
        {
            //this will be the default screen when the app loads
            decksButton.PerformClick();
        }
    }
}
