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
        }

        public void SetDeckToStudy(int DeckId)
        {
            DeckToStudy = DeckManager.GetDeckFromId(DeckId);

            CurrentCardIndex = 0;
            CurrentCard = DeckToStudy.Cards[0];

            IncorrectCardIndexes.Clear();

            ShowCardQuestion();
            ShowSubmitButton();
        }

        private void ShowCardQuestion()
        {
            termTitleLabel.Text = CurrentCard.Question;
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
                return true;
            }
            else
            {
                this.BackColor = Color.LightSalmon;
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
                this.BackColor = StudyPanel.DefaultBackColor;
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
    }
}
