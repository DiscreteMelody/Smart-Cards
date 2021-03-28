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
        public string question { get; set; }
        public string answer { get; set; }

        public Card(string newQuestion, string newAnswer)
        {
            question = newQuestion;
            answer = newAnswer;
        }

        public override string ToString()
        {
            return "Question: " + question +
                "\nAnswer: " + answer;
        }
    }
}
