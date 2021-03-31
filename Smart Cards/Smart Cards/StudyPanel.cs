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
        public StudyPanel()
        {
            InitializeComponent();
        }

        //use this to run code that's necessary when the StudyPanel loads
        private void StudyPanel_Load(object sender, EventArgs e)
        {
            termAnswerLabel.Visible = false;
            nextTermButton.Visible = false;
        }

        private void submitAnswerButton_Click(object sender, EventArgs e)
        {
            termAnswerLabel.Visible = true;
            nextTermButton.Visible = true;
        }

        private void nextTermButton_Click(object sender, EventArgs e)
        {
            termAnswerLabel.Visible = false;
            nextTermButton.Visible = false;
        }
    }
}
