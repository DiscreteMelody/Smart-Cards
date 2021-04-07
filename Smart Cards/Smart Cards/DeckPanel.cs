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
    public partial class DeckPanel : UserControl
    {
        public Deck DeckReference { get; set; }
        
        public CircularButton StudyButton
        {
            get { return studyButton; }
        }

        public CircularButton EditButton
        {
            get { return editButton; }
        }

        public DeckPanel(Deck d)
        {
            InitializeComponent();

            DeckReference = d;

            deckTitleLabel.Text = DeckReference.Title;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            PrimaryForm mainForm = (PrimaryForm)ParentForm;
            mainForm.EditPanelObject.BringToFront();
            mainForm.EditPanelObject.SetDeckToEdit(DeckReference.Id);
        }

        private void studyButton_Click(object sender, EventArgs e)
        {
            PrimaryForm mainForm = (PrimaryForm)ParentForm;
            mainForm.StudyPanelObject.BringToFront();
            mainForm.StudyPanelObject.SetDeckToStudy(DeckReference.Id);
        }
    }
}
