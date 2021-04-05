using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Cards
{
    public class Card
    {
        public int Id { get; }
        public string Question { get; set; }
        public string Answer { get; set; }


        public Card()
        {
            Question = "Enter a question";
            Answer = "Enter an answer";
        }
        [JsonConstructor]
        public Card(int id,string question, string answer)
        {
            Id = id;
            Question = question;
            Answer = answer;
        }

        public override string ToString()
        {
            return "Id:\t\t\t" + Id + "\nQuestion:\t\t\t" + Question +
                "\nAnswer:\t\t\t\t" + Answer;
        }
    }
}
