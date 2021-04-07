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
    public partial class DeckListPanel : UserControl
    {
        public DeckListPanel()
        {
            InitializeComponent();
        }

        //takes deck panels that DeckManager creates from its DeckList
        //and adds the controls into the flow layout
        public void LoadDeckPanels()
        {
            foreach (DeckPanel dp in DeckManager.CreateDeckPanels())
            {
                DeckListFlowLayoutPanel.Controls.Add(dp);
            }
        }
    }
}
