using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Cards
{
    public class Card
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public Card(string newQuestion, string newAnswer)
        {
            Question = newQuestion;
            Answer = newAnswer;
        }

        public override string ToString()
        {
            return "Question: " + Question +
                "\nAnswer: " + Answer;
        }
    }
}
