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
        private List<DeckPanel> DeckPanels;

        public PrimaryForm()
        {
            InitializeComponent();

            fm = new FileManager("deck_data/DeckList.json");
            DeckList = fm.ImportDecksFromJson();
        }

        //use this to run neccessary code at the time the application runs
        private void PrimaryForm_Load(object sender, EventArgs e)
        {
            //instantiate the necessary variables
            MenuButtons = new Button[] { decksButton, addDeckButton, helpButton };
            DeckPanels = new List<DeckPanel>();

            //this will be the default screen when the app loads
            decksButton.PerformClick();
        }

        private void UpdateDeckScreen()
        {
            DeckPanel newDeckPanel;
            DeckPanels.Clear();
            foreach (Deck d in DeckList)
            {
                newDeckPanel = new DeckPanel(d);
                DeckListFlowPanel.Controls.Add(newDeckPanel);
                DeckPanels.Add(newDeckPanel);
                newDeckPanel.StudyButton.Click += new EventHandler(OnStudyButtonClicked);
                newDeckPanel.EditButton.Click += new EventHandler(OnEditButtonClicked);
            }
        }

        /// <summary>
        /// Styles the Menu to show which button is clicked
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

        /// <summary>
        /// Executes whenever a Study button of a deck is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnStudyButtonClicked(object sender, EventArgs e)
        {
            DeckListFlowPanel.Controls.Clear();
            DeckListFlowPanel.Controls.Add(new StudyPanel());
            MessageBox.Show("TODO: Show actual deck questions and answers here");
        }

        /// <summary>
        /// Executes whenever an Edit button of a deck is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            //clicks the Add Deck button on the menu bar for now
            addDeckButton_Click(null, EventArgs.Empty);
            MessageBox.Show("TODO: Populate textboxes with existing deck data");
        }
    }
}
