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
    public partial class EditCardPanel : UserControl
    {
        public static EditPanel edit;
        public Card CardReference { get; set; }

        public EditCardPanel(Card c, EditPanel ep)
        {
            InitializeComponent();


            CardReference = c;
            edit = ep;

            QuestionTextbox.Text = CardReference.Question;
            AnswerTextbox.Text = CardReference.Answer;
        }

        //returns this EditCardPanel's values as a Card
        public Card ConvertToCard()
        {
            return new Card(QuestionTextbox.Text, AnswerTextbox.Text);
        }

        private void deleteTermButton_Click_1(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            edit.OnCardRemoved();
        }

    }
}
