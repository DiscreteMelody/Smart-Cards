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
    public partial class DeckPanel : UserControl
    {
        private Deck DeckReference;
        public DeckPanel(Deck d)
        {
            InitializeComponent();

            DeckReference = d;

            deckTitleLabel.Text = DeckReference.Title;
        }
    }
}
