using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Cards
{
    //Class representing a Card object that will be contained in a single Deck
    //Author: BH
    public class Card
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        //Empty default constructor - BH
        public Card()
        {
            Question = "";
            Answer = "";
        }
        //Constructor with parameters to set the question and answer properties of the Card object - BH
        public Card(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }

        //Override of the ToString method used during the debugging process - BH
        public override string ToString()
        {
            return "Question:\t\t\t" + Question +
                "\nAnswer:\t\t\t\t" + Answer;
        }
    }
}
