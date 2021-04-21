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

        private List<Card> Cards = new List<Card>();
        private Card CurrentCard;
        private int Guesses;
        private int InitialCardCount;

        public StudyPanel()
        {
            InitializeComponent();
            termAnswerTextbox.SetSubmitButton(submitAnswerButton);
        }

        public void SetDeckToStudy(int DeckId)
        {
            DeckToStudy = DeckManager.GetDeckFromId(DeckId);

            //disallow decks with 0 cards to be studied - LS
            if(DeckToStudy.Cards.Count <= 0)
            {
                MessageBox.Show("It looks like there are no cards in this deck to study. Try adding some now.");
                NavigationManager.SetActiveScreen(NavigationScreen.EditDeck, DeckId);
            }
            else
            {
                Cards.Clear();

                //C# passes by reference, so a for loop must be used - LS
                foreach(Card card in DeckToStudy.Cards)
                {
                    Cards.Add(card);
                }

                //reset necessary variables for a study session - LS
                CurrentDeckTitle.Text = DeckToStudy.Title;
                CurrentCard = Cards[0];
                Guesses = 0;
                InitialCardCount = Cards.Count;

                termAnswerTextbox.Show();
                termAnswerTextbox.clearText();
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

        //make the Submit button visible and enabled - LS
        private void ShowSubmitButton()
        {
            submitAnswerButton.Visible = true;
            nextTermButton.Visible = false;
        }

        //make the Next button visible and enabled - LS
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
                Cards.Add(CurrentCard);
                return false;
            }
        }

        private void NextQuestion()
        {
            //if there is at least one more card in the deck - LS
            if (Cards.Count > 0)
            {
                //update the current card - LS
                CurrentCard = Cards[0];
                ShowCardQuestion();
                termAnswerTextbox.clearText();
                ShowSubmitButton();
            }
            //when the study session is complete, show some basic stats - LS
            else
            {
                termTitleLabel.Text = "Nice job. You studied " + InitialCardCount + " cards in " + Guesses.ToString() + " attempts.";
                nextTermButton.Hide();
                termAnswerTextbox.Hide();
            }
        }

        //fires whenever the Submit button is clicked - LS
        private void submitAnswerButton_Click(object sender, EventArgs e)
        {
            if(termAnswerTextbox.Text.Trim() != "")
            {
                Guesses++;
                Cards.RemoveAt(0);
                ShowCardAnswer();
                CompareAnswer();
                ShowNextButton();
            }
        }

        //fires when the Next button is clicked - LS
        private void nextTermButton_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        //fires when a key is pressed and the answer textbox is in focus - LS
        private void termAnswerTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }
    }
}
