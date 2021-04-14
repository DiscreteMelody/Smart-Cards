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
    public partial class StudyPanel : UserControl
    {
        private Deck DeckToStudy;

        private int CurrentCardIndex;
        private Card CurrentCard;

        private static List<int> IncorrectCardIndexes = new List<int>();
        public StudyPanel()
        {
            InitializeComponent();
            termAnswerTextbox.SetSubmitButton(submitAnswerButton);
        }

        public void SetDeckToStudy(int DeckId)
        {
            DeckToStudy = DeckManager.GetDeckFromId(DeckId);

            //disallow decks with 0 cards to be studied
            if(DeckToStudy.Cards.Count <= 0)
            {
                MessageBox.Show("It looks like there are no cards in this deck to study. Try adding some now.");
                NavigationManager.SetActiveScreen(NavigationScreen.EditDeck, DeckId);
            }
            else
            {
                CurrentDeckTitle.Text = DeckToStudy.Title;

                CurrentCardIndex = 0;
                CurrentCard = DeckToStudy.Cards[0];

                IncorrectCardIndexes.Clear();

                ShowCardQuestion();
                ShowSubmitButton();
            }
        }

        private void ShowCardQuestion()
        {
            termTitleLabel.Text = CurrentCard.Question;

            this.BackColor = StudyPanel.DefaultBackColor;
            CurrentDeckTitle.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void ShowCardAnswer()
        {
            termTitleLabel.Text = CurrentCard.Answer;
        }

        private void ShowSubmitButton()
        {
            submitAnswerButton.Visible = true;
            nextTermButton.Visible = false;
        }

        private void ShowNextButton()
        {
            nextTermButton.Visible = true;
            submitAnswerButton.Visible = false;
        }

        private bool CompareAnswer()
        {
            //if your answer matches the card's answer
            if (termAnswerTextbox.Text.Equals(CurrentCard.Answer, StringComparison.OrdinalIgnoreCase))
            {
                this.BackColor = Color.LightGreen;
                CurrentDeckTitle.BackColor = Color.FromArgb(95,46, 204, 113);
                return true;
            }
            else
            {
                this.BackColor = Color.FromArgb(250, 177, 160);
                CurrentDeckTitle.BackColor = Color.LightSalmon;
                IncorrectCardIndexes.Add(CurrentCardIndex);
                return false;
            }
        }

        private void NextQuestion()
        {
            //if there is at least one more card in the deck
            if (DeckToStudy.Cards.Count > ++CurrentCardIndex)
            {
                //update the current card
                CurrentCard = DeckToStudy.Cards[CurrentCardIndex];
                ShowCardQuestion();
                termAnswerTextbox.clearText();
                ShowSubmitButton();
            }
        }

        private void submitAnswerButton_Click(object sender, EventArgs e)
        {
            if(termAnswerTextbox.Text.Trim() != "")
            {
                ShowCardAnswer();
                CompareAnswer();
                ShowNextButton();
            }
        }

        private void nextTermButton_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void termAnswerTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }
    }
}
