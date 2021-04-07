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
        private Button[] MenuButtons;
        public EditPanel EditPanelObject { get; set; }
        public StudyPanel StudyPanelObject { get; set; }
        public HelpPanel HelpPanelObject { get; set; }
        public DeckListPanel DeckListObject { get; set; }

        public PrimaryForm()
        {
            InitializeComponent();

            EditPanelObject = PrimaryEditPanel;
            StudyPanelObject = PrimaryStudyPanel;
            HelpPanelObject = PrimaryHelpPanel;
            DeckListObject = PrimaryDeckListPanel;

            DeckManager.ImportDecksFromJson();
        }

        //use this to run neccessary code at the time the application runs
        private void PrimaryForm_Load(object sender, EventArgs e)
        {
            //instantiate the necessary variables
            MenuButtons = new Button[] { decksButton, addDeckButton, helpButton };

            //this will be the default screen when the app loads
            decksButton.PerformClick();
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
            setToDecksView();
        }

        public void setToDecksView()
        {
            SetMenuButtonAsClicked(decksButton);
            DeckListObject.BringToFront();
            DeckListObject.LoadDeckPanels();
        }

        private void addDeckButton_Click(object sender, EventArgs e)
        {
            SetMenuButtonAsClicked(addDeckButton);
            EditPanelObject.BringToFront();
            EditPanelObject.SetDeckToEdit(DeckManager.GetNewDeck().Id);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            SetMenuButtonAsClicked(helpButton);
            HelpPanelObject.BringToFront();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrimaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeckManager.ExportDecksToJson();
        }
    }
}
