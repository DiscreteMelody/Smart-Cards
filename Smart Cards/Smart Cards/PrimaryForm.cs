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
        private Button[] MenuButtons;

        public PrimaryForm()
        {
            InitializeComponent();

            fm = new FileManager("deck_data/DeckList.json");
            DeckList = fm.ImportDecksFromJson();
        }

        //use this to run neccessary code at the time the application runs
        private void PrimaryForm_Load(object sender, EventArgs e)
        {
            //instantiate the side menu buttons here
            MenuButtons = new Button[] { decksButton, addDeckButton, helpButton };

            //this will be the default screen when the app loads
            decksButton.PerformClick();
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

        /// <summary>
        /// Styles the Menu to show which button
        /// </summary>
        /// <param name="button"></param>
        private void SetMenuButtonAsClicked(Button button)
        {
            ResetMenuButtons();
            button.BackColor = StyleManager.primaryColor;
            //set the highlight panel to the right of the clicked button
            highlightPanel.Location = new Point(button.Location.X + button.Width - highlightPanel.Width, button.Location.Y);
        }

        /// <summary>
        /// Resets the left hand menu buttons as not clicked
        /// </summary>
        private void ResetMenuButtons()
        {
            for (int i = 0; i < MenuButtons.Length; i++)
            {
                Button buttonToStyle = MenuButtons[i];
                buttonToStyle.BackColor = StyleManager.secondaryColor;
            }
        }

        private void decksButton_Click(object sender, EventArgs e)
        {
            SetMenuButtonAsClicked(decksButton);
            DeckListFlowPanel.Controls.Clear();
            UpdateDeckScreen();
        }

        private void addDeckButton_Click(object sender, EventArgs e)
        {
            SetMenuButtonAsClicked(addDeckButton);
            DeckListFlowPanel.Controls.Clear();
            DeckListFlowPanel.Controls.Add(new EditPanel());
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            SetMenuButtonAsClicked(helpButton);
            DeckListFlowPanel.Controls.Clear();
            DeckListFlowPanel.Controls.Add(new HelpPanel());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
