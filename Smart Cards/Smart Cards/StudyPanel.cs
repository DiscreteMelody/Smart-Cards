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
        private readonly Deck DeckToStudy;

        private int CurrentCardIndex;
        private Card CurrentCard;

        private List<int> IncorrectCardIndexes;
        public StudyPanel(Deck d)
        {
            InitializeComponent();

            DeckToStudy = d;
            CurrentCardIndex = 0;

            if (DeckToStudy.Cards.Count > 0)
                CurrentCard = DeckToStudy.Cards[0];

            IncorrectCardIndexes = new List<int>();
        }

        //use this to run code that's necessary when the StudyPanel loads
        private void StudyPanel_Load(object sender, EventArgs e)
        {
            termAnswerLabel.Visible = false;
            nextTermButton.Visible = false;
            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.Width = Parent.Width;
            this.Height = Parent.Height;
            termAnswerTextbox.SetSubmitButton(submitAnswerButton);

            UpdateCard();
        }

        private void submitAnswerButton_Click(object sender, EventArgs e)
        {
            termAnswerLabel.Visible = true;
            nextTermButton.Visible = true;
            nextTermButton.Enabled = true;

            termAnswerLabel.Location = termTitleLabel.Location;
            nextTermButton.Location = submitAnswerButton.Location;

            submitAnswerButton.Visible = false;
            submitAnswerButton.Enabled = false;

            CompareAnswer();
        }

        private void nextTermButton_Click(object sender, EventArgs e)
        {
            termAnswerLabel.Visible = false;
            nextTermButton.Visible = false;
            nextTermButton.Enabled = false;

            submitAnswerButton.Visible = true;
            submitAnswerButton.Enabled = true;

            termAnswerTextbox.PerformClick();

            NextQuestion();
        }

        private void CompareAnswer()
        {
            //if your answer matches the card's answer
            if (termAnswerTextbox.Text.Equals(CurrentCard.Answer, StringComparison.OrdinalIgnoreCase))
            {
                this.BackColor = Color.LightGreen;
            }
            else
            {
                this.BackColor = Color.LightSalmon;
                IncorrectCardIndexes.Add(CurrentCardIndex);
            }
        }

        private void NextQuestion()
        {
            //if there is at least one more card in the deck
            if(DeckToStudy.Cards.Count > ++CurrentCardIndex)
            {
                //update the current card
                CurrentCard = DeckToStudy.Cards[CurrentCardIndex];
                UpdateCard();
            }
        }

        private void UpdateCard()
        {
            termTitleLabel.Text = CurrentCard.Question;
            termAnswerLabel.Text = CurrentCard.Answer;

            this.BackColor = StudyPanel.DefaultBackColor;
        }

        private void StudyPanel_Resize(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.Width = Parent.Width;
            this.Height = Parent.Height;
        }
    }
}
